using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class ModifyPatientForm : Form
    {
        public ModifyPatientForm()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            BigInteger oib;

            if (BigInteger.TryParse(textBoxOib.Text, out oib))
            {
                Patient patient = Patient.FindPatient(oib);
                if (patient != null)
                {
                    SetDiagnosis setDiagnosis = new SetDiagnosis(patient);
                    setDiagnosis.Show();
                    Close();
                }
                else
                    labelError.Text = "Error: Patient not found.";
            }
        }
    }
}
