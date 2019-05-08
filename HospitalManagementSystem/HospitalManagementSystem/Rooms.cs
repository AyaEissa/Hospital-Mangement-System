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
    public partial class Rooms : Form
    {
        string orcl = "Data Source = orcl; User Id = hr; Password = hr";
        OracleConnection con;

        public Rooms()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Rooms " +
                 "VALUES (:Room_Number, :Room_Type,:Status, :Floor)";

            cmd.Parameters.Add("Room_Number", comboBox3.Text);
            cmd.Parameters.Add("Room_Type", comboBox1.Text);
            cmd.Parameters.Add("Status", comboBox2.Text);
            cmd.Parameters.Add("Floor", textBox2.Text);
            int x = cmd.ExecuteNonQuery();

            if (x != -1)
            {
                DialogResult res = MessageBox.Show("Room Successfully Added.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                    this.Close();
            }
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(orcl);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Room_Number from Rooms";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Rooms Set Room_Number=:Room_Number," +
                "Room_Type=:Room_Type," +
                " Status=:Status," +
                "Floor=:Floor" +
                " where Room_Number=:Room_Number";


            cmd.Parameters.Add("Room_Number", comboBox3.Text);
            cmd.Parameters.Add("Room_Type", comboBox1.Text);
            cmd.Parameters.Add("Status", comboBox2.Text);
            cmd.Parameters.Add("Floor", textBox2.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Room modified");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from Rooms where Room_Number=:Room_Number";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("Room_Number", comboBox3.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                comboBox1.Text = dr[1].ToString();
                textBox2.Text = dr[3].ToString();
                comboBox2.Text = dr[2].ToString();

            }
            dr.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
