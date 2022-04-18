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

    public async Task<List<UserModel>> GetUsers() {
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            var result = await connection.QueryAsync<UserModel>("spUser_GetAll", new { }, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }

    public async Task AddUser(UserModel model, string password) {
        
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync(
                "spUser_Add",
                new {
                    Name = model.Name,
                    Address = model.Address,
                    Salary = model.Salary,
                    PhoneNumber1 = model.PhoneNumber1,
                    PhoneNumber2 = model.PhoneNumber2,
                    Password = password,
                    RoleLevel = model.RoleLevel
                },
                commandType: CommandType.StoredProcedure);

        }
    }

    public async Task<UserModel> GetUserByName(string name) {
        
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            var result = await connection.QueryAsync<UserModel>("spUser_GetByName", new { Name = name}, commandType: CommandType.StoredProcedure);

            return result.ToList().First();
        }
    }

    public async Task<List<EmployeeModel>> GetEmployees() {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            var result = await connection.QueryAsync<EmployeeModel>("spEmployee_GetAll", new { }, commandType: CommandType.StoredProcedure);

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

    public async Task UpdateUser(UserModel model) {
        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spUser_Update", model, commandType: CommandType.StoredProcedure);
        }
    }

    public async Task UpdateEmployee(EmployeeModel model) {

        using (IDbConnection connection = new SqlConnection(GetConnString())) {

            await connection.ExecuteAsync("spEmployee_Update", model, commandType: CommandType.StoredProcedure);
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


