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
    public partial class Nurse : Form
    {
        string orcl = "Data Source=orcl; User ID=hr; Password=hr";
        OracleConnection con;
        public Nurse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Nurse set username=:username , Password_=:Password_,Fname=:Fname,Lname=:Lname,Mobilenumber=:Mobilenumber where Username=:Username";

            cmd.Parameters.Add("Username", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("Password_", Cryptography.Encrypt(textBox3.Text));
            cmd.Parameters.Add("Fname", textBox1.Text);
            cmd.Parameters.Add("Lname", textBox2.Text);
            cmd.Parameters.Add("Mobile_number", textBox4.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Patient Updated");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from Nurse where Username =:Username ";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("Username", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                textBox3.Text = Cryptography.Decrypt(dr[1].ToString());
                textBox1.Text = dr[2].ToString();
                textBox2.Text = dr[3].ToString();
                textBox4.Text = dr[4].ToString();

            }
            dr.Close();
        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(orcl);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Username from Nurse";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

