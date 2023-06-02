namespace ConnectSQL
{
    partial class Form3
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAPHIEUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYMUONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYTRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuVienDataSet1 = new ConnectSQL.ThuVienDataSet1();
            this.NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.NgayTra = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pHIEUMUONTableAdapter = new ConnectSQL.ThuVienDataSet1TableAdapters.PHIEUMUONTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(436, 474);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 35);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(309, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 35);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ADD
            // 
            this.ADD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ADD.Location = new System.Drawing.Point(190, 474);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(86, 35);
            this.ADD.TabIndex = 26;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(535, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ngày Trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(329, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã Thẻ";
            // 
            // txtmt
            // 
            this.txtmt.Location = new System.Drawing.Point(395, 423);
            this.txtmt.Name = "txtmt";
            this.txtmt.Size = new System.Drawing.Size(100, 22);
            this.txtmt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(329, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã Sách";
            // 
            // txtms
            // 
            this.txtms.Location = new System.Drawing.Point(395, 375);
            this.txtms.Name = "txtms";
            this.txtms.Size = new System.Drawing.Size(100, 22);
            this.txtms.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(92, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày Mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(107, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Phiếu";
            // 
            // txtMP
            // 
            this.txtMP.Location = new System.Drawing.Point(189, 378);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(124, 22);
            this.txtMP.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAPHIEUDataGridViewTextBoxColumn,
            this.nGAYMUONDataGridViewTextBoxColumn,
            this.mASACHDataGridViewTextBoxColumn,
            this.mATHEDataGridViewTextBoxColumn,
            this.nGAYTRADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pHIEUMUONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(77, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 246);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // mAPHIEUDataGridViewTextBoxColumn
            // 
            this.mAPHIEUDataGridViewTextBoxColumn.DataPropertyName = "MAPHIEU";
            this.mAPHIEUDataGridViewTextBoxColumn.HeaderText = "Mã Phiếu";
            this.mAPHIEUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAPHIEUDataGridViewTextBoxColumn.Name = "mAPHIEUDataGridViewTextBoxColumn";
            this.mAPHIEUDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYMUONDataGridViewTextBoxColumn
            // 
            this.nGAYMUONDataGridViewTextBoxColumn.DataPropertyName = "NGAYMUON";
            this.nGAYMUONDataGridViewTextBoxColumn.HeaderText = "Ngày Mượn";
            this.nGAYMUONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYMUONDataGridViewTextBoxColumn.Name = "nGAYMUONDataGridViewTextBoxColumn";
            this.nGAYMUONDataGridViewTextBoxColumn.Width = 125;
            // 
            // mASACHDataGridViewTextBoxColumn
            // 
            this.mASACHDataGridViewTextBoxColumn.DataPropertyName = "MASACH";
            this.mASACHDataGridViewTextBoxColumn.HeaderText = "Mã Sách";
            this.mASACHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASACHDataGridViewTextBoxColumn.Name = "mASACHDataGridViewTextBoxColumn";
            this.mASACHDataGridViewTextBoxColumn.Width = 125;
            // 
            // mATHEDataGridViewTextBoxColumn
            // 
            this.mATHEDataGridViewTextBoxColumn.DataPropertyName = "MATHE";
            this.mATHEDataGridViewTextBoxColumn.HeaderText = "Mã Thẻ";
            this.mATHEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mATHEDataGridViewTextBoxColumn.Name = "mATHEDataGridViewTextBoxColumn";
            this.mATHEDataGridViewTextBoxColumn.Width = 125;
            // 
            // nGAYTRADataGridViewTextBoxColumn
            // 
            this.nGAYTRADataGridViewTextBoxColumn.DataPropertyName = "NGAYTRA";
            this.nGAYTRADataGridViewTextBoxColumn.HeaderText = "Ngày Trả";
            this.nGAYTRADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYTRADataGridViewTextBoxColumn.Name = "nGAYTRADataGridViewTextBoxColumn";
            this.nGAYTRADataGridViewTextBoxColumn.Width = 125;
            // 
            // pHIEUMUONBindingSource
            // 
            this.pHIEUMUONBindingSource.DataMember = "PHIEUMUON";
            this.pHIEUMUONBindingSource.DataSource = this.thuVienDataSet1;
            // 
            // thuVienDataSet1
            // 
            this.thuVienDataSet1.DataSetName = "ThuVienDataSet1";
            this.thuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NgayMuon
            // 
            this.NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayMuon.Location = new System.Drawing.Point(189, 420);
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Size = new System.Drawing.Size(124, 22);
            this.NgayMuon.TabIndex = 30;
            // 
            // NgayTra
            // 
            this.NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayTra.Location = new System.Drawing.Point(703, 369);
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Size = new System.Drawing.Size(124, 22);
            this.NgayTra.TabIndex = 31;
            this.NgayTra.ValueChanged += new System.EventHandler(this.NgayTra_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(229, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(539, 32);
            this.label7.TabIndex = 33;
            this.label7.Text = "Phần Mềm Quản Lý Thư Viện-Phiếu Mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(316, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nhập Thông Tin Phiếu Mượn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(527, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tìm Kiếm Theo Mã Phiếu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(703, 419);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 40;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(565, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 42;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pHIEUMUONTableAdapter
            // 
            this.pHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(798, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 43;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(693, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 44;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 531);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NgayTra);
            this.Controls.Add(this.NgayMuon);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "PHIEUMUON";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker NgayMuon;
        private System.Windows.Forms.DateTimePicker NgayTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private ThuVienDataSet1 thuVienDataSet1;
        private System.Windows.Forms.BindingSource pHIEUMUONBindingSource;
        private ThuVienDataSet1TableAdapters.PHIEUMUONTableAdapter pHIEUMUONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHIEUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYMUONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATHEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYTRADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}