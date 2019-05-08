namespace HospitalManagementSystem
{
    partial class frm_doctorSchedule
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_schedule = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chk_sunday = new System.Windows.Forms.CheckBox();
            this.chk_monday = new System.Windows.Forms.CheckBox();
            this.chk_tuesday = new System.Windows.Forms.CheckBox();
            this.chk_wednesday = new System.Windows.Forms.CheckBox();
            this.chk_thursday = new System.Windows.Forms.CheckBox();
            this.chk_friday = new System.Windows.Forms.CheckBox();
            this.chk_saturday = new System.Windows.Forms.CheckBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_schedule
            // 
            this.lbl_schedule.AutoSize = true;
            this.lbl_schedule.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_schedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_schedule.Location = new System.Drawing.Point(4, 86);
            this.lbl_schedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_schedule.Name = "lbl_schedule";
            this.lbl_schedule.Size = new System.Drawing.Size(248, 28);
            this.lbl_schedule.TabIndex = 10;
            this.lbl_schedule.Text = "Your Available Days";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.chk_sunday, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chk_monday, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chk_tuesday, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.chk_wednesday, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.chk_thursday, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.chk_friday, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.chk_saturday, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 139);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 243);
            this.tableLayoutPanel2.TabIndex = 9;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // chk_sunday
            // 
            this.chk_sunday.AutoSize = true;
            this.chk_sunday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_sunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.chk_sunday.Location = new System.Drawing.Point(4, 4);
            this.chk_sunday.Margin = new System.Windows.Forms.Padding(4);
            this.chk_sunday.Name = "chk_sunday";
            this.chk_sunday.Size = new System.Drawing.Size(104, 26);
            this.chk_sunday.TabIndex = 0;
            this.chk_sunday.Text = "Sunday";
            this.chk_sunday.UseVisualStyleBackColor = true;
            this.chk_sunday.CheckedChanged += new System.EventHandler(this.chk_sunday_CheckedChanged);
            // 
            // chk_monday
            // 
            this.chk_monday.AutoSize = true;
            this.chk_monday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_monday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.chk_monday.Location = new System.Drawing.Point(4, 38);
            this.chk_monday.Margin = new System.Windows.Forms.Padding(4);
            this.chk_monday.Name = "chk_monday";
            this.chk_monday.Size = new System.Drawing.Size(113, 26);
            this.chk_monday.TabIndex = 9;
            this.chk_monday.Text = "Monday";
            this.chk_monday.UseVisualStyleBackColor = true;
            this.chk_monday.CheckedChanged += new System.EventHandler(this.chk_monday_CheckedChanged);
            // 
            // chk_tuesday
            // 
            this.chk_tuesday.AutoSize = true;
            this.chk_tuesday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_tuesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.chk_tuesday.Location = new System.Drawing.Point(4, 72);
            this.chk_tuesday.Margin = new System.Windows.Forms.Padding(4);
            this.chk_tuesday.Name = "chk_tuesday";
            this.chk_tuesday.Size = new System.Drawing.Size(112, 26);
            this.chk_tuesday.TabIndex = 10;
            this.chk_tuesday.Text = "Tuesday";
            this.chk_tuesday.UseVisualStyleBackColor = true;
            this.chk_tuesday.CheckedChanged += new System.EventHandler(this.chk_tuesday_CheckedChanged);
            // 
            // chk_wednesday
            // 
            this.chk_wednesday.AutoSize = true;
            this.chk_wednesday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_wednesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.chk_wednesday.Location = new System.Drawing.Point(4, 106);
            this.chk_wednesday.Margin = new System.Windows.Forms.Padding(4);
            this.chk_wednesday.Name = "chk_wednesday";
            this.chk_wednesday.Size = new System.Drawing.Size(148, 26);
            this.chk_wednesday.TabIndex = 11;
            this.chk_wednesday.Text = "Wednesday";
            this.chk_wednesday.UseVisualStyleBackColor = true;
            this.chk_wednesday.CheckedChanged += new System.EventHandler(this.chk_wednesday_CheckedChanged);
            // 
            // chk_thursday
            // 
            this.chk_thursday.AutoSize = true;
            this.chk_thursday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_thursday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.chk_thursday.Location = new System.Drawing.Point(4, 140);
            this.chk_thursday.Margin = new System.Windows.Forms.Padding(4);
            this.chk_thursday.Name = "chk_thursday";
            this.chk_thursday.Size = new System.Drawing.Size(117, 26);
            this.chk_thursday.TabIndex = 12;
            this.chk_thursday.Text = "Thursday";
            this.chk_thursday.UseVisualStyleBackColor = true;
            this.chk_thursday.CheckedChanged += new System.EventHandler(this.chk_thursday_CheckedChanged);
            // 
            // chk_friday
            // 
            this.chk_friday.AutoSize = true;
            this.chk_friday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_friday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.chk_friday.Location = new System.Drawing.Point(4, 174);
            this.chk_friday.Margin = new System.Windows.Forms.Padding(4);
            this.chk_friday.Name = "chk_friday";
            this.chk_friday.Size = new System.Drawing.Size(91, 26);
            this.chk_friday.TabIndex = 13;
            this.chk_friday.Text = "Friday";
            this.chk_friday.UseVisualStyleBackColor = true;
            this.chk_friday.CheckedChanged += new System.EventHandler(this.chk_friday_CheckedChanged);
            // 
            // chk_saturday
            // 
            this.chk_saturday.AutoSize = true;
            this.chk_saturday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_saturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.chk_saturday.Location = new System.Drawing.Point(4, 208);
            this.chk_saturday.Margin = new System.Windows.Forms.Padding(4);
            this.chk_saturday.Name = "chk_saturday";
            this.chk_saturday.Size = new System.Drawing.Size(117, 27);
            this.chk_saturday.TabIndex = 14;
            this.chk_saturday.Text = "Saturday";
            this.chk_saturday.UseVisualStyleBackColor = true;
            this.chk_saturday.CheckedChanged += new System.EventHandler(this.chk_saturday_CheckedChanged);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_header.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_header.Location = new System.Drawing.Point(4, 37);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(501, 49);
            this.lbl_header.TabIndex = 8;
            this.lbl_header.Text = "Hello, Dr. ";
            this.lbl_header.Click += new System.EventHandler(this.lbl_header_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_header, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_schedule, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 386);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // frm_doctorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(509, 386);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_doctorSchedule";
            this.Text = "frm_doctorSchedule";
            this.Load += new System.EventHandler(this.frm_doctorSchedule_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_schedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chk_sunday;
        private System.Windows.Forms.CheckBox chk_monday;
        private System.Windows.Forms.CheckBox chk_tuesday;
        private System.Windows.Forms.CheckBox chk_wednesday;
        private System.Windows.Forms.CheckBox chk_thursday;
        private System.Windows.Forms.CheckBox chk_friday;
        private System.Windows.Forms.CheckBox chk_saturday;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}