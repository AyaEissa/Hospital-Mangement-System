using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class AdminOptions : Form
    {
        public AdminOptions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Nurse n = new Nurse();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Medicine fm = new Form_Medicine();
            fm.Show();
        }

        private void AdminOptions_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Medicine fm = new Form_Medicine();
            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rooms r = new Rooms();
            r.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rooms r = new Rooms();
            r.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
