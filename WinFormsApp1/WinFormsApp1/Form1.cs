
namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        string userName = "admin";
        string password = "admin";
        string type = "Admin";

        public void checkLogin(string user, string pass, string usertype)
        {
            if (userName==user && password == pass && type == usertype)
            {
                MessageBox.Show("Login Sucess");
                //Application.Run(new Form2());
                Form2 form2 = new Form2();

            }
            else
            {
                MessageBox.Show("Invalid Login", "Warning");
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
           checkLogin(TxtUser.Text,TxtPass.Text,CboxUsertype.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboxUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}