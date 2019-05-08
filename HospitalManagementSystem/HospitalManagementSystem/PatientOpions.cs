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
    public partial class PatientOpions : Form
    {
        public PatientOpions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor(false);
            doctor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
