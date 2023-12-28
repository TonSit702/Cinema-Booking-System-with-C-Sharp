namespace FinalTerm1
{
    partial class Report
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbplatinum = new System.Windows.Forms.Label();
            this.lbmoviename = new System.Windows.Forms.Label();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbhall = new System.Windows.Forms.Label();
            this.lbseat = new System.Windows.Forms.Label();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbstatusb = new System.Windows.Forms.Label();
            this.btrefresh = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 268);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbplatinum
            // 
            this.lbplatinum.AutoSize = true;
            this.lbplatinum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbplatinum.Location = new System.Drawing.Point(62, 27);
            this.lbplatinum.Name = "lbplatinum";
            this.lbplatinum.Size = new System.Drawing.Size(262, 32);
            this.lbplatinum.TabIndex = 1;
            this.lbplatinum.Text = "Platinum Cineplex";
            // 
            // lbmoviename
            // 
            this.lbmoviename.AutoSize = true;
            this.lbmoviename.BackColor = System.Drawing.Color.Transparent;
            this.lbmoviename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmoviename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbmoviename.Location = new System.Drawing.Point(419, 50);
            this.lbmoviename.Name = "lbmoviename";
            this.lbmoviename.Size = new System.Drawing.Size(180, 32);
            this.lbmoviename.TabIndex = 2;
            this.lbmoviename.Text = "Movie Name:";
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtime.Location = new System.Drawing.Point(420, 126);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(62, 25);
            this.lbtime.TabIndex = 3;
            this.lbtime.Text = "Time:";
            // 
            // lbhall
            // 
            this.lbhall.AutoSize = true;
            this.lbhall.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhall.Location = new System.Drawing.Point(610, 180);
            this.lbhall.Name = "lbhall";
            this.lbhall.Size = new System.Drawing.Size(92, 42);
            this.lbhall.TabIndex = 4;
            this.lbhall.Text = "Hall:";
            // 
            // lbseat
            // 
            this.lbseat.AutoSize = true;
            this.lbseat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbseat.Location = new System.Drawing.Point(418, 180);
            this.lbseat.Name = "lbseat";
            this.lbseat.Size = new System.Drawing.Size(163, 42);
            this.lbseat.TabIndex = 5;
            this.lbseat.Text = "Seat No:";
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(422, 250);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(92, 25);
            this.lbdate.TabIndex = 6;
            this.lbdate.Text = "datetime:";
            // 
            // lbstatusb
            // 
            this.lbstatusb.AutoSize = true;
            this.lbstatusb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatusb.Location = new System.Drawing.Point(612, 126);
            this.lbstatusb.Name = "lbstatusb";
            this.lbstatusb.Size = new System.Drawing.Size(74, 25);
            this.lbstatusb.TabIndex = 7;
            this.lbstatusb.Text = "Status:";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(112, 363);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(172, 52);
            this.btrefresh.TabIndex = 8;
            this.btrefresh.Text = "refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // bthome
            // 
            this.bthome.Location = new System.Drawing.Point(595, 363);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(172, 52);
            this.bthome.TabIndex = 9;
            this.bthome.Text = "Back to  Home";
            this.bthome.UseVisualStyleBackColor = true;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bthome);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.lbstatusb);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.lbseat);
            this.Controls.Add(this.lbhall);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.lbmoviename);
            this.Controls.Add(this.lbplatinum);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbplatinum;
        private System.Windows.Forms.Label lbmoviename;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbhall;
        private System.Windows.Forms.Label lbseat;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbstatusb;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button bthome;
    }
}