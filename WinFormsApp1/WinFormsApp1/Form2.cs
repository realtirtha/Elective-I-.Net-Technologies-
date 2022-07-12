using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["connect"]);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TotalUser();
         //   con.Open();
            string sql = "SELECT * FROM tblUser";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "user");

            dataGridView1.DataSource = ds.Tables["user"];

        }

        private void btnCreateuser_Click(object sender, EventArgs e)
        {
            if (TxtPass.Text == TxtRepass.Text)
            {
                string sql = "INSERT INTO tblUser(Username,[Password],Usertype) values(@User,@Pass,@Usertype)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@User",TxtUser.Text);
                cmd.Parameters.AddWithValue("@Pass", TxtPass.Text);
                cmd.Parameters.AddWithValue("@Usertype", comboBox1.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery(); //insert,delete,update
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                    MessageBox.Show("User Created Sucessfully");
                    Form2_Load(sender, e);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TxtPass.Text == TxtRepass.Text)
            {
                string sql = "UPDATE tblUser set Username=@user, Password=@pass, Usertype=@type WHERE Userid=@id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@user", TxtUser.Text);
                cmd.Parameters.AddWithValue("@pass", TxtPass.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery(); //insert,delete,update
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    con.Close();
                    MessageBox.Show("User Updated Sucessfully");
                    Form2_Load(sender, e);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tblUser WHERE Userid =@id and Username=@User ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@User", TxtUser.Text);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); //insert,delete,update
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
                MessageBox.Show("User deleted Sucessfully");
                Form2_Load(sender, e);
            }
        }

        public int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    id = Convert.ToInt32(row.Cells["userid"].Value.ToString());
                    TxtUser.Text = row.Cells["username"].Value.ToString();
                    TxtPass.Text = row.Cells["password"].Value.ToString();
                    comboBox1.Text = row.Cells["usertype"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Valid index");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        public void ClearBoxes()
        {
            TxtUser.Clear();
            TxtPass.Clear();
            TxtRepass.Clear();
            comboBox1.SelectedIndex = 0;
            id = 0;
        }

        public void TotalUser()
        {
            //SqlConnection con = new SqlConnection(connectionString);
            string sql = "select COUNT(Userid) from tblUser";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "countuser");

            label1.Text = "Total User:" + " " + ds.Tables["countuser"].Rows[0][0].ToString();
        }
    }
}
 