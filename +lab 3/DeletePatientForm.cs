using System;
using System.Numerics;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class DeletePatientForm : Form
    {
        public DeletePatientForm()
        {
            InitializeComponent();
        }

        private void bottunDelete_Click(object sender, EventArgs e)
        {
            BigInteger oib;

            if (BigInteger.TryParse(textBoxOib.Text, out oib))
            {
                Patient patient = Patient.FindPatient(oib);
                if(patient != null)
                {
                    string message = "Are you sure you want to delete patient:\n";
                    message += patient.GetFullName() + "?";
                    DialogResult dialogResult = MessageBox.Show(message, "DELETE PATIENT", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Patient.patientList.Remove(patient);
                        patient = null;
                        Patient.JsonWrite(Patient.patientList);
                        Close();
                    }
                }
                else
                    labelError.Text = "Error: Patient not found.";
            }
        }
    }
}
