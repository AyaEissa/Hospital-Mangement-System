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
    public partial class frm_doctorSchedule : Form
    {
        string dataConnection = "Data Source = orcl; User Id = hr; Password = hr";
        OracleConnection connection;

        string docterUsername;
        public frm_doctorSchedule(string docUsername)
        {
            InitializeComponent();
            docterUsername = docUsername;
        }

        private void frm_doctorSchedule_Load(object sender, EventArgs e)
        {
            GetDoctorInfo();
            GetDoctorSchedule();
        }

        public void GetDoctorInfo()
        {
            connection = new OracleConnection(dataConnection);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select * from DOCTOR where USERNAME = :N";
            cmd.Parameters.Add(":N", docterUsername);

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                lbl_header.Text += reader[2].ToString() + ' ' + reader[3].ToString();
        }

        private void GetDoctorSchedule()
        {
            connection = new OracleConnection(dataConnection);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select * from DoctorSchedule where USERNAME = :N";
            cmd.Parameters.Add(":N", docterUsername);

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[1].ToString() == "n")
                    chk_sunday.Checked = false;
                else
                    chk_sunday.Checked = true;

                if (reader[2].ToString() == "n")
                    chk_monday.Checked = false;
                else
                    chk_monday.Checked = true;

                if (reader[3].ToString() == "n")
                    chk_tuesday.Checked = false;
                else
                    chk_tuesday.Checked = true;

                if (reader[4].ToString() == "n")
                    chk_wednesday.Checked = false;
                else
                    chk_wednesday.Checked = true;

                if (reader[5].ToString() == "n")
                    chk_thursday.Checked = false;
                else
                    chk_thursday.Checked = true;

                if (reader[6].ToString() == "n")
                    chk_friday.Checked = false;
                else
                    chk_friday.Checked = true;

                if (reader[7].ToString() == "n")
                    chk_saturday.Checked = false;
                else
                    chk_saturday.Checked = true;
            }
        }

        private void chk_sunday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAvailableDay("sunday", chk_sunday.Checked);
        }

        private void chk_monday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAvailableDay("monday", chk_monday.Checked);
        }

        private void chk_tuesday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAvailableDay("tuesday", chk_tuesday.Checked);
        }

        private void chk_wednesday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAvailableDay("wednesday", chk_wednesday.Checked);
        }

        private void chk_thursday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAvailableDay("thursday", chk_thursday.Checked);
        }

        private void chk_friday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAvailableDay("friday", chk_friday.Checked);
        }

        private void chk_saturday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeAvailableDay("saturday", chk_saturday.Checked);
        }

        private void ChangeAvailableDay(string day, bool isAvailable)
        {
            connection = new OracleConnection(dataConnection);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;

            if (!CheckUsername("DoctorSchedule", docterUsername))
            {
                OracleCommand tmpCmd = new OracleCommand();
                tmpCmd.Connection = connection;

                tmpCmd.CommandText = "INSERT INTO DoctorSchedule " +
                    "VALUES ('" + docterUsername + "', 'n', 'n', 'n', 'n', 'n', 'n', 'n')";
                tmpCmd.ExecuteNonQuery();
            }

            if (isAvailable)
                cmd.CommandText = "UPDATE DoctorSchedule " +
                "SET " + day + " = " + "'y' " +
                "WHERE username = " + "'" + docterUsername + "'";
            else
                cmd.CommandText = "UPDATE DoctorSchedule " +
                "SET " + day + " = " + "'n' " +
                "WHERE username = " + "'" + docterUsername + "'";

            cmd.ExecuteNonQuery();
        }

        private bool CheckUsername(string loginAs, string username)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT Username ";

            cmd.CommandText += "FROM " + loginAs +
                " WHERE Username = :username";

            cmd.Parameters.Add("username", username);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            return false;
        }
    }
}
