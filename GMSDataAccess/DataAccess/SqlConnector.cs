using Dapper;
using System;
using System.Collections.Generic;
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

    public async Task<bool> LogIn(string username, string password) {

        bool output = false;
        int r;

        using (IDbConnection connection = new SqlConnection(GetConnString())) {
            
            var result = await connection.QueryAsync<int>(
                "spEmployee_LogIn",
                new { Username = username, Password = password },
                commandType: CommandType.StoredProcedure);

            r = result.FirstOrDefault();
        }

        if (r == 1) {
            output = true;
        }

        return output;


    }
}


