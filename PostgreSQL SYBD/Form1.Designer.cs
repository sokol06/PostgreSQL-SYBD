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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.postgresDataSet = new PostgreSQL_SYBD.postgresDataSet();
            this.studentsdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_dataTableAdapter = new PostgreSQL_SYBD.postgresDataSetTableAdapters.students_dataTableAdapter();
            this.stidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsdataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stidDataGridViewTextBoxColumn,
            this.stnameDataGridViewTextBoxColumn,
            this.stemailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsdataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(419, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(177, 212);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(165, 20);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите имя нового студента и его email и нажмите ENTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "email";
            // 
            // textBox1_email
            // 
            this.textBox1_email.Location = new System.Drawing.Point(177, 258);
            this.textBox1_email.Name = "textBox1_email";
            this.textBox1_email.Size = new System.Drawing.Size(165, 20);
            this.textBox1_email.TabIndex = 5;
            this.textBox1_email.TextChanged += new System.EventHandler(this.textBox1_email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер зачётки";
            // 
            // textBox2_id
            // 
            this.textBox2_id.Location = new System.Drawing.Point(177, 167);
            this.textBox2_id.Name = "textBox2_id";
            this.textBox2_id.Size = new System.Drawing.Size(165, 20);
            this.textBox2_id.TabIndex = 7;
            this.textBox2_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вставить в таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // postgresDataSet
            // 
            this.postgresDataSet.DataSetName = "postgresDataSet";
            this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsdataBindingSource
            // 
            this.studentsdataBindingSource.DataMember = "students_data";
            this.studentsdataBindingSource.DataSource = this.postgresDataSet;
            // 
            // students_dataTableAdapter
            // 
            this.students_dataTableAdapter.ClearBeforeFill = true;
            // 
            // stidDataGridViewTextBoxColumn
            // 
            this.stidDataGridViewTextBoxColumn.DataPropertyName = "st_id";
            this.stidDataGridViewTextBoxColumn.HeaderText = "st_id";
            this.stidDataGridViewTextBoxColumn.Name = "stidDataGridViewTextBoxColumn";
            // 
            // stnameDataGridViewTextBoxColumn
            // 
            this.stnameDataGridViewTextBoxColumn.DataPropertyName = "st_name";
            this.stnameDataGridViewTextBoxColumn.HeaderText = "st_name";
            this.stnameDataGridViewTextBoxColumn.Name = "stnameDataGridViewTextBoxColumn";
            // 
            // stemailDataGridViewTextBoxColumn
            // 
            this.stemailDataGridViewTextBoxColumn.DataPropertyName = "st_email";
            this.stemailDataGridViewTextBoxColumn.HeaderText = "st_email";
            this.stemailDataGridViewTextBoxColumn.Name = "stemailDataGridViewTextBoxColumn";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEdit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsdataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2_id;
        private System.Windows.Forms.Button button1;
        private postgresDataSet postgresDataSet;
        private System.Windows.Forms.BindingSource studentsdataBindingSource;
        private postgresDataSetTableAdapters.students_dataTableAdapter students_dataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stemailDataGridViewTextBoxColumn;
    }
}

