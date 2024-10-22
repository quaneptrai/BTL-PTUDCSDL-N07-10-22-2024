using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;
namespace WinFormsApp1
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Thoat);         
        }

        private void PBpanel_Click(object sender, EventArgs e)
        {

        }

        private void LBforgotpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuenMatKhau form = new QuenMatKhau();
            form.Show();
        }

        private void Thoat(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Blogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-EDAASRI2\\SQLEXPRESS;Initial Catalog=UserInfor;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            string querry = ("SELECT COUNT(*) FROM UserLogin WHERE username=@username AND userpassword=@password");
            SqlCommand cmd = new SqlCommand(querry,con);
            cmd.Parameters.AddWithValue("@username",TXTusername.Text);
            cmd.Parameters.AddWithValue("@password", TXTpassword.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0) {
                string username = TXTusername.Text;
                TrangChu form1 = new TrangChu(username);
                this.Hide();
                form1.Show();
            }
        }
    }
}
