using Dapper;
using GMSDataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSDataAccess.DataAccess;
public class SqlConnector {
    private string GetConnString() {

        return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
    }

    public async Task<bool> LogIn(string name, string password) {

        bool output = false;
        int r;

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            var result = await connection.QueryAsync<int>(
                "spUser_LogIn",
                new { Name = name, Password = password },
                commandType: CommandType.StoredProcedure);

            r = result.FirstOrDefault();
        }

        if (r == 1) {
            output = true;
        }

        return output;

    }

    public async Task BackupDatabase(string destination, string fileName) {

        destination = $"{destination}\\{fileName}.bak";

        using (IDbConnection connection = new SqlConnection(GetConnString())) {


            await connection.ExecuteAsync("spDbBackup", new { Destination = destination }, commandType: CommandType.StoredProcedure);

        }
    }

    public async Task CheckMembershipExpirationsAsync() {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spMembership_CheckExpirations", commandType: CommandType.StoredProcedure);

        }
    }

    public async Task<List<MemberModel>> GetMembers() {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            var result = await connection.QueryAsync<MemberModel>("spMember_GetAll", new { }, commandType: CommandType.StoredProcedure);

            return result.ToList();

        }
    }

    public async Task AddPlan(PlanModel model) {
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync(
                "spPlan_Add",
                new {
                    Name = model.Name,
                    Start = model.Start,
                    End = model.End,
                    Fee = model.Fee
                },
                commandType: CommandType.StoredProcedure);
        }
    }

    public async Task RestoreDatabase(string file) {
        
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync(@$"IF DB_ID('TempoDB') IS NULL BEGIN CREATE DATABASE TempoDB; END");
            await connection.ExecuteAsync(@$"USE TempoDB; RESTORE DATABASE GMSData FROM DISK = N'{file}' WITH REPLACE");

        }
    }

    public async Task AddMember(MemberModel model) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync(
                "spMember_Add",
                new {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Gender = model.Gender,
                    BirthDate = model.BirthDate,
                    PhoneNumber1 = model.PhoneNumber1,
                    PhoneNumber2 = model.PhoneNumber2
                },
                commandType: CommandType.StoredProcedure);
        }
    }

    public async Task<List<MembershipModel>> GetMemberships(string fetchType) {

        IEnumerable<MembershipModel> result;

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            switch (fetchType) {

                case "Active":
                    result = await connection.QueryAsync<MembershipModel>("spMembership_GetActive", new { }, commandType: CommandType.StoredProcedure);
                    break;

                case "Expired":
                    result = await connection.QueryAsync<MembershipModel>("spMembership_GetExpired", new { }, commandType: CommandType.StoredProcedure);
                    break;

                default:
                    result = await connection.QueryAsync<MembershipModel>("spMembership_GetAll", new { }, commandType: CommandType.StoredProcedure);
                    break;
            }

            foreach (var item in result) {
                var r = await connection.QueryAsync<EmployeeModel>("spMembership_GetTrainersById", new { Id = item.Id }, commandType: CommandType.StoredProcedure);
                item.Trainers = r.ToList();
            }

            return result.ToList();
        }
    }

    public async Task<List<UserModel>> GetUsers() {
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            var result = await connection.QueryAsync<UserModel>("spUser_GetAll", new { }, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }

    public async Task<List<PlanModel>> GetPlans() {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            var result = await connection.QueryAsync<PlanModel>("spPlan_GetAll", new { }, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }

    public async Task AddMembership(MembershipModel model) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            DynamicParameters p = new DynamicParameters();

            p.Add("Id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            p.Add("MemberId", model.MemberId);
            p.Add("PlanId", model.PlanId);
            p.Add("StartingDate", model.StartingDate);
            p.Add("ExpirationDate", model.ExpirationDate);
            p.Add("UserId", model.UserId);
            p.Add("AutoRenew", model.AutoRenew);

            await connection.ExecuteAsync("spMembership_Add", p, commandType: CommandType.StoredProcedure);

            int id = p.Get<int>("Id");

            foreach (var t in model.Trainers) {
                await connection.ExecuteAsync("spMembershipTrainers_Add", new { MembershipId = id, TrainerId = t.Id }, commandType: CommandType.StoredProcedure);
            }

        }
    }

    public async Task UpdatePlan(PlanModel model) {
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync(
                "spPlan_Update",
                new {
                    Id = model.Id,
                    Name = model.Name,
                    Start = model.Start,
                    End = model.End,
                    Fee = model.Fee
                },
                commandType: CommandType.StoredProcedure);
        }
    }

    public async Task AddUser(UserModel model, string password) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync(
                "spUser_Add",
                new {
                    Name = model.Name,
                    Address = model.Address,
                    PhoneNumber1 = model.PhoneNumber1,
                    PhoneNumber2 = model.PhoneNumber2,
                    Password = password,
                    Role = model.Role
                },
                commandType: CommandType.StoredProcedure);

        }
    }

    public async Task UpdateMembership(MembershipModel model) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync(
                "spMembership_Update",
                new {
                    Id = model.Id,
                    PlanId = model.PlanId,
                    StartingDate = model.StartingDate,
                    ExpirationDate = model.ExpirationDate,
                    AutoRenew = model.AutoRenew,
                }
                , commandType: CommandType.StoredProcedure);



            await connection.ExecuteAsync("spMembershipTrainers_Delete", new { Id = model.Id }, commandType: CommandType.StoredProcedure);

            foreach (var t in model.Trainers) {

                await connection.ExecuteAsync("spMembershipTrainers_Add", new { MembershipId = model.Id, TrainerId = t.Id }, commandType: CommandType.StoredProcedure);

            }

        }
    }

    public async Task UpdateMember(MemberModel model) {
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync(
                "spMember_Update",
                new {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Gender = model.Gender,
                    BirthDate = model.BirthDate,
                    PhoneNumber1 = model.PhoneNumber1,
                    PhoneNumber2 = model.PhoneNumber2
                }
                , commandType: CommandType.StoredProcedure);
        }
    }

    public async Task DeleteMembership(int id) {
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spMembershipTrainers_Delete", new { Id = id }, commandType: CommandType.StoredProcedure);

            await connection.ExecuteAsync("spMembership_Delete", new { Id = id }, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task<UserModel> GetUserByName(string name) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            var result = await connection.QueryAsync<UserModel>("spUser_GetByName", new { Name = name }, commandType: CommandType.StoredProcedure);

            return result.ToList().First();
        }
    }

    public async Task DeleteMember(int id) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spMember_Delete", new { Id = id }, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task<List<EmployeeModel>> GetEmployees(string fetchType) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            IEnumerable<EmployeeModel> result;

            switch (fetchType) {
                case "Trainer":
                    result = await connection.QueryAsync<EmployeeModel>("spEmployee_GetTrainers", new { }, commandType: CommandType.StoredProcedure);
                    break;


                case "Staff":
                    result = await connection.QueryAsync<EmployeeModel>("spEmployee_GetStaffs", new { }, commandType: CommandType.StoredProcedure);
                    break;

                default:
                    result = await connection.QueryAsync<EmployeeModel>("spEmployee_GetAll", new { }, commandType: CommandType.StoredProcedure);
                    break;
            }

            return result.ToList();
        }
    }

    public async Task AddEmployee(EmployeeModel model) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync(
                "spEmployee_Add",
                new {
                    Name = model.Name,
                    Address = model.Address,
                    Salary = model.Salary,
                    JobType = model.JobType,
                    PhoneNumber1 = model.PhoneNumber1,
                    PhoneNumber2 = model.PhoneNumber2
                },
                commandType: CommandType.StoredProcedure);

        }
    }

    public async Task DeletePlan(int id) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spPlan_Delete", new { Id = id }, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task UpdateUser(UserModel model) {
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spUser_Update", model, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task UpdateEmployee(EmployeeModel model) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spEmployee_Update",
                new {
                    Id = model.Id,
                    Name = model.Name,
                    Address = model.Address,
                    Salary = model.Salary,
                    JobType = model.JobType,
                    PhoneNumber1 = model.PhoneNumber1,
                    PhoneNumber2 = model.PhoneNumber2
                },
                commandType: CommandType.StoredProcedure);
        }
    }

    public async Task UpdateUserPassword(int id, string password) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spUser_UpdatePassword", new { Id = id, Password = password }, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task DeleteUser(int id) {
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spUser_Delete", new { Id = id }, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task DeleteEmployee(int id) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spEmployee_Delete", new { Id = id }, commandType: CommandType.StoredProcedure);
        }
    }
}


