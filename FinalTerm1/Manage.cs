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
    public partial class Manage : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        //SqlDataAdapter da;
        public Manage()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            
            this.movienameTableAdapter.Fill(this.sITDBDataSet.moviename);
            cn = new SqlConnection("Data Source = IPHONE-15-PRO; Initial Catalog = SITDB; Integrated Security = True");
            cn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtmoviename.Text != string.Empty)
            {
                cmd = new SqlCommand("SELECT * FROM moviename WHERE mName='" + txtmoviename.Text + "'", cn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("This Movie already Exists, Please use another...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    DialogResult result = MessageBox.Show("Do you want to ADD this User?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        
                        if (DateTime.TryParse(mvStart.Text, out DateTime movieStart) && DateTime.TryParse(mvEnd.Text, out DateTime movieEnd))
                        {
                            
                            string selectedHalls = string.Join(",", checkedListBox1.CheckedItems.Cast<object>().Select(item => item.ToString()));
                            string selectedTimes = cbtimemv.SelectedItem?.ToString();

                            cmd = new SqlCommand("INSERT INTO moviename (mName, mStart, mEnd, Hall, Time) " +
                                                 "VALUES (@movieName, @movieStart, @movieEnd, @hall, @time)", cn);
                            cmd.Parameters.AddWithValue("@movieName", txtmoviename.Text);
                            cmd.Parameters.AddWithValue("@movieStart", movieStart);
                            cmd.Parameters.AddWithValue("@movieEnd", movieEnd);
                            cmd.Parameters.AddWithValue("@hall", selectedHalls);
                            cmd.Parameters.AddWithValue("@time", selectedTimes);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your data has been added", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format. Please enter valid dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }
        

        private void TimeChecklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmoviename.Text != string.Empty && tbmid.Text != string.Empty)
            {
                cmd = new SqlCommand("SELECT * FROM moviename WHERE MID = @mid", cn);
                cmd.Parameters.AddWithValue("@mid", tbmid.Text);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();

                    
                    DialogResult result = MessageBox.Show("Do you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        
                        if (DateTime.TryParse(mvStart.Text, out DateTime movieStart) && DateTime.TryParse(mvEnd.Text, out DateTime movieEnd))
                        {
                            
                            string selectedHalls = string.Join(",", checkedListBox1.CheckedItems.Cast<object>().Select(item => item.ToString()));
                            string selectedTimes = cbtimemv.SelectedItem?.ToString();


                            cmd = new SqlCommand("UPDATE moviename SET mName = @movieName, mStart = @movieStart, mEnd = @movieEnd, Hall = @hall, Time = @time WHERE MID = @mid", cn);
                            cmd.Parameters.AddWithValue("@movieName", txtmoviename.Text);
                            cmd.Parameters.AddWithValue("@movieStart", movieStart);
                            cmd.Parameters.AddWithValue("@movieEnd", movieEnd);
                            cmd.Parameters.AddWithValue("@hall", selectedHalls);
                            cmd.Parameters.AddWithValue("@time", selectedTimes);
                            cmd.Parameters.AddWithValue("@mid", tbmid.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your data has been updated", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format. Please enter valid dates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No record found with MID: " + tbmid.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please input all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

    }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbmid.Text != string.Empty)
            {
                
                cmd = new SqlCommand("SELECT * FROM moviename WHERE MID = @mid", cn);
                cmd.Parameters.AddWithValue("@mid", tbmid.Text);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();

                    
                    DialogResult result = MessageBox.Show("Do you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        
                        cmd = new SqlCommand("DELETE FROM moviename WHERE MID = @mid", cn);
                        cmd.Parameters.AddWithValue("@mid", tbmid.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record with MID: " + tbmid.Text + " has been deleted", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGridView();
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No record found with MID: " + tbmid.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please input MID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void RefreshDataGridView()
        {


            try
            {
                string query = "SELECT * FROM moviename";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);

                txtmoviename.Text = string.Empty;
                tbmid.Text = string.Empty;
                mvStart.Text = string.Empty;
                mvEnd.Text = string.Empty;
                checkedListBox1.ClearSelected();
                cbtimemv.SelectedIndex = -1;

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home main = new Home();
            main.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand updateCmd = new SqlCommand(
                    "UPDATE [dbo].[Mseats] " +
                    "SET IsOccupied = 0", cn);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Occupancy status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
          
}
