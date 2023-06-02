namespace ConnectSQL
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatef2 = new System.Windows.Forms.Button();
            this.btnDeletef2 = new System.Windows.Forms.Button();
            this.ADDBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNameDG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mATHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHEDOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuVienDataSet1 = new ConnectSQL.ThuVienDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.thuVienDataSet = new ConnectSQL.ThuVienDataSet();
            this.thuVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHEDOCGIATableAdapter = new ConnectSQL.ThuVienDataSet1TableAdapters.THEDOCGIATableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-103, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-103, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Sâch";
            // 
            // btnUpdatef2
            // 
            this.btnUpdatef2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdatef2.Location = new System.Drawing.Point(410, 490);
            this.btnUpdatef2.Name = "btnUpdatef2";
            this.btnUpdatef2.Size = new System.Drawing.Size(102, 34);
            this.btnUpdatef2.TabIndex = 33;
            this.btnUpdatef2.Text = "Update";
            this.btnUpdatef2.UseVisualStyleBackColor = true;
            this.btnUpdatef2.Click += new System.EventHandler(this.btnUpdatef2_Click);
            // 
            // btnDeletef2
            // 
            this.btnDeletef2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeletef2.Location = new System.Drawing.Point(283, 490);
            this.btnDeletef2.Name = "btnDeletef2";
            this.btnDeletef2.Size = new System.Drawing.Size(102, 34);
            this.btnDeletef2.TabIndex = 32;
            this.btnDeletef2.Text = "Delete";
            this.btnDeletef2.UseVisualStyleBackColor = true;
            this.btnDeletef2.Click += new System.EventHandler(this.btnDeletef2_Click);
            // 
            // ADDBTN
            // 
            this.ADDBTN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ADDBTN.Location = new System.Drawing.Point(164, 490);
            this.ADDBTN.Name = "ADDBTN";
            this.ADDBTN.Size = new System.Drawing.Size(86, 34);
            this.ADDBTN.TabIndex = 31;
            this.ADDBTN.Text = "Add";
            this.ADDBTN.UseVisualStyleBackColor = true;
            this.ADDBTN.Click += new System.EventHandler(this.ADDBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(409, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(565, 378);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(193, 22);
            this.txtDC.TabIndex = 27;
            this.txtDC.TextChanged += new System.EventHandler(this.txtDC_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(94, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Họ Tên";
            // 
            // TxtNameDG
            // 
            this.TxtNameDG.Location = new System.Drawing.Point(160, 426);
            this.TxtNameDG.Name = "TxtNameDG";
            this.TxtNameDG.Size = new System.Drawing.Size(175, 22);
            this.TxtNameDG.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(94, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã Thẻ";
            // 
            // txtMT
            // 
            this.txtMT.Location = new System.Drawing.Point(160, 384);
            this.txtMT.Name = "txtMT";
            this.txtMT.Size = new System.Drawing.Size(175, 22);
            this.txtMT.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATHEDataGridViewTextBoxColumn,
            this.hOTENDGDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tHEDOCGIABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(907, 246);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // mATHEDataGridViewTextBoxColumn
            // 
            this.mATHEDataGridViewTextBoxColumn.DataPropertyName = "MATHE";
            this.mATHEDataGridViewTextBoxColumn.HeaderText = "Mã Thẻ";
            this.mATHEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mATHEDataGridViewTextBoxColumn.Name = "mATHEDataGridViewTextBoxColumn";
            this.mATHEDataGridViewTextBoxColumn.Width = 125;
            // 
            // hOTENDGDataGridViewTextBoxColumn
            // 
            this.hOTENDGDataGridViewTextBoxColumn.DataPropertyName = "HOTENDG";
            this.hOTENDGDataGridViewTextBoxColumn.HeaderText = "Họ Tên Độc Giả";
            this.hOTENDGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hOTENDGDataGridViewTextBoxColumn.Name = "hOTENDGDataGridViewTextBoxColumn";
            this.hOTENDGDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.Width = 200;
            // 
            // tHEDOCGIABindingSource
            // 
            this.tHEDOCGIABindingSource.DataMember = "THEDOCGIA";
            this.tHEDOCGIABindingSource.DataSource = this.thuVienDataSet1;
            // 
            // thuVienDataSet1
            // 
            this.thuVienDataSet1.DataSetName = "ThuVienDataSet1";
            this.thuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(251, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 32);
            this.label3.TabIndex = 36;
            this.label3.Text = "Phần Mềm Quản Lý Thư Viện-Thẻ Độc Giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(344, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 32);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nhập Thông Tin Độc Giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(388, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tìm Kiếm Theo Mã Thẻ ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(565, 420);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(540, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 40;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // thuVienDataSet
            // 
            this.thuVienDataSet.DataSetName = "ThuVienDataSet";
            this.thuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuVienDataSetBindingSource
            // 
            this.thuVienDataSetBindingSource.DataSource = this.thuVienDataSet;
            this.thuVienDataSetBindingSource.Position = 0;
            // 
            // tHEDOCGIATableAdapter
            // 
            this.tHEDOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(781, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 41;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(670, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 42;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdatef2);
            this.Controls.Add(this.btnDeletef2);
            this.Controls.Add(this.ADDBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNameDG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "THEDOCGIA";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEDOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatef2;
        private System.Windows.Forms.Button btnDeletef2;
        private System.Windows.Forms.Button ADDBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNameDG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource thuVienDataSetBindingSource;
        private ThuVienDataSet thuVienDataSet;
        private ThuVienDataSet1 thuVienDataSet1;
        private System.Windows.Forms.BindingSource tHEDOCGIABindingSource;
        private ThuVienDataSet1TableAdapters.THEDOCGIATableAdapter tHEDOCGIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATHEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}