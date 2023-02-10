using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using myLib;


namespace PostgreSQL_SYBD
{

   
    public partial class FormEdit : Form
    {
        public string st_name_select;
        public int st_id_select;
        public string st_email_select;
        public bool add = false;
        public bool replay = true;

        
        
        public FormEdit()
        {
            InitializeComponent();
        }
        
        NpgsqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postgresDataSet.students_data". При необходимости она может быть перемещена или удалена.
            this.students_dataTableAdapter.Fill(this.postgresDataSet.students_data);
        }

        //public void addRow()
        //{

        //    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;port=5432;Database=postgres;User Id=postgres;Password=06231209");
        //    conn.Open();

        //    NpgsqlCommand cmd = new NpgsqlCommand();
        //    cmd.Connection = conn;

        //    cmd.CommandText = $"INSERT INTO students_data(st_id,st_name,st_email) VELUES ({st_id_select},{st_name_select},{st_email_select})";

        //}


        public void textBox_name_TextChanged(object sender, EventArgs e)
        {
            st_name_select = textBox_name.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            st_id_select = Int32.Parse(textBox2_id.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox1_email_TextChanged(object sender, EventArgs e)
        {
            st_email_select = textBox1_email.Text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            connect_bd conn;
            conn = new connect_bd();
            conn.connect();
            cmd = new NpgsqlCommand();
            cmd.CommandText = "SELECT * FROM public.students_data;";
            cmd.CommandText = $"INSERT INTO students_data(st_id,st_name,st_email) VELUES (9,rgrg,grg)";
            cmd.CommandText = "SELECT * FROM public.students_data;";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
