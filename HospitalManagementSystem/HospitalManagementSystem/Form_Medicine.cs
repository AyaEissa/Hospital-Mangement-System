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

        private void Form_Medicine_Load(object sender, EventArgs e)
        {

            getMedcine();

            medicineTable.Columns[0].HeaderText = "Name";
            medicineTable.Columns[1].HeaderText = "ID";
            medicineTable.Columns[2].HeaderText = "Quantity";
            medicineTable.Columns[3].HeaderText = "Expiry Year";

            if (medicineTable.RowCount > 0)
            {
                medicieneName_txt.Text = medicineTable.Rows[0].Cells[0].Value.ToString();
                medicineId_cmb.Text = medicineTable.Rows[0].Cells[1].Value.ToString();
                medicineQuantity_txt.Text = medicineTable.Rows[0].Cells[2].Value.ToString();
                medicineYear_txt.Text = medicineTable.Rows[0].Cells[2].Value.ToString();
            }

            con = new OracleConnection(orcl);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Medicine_ID from Medicine";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                medicineId_cmb.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void medicineTable_MouseClick(object sender, MouseEventArgs e)
        {
            medicieneName_txt.Text = medicineTable.SelectedRows[0].Cells[0].Value.ToString();
            medicineId_cmb.Text = medicineTable.SelectedRows[0].Cells[1].Value.ToString();
            medicineQuantity_txt.Text = medicineTable.SelectedRows[0].Cells[2].Value.ToString();
            medicineYear_txt.Text = medicineTable.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Medicine " +
                   "VALUES (:Medicine_name, :Medicine_ID,:Quantity, :Expiry_year)";

            cmd.Parameters.Add("Medicine_name", medicieneName_txt.Text);
            cmd.Parameters.Add("Medicine_ID", medicineId_cmb.Text);
            cmd.Parameters.Add("Quanitiy", medicineQuantity_txt.Text);
            cmd.Parameters.Add("Expiry_year", medicineYear_txt.Text);
            int row = cmd.ExecuteNonQuery();

            if (row != -1)
            {
                DialogResult res = MessageBox.Show("Medicine Successfully Added.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

               medicineTable.Rows.Clear();
                getMedcine();
            }
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


            cmd.Parameters.Add("Medicine_name", medicieneName_txt.Text);
            cmd.Parameters.Add("Medicine_ID", medicineId_cmb.SelectedItem.ToString());
            cmd.Parameters.Add("Expiry_year", medicineYear_txt.Text);
            cmd.Parameters.Add("Quanitiy", medicineQuantity_txt.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Medicine modified");

                medicineTable.Rows.Clear();
                getMedcine();

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from Medicine where Medicine_ID=:Medicine_ID";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("Medicine_ID", medicineId_cmb.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                medicieneName_txt.Text = dr[0].ToString();
                medicineQuantity_txt.Text = dr[2].ToString();
                medicineYear_txt.Text = dr[3].ToString();

            }
            dr.Close();

        }



        public void getMedcine()
        {
            string selectCommand = "select * from MEDICINE";
            OracleDataAdapter adapter = new OracleDataAdapter(selectCommand, orcl);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            medicineTable.DataSource = dataSet.Tables[0];
            return;
        }

        private void medicineTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
