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
    public partial class doctorForm : Form
    {
        string doctorUserName;
        Form loginFrm;

        string dataConnection = "Data Source = orcl; User Id = hr; Password = hr";
        OracleConnection connection;

        public doctorForm(Form frm, string _userName)
        {
            InitializeComponent();
            doctorUserName = _userName;
            loginFrm = frm;
        }

        private void doctorForm_Load(object sender, EventArgs e)
        {
            getDoctorInfo();

            List<string> patientUserName = new List<string>();
            getPatientUserName(ref patientUserName);
            for(int i = 0; i<patientUserName.Count; i++)
            {
                patientName_cmb.Items.Add(patientUserName[i]);
            }

            patientName_cmb.Items.IndexOf(0);
        }

        private void patientName_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            patientHealth_dataGrid.Rows.Clear();

            getPatientHealth(userName_txt.Text, patientName_cmb.SelectedItem.ToString());
        }

        private void updateDoctorInfo_btn_Click(object sender, EventArgs e)
        {
            saveUpdate_btn.Visible = true;
            cancelUpdate_btn.Visible = true;

            //fName_txt.BackColor = SystemColors.Window;
            fName_txt.BorderStyle = BorderStyle.Fixed3D;

            //lName_txt.BackColor = SystemColors.Window;
            lName_txt.BorderStyle = BorderStyle.Fixed3D;

            //password_txt.BackColor = SystemColors.Window;
            password_txt.BorderStyle = BorderStyle.Fixed3D;

            //department_txt.BackColor = SystemColors.Window;
            department_txt.BorderStyle = BorderStyle.Fixed3D;

            //mobileNum_txt.BackColor = SystemColors.Window;
            mobileNum_txt.BorderStyle = BorderStyle.Fixed3D;
        }

        private void saveUpdate_btn_Click(object sender, EventArgs e)
        {
            updateDoctorInfo(userName_txt.Text, password_txt.Text, fName_txt.Text, lName_txt.Text,
                mobileNum_txt.Text, department_txt.Text);
            MessageBox.Show("Doctor Information Updated Successfully.", "Updated Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            saveUpdate_btn.Visible = false;
            cancelUpdate_btn.Visible = false;

            //fName_txt.BackColor = SystemColors.Control;
            fName_txt.BorderStyle = BorderStyle.FixedSingle;

            //lName_txt.BackColor = SystemColors.Control;
            lName_txt.BorderStyle = BorderStyle.FixedSingle;

            //password_txt.BackColor = SystemColors.Control;
            password_txt.BorderStyle = BorderStyle.FixedSingle;

            //department_txt.BackColor = SystemColors.Control;
            department_txt.BorderStyle = BorderStyle.FixedSingle;

            //mobileNum_txt.BackColor = SystemColors.Control;
            mobileNum_txt.BorderStyle = BorderStyle.FixedSingle;
        }

        private void cancelUpdate_btn_Click(object sender, EventArgs e)
        {
            saveUpdate_btn.Visible = false;
            cancelUpdate_btn.Visible = false;

            //fName_txt.BackColor = SystemColors.Control;
            fName_txt.BorderStyle = BorderStyle.FixedSingle;

            //lName_txt.BackColor = SystemColors.Control;
            lName_txt.BorderStyle = BorderStyle.FixedSingle;

            //password_txt.BackColor = SystemColors.Control;
            password_txt.BorderStyle = BorderStyle.FixedSingle;

            //department_txt.BackColor = SystemColors.Control;
            department_txt.BorderStyle = BorderStyle.FixedSingle;

            //mobileNum_txt.BackColor = SystemColors.Control;
            mobileNum_txt.BorderStyle = BorderStyle.FixedSingle;
        }

        private void saveHealth_btn_Click(object sender, EventArgs e)
        {
            if (patientName_cmb.Items.Count != 0)
            {
                addState_groupBox.Visible = true;
                saveHealth_btn.Visible = false;

                date_txt.Text = DateTime.Now.ToString();
            }
        }

        private void saveHealthState_btn_Click(object sender, EventArgs e)
        {
            InsertHealthState(userName_txt.Text, patientName_cmb.SelectedItem.ToString(),date_txt.Text,
                state_txt.Text, descraption_txt.Text);

            patientHealth_dataGrid.Rows.Clear();
            getPatientHealth(userName_txt.Text, patientName_cmb.SelectedItem.ToString());

            
            addState_groupBox.Visible = false;
            saveHealth_btn.Visible = true;
        }

        private void cancelHealthState_btn_Click(object sender, EventArgs e)
        {
            addState_groupBox.Visible = false;
            saveHealth_btn.Visible = true;
        }


        /// <summary>
        /// DataBase Access Functions
        ///  1) Get Doctor Iformation
        ///  2) Update Doctor Info
        /// </summary>
        public void getDoctorInfo()
        {
            connection = new OracleConnection(dataConnection);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select * from DOCTOR where USERNAME = :N";
            cmd.Parameters.Add(":N", doctorUserName);
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userName_txt.Text = reader[0].ToString();
                password_txt.Text = Cryptography.Decrypt(reader[1].ToString());
                fName_txt.Text = reader[2].ToString();
                lName_txt.Text = reader[3].ToString();
                mobileNum_txt.Text = reader[4].ToString();
                department_txt.Text = reader[5].ToString();
            }
        }

        public void updateDoctorInfo(string _userName, string _password, string _fName,
            string _lName, string _mobileNum, string _department)
        {
            connection = new OracleConnection(dataConnection);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "update DOCTOR set FNAME = :firstName, LNAME = :lastName, PASSWORD_ = :password, MOBILENUMBER = :mobileNumber, Department = :department where USERNAME = :userName";
            cmd.Parameters.Add(":firstNmae", _fName);
            cmd.Parameters.Add(":lastName", _lName);
            cmd.Parameters.Add(":password", Cryptography.Encrypt(_password));
            cmd.Parameters.Add(":mobileNumber", _mobileNum);
            cmd.Parameters.Add(":department", _department);
            cmd.Parameters.Add(":userName", _userName);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
        }

        public void getPatientUserName(ref List<string> _patientUserName)
        {
            connection = new OracleConnection(dataConnection);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select USERNAME from PATIENT";
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _patientUserName.Add(reader[0].ToString());
            }

            return;
        }

        public void getPatientHealth(string _doctorUserName, string _patientUserName)
        {
            connection = new OracleConnection(dataConnection);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select * from PATIENTHEALTH where DOCTORUSERNAME = :N and PATIENTUSERNAME = :P";
            cmd.Parameters.Add(":N", _doctorUserName);
            cmd.Parameters.Add(":P", _patientUserName);
            cmd.CommandType = System.Data.CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] data = new string[]{ reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                patientHealth_dataGrid.Rows.Add(data);
            }

            return;
        }

        public void InsertHealthState(string _doctorUserName, string _patientUserName, string _date,
            string _state, string _descaption)
        {
            connection = new OracleConnection(dataConnection);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into PATIENTHEALTH values(:du, :pu, :vd, :s, :d)";
            cmd.Parameters.Add(":du", _doctorUserName);
            cmd.Parameters.Add(":pu", _patientUserName);
            cmd.Parameters.Add(":vd",_date);
            cmd.Parameters.Add(":s", _state);
            cmd.Parameters.Add(":d", _descaption);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.ExecuteNonQuery();

            return;
        }

        private void doctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginFrm.Show();
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            frm_doctorSchedule scheduleForm = new frm_doctorSchedule(doctorUserName);
            scheduleForm.Show();
        }

        private void userName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
