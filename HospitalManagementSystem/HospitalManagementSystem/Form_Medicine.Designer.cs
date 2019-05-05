namespace HospitalManagementSystem
{
    partial class Form_Medicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.medicieneName_txt = new System.Windows.Forms.TextBox();
            this.medicineQuantity_txt = new System.Windows.Forms.TextBox();
            this.medicineYear_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.medicineId_cmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.medicineTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expiry Year";
            // 
            // medicieneName_txt
            // 
            this.medicieneName_txt.Location = new System.Drawing.Point(96, 6);
            this.medicieneName_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medicieneName_txt.Name = "medicieneName_txt";
            this.medicieneName_txt.Size = new System.Drawing.Size(134, 20);
            this.medicieneName_txt.TabIndex = 3;
            // 
            // medicineQuantity_txt
            // 
            this.medicineQuantity_txt.Location = new System.Drawing.Point(96, 56);
            this.medicineQuantity_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medicineQuantity_txt.Name = "medicineQuantity_txt";
            this.medicineQuantity_txt.Size = new System.Drawing.Size(134, 20);
            this.medicineQuantity_txt.TabIndex = 4;
            // 
            // medicineYear_txt
            // 
            this.medicineYear_txt.Location = new System.Drawing.Point(96, 81);
            this.medicineYear_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medicineYear_txt.Name = "medicineYear_txt";
            this.medicineYear_txt.Size = new System.Drawing.Size(134, 20);
            this.medicineYear_txt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // medicineId_cmb
            // 
            this.medicineId_cmb.FormattingEnabled = true;
            this.medicineId_cmb.Location = new System.Drawing.Point(96, 31);
            this.medicineId_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medicineId_cmb.Name = "medicineId_cmb";
            this.medicineId_cmb.Size = new System.Drawing.Size(134, 21);
            this.medicineId_cmb.TabIndex = 9;
            this.medicineId_cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Medicine ID";
            // 
            // medicineTable
            // 
            this.medicineTable.AllowUserToAddRows = false;
            this.medicineTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medicineTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.medicineTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicineTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineTable.Location = new System.Drawing.Point(12, 128);
            this.medicineTable.Name = "medicineTable";
            this.medicineTable.ReadOnly = true;
            this.medicineTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicineTable.Size = new System.Drawing.Size(576, 226);
            this.medicineTable.TabIndex = 11;
            this.medicineTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.medicineTable_MouseClick);
            // 
            // Form_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.medicineTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medicineId_cmb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.medicineYear_txt);
            this.Controls.Add(this.medicineQuantity_txt);
            this.Controls.Add(this.medicieneName_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Medicine";
            this.Text = "Form_Medicine";
            this.Load += new System.EventHandler(this.Form_Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicineTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox medicieneName_txt;
        private System.Windows.Forms.TextBox medicineQuantity_txt;
        private System.Windows.Forms.TextBox medicineYear_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox medicineId_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView medicineTable;
    }
}