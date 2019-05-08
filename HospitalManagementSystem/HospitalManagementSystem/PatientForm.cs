using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace HospitalManagementSystem
{

    public partial class PatientForm : Form
    {
        string username;
        rpt_patient CR;
        public PatientForm()
        {
            //username = _userName;
            InitializeComponent();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CR = new rpt_patient();
            //CR.SetParameterValue(0, username);
            crystalReportViewer1.ReportSource = CR;

        }

    }
}
