using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace myLib
{

    public class RowAdd
    {
        NpgsqlConnection conn;
        NpgsqlCommand comm;
        public void Add(int IdTarget, string NameTarget,string EmailTarget)
        {
            conn = new NpgsqlConnection("Server=192.168.0.13;port=5432;Database=postgres;User Id=postgres;Password=dspace");
            conn.Open();
            comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM public.students_data";
            comm.CommandText = $"INSERT INTO students_data(st_id,st_name,st_email) VALUES ('{IdTarget}','{NameTarget}','{EmailTarget}')";
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }

    public class RowDel
    {
        NpgsqlConnection conn;
        NpgsqlCommand comm;
        public void Del(int IdTarget)
        {
            conn = new NpgsqlConnection("Server=192.168.0.13;port=5432;Database=postgres;User Id=postgres;Password=dspace");
            conn.Open();
            comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM public.students_data";
            comm.CommandText = $"DELETE FROM students_data WHERE st_id={IdTarget}";
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}

