using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FinalTerm1
{
    public partial class Getticket : Form
    {
        
        SqlConnection cn;
        public Getticket()
        {
            InitializeComponent();
        }

        private void Getticket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sITDBDataSet1.Mtickets' table. You can move, or remove it, as needed.
            this.mticketsTableAdapter.Fill(this.sITDBDataSet1.Mtickets);
            cn = new SqlConnection("Data Source = IPHONE-15-PRO; Initial Catalog = SITDB; Integrated Security = True");
            cn.Open();
            LoadMovieNames();

        }
        private void LoadMovieNames()
        {
            try
            {
                string query = "SELECT DISTINCT mName FROM moviename";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbmvname.Items.Add(dr["mName"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading movie names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertTicketData(string movieName, string time, DateTime date, string hall, string seatNo, string tel, decimal price, bool statusBought, string randomCodeQR, int ticketAmount)
        {
            List<int> seatNumbersList = seatNo.Split(',').Select(int.Parse).ToList();

            try
            {
                // Process each seat number individually
                foreach (int seatNumber in seatNumbersList)
                {
                    SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO [dbo].[Mtickets] " +
                        "([MovieName], [Time], [Date], [Hall], [SeatNo], [Tel], [Price], [StatusBought], [RandomCodeQR], [TicketAmount]) " +
                        "VALUES (@movieName, @time, @date, @hall, @seatNumber, @tel, @price, @statusBought, @randomCodeQR, @ticketAmount)", cn);

                    insertCmd.Parameters.AddWithValue("@movieName", string.IsNullOrEmpty(movieName) ? DBNull.Value : (object)movieName);
                    insertCmd.Parameters.AddWithValue("@time", time);
                    insertCmd.Parameters.AddWithValue("@date", date);
                    insertCmd.Parameters.AddWithValue("@hall", hall);
                    insertCmd.Parameters.AddWithValue("@seatNumber", seatNumber);
                    insertCmd.Parameters.AddWithValue("@tel", string.IsNullOrEmpty(tel) ? DBNull.Value : (object)tel);
                    insertCmd.Parameters.AddWithValue("@price", price);
                    insertCmd.Parameters.AddWithValue("@statusBought", statusBought);
                    insertCmd.Parameters.AddWithValue("@randomCodeQR", string.IsNullOrEmpty(randomCodeQR) ? DBNull.Value : (object)randomCodeQR);
                    insertCmd.Parameters.AddWithValue("@ticketAmount", ticketAmount);

                    insertCmd.ExecuteNonQuery();
                }

                // After all tickets have been inserted, update the seat status
                foreach (int seatNumber in seatNumbersList)
                {
                    SqlCommand updateCmd = new SqlCommand(
                        "UPDATE [dbo].[Mseats] " +
                        "SET IsOccupied = 1 " +
                        "WHERE HallNumber = @hall AND SeatNumber = @seatNumber", cn);

                    updateCmd.Parameters.AddWithValue("@hall", hall);
                    updateCmd.Parameters.AddWithValue("@seatNumber", seatNumber);

                    try
                    {
                        updateCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during seat update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during ticket insertion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetInputFields()
        {
            
            cbmvname.SelectedIndex = -1;
            cbtime.SelectedIndex = -1;
            dtimepicker.Value = DateTime.Now;
            cbhall.SelectedIndex = -1;
            tbseatnumber.Text = string.Empty;
            tbtel.Text = string.Empty;
            tbprice.Text = string.Empty;
            cbstatus.SelectedIndex = -1;

        }
        private void btgetticket_Click(object sender, EventArgs e)
        {
            try
            {
                string hallNumber = cbhall.SelectedItem?.ToString();
                int seatNumber;
                int selectedTicketAmount;

                string[] seatNumberStrings = tbseatnumber.Text.Split(',');
                List<int> seatNumbers = new List<int>();

                foreach (string seatNumberString in seatNumberStrings)
                {
                    if (int.TryParse(seatNumberString, out seatNumber))
                    {
                        seatNumbers.Add(seatNumber);
                    }
                }

                if (AreSeatsEmpty(hallNumber, seatNumbers))
                {
                    DialogResult result = MessageBox.Show("Do you want to GET Ticket?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string movieName = cbmvname.SelectedItem?.ToString();
                        string time = cbtime.SelectedItem?.ToString();
                        DateTime date = dtimepicker.Value;
                        string hall = cbhall.SelectedItem?.ToString();
                        string seatNo = tbseatnumber.Text.Trim();
                        decimal price;

                        if (!decimal.TryParse(tbprice.Text, out price))
                        {
                            MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string tel = tbtel.Text;
                        bool statusBought = cbstatus.SelectedItem?.ToString() == "bought";
                        string randomCodeQR = tbtel.Text + Guid.NewGuid().ToString();

                        if (cbticketamount.SelectedItem != null && int.TryParse(cbticketamount.SelectedItem.ToString(), out selectedTicketAmount))
                        {
                            decimal totalPrice = price * selectedTicketAmount;

                            InsertTicketData(movieName, time, date, hall, seatNo, tel, totalPrice, statusBought, randomCodeQR, selectedTicketAmount);

                            labeldisprice.Text = $"{totalPrice:N2}";
                            MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid ticket amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter a valid seat number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private bool AreSeatsEmpty(string hallNumber, List<int> seatNumbers)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Mseats WHERE HallNumber = @hallNumber AND SeatNumber IN ({0}) AND IsOccupied = 1";
                string seatNumberParameters = string.Join(",", seatNumbers.Select((_, index) => $"@seatNumber{index}"));
                query = string.Format(query, seatNumberParameters);

                using (SqlCommand checkSeatCmd = new SqlCommand(query, cn))
                {
                    checkSeatCmd.Parameters.AddWithValue("@hallNumber", hallNumber);

                    for (int i = 0; i < seatNumbers.Count; i++)
                    {
                        checkSeatCmd.Parameters.AddWithValue($"@seatNumber{i}", seatNumbers[i]);
                    }

                    int occupiedSeatsCount = (int)checkSeatCmd.ExecuteScalar();

                    return occupiedSeatsCount == 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during seat check: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // or handle the error accordingly
            }
        }

        private void btmoviecheck_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedMovieName = cbmvname.SelectedItem?.ToString();
                string selectedHall = cbhall.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(selectedMovieName) && !string.IsNullOrEmpty(selectedHall))
                {
                    string movieQuery = $"SELECT * FROM moviename WHERE mName = '{selectedMovieName}'";
                    string seatsQuery = $"SELECT SeatNumber FROM Mseats WHERE HallNumber = '{selectedHall}' AND IsOccupied = 0";

                    SqlCommand movieCmd = new SqlCommand(movieQuery, cn);
                    SqlDataReader movieDr = movieCmd.ExecuteReader();

                    if (movieDr.Read())
                    {
                        lbdisplay.Text = $"Movie Name: {movieDr["mName"]}\nStart: {movieDr["mStart"]}, End: {movieDr["mEnd"]}\nOn Hall: {movieDr["Hall"]}\nTime: {movieDr["Time"]}";
                    }
                    else
                    {
                        lbdisplay.Text = "No data found for the selected movie name.";
                    }

                    movieDr.Close();

                    
                    SqlCommand seatsCmd = new SqlCommand(seatsQuery, cn);
                    SqlDataReader seatsDr = seatsCmd.ExecuteReader();

                    StringBuilder seatNumbers = new StringBuilder();

                    while (seatsDr.Read())
                    {
                        seatNumbers.Append($"{seatsDr["SeatNumber"]}, ");
                    }

                    seatsDr.Close();

                    if (seatNumbers.Length > 0)
                    {
                        seatNumbers.Length -= 2; 
                        lbdisplay.Text += $"\nAll SeatNumbers with IsOccupied = 0 for Hall {selectedHall}: {seatNumbers.ToString()}";
                    }
                    else
                    {
                        lbdisplay.Text += $"\nNo available seats with IsOccupied = 0 for Hall {selectedHall}.";
                    }
                }
                else
                {
                    lbdisplay.Text = "Please select a movie name and Hall from the ComboBox.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt2home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home main = new Home();
            main.ShowDialog();
        }




        private void btshowtickets_Click(object sender, EventArgs e)
        {
            Report main = new Report();
            main.Show();
            

            
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            
        }
    }
}
