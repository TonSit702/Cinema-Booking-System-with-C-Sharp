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
    public partial class Register : Form
    {

        
        SqlConnection cn;
        
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.ShowDialog();
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            try
            {
                
                string username = tbuser.Text;
                string password = tbpass.Text;
                string email = tbemail.Text;
                string tel = tbtel.Text;

                
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(email))
                {
                    
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Musers WHERE Username = @username", cn);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int existingUserCount = (int)checkCmd.ExecuteScalar();

                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Confirm to Register member?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            SqlCommand insertCmd = new SqlCommand("INSERT INTO Musers (Username, Password, Email, Tel) VALUES (@username, @password, @email, @tel)", cn);
                            insertCmd.Parameters.AddWithValue("@username", username);
                            insertCmd.Parameters.AddWithValue("@password", password);
                            insertCmd.Parameters.AddWithValue("@email", email);
                            insertCmd.Parameters.AddWithValue("@tel", tel);

                            int rowsAffected = insertCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                tbuser.Clear();
                                tbpass.Clear();
                                tbemail.Clear();
                                tbtel.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Register_Load(object sender, EventArgs e)
        {
            
            cn = new SqlConnection("Data Source = IPHONE-15-PRO; Initial Catalog = SITDB; Integrated Security = True");
            cn.Open();
        }
    }
}
