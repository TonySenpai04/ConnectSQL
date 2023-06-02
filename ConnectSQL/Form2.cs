using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectSQL
{

    public partial class Form2 : Form
    {
        public static Form2 f2 = new Form2();
        DataTable dt;
        string AdConnect = "Data Source=LAPOFTONY\\SQLEXPRESS;Initial Catalog=ThuVien;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }
        public void ConnectSQL(string sqlcmd)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = AdConnect; conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
       


        private void CommandSQL(string sqlcmd)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = AdConnect;
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sqlcmd, conn);
            sqlCommand.CommandText = sqlcmd;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;
            sqlCommand.Parameters.AddWithValue("@MATHE", txtMT.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@HOTENDG", TxtNameDG.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@DIACHI", txtDC.Text.ToString());
            sqlCommand.ExecuteNonQuery();
            conn.Dispose();

        }
        public void AddData()
        {
            string cmd = "INSERT INTO THEDOCGIA VALUES(@MATHE,@HOTENDG,@DIACHI)";
            CommandSQL(cmd);
            ConnectSQL("select* from THEDOCGIA");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet1.THEDOCGIA' table. You can move, or remove it, as needed.
            this.tHEDOCGIATableAdapter.Fill(this.thuVienDataSet1.THEDOCGIA);
            ConnectSQL("Select * from THEDOCGIA");
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

        }
        public void Delete()
        {
            string cmd = "delete  THEDOCGIA where MATHE=@MATHE";
            CommandSQL(cmd);
            ConnectSQL("select* from THEDOCGIA");
        }
        
        private void UpdateData()
        {
            string cmd = "update  THEDOCGIA set HOTENDG=@HOTENDG,DIACHI=@DIACHI where MATHE=@MATHE";
            CommandSQL(cmd);
            ConnectSQL("select* from THEDOCGIA");
        }
        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ADDBTN_Click(object sender, EventArgs e)
        {
            if (txtDC.Text==""||txtMT.Text==""||TxtNameDG.Text=="")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin! ");

            }
            else
            {
                string sql = "select * from THEDOCGIA where MATHE='" + txtMT.Text + "'"; ;
                ConnectSQL(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã thẻ đã tồn tại");
                    ConnectSQL("select* from THEDOCGIA");

                }
                else
                {
                    AddData();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
            }
        }

        private void btnDeletef2_Click(object sender, EventArgs e)
        {
            if (txtDC.Text == "" || txtMT.Text == "" || TxtNameDG.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Dữ Liệu Cần Xóa! ");

            }
            else
            {
                Delete();
                MessageBox.Show("Xóa dữ liệu thành công!");
            }
        }

        private void btnUpdatef2_Click(object sender, EventArgs e)
        {
            if (txtDC.Text == "" || txtMT.Text == "" || TxtNameDG.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Dữ Liệu Muốn Thay Đổi! ");
                
            }
            else
            {
                UpdateData();
                MessageBox.Show("Thay đổi dữ liệu thành công!");
            }
        }

        private void btnConnSach_Click(object sender, EventArgs e)
        {
            this.Hide();          
            Form3.Instance.Show();
            Form3.Instance.ConnectSQL("Select * from PHIEUMUON");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Instance.Show();
            Form1.Instance.ConnectSQL("Select * from SACH");
            
        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ConnectSQL("select* from THEDOCGIA where MATHE='" + textBox1.Text + "'");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Mã Thẻ Muốn Tìm Kiếm!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMT.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMT.Enabled = false;
            TxtNameDG.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDC.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            if (txtDC.Text == "" || txtMT.Text == "" || TxtNameDG.Text == "")
            {
                txtMT.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectSQL("select* from THEDOCGIA");
        }
    }
}
