namespace FinalTerm1
{
    partial class Manage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtmoviename = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mvStart = new System.Windows.Forms.DateTimePicker();
            this.mvEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tbmid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movienameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sITDBDataSet = new FinalTerm1.SITDBDataSet();
            this.movienameTableAdapter = new FinalTerm1.SITDBDataSetTableAdapters.movienameTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.cbtimemv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movienameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management Movie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtmoviename
            // 
            this.txtmoviename.Location = new System.Drawing.Point(167, 128);
            this.txtmoviename.Name = "txtmoviename";
            this.txtmoviename.Size = new System.Drawing.Size(200, 22);
            this.txtmoviename.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 38);
            this.button3.TabIndex = 16;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(364, 477);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 39);
            this.button4.TabIndex = 17;
            this.button4.Text = "Back To Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Movie Start";
            // 
            // mvStart
            // 
            this.mvStart.Location = new System.Drawing.Point(166, 183);
            this.mvStart.Name = "mvStart";
            this.mvStart.Size = new System.Drawing.Size(200, 22);
            this.mvStart.TabIndex = 19;
            // 
            // mvEnd
            // 
            this.mvEnd.Location = new System.Drawing.Point(166, 230);
            this.mvEnd.Name = "mvEnd";
            this.mvEnd.Size = new System.Drawing.Size(200, 22);
            this.mvEnd.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Movie End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hall";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Time";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Hall 1",
            "Hall 2",
            "Hall 3",
            "Hall 4"});
            this.checkedListBox1.Location = new System.Drawing.Point(167, 320);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 25;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tbmid
            // 
            this.tbmid.Location = new System.Drawing.Point(167, 83);
            this.tbmid.Name = "tbmid";
            this.tbmid.Size = new System.Drawing.Size(200, 22);
            this.tbmid.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "MID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIDDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.mStartDataGridViewTextBoxColumn,
            this.mEndDataGridViewTextBoxColumn,
            this.hallDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movienameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(541, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 480);
            this.dataGridView1.TabIndex = 29;
            // 
            // mIDDataGridViewTextBoxColumn
            // 
            this.mIDDataGridViewTextBoxColumn.DataPropertyName = "MID";
            this.mIDDataGridViewTextBoxColumn.HeaderText = "MID";
            this.mIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mIDDataGridViewTextBoxColumn.Name = "mIDDataGridViewTextBoxColumn";
            this.mIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "mName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "mName";
            this.mNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // mStartDataGridViewTextBoxColumn
            // 
            this.mStartDataGridViewTextBoxColumn.DataPropertyName = "mStart";
            this.mStartDataGridViewTextBoxColumn.HeaderText = "mStart";
            this.mStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mStartDataGridViewTextBoxColumn.Name = "mStartDataGridViewTextBoxColumn";
            this.mStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // mEndDataGridViewTextBoxColumn
            // 
            this.mEndDataGridViewTextBoxColumn.DataPropertyName = "mEnd";
            this.mEndDataGridViewTextBoxColumn.HeaderText = "mEnd";
            this.mEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mEndDataGridViewTextBoxColumn.Name = "mEndDataGridViewTextBoxColumn";
            this.mEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // hallDataGridViewTextBoxColumn
            // 
            this.hallDataGridViewTextBoxColumn.DataPropertyName = "Hall";
            this.hallDataGridViewTextBoxColumn.HeaderText = "Hall";
            this.hallDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallDataGridViewTextBoxColumn.Name = "hallDataGridViewTextBoxColumn";
            this.hallDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // movienameBindingSource
            // 
            this.movienameBindingSource.DataMember = "moviename";
            this.movienameBindingSource.DataSource = this.sITDBDataSet;
            // 
            // sITDBDataSet
            // 
            this.sITDBDataSet.DataSetName = "SITDBDataSet";
            this.sITDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movienameTableAdapter
            // 
            this.movienameTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(214, 477);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 39);
            this.button5.TabIndex = 30;
            this.button5.Text = "Clear Seat No";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbtimemv
            // 
            this.cbtimemv.FormattingEnabled = true;
            this.cbtimemv.Items.AddRange(new object[] {
            "Start 9:00 AM",
            "Start 12:00 PM",
            "Start 4:00 PM",
            "Start 7:00 PM"});
            this.cbtimemv.Location = new System.Drawing.Point(166, 271);
            this.cbtimemv.Name = "cbtimemv";
            this.cbtimemv.Size = new System.Drawing.Size(199, 24);
            this.cbtimemv.TabIndex = 31;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 529);
            this.Controls.Add(this.cbtimemv);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbmid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mvEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mvStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtmoviename);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Manage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movienameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtmoviename;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker mvStart;
        private System.Windows.Forms.DateTimePicker mvEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox tbmid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SITDBDataSet sITDBDataSet;
        private System.Windows.Forms.BindingSource movienameBindingSource;
        private SITDBDataSetTableAdapters.movienameTableAdapter movienameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbtimemv;
    }
}