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
    public partial class NurseOptions : Form
    {
        public NurseOptions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nurse a = new Nurse();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Medicine med = new Form_Medicine();
            med.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
