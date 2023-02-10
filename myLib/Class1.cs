using Npgsql;
using System.Data;

namespace myLib
{
    
    public class connect_bd
    {
        public string st_name_select;
        public int st_id_select;
        public string st_email_select;
        public bool add = false;
        public bool replay = true;

        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        public void connect()
        {
            conn = new NpgsqlConnection("Server=localhost;port=5432;Database=postgres;User Id=postgres;Password=06231209");

            conn.Open();

            cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM public.students_data";
            NpgsqlDataReader dr = cmd.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    DataTable dt = new DataTable();
            //    dt.Load(dr);
            //    dataGridView1.DataSource = dt;
            //}


        }
    }
}