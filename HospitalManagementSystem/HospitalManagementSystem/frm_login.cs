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
    public partial class frm_login : Form
    {
        string orcl = "Data Source = orcl; User Id = hr; Password = hr";
        OracleConnection con;

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            frm_register regForm = new frm_register();
            regForm.Show();
        }

        private void cmb_loginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateUsernameTextColor();

            txt_username.Focus();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(orcl);
            con.Open();

            cmb_loginas.SelectedIndex = 0;
        }

        private bool checkUsernameAndPassword(string loginAs, string username, string password)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Username, Password_ ";

            cmd.CommandText += "FROM " + loginAs +
                " WHERE Username = :username";

            cmd.Parameters.Add("username", username);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                if (Cryptography.Decrypt(dr[1].ToString()) == password)
                    return true;
            return false;
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (checkUsernameAndPassword(cmb_loginas.Items[cmb_loginas.SelectedIndex].ToString(),
                txt_username.Text, txt_password.Text))
                MessageBox.Show("Login Successfully", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Login Failed", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            updateUsernameTextColor();
        }

        private void updateUsernameTextColor()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Username, Password_ ";

            cmd.CommandText += "FROM " + cmb_loginas.Items[cmb_loginas.SelectedIndex].ToString() +
                " WHERE Username = :username";

            cmd.Parameters.Add("username", txt_username.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                txt_username.ForeColor = Color.Green;
            else
                txt_username.ForeColor = Color.Red;
        }
    }
}
