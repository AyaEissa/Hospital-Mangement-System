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
        string orcl = "Data Source = orcl; User Id = hr; Password = hr";
        OracleConnection con;

        public Nurse()
        {
            InitializeComponent();
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
                password.Text = dr[1].ToString();
                firstname.Text = dr[2].ToString();
                lastname.Text = dr[3].ToString();
                mobile.Text = dr[4].ToString();
                
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

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Nurse Set Username =:Username ," +
                "Password_=:Password_," +
                " Fname  =:Fname  ," +
                " Lname  =:Lname  ," +
                "Mobilenumber  =:Mobilenumber , " +
                " where Username=:Username";


            cmd.Parameters.Add("Username", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("Password_", password.Text);
            cmd.Parameters.Add("Fname", firstname.Text);
            cmd.Parameters.Add("Lname", lastname.Text);
            cmd.Parameters.Add("Mobilenumber", mobile.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Nurse Updated");
            }

        
    }
    }
}
