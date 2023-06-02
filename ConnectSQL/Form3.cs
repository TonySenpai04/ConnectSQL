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
    public partial class Form3 : Form
    {
        public static Form3 Instance=new Form3();
        DataTable dt;
        string AdConnect = "Data Source=LAPOFTONY\\SQLEXPRESS;Initial Catalog=ThuVien;Integrated Security=True";
        public Form3()
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
            sqlCommand.Parameters.AddWithValue("@MAPHIEU", txtMP.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@NGAYMUON", NgayMuon.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@MASACH", txtms.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@MATHE", txtmt.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@NGAYTRA", NgayTra.Text.ToString());
            sqlCommand.ExecuteNonQuery();
            conn.Dispose();

        }
        private void ADD_Click(object sender, EventArgs e)
        {
            if (txtMP.Text == "" || txtms.Text == "" || txtmt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                string sql = "select * from PHIEUMUON where MAPHIEU='" + txtMP.Text + "'"; ;
                ConnectSQL(sql);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã phiếu đã tồn tại");
                    ConnectSQL("select* from PHIEUMUON");

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
            string cmd = "delete  PHIEUMUON where MAPHIEU=@MAPHIEU";
            CommandSQL(cmd);
            ConnectSQL("select* from PHIEUMUON");
        }
        public void AddData()
        {
          
                string cmd = "INSERT INTO PHIEUMUON VALUES(@MAPHIEU,@NGAYMUON,@MASACH,@MATHE,@NGAYTRA)";
                CommandSQL(cmd);
                ConnectSQL("select* from PHIEUMUON");
            
        }
        private void UpdateData()
        {
            string cmd = "update  PHIEUMUON set NGAYMUON=@NGAYMUON,MASACH=@MASACH,MATHE=@MATHE,NGAYTRA=@NGAYTRA where MAPHIEU=@MAPHIEU";
            CommandSQL(cmd);
            ConnectSQL("select* from PHIEUMUON");
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet1.PHIEUMUON' table. You can move, or remove it, as needed.
            this.pHIEUMUONTableAdapter.Fill(this.thuVienDataSet1.PHIEUMUON);
            ConnectSQL("select *from PHIEUMUON");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMP.Text == "" || txtms.Text == "" || txtmt.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Dữ Liệu Cần Xóa!");
            }
            else
            {
                Delete();
                MessageBox.Show("Xóa dữ liệu thành công!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtMP.Text == "" || txtms.Text == "" || txtmt.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Dữ Liệu Muốn Thay Đổi!");
            }
            else
            {
                UpdateData();
                MessageBox.Show("Thay đổi dữ liệu thành công!");
            }
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int i = dataGridView1.CurrentRow.Index;
            txtMP.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMP.Enabled = false;
            NgayMuon.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtms.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtmt.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            NgayTra.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            if (txtMP.Text == "" || txtms.Text == "" || txtmt.Text == "")
            {
                txtMP.Enabled = true;
            }
        }

        private void btnConnTDG_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.f2.Show();
            Form2.f2.ConnectSQL("Select * from THEDOCGIA");

        }

        private void btnSACH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Instance.Show();
            Form1.Instance.ConnectSQL("Select * from SACH");

        }

        private void NgayTra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ConnectSQL("select* from PHIEUMUON where MAPHIEU='" + textBox1.Text + "'");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Mã Phiếu Muốn Tìm Kiếm!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectSQL("select *from PHIEUMUON");
        }
    }
}
