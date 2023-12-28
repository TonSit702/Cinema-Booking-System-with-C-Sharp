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

namespace FinalTerm1
{
    public partial class Login : Form
    {
        SqlConnection cn;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register main = new Register();
            main.ShowDialog();
        }
        private bool CheckLogin(string loginUsername, string loginPassword)
        {
            SqlCommand checkLoginCmd = new SqlCommand("SELECT COUNT(*) FROM Musers WHERE Username = @username AND Password = @password", cn);
            checkLoginCmd.Parameters.AddWithValue("@username", loginUsername);
            checkLoginCmd.Parameters.AddWithValue("@password", loginPassword);

            int userCount = (int)checkLoginCmd.ExecuteScalar();
            return userCount > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string loginUsername = tbuser.Text.Trim();
                string loginPassword = tbpass.Text;

                if (!string.IsNullOrEmpty(loginUsername) && !string.IsNullOrEmpty(loginPassword))
                {
                    if (CheckLogin(loginUsername, loginPassword))
                    {                       
                        tbuser.Clear();
                        tbpass.Clear();

                        this.Hide();
                        Home main = new Home();
                        main.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = IPHONE-15-PRO; Initial Catalog = SITDB; Integrated Security = True");
            cn.Open();
        }
    }
}
