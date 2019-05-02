using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace HospitalManagementSystem
{
    public partial class frm_register : Form
    {
        string orcl = "Data Source = orcl; User Id = hr; Password = hr";
        OracleConnection con;

        public frm_register()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Doctor " +
                "VALUES (:username, :password, :fname, :lname, :mobilenumber, :department)";
            cmd.Parameters.Add("username", txt_username.Text);
            cmd.Parameters.Add("password", Cryptography.Encrypt(txt_password.Text));
            cmd.Parameters.Add("fname", txt_fname.Text);
            cmd.Parameters.Add("lname", txt_lname.Text);
            cmd.Parameters.Add("mobilenumber", txt_mobile.Text);
            cmd.Parameters.Add("department", txt_department.Text);

            int row = cmd.ExecuteNonQuery();
            if (row != -1)
            {
                DialogResult res = MessageBox.Show("Registraion Done Successfully.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                    this.Close();
            }
        }

        private void frm_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Dispose();
        }

        private void frm_register_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(orcl);
            con.Open();

            cmb_registeras.SelectedIndex = 0;
        }

        private void cmb_registeras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_registeras.SelectedIndex == 0)
                pnl_doctor.Visible = true;
            else
                pnl_doctor.Visible = false;
            txt_username.Focus();
        }
    }
}
