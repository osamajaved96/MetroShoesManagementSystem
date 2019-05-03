using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metroshoesmaagementsystem
{
    class employee_scale
    {
        int employee_scale_ID;
        string name;
        string description;
        employee_scale get(int ID, DbConnection connection )
        {
            string queryString = "SELECT name, description FROM employee WHERE user_ID =='1'";
            DbCommand command = connection.CreateCommand();
            command.CommandText = queryString;
            command.CommandType = CommandType.Text;
            connection.Open();
            DbDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("name"));
                description = reader.GetString(reader.GetOrdinal("description"));
            }
            return this;
        }
    }
}