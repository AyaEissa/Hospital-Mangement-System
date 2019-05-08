namespace HospitalManagementSystem
{
    partial class Doctor
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
            this.label7 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.firstname = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(197, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Department:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // department
            // 
            this.department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.department.Location = new System.Drawing.Point(389, 250);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(170, 22);
            this.department.TabIndex = 26;
            this.department.TextChanged += new System.EventHandler(this.nationalid_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(340, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstname.Location = new System.Drawing.Point(394, 90);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(165, 22);
            this.firstname.TabIndex = 23;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(389, 195);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(170, 22);
            this.password.TabIndex = 22;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // mobile
            // 
            this.mobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobile.ForeColor = System.Drawing.SystemColors.MenuText;
            this.mobile.Location = new System.Drawing.Point(389, 295);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(170, 22);
            this.mobile.TabIndex = 21;
            this.mobile.TextChanged += new System.EventHandler(this.mobile_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(197, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mobile Number:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(196, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(197, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "First Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(132, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Choose Doctor Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 27);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(196, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Last Name:";
            // 
            // lastname
            // 
            this.lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastname.Location = new System.Drawing.Point(389, 138);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(170, 22);
            this.lastname.TabIndex = 29;
            this.lastname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.department);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastname;
    }
}