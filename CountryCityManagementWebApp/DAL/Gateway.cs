using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CountryCityManagementWebApp.DAL
{
    public class Gateway
    {
        string connectionString = @"Server = .\SQLEXPRESS; Database=CountryManagementDB; Integrated Security=true";
        public Gateway()
        {
            Connection = new SqlConnection(connectionString);
            Command = new SqlCommand();
            Command.Connection = Connection;

        }

        protected SqlConnection Connection { get; set; }
        protected SqlCommand Command { get; set; }
    }
}