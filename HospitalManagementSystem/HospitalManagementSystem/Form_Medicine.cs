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
    public partial class Form_Medicine : Form
    {
        string orcl = "Data Source = orcl; User Id = hr; Password = hr";
        OracleConnection con;

        public Form_Medicine()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Medicine_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(orcl);
            con.Open();
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Medicine_ID from Medicine";
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
            cmd.CommandText = "INSERT INTO Medicine " +
                   "VALUES (:Medicine_name, :Medicine_ID,:Quantity, :Expiry_year)";
            
            cmd.Parameters.Add("Medicine_name", textBox1.Text);
            cmd.Parameters.Add("Medicine_ID", comboBox1.Text);
            cmd.Parameters.Add("Quanitiy", textBox2.Text);
            cmd.Parameters.Add("Expiry_year", textBox3.Text);
            int row =cmd.ExecuteNonQuery();
            
            if (row != -1)
            {
                DialogResult res = MessageBox.Show("Medicine Successfully Added.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                    this.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Medicine Set Medicine_name=:Medicine_name," +
                "Medicine_ID=:Medicine_ID," +
                " Expiry_year=:Expiry_year," +
                "Quantity=:Quantity" +
                " where Medicine_ID=:medicine_id";
                   

            cmd.Parameters.Add("Medicine_name", textBox1.Text);
            cmd.Parameters.Add("Medicine_ID", comboBox1.SelectedItem.ToString());
             cmd.Parameters.Add("Expiry_year", textBox3.Text);
            cmd.Parameters.Add("Quanitiy", textBox2.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Medicine modified");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from Medicine where Medicine_ID=:Medicine_ID";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("Medicine_ID", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[2].ToString();
                textBox3.Text = dr[3].ToString();
                 
            }
            dr.Close();

        }
    }
}
