namespace FinalTerm1
{
    partial class Getticket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt2home = new System.Windows.Forms.Button();
            this.btgetticket = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbhall = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmvname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.lbdisplay = new System.Windows.Forms.Label();
            this.btmoviecheck = new System.Windows.Forms.Button();
            this.dtimepicker = new System.Windows.Forms.DateTimePicker();
            this.tbseatnumber = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.Label();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbticketamount = new System.Windows.Forms.ComboBox();
            this.labelticketamount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labeldisprice = new System.Windows.Forms.Label();
            this.btshowtickets = new System.Windows.Forms.Button();
            this.mticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sITDBDataSet1 = new FinalTerm1.SITDBDataSet1();
            this.mticketsTableAdapter = new FinalTerm1.SITDBDataSet1TableAdapters.MticketsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt2home
            // 
            this.bt2home.Location = new System.Drawing.Point(837, 520);
            this.bt2home.Name = "bt2home";
            this.bt2home.Size = new System.Drawing.Size(125, 39);
            this.bt2home.TabIndex = 25;
            this.bt2home.Text = "back to Home";
            this.bt2home.UseVisualStyleBackColor = true;
            this.bt2home.Click += new System.EventHandler(this.bt2home_Click);
            // 
            // btgetticket
            // 
            this.btgetticket.Location = new System.Drawing.Point(398, 470);
            this.btgetticket.Name = "btgetticket";
            this.btgetticket.Size = new System.Drawing.Size(200, 89);
            this.btgetticket.TabIndex = 24;
            this.btgetticket.Text = "GET Ticket";
            this.btgetticket.UseVisualStyleBackColor = true;
            this.btgetticket.Click += new System.EventHandler(this.btgetticket_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Seat No";
            // 
            // cbhall
            // 
            this.cbhall.FormattingEnabled = true;
            this.cbhall.Items.AddRange(new object[] {
            "Hall 1",
            "Hall 2",
            "Hall 3",
            "Hall 4"});
            this.cbhall.Location = new System.Drawing.Point(164, 190);
            this.cbhall.Name = "cbhall";
            this.cbhall.Size = new System.Drawing.Size(200, 24);
            this.cbhall.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date";
            // 
            // cbtime
            // 
            this.cbtime.FormattingEnabled = true;
            this.cbtime.Items.AddRange(new object[] {
            "Start 9:00 AM",
            "Start 12:00 PM",
            "Start 4:00 PM",
            "Start 7:00 PM"});
            this.cbtime.Location = new System.Drawing.Point(164, 144);
            this.cbtime.Name = "cbtime";
            this.cbtime.Size = new System.Drawing.Size(200, 24);
            this.cbtime.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Time";
            // 
            // cbmvname
            // 
            this.cbmvname.FormattingEnabled = true;
            this.cbmvname.IntegralHeight = false;
            this.cbmvname.Location = new System.Drawing.Point(164, 97);
            this.cbmvname.Name = "cbmvname";
            this.cbmvname.Size = new System.Drawing.Size(200, 24);
            this.cbmvname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Movie Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Management Movie Ticket";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Price";
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(164, 418);
            this.tbprice.Multiline = true;
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(200, 34);
            this.tbprice.TabIndex = 27;
            // 
            // lbdisplay
            // 
            this.lbdisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdisplay.Location = new System.Drawing.Point(395, 97);
            this.lbdisplay.Name = "lbdisplay";
            this.lbdisplay.Size = new System.Drawing.Size(567, 322);
            this.lbdisplay.TabIndex = 28;
            this.lbdisplay.Text = "Movie Information:";
            // 
            // btmoviecheck
            // 
            this.btmoviecheck.Location = new System.Drawing.Point(639, 520);
            this.btmoviecheck.Name = "btmoviecheck";
            this.btmoviecheck.Size = new System.Drawing.Size(125, 39);
            this.btmoviecheck.TabIndex = 29;
            this.btmoviecheck.Text = "Movie Check";
            this.btmoviecheck.UseVisualStyleBackColor = true;
            this.btmoviecheck.Click += new System.EventHandler(this.btmoviecheck_Click);
            // 
            // dtimepicker
            // 
            this.dtimepicker.Location = new System.Drawing.Point(164, 240);
            this.dtimepicker.Name = "dtimepicker";
            this.dtimepicker.Size = new System.Drawing.Size(200, 22);
            this.dtimepicker.TabIndex = 30;
            // 
            // tbseatnumber
            // 
            this.tbseatnumber.Location = new System.Drawing.Point(164, 292);
            this.tbseatnumber.Multiline = true;
            this.tbseatnumber.Name = "tbseatnumber";
            this.tbseatnumber.Size = new System.Drawing.Size(200, 36);
            this.tbseatnumber.TabIndex = 31;
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(164, 353);
            this.tbtel.Multiline = true;
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(200, 34);
            this.tbtel.TabIndex = 33;
            // 
            // Tel
            // 
            this.Tel.AutoSize = true;
            this.Tel.Location = new System.Drawing.Point(72, 371);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(27, 16);
            this.Tel.TabIndex = 32;
            this.Tel.Text = "Tel";
            // 
            // cbstatus
            // 
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "bought",
            "not bought yet"});
            this.cbstatus.Location = new System.Drawing.Point(164, 478);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(200, 24);
            this.cbstatus.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Status";
            // 
            // cbticketamount
            // 
            this.cbticketamount.FormattingEnabled = true;
            this.cbticketamount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbticketamount.Location = new System.Drawing.Point(164, 528);
            this.cbticketamount.Name = "cbticketamount";
            this.cbticketamount.Size = new System.Drawing.Size(200, 24);
            this.cbticketamount.TabIndex = 37;
            // 
            // labelticketamount
            // 
            this.labelticketamount.AutoSize = true;
            this.labelticketamount.Location = new System.Drawing.Point(54, 531);
            this.labelticketamount.Name = "labelticketamount";
            this.labelticketamount.Size = new System.Drawing.Size(92, 16);
            this.labelticketamount.TabIndex = 36;
            this.labelticketamount.Text = "Ticket Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(443, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Total price:";
            // 
            // labeldisprice
            // 
            this.labeldisprice.AutoSize = true;
            this.labeldisprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldisprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labeldisprice.Location = new System.Drawing.Point(610, 15);
            this.labeldisprice.Name = "labeldisprice";
            this.labeldisprice.Size = new System.Drawing.Size(265, 54);
            this.labeldisprice.TabIndex = 39;
            this.labeldisprice.Text = "xxx.xxx.xxx";
            // 
            // btshowtickets
            // 
            this.btshowtickets.Location = new System.Drawing.Point(639, 470);
            this.btshowtickets.Name = "btshowtickets";
            this.btshowtickets.Size = new System.Drawing.Size(125, 39);
            this.btshowtickets.TabIndex = 40;
            this.btshowtickets.Text = "Show Tickets";
            this.btshowtickets.UseVisualStyleBackColor = true;
            this.btshowtickets.Click += new System.EventHandler(this.btshowtickets_Click);
            // 
            // mticketsBindingSource
            // 
            this.mticketsBindingSource.DataMember = "Mtickets";
            this.mticketsBindingSource.DataSource = this.sITDBDataSet1;
            // 
            // sITDBDataSet1
            // 
            this.sITDBDataSet1.DataSetName = "SITDBDataSet1";
            this.sITDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mticketsTableAdapter
            // 
            this.mticketsTableAdapter.ClearBeforeFill = true;
            // 
            // Getticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 579);
            this.Controls.Add(this.btshowtickets);
            this.Controls.Add(this.labeldisprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbticketamount);
            this.Controls.Add(this.labelticketamount);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbtel);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.tbseatnumber);
            this.Controls.Add(this.dtimepicker);
            this.Controls.Add(this.btmoviecheck);
            this.Controls.Add(this.lbdisplay);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt2home);
            this.Controls.Add(this.btgetticket);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbhall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbmvname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Getticket";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Getticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt2home;
        private System.Windows.Forms.Button btgetticket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbhall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmvname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label lbdisplay;
        private System.Windows.Forms.Button btmoviecheck;
        private System.Windows.Forms.DateTimePicker dtimepicker;
        private System.Windows.Forms.TextBox tbseatnumber;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.Label Tel;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbticketamount;
        private System.Windows.Forms.Label labelticketamount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labeldisprice;
        private System.Windows.Forms.Button btshowtickets;
        private SITDBDataSet1 sITDBDataSet1;
        private System.Windows.Forms.BindingSource mticketsBindingSource;
        private SITDBDataSet1TableAdapters.MticketsTableAdapter mticketsTableAdapter;
    }
}