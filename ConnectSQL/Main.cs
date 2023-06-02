using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectSQL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2.f2.ShowDialog();
            Form2.f2.ConnectSQL("Select * from THEDOCGIA");

        }

        private void btnConnTDG_Click(object sender, EventArgs e)
        {
           // this.Hide();
            Form1.Instance.ShowDialog();
            Form1.Instance.ConnectSQL("Select * from SACH");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.Hide();
            Form3.Instance.ShowDialog();
            Form3.Instance.ConnectSQL("Select * from PHIEUMUON");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
