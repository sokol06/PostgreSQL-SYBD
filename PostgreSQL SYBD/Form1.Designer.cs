namespace PostgreSQL_SYBD
{
    partial class FormEdit
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ReLoadButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.win_Button = new System.Windows.Forms.Button();
            this.WinPic = new System.Windows.Forms.PictureBox();
            this.studentsdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postgresDataSet = new PostgreSQL_SYBD.postgresDataSet();
            this.students_dataTableAdapter = new PostgreSQL_SYBD.postgresDataSetTableAdapters.students_dataTableAdapter();
            this.dataSet1 = new PostgreSQL_SYBD.DataSet1();
            this.students_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_dataTableAdapter1 = new PostgreSQL_SYBD.DataSet1TableAdapters.students_dataTableAdapter();
            this.tableAdapterManager = new PostgreSQL_SYBD.DataSet1TableAdapters.TableAdapterManager();
            this.stidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stidDataGridViewTextBoxColumn,
            this.stnameDataGridViewTextBoxColumn,
            this.stemailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.students_dataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(369, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(357, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(177, 275);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(165, 20);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "email";
            // 
            // textBox1_email
            // 
            this.textBox1_email.Location = new System.Drawing.Point(177, 301);
            this.textBox1_email.Name = "textBox1_email";
            this.textBox1_email.Size = new System.Drawing.Size(165, 20);
            this.textBox1_email.TabIndex = 5;
            this.textBox1_email.TextChanged += new System.EventHandler(this.textBox1_email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // textBox2_id
            // 
            this.textBox2_id.Location = new System.Drawing.Point(177, 249);
            this.textBox2_id.Name = "textBox2_id";
            this.textBox2_id.Size = new System.Drawing.Size(165, 20);
            this.textBox2_id.TabIndex = 7;
            this.textBox2_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить строку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReLoadButton
            // 
            this.ReLoadButton.Location = new System.Drawing.Point(369, 340);
            this.ReLoadButton.Name = "ReLoadButton";
            this.ReLoadButton.Size = new System.Drawing.Size(81, 28);
            this.ReLoadButton.TabIndex = 9;
            this.ReLoadButton.Text = "Обновить";
            this.ReLoadButton.UseVisualStyleBackColor = true;
            this.ReLoadButton.Click += new System.EventHandler(this.ReLoadButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(261, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Режим редактирования";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(177, 329);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 38);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Удалить строку";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(31, 59);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 37);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(177, 148);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(165, 83);
            this.label2.TabIndex = 14;
            this.label2.Text = "Для вставки строки введите id, имя, email и нажмите \"Добавить строку\". Для удален" +
    "ия строки введите id и нажмите \"Удалить строку\"\r\n";
            // 
            // win_Button
            // 
            this.win_Button.Location = new System.Drawing.Point(328, 398);
            this.win_Button.Name = "win_Button";
            this.win_Button.Size = new System.Drawing.Size(154, 31);
            this.win_Button.TabIndex = 15;
            this.win_Button.Text = "Нажать, если лаба сдана";
            this.win_Button.UseVisualStyleBackColor = true;
            this.win_Button.Click += new System.EventHandler(this.win_Button_Click);
            // 
            // WinPic
            // 
            this.WinPic.ImageLocation = "https://i.yapx.ru/HTjD4.gif";
            this.WinPic.Location = new System.Drawing.Point(-179, -233);
            this.WinPic.Name = "WinPic";
            this.WinPic.Size = new System.Drawing.Size(1088, 686);
            this.WinPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinPic.TabIndex = 16;
            this.WinPic.TabStop = false;
            this.WinPic.Visible = false;
            // 
            // studentsdataBindingSource
            // 
            this.studentsdataBindingSource.DataMember = "students_data";
            this.studentsdataBindingSource.DataSource = this.postgresDataSet;
            // 
            // postgresDataSet
            // 
            this.postgresDataSet.DataSetName = "postgresDataSet";
            this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_dataTableAdapter
            // 
            this.students_dataTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_dataBindingSource
            // 
            this.students_dataBindingSource.DataMember = "students_data";
            this.students_dataBindingSource.DataSource = this.dataSet1;
            // 
            // students_dataTableAdapter1
            // 
            this.students_dataTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.students_dataTableAdapter = this.students_dataTableAdapter1;
            this.tableAdapterManager.UpdateOrder = PostgreSQL_SYBD.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stidDataGridViewTextBoxColumn
            // 
            this.stidDataGridViewTextBoxColumn.DataPropertyName = "st_id";
            this.stidDataGridViewTextBoxColumn.HeaderText = "st_id";
            this.stidDataGridViewTextBoxColumn.Name = "stidDataGridViewTextBoxColumn";
            this.stidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stnameDataGridViewTextBoxColumn
            // 
            this.stnameDataGridViewTextBoxColumn.DataPropertyName = "st_name";
            this.stnameDataGridViewTextBoxColumn.HeaderText = "st_name";
            this.stnameDataGridViewTextBoxColumn.Name = "stnameDataGridViewTextBoxColumn";
            this.stnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stemailDataGridViewTextBoxColumn
            // 
            this.stemailDataGridViewTextBoxColumn.DataPropertyName = "st_email";
            this.stemailDataGridViewTextBoxColumn.HeaderText = "st_email";
            this.stemailDataGridViewTextBoxColumn.Name = "stemailDataGridViewTextBoxColumn";
            this.stemailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.win_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReLoadButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.WinPic);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormEdit";
            this.Text = "Режим редактирования";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2_id;
        private System.Windows.Forms.Button button1;
        private postgresDataSet postgresDataSet;
        private System.Windows.Forms.BindingSource studentsdataBindingSource;
        private postgresDataSetTableAdapters.students_dataTableAdapter students_dataTableAdapter;
        private System.Windows.Forms.Button ReLoadButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button win_Button;
        public System.Windows.Forms.PictureBox WinPic;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource students_dataBindingSource;
        private DataSet1TableAdapters.students_dataTableAdapter students_dataTableAdapter1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn stidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stemailDataGridViewTextBoxColumn;
    }
}

