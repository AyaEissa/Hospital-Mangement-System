namespace HospitalManagementSystem
{
    partial class frm_register
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
            this.lbl_registeras = new System.Windows.Forms.Label();
            this.cmb_registeras = new System.Windows.Forms.ComboBox();
            this.pnl_doctor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_Fname = new System.Windows.Forms.Label();
            this.lbl_Lname = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_patient = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_patUsername = new System.Windows.Forms.Label();
            this.lbl_patPassword = new System.Windows.Forms.Label();
            this.lbl_patName = new System.Windows.Forms.Label();
            this.lbl_patNationalID = new System.Windows.Forms.Label();
            this.lbl_patAge = new System.Windows.Forms.Label();
            this.lbl_patMobilenumber = new System.Windows.Forms.Label();
            this.txt_patUsername = new System.Windows.Forms.TextBox();
            this.txt_patPassword = new System.Windows.Forms.TextBox();
            this.txt_patName = new System.Windows.Forms.TextBox();
            this.txt_patNationalID = new System.Windows.Forms.TextBox();
            this.txt_patAge = new System.Windows.Forms.TextBox();
            this.txt_patMobilenumber = new System.Windows.Forms.TextBox();
            this.pnl_nurse = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nurUsername = new System.Windows.Forms.Label();
            this.lbl_nurPassword = new System.Windows.Forms.Label();
            this.lbl_nurFname = new System.Windows.Forms.Label();
            this.lbl_nurLname = new System.Windows.Forms.Label();
            this.lbl_nurMobile = new System.Windows.Forms.Label();
            this.txt_nurUsername = new System.Windows.Forms.TextBox();
            this.txt_nurPassword = new System.Windows.Forms.TextBox();
            this.txt_nurFname = new System.Windows.Forms.TextBox();
            this.txt_nurLname = new System.Windows.Forms.TextBox();
            this.txt_nurMobile = new System.Windows.Forms.TextBox();
            this.pnl_doctor.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.pnl_patient.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnl_nurse.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_registeras
            // 
            this.lbl_registeras.AutoSize = true;
            this.lbl_registeras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_registeras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registeras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_registeras.Location = new System.Drawing.Point(3, 55);
            this.lbl_registeras.Name = "lbl_registeras";
            this.lbl_registeras.Size = new System.Drawing.Size(656, 18);
            this.lbl_registeras.TabIndex = 8;
            this.lbl_registeras.Text = "Register As";
            // 
            // cmb_registeras
            // 
            this.cmb_registeras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.cmb_registeras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_registeras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_registeras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_registeras.ForeColor = System.Drawing.Color.White;
            this.cmb_registeras.FormattingEnabled = true;
            this.cmb_registeras.Items.AddRange(new object[] {
            "Doctor",
            "Patient",
            "Nurse"});
            this.cmb_registeras.Location = new System.Drawing.Point(3, 76);
            this.cmb_registeras.Name = "cmb_registeras";
            this.cmb_registeras.Size = new System.Drawing.Size(656, 29);
            this.cmb_registeras.TabIndex = 0;
            this.cmb_registeras.SelectedIndexChanged += new System.EventHandler(this.cmb_registeras_SelectedIndexChanged);
            // 
            // pnl_doctor
            // 
            this.pnl_doctor.Controls.Add(this.tableLayoutPanel3);
            this.pnl_doctor.Location = new System.Drawing.Point(12, 113);
            this.pnl_doctor.Name = "pnl_doctor";
            this.pnl_doctor.Size = new System.Drawing.Size(468, 176);
            this.pnl_doctor.TabIndex = 10;
            this.pnl_doctor.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_username, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_password, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Fname, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Lname, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_mobile, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_department, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txt_username, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_password, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_fname, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_lname, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_mobile, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txt_department, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(468, 176);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_username.Location = new System.Drawing.Point(3, 5);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(228, 18);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_password.Location = new System.Drawing.Point(237, 5);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(228, 18);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password";
            // 
            // lbl_Fname
            // 
            this.lbl_Fname.AutoSize = true;
            this.lbl_Fname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Fname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_Fname.Location = new System.Drawing.Point(3, 51);
            this.lbl_Fname.Name = "lbl_Fname";
            this.lbl_Fname.Size = new System.Drawing.Size(228, 18);
            this.lbl_Fname.TabIndex = 8;
            this.lbl_Fname.Text = "First Name";
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Lname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_Lname.Location = new System.Drawing.Point(237, 51);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(228, 18);
            this.lbl_Lname.TabIndex = 9;
            this.lbl_Lname.Text = "Last Name";
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_mobile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_mobile.Location = new System.Drawing.Point(3, 97);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(228, 18);
            this.lbl_mobile.TabIndex = 10;
            this.lbl_mobile.Text = "Mobile Number";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_department.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_department.Location = new System.Drawing.Point(237, 97);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(228, 18);
            this.lbl_department.TabIndex = 11;
            this.lbl_department.Text = "Department";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(3, 26);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(228, 27);
            this.txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(237, 26);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.Size = new System.Drawing.Size(228, 27);
            this.txt_password.TabIndex = 2;
            // 
            // txt_fname
            // 
            this.txt_fname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_fname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.ForeColor = System.Drawing.Color.White;
            this.txt_fname.Location = new System.Drawing.Point(3, 72);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(228, 27);
            this.txt_fname.TabIndex = 3;
            // 
            // txt_lname
            // 
            this.txt_lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_lname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.ForeColor = System.Drawing.Color.White;
            this.txt_lname.Location = new System.Drawing.Point(237, 72);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(228, 27);
            this.txt_lname.TabIndex = 4;
            // 
            // txt_mobile
            // 
            this.txt_mobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mobile.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_mobile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobile.ForeColor = System.Drawing.Color.White;
            this.txt_mobile.Location = new System.Drawing.Point(3, 118);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(228, 27);
            this.txt_mobile.TabIndex = 5;
            // 
            // txt_department
            // 
            this.txt_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_department.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_department.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.ForeColor = System.Drawing.Color.White;
            this.txt_department.Location = new System.Drawing.Point(237, 118);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(228, 27);
            this.txt_department.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btn_save.Location = new System.Drawing.Point(3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(325, 40);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Confirm";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btn_cancel.Location = new System.Drawing.Point(334, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(325, 40);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Discard";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_save, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_cancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 373);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(662, 46);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cmb_registeras, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_registeras, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 107);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Controls.Add(this.btn_close, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(656, 34);
            this.tableLayoutPanel6.TabIndex = 12;
            this.tableLayoutPanel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel6_MouseDown);
            this.tableLayoutPanel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel6_MouseMove);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(629, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 28);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_patient
            // 
            this.pnl_patient.Controls.Add(this.tableLayoutPanel4);
            this.pnl_patient.Location = new System.Drawing.Point(118, 143);
            this.pnl_patient.Name = "pnl_patient";
            this.pnl_patient.Size = new System.Drawing.Size(468, 176);
            this.pnl_patient.TabIndex = 13;
            this.pnl_patient.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_patUsername, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patPassword, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patName, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patNationalID, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patAge, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lbl_patMobilenumber, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txt_patUsername, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_patPassword, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_patName, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txt_patNationalID, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.txt_patAge, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txt_patMobilenumber, 1, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(468, 176);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lbl_patUsername
            // 
            this.lbl_patUsername.AutoSize = true;
            this.lbl_patUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_patUsername.Location = new System.Drawing.Point(3, 5);
            this.lbl_patUsername.Name = "lbl_patUsername";
            this.lbl_patUsername.Size = new System.Drawing.Size(228, 18);
            this.lbl_patUsername.TabIndex = 6;
            this.lbl_patUsername.Text = "Username";
            // 
            // lbl_patPassword
            // 
            this.lbl_patPassword.AutoSize = true;
            this.lbl_patPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_patPassword.Location = new System.Drawing.Point(237, 5);
            this.lbl_patPassword.Name = "lbl_patPassword";
            this.lbl_patPassword.Size = new System.Drawing.Size(228, 18);
            this.lbl_patPassword.TabIndex = 7;
            this.lbl_patPassword.Text = "Password";
            // 
            // lbl_patName
            // 
            this.lbl_patName.AutoSize = true;
            this.lbl_patName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_patName.Location = new System.Drawing.Point(3, 51);
            this.lbl_patName.Name = "lbl_patName";
            this.lbl_patName.Size = new System.Drawing.Size(228, 18);
            this.lbl_patName.TabIndex = 8;
            this.lbl_patName.Text = "Name";
            // 
            // lbl_patNationalID
            // 
            this.lbl_patNationalID.AutoSize = true;
            this.lbl_patNationalID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patNationalID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_patNationalID.Location = new System.Drawing.Point(237, 51);
            this.lbl_patNationalID.Name = "lbl_patNationalID";
            this.lbl_patNationalID.Size = new System.Drawing.Size(228, 18);
            this.lbl_patNationalID.TabIndex = 9;
            this.lbl_patNationalID.Text = "National ID";
            // 
            // lbl_patAge
            // 
            this.lbl_patAge.AutoSize = true;
            this.lbl_patAge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patAge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_patAge.Location = new System.Drawing.Point(3, 97);
            this.lbl_patAge.Name = "lbl_patAge";
            this.lbl_patAge.Size = new System.Drawing.Size(228, 18);
            this.lbl_patAge.TabIndex = 10;
            this.lbl_patAge.Text = "Age";
            // 
            // lbl_patMobilenumber
            // 
            this.lbl_patMobilenumber.AutoSize = true;
            this.lbl_patMobilenumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_patMobilenumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patMobilenumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_patMobilenumber.Location = new System.Drawing.Point(237, 97);
            this.lbl_patMobilenumber.Name = "lbl_patMobilenumber";
            this.lbl_patMobilenumber.Size = new System.Drawing.Size(228, 18);
            this.lbl_patMobilenumber.TabIndex = 11;
            this.lbl_patMobilenumber.Text = "Mobile Number";
            // 
            // txt_patUsername
            // 
            this.txt_patUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_patUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patUsername.ForeColor = System.Drawing.Color.White;
            this.txt_patUsername.Location = new System.Drawing.Point(3, 26);
            this.txt_patUsername.Name = "txt_patUsername";
            this.txt_patUsername.Size = new System.Drawing.Size(228, 27);
            this.txt_patUsername.TabIndex = 1;
            // 
            // txt_patPassword
            // 
            this.txt_patPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_patPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patPassword.ForeColor = System.Drawing.Color.White;
            this.txt_patPassword.Location = new System.Drawing.Point(237, 26);
            this.txt_patPassword.Name = "txt_patPassword";
            this.txt_patPassword.PasswordChar = '●';
            this.txt_patPassword.Size = new System.Drawing.Size(228, 27);
            this.txt_patPassword.TabIndex = 2;
            // 
            // txt_patName
            // 
            this.txt_patName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_patName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patName.ForeColor = System.Drawing.Color.White;
            this.txt_patName.Location = new System.Drawing.Point(3, 72);
            this.txt_patName.Name = "txt_patName";
            this.txt_patName.Size = new System.Drawing.Size(228, 27);
            this.txt_patName.TabIndex = 3;
            // 
            // txt_patNationalID
            // 
            this.txt_patNationalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_patNationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patNationalID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patNationalID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patNationalID.ForeColor = System.Drawing.Color.White;
            this.txt_patNationalID.Location = new System.Drawing.Point(237, 72);
            this.txt_patNationalID.Name = "txt_patNationalID";
            this.txt_patNationalID.Size = new System.Drawing.Size(228, 27);
            this.txt_patNationalID.TabIndex = 4;
            // 
            // txt_patAge
            // 
            this.txt_patAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_patAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patAge.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patAge.ForeColor = System.Drawing.Color.White;
            this.txt_patAge.Location = new System.Drawing.Point(3, 118);
            this.txt_patAge.Name = "txt_patAge";
            this.txt_patAge.Size = new System.Drawing.Size(228, 27);
            this.txt_patAge.TabIndex = 5;
            // 
            // txt_patMobilenumber
            // 
            this.txt_patMobilenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_patMobilenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_patMobilenumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_patMobilenumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patMobilenumber.ForeColor = System.Drawing.Color.White;
            this.txt_patMobilenumber.Location = new System.Drawing.Point(237, 118);
            this.txt_patMobilenumber.Name = "txt_patMobilenumber";
            this.txt_patMobilenumber.Size = new System.Drawing.Size(228, 27);
            this.txt_patMobilenumber.TabIndex = 6;
            // 
            // pnl_nurse
            // 
            this.pnl_nurse.Controls.Add(this.tableLayoutPanel5);
            this.pnl_nurse.Location = new System.Drawing.Point(185, 182);
            this.pnl_nurse.Name = "pnl_nurse";
            this.pnl_nurse.Size = new System.Drawing.Size(468, 176);
            this.pnl_nurse.TabIndex = 14;
            this.pnl_nurse.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lbl_nurUsername, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_nurPassword, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_nurFname, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_nurLname, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_nurMobile, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.txt_nurUsername, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_nurPassword, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txt_nurFname, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.txt_nurLname, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.txt_nurMobile, 0, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(468, 176);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // lbl_nurUsername
            // 
            this.lbl_nurUsername.AutoSize = true;
            this.lbl_nurUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_nurUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nurUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_nurUsername.Location = new System.Drawing.Point(3, 5);
            this.lbl_nurUsername.Name = "lbl_nurUsername";
            this.lbl_nurUsername.Size = new System.Drawing.Size(228, 18);
            this.lbl_nurUsername.TabIndex = 6;
            this.lbl_nurUsername.Text = "Username";
            // 
            // lbl_nurPassword
            // 
            this.lbl_nurPassword.AutoSize = true;
            this.lbl_nurPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_nurPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nurPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_nurPassword.Location = new System.Drawing.Point(237, 5);
            this.lbl_nurPassword.Name = "lbl_nurPassword";
            this.lbl_nurPassword.Size = new System.Drawing.Size(228, 18);
            this.lbl_nurPassword.TabIndex = 7;
            this.lbl_nurPassword.Text = "Password";
            // 
            // lbl_nurFname
            // 
            this.lbl_nurFname.AutoSize = true;
            this.lbl_nurFname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_nurFname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nurFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_nurFname.Location = new System.Drawing.Point(3, 51);
            this.lbl_nurFname.Name = "lbl_nurFname";
            this.lbl_nurFname.Size = new System.Drawing.Size(228, 18);
            this.lbl_nurFname.TabIndex = 8;
            this.lbl_nurFname.Text = "First Name";
            // 
            // lbl_nurLname
            // 
            this.lbl_nurLname.AutoSize = true;
            this.lbl_nurLname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_nurLname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nurLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_nurLname.Location = new System.Drawing.Point(237, 51);
            this.lbl_nurLname.Name = "lbl_nurLname";
            this.lbl_nurLname.Size = new System.Drawing.Size(228, 18);
            this.lbl_nurLname.TabIndex = 9;
            this.lbl_nurLname.Text = "Last Name";
            // 
            // lbl_nurMobile
            // 
            this.lbl_nurMobile.AutoSize = true;
            this.lbl_nurMobile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_nurMobile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nurMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lbl_nurMobile.Location = new System.Drawing.Point(3, 97);
            this.lbl_nurMobile.Name = "lbl_nurMobile";
            this.lbl_nurMobile.Size = new System.Drawing.Size(228, 18);
            this.lbl_nurMobile.TabIndex = 10;
            this.lbl_nurMobile.Text = "Mobile Number";
            // 
            // txt_nurUsername
            // 
            this.txt_nurUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_nurUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nurUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nurUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nurUsername.ForeColor = System.Drawing.Color.White;
            this.txt_nurUsername.Location = new System.Drawing.Point(3, 26);
            this.txt_nurUsername.Name = "txt_nurUsername";
            this.txt_nurUsername.Size = new System.Drawing.Size(228, 27);
            this.txt_nurUsername.TabIndex = 1;
            // 
            // txt_nurPassword
            // 
            this.txt_nurPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_nurPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nurPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nurPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nurPassword.ForeColor = System.Drawing.Color.White;
            this.txt_nurPassword.Location = new System.Drawing.Point(237, 26);
            this.txt_nurPassword.Name = "txt_nurPassword";
            this.txt_nurPassword.PasswordChar = '●';
            this.txt_nurPassword.Size = new System.Drawing.Size(228, 27);
            this.txt_nurPassword.TabIndex = 2;
            // 
            // txt_nurFname
            // 
            this.txt_nurFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_nurFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nurFname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nurFname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nurFname.ForeColor = System.Drawing.Color.White;
            this.txt_nurFname.Location = new System.Drawing.Point(3, 72);
            this.txt_nurFname.Name = "txt_nurFname";
            this.txt_nurFname.Size = new System.Drawing.Size(228, 27);
            this.txt_nurFname.TabIndex = 3;
            // 
            // txt_nurLname
            // 
            this.txt_nurLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_nurLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nurLname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nurLname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nurLname.ForeColor = System.Drawing.Color.White;
            this.txt_nurLname.Location = new System.Drawing.Point(237, 72);
            this.txt_nurLname.Name = "txt_nurLname";
            this.txt_nurLname.Size = new System.Drawing.Size(228, 27);
            this.txt_nurLname.TabIndex = 4;
            // 
            // txt_nurMobile
            // 
            this.txt_nurMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.txt_nurMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nurMobile.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nurMobile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nurMobile.ForeColor = System.Drawing.Color.White;
            this.txt_nurMobile.Location = new System.Drawing.Point(3, 118);
            this.txt_nurMobile.Name = "txt_nurMobile";
            this.txt_nurMobile.Size = new System.Drawing.Size(228, 27);
            this.txt_nurMobile.TabIndex = 5;
            // 
            // frm_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(662, 419);
            this.Controls.Add(this.pnl_nurse);
            this.Controls.Add(this.pnl_patient);
            this.Controls.Add(this.pnl_doctor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_register";
            this.Text = "frm_register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_register_FormClosed);
            this.Load += new System.EventHandler(this.frm_register_Load);
            this.pnl_doctor.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.pnl_patient.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pnl_nurse.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_registeras;
        private System.Windows.Forms.ComboBox cmb_registeras;
        private System.Windows.Forms.Panel pnl_doctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_Fname;
        private System.Windows.Forms.Label lbl_Lname;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_patient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_patUsername;
        private System.Windows.Forms.Label lbl_patPassword;
        private System.Windows.Forms.Label lbl_patName;
        private System.Windows.Forms.Label lbl_patNationalID;
        private System.Windows.Forms.Label lbl_patAge;
        private System.Windows.Forms.Label lbl_patMobilenumber;
        private System.Windows.Forms.TextBox txt_patUsername;
        private System.Windows.Forms.TextBox txt_patPassword;
        private System.Windows.Forms.TextBox txt_patName;
        private System.Windows.Forms.TextBox txt_patNationalID;
        private System.Windows.Forms.TextBox txt_patAge;
        private System.Windows.Forms.TextBox txt_patMobilenumber;
        private System.Windows.Forms.Panel pnl_nurse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbl_nurUsername;
        private System.Windows.Forms.Label lbl_nurPassword;
        private System.Windows.Forms.Label lbl_nurFname;
        private System.Windows.Forms.Label lbl_nurLname;
        private System.Windows.Forms.Label lbl_nurMobile;
        private System.Windows.Forms.TextBox txt_nurUsername;
        private System.Windows.Forms.TextBox txt_nurPassword;
        private System.Windows.Forms.TextBox txt_nurFname;
        private System.Windows.Forms.TextBox txt_nurLname;
        private System.Windows.Forms.TextBox txt_nurMobile;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}