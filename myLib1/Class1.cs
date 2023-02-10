using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace myLib
{

    public class connect_bd
    {
        string StrConn = "Server=localhost;port=5432;Database=postgres;User Id=postgres;Password=06231209";

        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        public void connect()
        {
            conn = new NpgsqlConnection();
            conn.ConnectionString = StrConn;
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        


    }
}
