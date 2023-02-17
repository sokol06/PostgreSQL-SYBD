using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using myLib;


namespace PostgreSQL_SYBD
{
    public partial class FormEdit : Form
    {
        public string st_name_select = "";
        public string st_id_select = "";
        public string st_email_select = "";
        public int st_id_select1;
        public bool add = false;
        public bool replay = true;

        public FormEdit()
        {
            InitializeComponent();
        }
        
        public void textBox_name_TextChanged(object sender, EventArgs e)
        {
            st_name_select = textBox_name.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            st_id_select = textBox2_id.Text;
        }

        private void textBox1_email_TextChanged(object sender, EventArgs e)
        {
            st_email_select = textBox1_email.Text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (st_id_select.Length >= 1 && st_email_select.Length >= 1 && st_name_select.Length >= 1)
            {
                try
                {
                    st_id_select1 = Int32.Parse(st_id_select);
                    st_email_select = Convert.ToString(st_email_select);
                    st_name_select = Convert.ToString(st_name_select);
                    MessageBox.Show("Строка добавлена! Обновите таблицу.");
                }
                catch
                {

                    MessageBox.Show("Некорректные данные!");

                }
            }
            else
            {
                MessageBox.Show("Не все данные введены!");
                return;
            }

            RowAdd conn;
            conn = new RowAdd();
            conn.Add(st_id_select1, st_name_select, st_email_select);

        }

        private void ReLoadButton_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.students_data". При необходимости она может быть перемещена или удалена.
            this.students_dataTableAdapter1.Fill(this.dataSet1.students_data);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (st_id_select.Length >= 1)
            {
                try
                {
                    st_id_select1 = Int32.Parse(st_id_select);
                    st_email_select = Convert.ToString(st_email_select);
                    st_name_select = Convert.ToString(st_name_select);
                    MessageBox.Show("Строка удалена! Обновите таблицу.");
                }
                catch
                {

                    MessageBox.Show("Некорректные данные!");

                }
            }
            else
            {
                MessageBox.Show("Не все данные введены!");
                return;
            }
            RowDel conn;
            conn = new RowDel();
            conn.Del(st_id_select1);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FormLoad FrLd = new FormLoad();
            FrLd.Show();
            Hide();
        }

        private void win_Button_Click(object sender, EventArgs e)
        {
            if (this.WinPic.Visible == true)
            {
                WinPic.Visible = false;
            }
            else
            {
                WinPic.Visible = true;
            }
            
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            

        }
    }
}
