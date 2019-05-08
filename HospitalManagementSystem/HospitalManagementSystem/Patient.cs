using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace HospitalManagementSystem
{
    public partial class Patient : Form
    {
        string orcl = "Data Source = orcl; User Id = hr; Password = hr";
        OracleConnection con;


        public Patient()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Patient Set Username =:Username ," +
                "Password_=:Password_," +
                " namee  =:namee  ," +
                "National_ID=:National_ID," +
                "age =:age ," +
                "Mobile_number =:Mobile_number " +
                " where Username=:Username";


            cmd.Parameters.Add("Username", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("Password_", Cryptography.Encrypt(password.Text));
            cmd.Parameters.Add("name", firstname.Text);
            cmd.Parameters.Add("National_ID", nationalid.Text);
            cmd.Parameters.Add("age", age.Text);
            cmd.Parameters.Add("Mobile_number", mobile.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Patient Update");
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(orcl);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Username from Patient";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from Patient where Username =:Username ";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("Username", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                password.Text = Cryptography.Decrypt(dr[1].ToString());
                firstname.Text = dr[2].ToString();
                //lastname.Text = dr[3].ToString();
                nationalid.Text = dr[3].ToString();
                age.Text = dr[4].ToString();
                mobile.Text = dr[5].ToString();
            }
            dr.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void vew_history_button_Click(object sender, EventArgs e)
        {
           /* PatientForm patienForm = new PatientForm(comboBox1.SelectedItem.ToString());
            patienForm.Show();*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
