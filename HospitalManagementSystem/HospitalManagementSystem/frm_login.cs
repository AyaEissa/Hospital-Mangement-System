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
        Point lastLoc;

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
            if (checkUsername(cmb_loginas.SelectedItem.ToString(), txt_username.Text))
                txt_username.ForeColor = Color.GreenYellow;
            else
                txt_username.ForeColor = Color.Red;

            txt_username.Focus();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(orcl);
            con.Open();

            cmb_loginas.SelectedIndex = 0;
        }

        private bool checkUsername(string loginAs, string username)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Username ";

            cmd.CommandText += "FROM " + loginAs +
                " WHERE Username = :username";

            cmd.Parameters.Add("username", username);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            return false;
        }

        private bool checkPassword(string loginAs, string username, string password)
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
            if (checkUsername(cmb_loginas.SelectedItem.ToString(),
                txt_username.Text)
                && checkPassword(cmb_loginas.SelectedItem.ToString(),
                txt_username.Text, txt_password.Text))
            {
                if (cmb_loginas.SelectedItem.ToString() == "Doctor")
                {
                    doctorForm Doctor_Form = new doctorForm(this, txt_username.Text);
                    this.Hide();
                    Doctor_Form.Show();
                }
                else if (cmb_loginas.SelectedItem.ToString() == "Patient")
                {
                    // Patient pat = new Patient(this, txt_username.Text);
                    Patient a = new Patient();
                    this.Hide();
                    a.Show();
                }
                else if (cmb_loginas.SelectedItem.ToString() == "Nurse")
                {
                    Nurse b = new Nurse();
                    this.Hide();
                    b.Show();

                }
            }
            else if (!checkUsername(cmb_loginas.SelectedItem.ToString(),
                txt_username.Text))
                MessageBox.Show("Username does not exist", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Password incorrect", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (checkUsername(cmb_loginas.SelectedItem.ToString(), txt_username.Text))
                txt_username.ForeColor = Color.GreenYellow;
            else
                txt_username.ForeColor = Color.Red;
        }

        private void tableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastLoc = e.Location;
        }

        private void tableLayoutPanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point((this.Location.X - lastLoc.X) + e.X, (this.Location.Y - lastLoc.Y) + e.Y);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
