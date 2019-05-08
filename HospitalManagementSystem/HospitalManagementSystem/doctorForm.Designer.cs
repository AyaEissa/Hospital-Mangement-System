namespace HospitalManagementSystem
{
    partial class doctorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.cancelUpdate_btn = new System.Windows.Forms.Button();
            this.saveUpdate_btn = new System.Windows.Forms.Button();
            this.department_txt = new System.Windows.Forms.TextBox();
            this.mobileNum_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.lName_txt = new System.Windows.Forms.TextBox();
            this.fName_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateDoctorInfo_btn = new System.Windows.Forms.Button();
            this.patientHealth_dataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descraption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.patientName_cmb = new System.Windows.Forms.ComboBox();
            this.saveHealth_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.state_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.descraption_txt = new System.Windows.Forms.TextBox();
            this.addState_groupBox = new System.Windows.Forms.GroupBox();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.cancelHealthState_btn = new System.Windows.Forms.Button();
            this.saveHealthState_btn = new System.Windows.Forms.Button();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.doctorInfo_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientHealth_dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.addState_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Name";
            // 
            // doctorInfo_groupBox
            // 
            this.doctorInfo_groupBox.Controls.Add(this.cancelUpdate_btn);
            this.doctorInfo_groupBox.Controls.Add(this.saveUpdate_btn);
            this.doctorInfo_groupBox.Controls.Add(this.department_txt);
            this.doctorInfo_groupBox.Controls.Add(this.mobileNum_txt);
            this.doctorInfo_groupBox.Controls.Add(this.password_txt);
            this.doctorInfo_groupBox.Controls.Add(this.userName_txt);
            this.doctorInfo_groupBox.Controls.Add(this.lName_txt);
            this.doctorInfo_groupBox.Controls.Add(this.fName_txt);
            this.doctorInfo_groupBox.Controls.Add(this.label5);
            this.doctorInfo_groupBox.Controls.Add(this.label4);
            this.doctorInfo_groupBox.Controls.Add(this.label3);
            this.doctorInfo_groupBox.Controls.Add(this.label2);
            this.doctorInfo_groupBox.Controls.Add(this.label1);
            this.doctorInfo_groupBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorInfo_groupBox.Location = new System.Drawing.Point(13, 51);
            this.doctorInfo_groupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doctorInfo_groupBox.Name = "doctorInfo_groupBox";
            this.doctorInfo_groupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doctorInfo_groupBox.Size = new System.Drawing.Size(441, 244);
            this.doctorInfo_groupBox.TabIndex = 1;
            this.doctorInfo_groupBox.TabStop = false;
            this.doctorInfo_groupBox.Text = "Doctor Informaion";
            // 
            // cancelUpdate_btn
            // 
            this.cancelUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelUpdate_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelUpdate_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.cancelUpdate_btn.Location = new System.Drawing.Point(202, 207);
            this.cancelUpdate_btn.Name = "cancelUpdate_btn";
            this.cancelUpdate_btn.Size = new System.Drawing.Size(113, 31);
            this.cancelUpdate_btn.TabIndex = 13;
            this.cancelUpdate_btn.Text = "Cancel";
            this.cancelUpdate_btn.UseVisualStyleBackColor = true;
            this.cancelUpdate_btn.Visible = false;
            this.cancelUpdate_btn.Click += new System.EventHandler(this.cancelUpdate_btn_Click);
            // 
            // saveUpdate_btn
            // 
            this.saveUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUpdate_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUpdate_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.saveUpdate_btn.Location = new System.Drawing.Point(321, 207);
            this.saveUpdate_btn.Name = "saveUpdate_btn";
            this.saveUpdate_btn.Size = new System.Drawing.Size(113, 31);
            this.saveUpdate_btn.TabIndex = 12;
            this.saveUpdate_btn.Text = "Save";
            this.saveUpdate_btn.UseVisualStyleBackColor = true;
            this.saveUpdate_btn.Visible = false;
            this.saveUpdate_btn.Click += new System.EventHandler(this.saveUpdate_btn_Click);
            // 
            // department_txt
            // 
            this.department_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.department_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.department_txt.ForeColor = System.Drawing.Color.White;
            this.department_txt.Location = new System.Drawing.Point(138, 178);
            this.department_txt.Name = "department_txt";
            this.department_txt.Size = new System.Drawing.Size(256, 30);
            this.department_txt.TabIndex = 10;
            this.department_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mobileNum_txt
            // 
            this.mobileNum_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.mobileNum_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileNum_txt.ForeColor = System.Drawing.Color.White;
            this.mobileNum_txt.Location = new System.Drawing.Point(138, 145);
            this.mobileNum_txt.Name = "mobileNum_txt";
            this.mobileNum_txt.Size = new System.Drawing.Size(256, 30);
            this.mobileNum_txt.TabIndex = 9;
            this.mobileNum_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_txt.ForeColor = System.Drawing.Color.White;
            this.password_txt.Location = new System.Drawing.Point(138, 112);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(256, 30);
            this.password_txt.TabIndex = 8;
            this.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userName_txt
            // 
            this.userName_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.userName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName_txt.ForeColor = System.Drawing.Color.White;
            this.userName_txt.Location = new System.Drawing.Point(138, 77);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(256, 30);
            this.userName_txt.TabIndex = 7;
            this.userName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userName_txt.TextChanged += new System.EventHandler(this.userName_txt_TextChanged);
            // 
            // lName_txt
            // 
            this.lName_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.lName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lName_txt.ForeColor = System.Drawing.Color.White;
            this.lName_txt.Location = new System.Drawing.Point(269, 43);
            this.lName_txt.Name = "lName_txt";
            this.lName_txt.Size = new System.Drawing.Size(125, 30);
            this.lName_txt.TabIndex = 6;
            this.lName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fName_txt
            // 
            this.fName_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.fName_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fName_txt.ForeColor = System.Drawing.Color.White;
            this.fName_txt.Location = new System.Drawing.Point(138, 43);
            this.fName_txt.Name = "fName_txt";
            this.fName_txt.Size = new System.Drawing.Size(125, 30);
            this.fName_txt.TabIndex = 5;
            this.fName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(8, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(8, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // updateDoctorInfo_btn
            // 
            this.updateDoctorInfo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateDoctorInfo_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDoctorInfo_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.updateDoctorInfo_btn.Location = new System.Drawing.Point(12, 12);
            this.updateDoctorInfo_btn.Name = "updateDoctorInfo_btn";
            this.updateDoctorInfo_btn.Size = new System.Drawing.Size(177, 31);
            this.updateDoctorInfo_btn.TabIndex = 11;
            this.updateDoctorInfo_btn.Text = "Updated Info";
            this.updateDoctorInfo_btn.UseVisualStyleBackColor = true;
            this.updateDoctorInfo_btn.Click += new System.EventHandler(this.updateDoctorInfo_btn_Click);
            // 
            // patientHealth_dataGrid
            // 
            this.patientHealth_dataGrid.AllowUserToAddRows = false;
            this.patientHealth_dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientHealth_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.patientHealth_dataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.patientHealth_dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientHealth_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientHealth_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.patientHealth_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientHealth_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.State,
            this.Descraption});
            this.patientHealth_dataGrid.Location = new System.Drawing.Point(11, 69);
            this.patientHealth_dataGrid.Name = "patientHealth_dataGrid";
            this.patientHealth_dataGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientHealth_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.patientHealth_dataGrid.Size = new System.Drawing.Size(445, 266);
            this.patientHealth_dataGrid.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "STATE";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Descraption
            // 
            this.Descraption.HeaderText = "DESCRAPTION";
            this.Descraption.Name = "Descraption";
            this.Descraption.ReadOnly = true;
            this.Descraption.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(7, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Patient User Name";
            // 
            // patientName_cmb
            // 
            this.patientName_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientName_cmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.patientName_cmb.FormattingEnabled = true;
            this.patientName_cmb.Location = new System.Drawing.Point(158, 30);
            this.patientName_cmb.Name = "patientName_cmb";
            this.patientName_cmb.Size = new System.Drawing.Size(201, 30);
            this.patientName_cmb.TabIndex = 15;
            this.patientName_cmb.SelectedIndexChanged += new System.EventHandler(this.patientName_cmb_SelectedIndexChanged);
            // 
            // saveHealth_btn
            // 
            this.saveHealth_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveHealth_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveHealth_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.saveHealth_btn.Location = new System.Drawing.Point(11, 376);
            this.saveHealth_btn.Name = "saveHealth_btn";
            this.saveHealth_btn.Size = new System.Drawing.Size(445, 31);
            this.saveHealth_btn.TabIndex = 13;
            this.saveHealth_btn.Text = "Add New Info";
            this.saveHealth_btn.UseVisualStyleBackColor = true;
            this.saveHealth_btn.Click += new System.EventHandler(this.saveHealth_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveHealth_btn);
            this.groupBox1.Controls.Add(this.patientName_cmb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.patientHealth_dataGrid);
            this.groupBox1.Location = new System.Drawing.Point(461, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 415);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Health State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(8, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "State";
            // 
            // state_txt
            // 
            this.state_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.state_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.state_txt.ForeColor = System.Drawing.Color.White;
            this.state_txt.Location = new System.Drawing.Point(284, 28);
            this.state_txt.Name = "state_txt";
            this.state_txt.Size = new System.Drawing.Size(150, 30);
            this.state_txt.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label9.Location = new System.Drawing.Point(8, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Descraption";
            // 
            // descraption_txt
            // 
            this.descraption_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.descraption_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descraption_txt.ForeColor = System.Drawing.Color.White;
            this.descraption_txt.Location = new System.Drawing.Point(113, 60);
            this.descraption_txt.Multiline = true;
            this.descraption_txt.Name = "descraption_txt";
            this.descraption_txt.Size = new System.Drawing.Size(321, 60);
            this.descraption_txt.TabIndex = 18;
            // 
            // addState_groupBox
            // 
            this.addState_groupBox.Controls.Add(this.date_txt);
            this.addState_groupBox.Controls.Add(this.cancelHealthState_btn);
            this.addState_groupBox.Controls.Add(this.saveHealthState_btn);
            this.addState_groupBox.Controls.Add(this.descraption_txt);
            this.addState_groupBox.Controls.Add(this.label9);
            this.addState_groupBox.Controls.Add(this.state_txt);
            this.addState_groupBox.Controls.Add(this.label8);
            this.addState_groupBox.Controls.Add(this.label7);
            this.addState_groupBox.Location = new System.Drawing.Point(13, 303);
            this.addState_groupBox.Name = "addState_groupBox";
            this.addState_groupBox.Size = new System.Drawing.Size(442, 163);
            this.addState_groupBox.TabIndex = 13;
            this.addState_groupBox.TabStop = false;
            this.addState_groupBox.Text = "New Health State";
            this.addState_groupBox.Visible = false;
            // 
            // date_txt
            // 
            this.date_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.date_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date_txt.ForeColor = System.Drawing.Color.White;
            this.date_txt.Location = new System.Drawing.Point(60, 28);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(168, 30);
            this.date_txt.TabIndex = 20;
            // 
            // cancelHealthState_btn
            // 
            this.cancelHealthState_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelHealthState_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelHealthState_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.cancelHealthState_btn.Location = new System.Drawing.Point(176, 126);
            this.cancelHealthState_btn.Name = "cancelHealthState_btn";
            this.cancelHealthState_btn.Size = new System.Drawing.Size(127, 31);
            this.cancelHealthState_btn.TabIndex = 19;
            this.cancelHealthState_btn.Text = "Cancel";
            this.cancelHealthState_btn.UseVisualStyleBackColor = true;
            this.cancelHealthState_btn.Click += new System.EventHandler(this.cancelHealthState_btn_Click);
            // 
            // saveHealthState_btn
            // 
            this.saveHealthState_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveHealthState_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveHealthState_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.saveHealthState_btn.Location = new System.Drawing.Point(309, 126);
            this.saveHealthState_btn.Name = "saveHealthState_btn";
            this.saveHealthState_btn.Size = new System.Drawing.Size(127, 31);
            this.saveHealthState_btn.TabIndex = 16;
            this.saveHealthState_btn.Text = "Save";
            this.saveHealthState_btn.UseVisualStyleBackColor = true;
            this.saveHealthState_btn.Click += new System.EventHandler(this.saveHealthState_btn_Click);
            // 
            // btn_schedule
            // 
            this.btn_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_schedule.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_schedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btn_schedule.Location = new System.Drawing.Point(195, 12);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(177, 31);
            this.btn_schedule.TabIndex = 14;
            this.btn_schedule.Text = "Schedule";
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(848, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(939, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_schedule);
            this.Controls.Add(this.addState_groupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updateDoctorInfo_btn);
            this.Controls.Add(this.doctorInfo_groupBox);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "doctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dector Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.doctorForm_FormClosed);
            this.Load += new System.EventHandler(this.doctorForm_Load);
            this.doctorInfo_groupBox.ResumeLayout(false);
            this.doctorInfo_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientHealth_dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.addState_groupBox.ResumeLayout(false);
            this.addState_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox doctorInfo_groupBox;
        private System.Windows.Forms.Button updateDoctorInfo_btn;
        private System.Windows.Forms.TextBox department_txt;
        private System.Windows.Forms.TextBox mobileNum_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.TextBox lName_txt;
        private System.Windows.Forms.TextBox fName_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelUpdate_btn;
        private System.Windows.Forms.Button saveUpdate_btn;
        private System.Windows.Forms.ComboBox patientName_cmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView patientHealth_dataGrid;
        private System.Windows.Forms.Button saveHealth_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descraption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox state_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox descraption_txt;
        private System.Windows.Forms.GroupBox addState_groupBox;
        private System.Windows.Forms.Button cancelHealthState_btn;
        private System.Windows.Forms.Button saveHealthState_btn;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Button button1;
    }
}