namespace FinalTerm1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.btmanagemv = new System.Windows.Forms.Button();
            this.btlogout = new System.Windows.Forms.Button();
            this.btticket = new System.Windows.Forms.Button();
            this.btregister = new System.Windows.Forms.Button();
            this.btlistticket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platinum Cineplex";
            // 
            // btmanagemv
            // 
            this.btmanagemv.BackColor = System.Drawing.Color.Transparent;
            this.btmanagemv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btmanagemv.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmanagemv.ForeColor = System.Drawing.Color.RosyBrown;
            this.btmanagemv.Image = ((System.Drawing.Image)(resources.GetObject("btmanagemv.Image")));
            this.btmanagemv.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmanagemv.Location = new System.Drawing.Point(118, 319);
            this.btmanagemv.Name = "btmanagemv";
            this.btmanagemv.Size = new System.Drawing.Size(131, 116);
            this.btmanagemv.TabIndex = 1;
            this.btmanagemv.Text = "Manage Movie";
            this.btmanagemv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmanagemv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btmanagemv.UseVisualStyleBackColor = false;
            this.btmanagemv.Click += new System.EventHandler(this.btmanagemv_Click);
            // 
            // btlogout
            // 
            this.btlogout.Font = new System.Drawing.Font("Noto Sans Lao", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogout.Image = ((System.Drawing.Image)(resources.GetObject("btlogout.Image")));
            this.btlogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btlogout.Location = new System.Drawing.Point(40, 527);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(70, 80);
            this.btlogout.TabIndex = 2;
            this.btlogout.Text = "Logout";
            this.btlogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // btticket
            // 
            this.btticket.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btticket.ForeColor = System.Drawing.Color.RosyBrown;
            this.btticket.Image = ((System.Drawing.Image)(resources.GetObject("btticket.Image")));
            this.btticket.Location = new System.Drawing.Point(118, 170);
            this.btticket.Name = "btticket";
            this.btticket.Size = new System.Drawing.Size(131, 116);
            this.btticket.TabIndex = 3;
            this.btticket.Text = "Reserve Ticket";
            this.btticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btticket.UseVisualStyleBackColor = true;
            this.btticket.Click += new System.EventHandler(this.btticket_Click);
            // 
            // btregister
            // 
            this.btregister.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregister.ForeColor = System.Drawing.Color.RosyBrown;
            this.btregister.Image = ((System.Drawing.Image)(resources.GetObject("btregister.Image")));
            this.btregister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btregister.Location = new System.Drawing.Point(293, 319);
            this.btregister.Name = "btregister";
            this.btregister.Size = new System.Drawing.Size(131, 116);
            this.btregister.TabIndex = 4;
            this.btregister.Text = "Add Employee";
            this.btregister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btregister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btregister.UseVisualStyleBackColor = true;
            this.btregister.Click += new System.EventHandler(this.btregister_Click);
            // 
            // btlistticket
            // 
            this.btlistticket.Font = new System.Drawing.Font("Noto Sans Lao", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlistticket.ForeColor = System.Drawing.Color.RosyBrown;
            this.btlistticket.Image = ((System.Drawing.Image)(resources.GetObject("btlistticket.Image")));
            this.btlistticket.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btlistticket.Location = new System.Drawing.Point(293, 170);
            this.btlistticket.Name = "btlistticket";
            this.btlistticket.Size = new System.Drawing.Size(131, 116);
            this.btlistticket.TabIndex = 5;
            this.btlistticket.Text = "List Ticket";
            this.btlistticket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btlistticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlistticket.UseVisualStyleBackColor = true;
            this.btlistticket.Click += new System.EventHandler(this.btlistticket_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.btlistticket);
            this.Controls.Add(this.btregister);
            this.Controls.Add(this.btticket);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.btmanagemv);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1030, 670);
            this.MinimumSize = new System.Drawing.Size(1030, 670);
            this.Name = "Home";
            this.Text = "Platinum Cineplex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmanagemv;
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Button btticket;
        private System.Windows.Forms.Button btregister;
        private System.Windows.Forms.Button btlistticket;
    }
}

