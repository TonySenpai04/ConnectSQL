using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConnectSQL
{
    public partial class Form1 : Form
    {
        public static Form1 Instance=new Form1();
        DataTable dt;
        string AdConnect = "Data Source=LAPOFTONY\\SQLEXPRESS;Initial Catalog=ThuVien;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        public void ConnectSQL(string sqlcmd)
        {
           SqlConnection conn = new SqlConnection();
            conn.ConnectionString=AdConnect; conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd,conn);
             dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.thuVienDataSet.SACH);
            ConnectSQL("Select * from SACH");
        }
        private void CommandSQL(string sqlcmd)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString= AdConnect;
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sqlcmd,conn);
            sqlCommand.CommandText = sqlcmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            sqlCommand.Parameters.AddWithValue("@MASACH", txtMS.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@TENSACH", TxtNameSach.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@NAMXB", txtNamXB.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@NHAXB", txtNhaXB.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@TACGIA", txtTacGia.Text.ToString());
            sqlCommand.ExecuteNonQuery();
            conn.Dispose();

        }
        public void AddData()
        {
            string cmd = "INSERT INTO SACH VALUES(@MASACH,@TENSACH,@NAMXB,@NHAXB,@TACGIA)";
            CommandSQL(cmd);
            ConnectSQL("select* from SACH");
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (txtMS.Text =="" || txtNamXB.Text=="" || txtNhaXB.Text=="" || txtTacGia.Text=="" || TxtNameSach.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin! ");               
            }
            else
            {
                string sql = "select * from SACH where MASACH='" + txtMS.Text + "'"; ;
                ConnectSQL(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã sách đã tồn tại");
                    ConnectSQL("select* from SACH");

                }
                else
                {
                    AddData();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
            }
            
        }
        public void Delete()
        {
            
                string cmd = "delete  SACH where MASACH=@MASACH";
                CommandSQL(cmd);
                ConnectSQL("select* from SACH");
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMS.Text == "" || txtNamXB.Text == "" || txtNhaXB.Text == "" || txtTacGia.Text == "" || TxtNameSach.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Dữ Liệu Cần Xóa!");
            }
            else
            {
                Delete();
                MessageBox.Show("Xóa dữ liệu thành công!");
            }
        }
        private void UpdateData()
        {
            string cmd = "update  SACH set TENSACH=@TENSACH,NAMXB=@NAMXB,NHAXB=@NHAXB,TACGIA=@TACGIA where MASACH=@MASACH";
            CommandSQL(cmd);
            ConnectSQL("select* from SACH");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMS.Text == "" || txtNamXB.Text == "" || txtNhaXB.Text == "" || txtTacGia.Text == "" || TxtNameSach.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Dữ Liệu Muốn Thay Đổi!");
            }
            else
            {
                UpdateData();
                MessageBox.Show("Thay đổi dữ liệu thành công!");
            }

                      
        }

        private void btnConnTDG_Click(object sender, EventArgs e)
        {         
            this.Hide();
            Form2.f2.Show();
            Form2.f2.ConnectSQL("Select * from THEDOCGIA");



        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Form3.Instance.Show();
            Form3.Instance.ConnectSQL("Select * from PHIEUMUON");
            
        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ConnectSQL("select* from SACH where NAMXB='" + textBox1.Text + "'");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Năm Xuất Bản Muốn Tìm!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMS.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMS.Enabled = false;
            TxtNameSach.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtNamXB.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtNhaXB.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtTacGia.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            if(txtMS.Text == "" || txtNamXB.Text == "" || txtNhaXB.Text == "" || txtTacGia.Text == "" || TxtNameSach.Text == "")
            {
                txtMS.Enabled = true;
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectSQL("select* from SACH");
        }
    }
}
