using System;

using System.Data.SqlClient;
using System.Drawing;

using System.Windows.Forms;


namespace FinalTerm1
{
    public partial class Report : Form
    {

        SqlConnection cn;
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = IPHONE-15-PRO; Initial Catalog = SITDB; Integrated Security = True");
            cn.Open();

        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT TOP 1 * FROM [SITDB].[dbo].[Mtickets] ORDER BY MTID DESC";
                SqlCommand cmd = new SqlCommand(selectQuery, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Assuming label1, label2, ..., label7 are the names of your labels
                    //lbmoviename.Text = dr["MovieName"].ToString();
                    lbmoviename.Text = char.ToUpper(dr["MovieName"].ToString()[0]) + dr["MovieName"].ToString().Substring(1);

                    lbtime.Text = dr["Time"].ToString();
                    lbdate.Text = dr["Date"].ToString();
                    lbhall.Text = dr["Hall"].ToString();
                    lbseat.Text = "Seat:" + dr["SeatNo"].ToString();



                    string randomCode = dr["RandomCodeQR"].ToString();
                    Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                    pictureBox1.Image = qrcode.Draw(randomCode, 70);

                    int statusBought = Convert.ToInt32(dr["StatusBought"]);
                    lbstatusb.Text = statusBought == 1 ? "Bought" : "Not Bought";
                    
                    lbstatusb.ForeColor = statusBought == 1 ? Color.Green : Color.Red;

                }
                else
                {
                    MessageBox.Show("No data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bthome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home main = new Home();
            main.Show();
        }
    }

}
   
