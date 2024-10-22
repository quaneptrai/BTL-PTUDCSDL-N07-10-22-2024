using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TrangChu : Form
    {
        public static TrangChu instance;
        public TrangChu(string username)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Thoat);
            TXTtendangnhap.Text = username;
        }
        private Form curentformchild;
        private void OpenChildForm(Form childform)
        {
            if (curentformchild != null)
            {
                curentformchild.Close();
            }
            curentformchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            Phienthi.Controls.Add(childform);
            Phienthi.BringToFront();
            childform.Show();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            CheckThongTin();
        }
        private void CheckThongTin()
        {
            string username = TXTtendangnhap.Text;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-EDAASRI2\\SQLEXPRESS;Initial Catalog=UserInfor;Integrated Security=True;Trust Server Certificate=True");
            string querry = "SELECT role FROM UserLogin WHERE username = @username";
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@username", username);
            object result = cmd.ExecuteScalar();
            if (result != null && result.ToString() == "manager") 
            {
                Bdsgiaovien.Enabled= true;            
            }
            else
            {
                Bdsgiaovien.Enabled = false;
                Bdsgiaovien.ForeColor = Color.Gray;
            }

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Thoat(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Bthoikhoabieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThoiKhoaBieu());
        }
        private void LBsignout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = new Login();
            form1.Show();
        }

        private void Pmaintrangchu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bdshocsinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Danhsachhocsinh());
        }

        private void Bdsgiaovien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Danhsachgiaovien());
        }

        private void Bcstaikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Chinhsuataikhoan());
        }

        private void Blbaocao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Lapbaocao());
        }
    }
}
