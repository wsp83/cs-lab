using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class SetDiagnosis : Form
    {
        Patient patient;
        public SetDiagnosis(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void comboBoxDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNewDiagnosis.Text = ((Diagnoses)comboBoxDiagnosis.SelectedIndex).ToString();
        }

        private void SetDiagnosis_Load(object sender, EventArgs e)
        {
            labelOib.Text += patient.GetOib().ToString();
            labelMbo.Text += patient.GetMbo().ToString();
            labelName.Text += patient.GetFullName();
            labelDob.Text += patient.GetDob().ToString("d.M.yyyy.");
            labelSex.Text += patient.GetSex().ToString();
            labelOldDiagnosis.Text += patient.GetDiagnosis();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string message = "Confirm the following changes for " + patient.GetFullName();
            message += "\nNew diagnosis: " + labelNewDiagnosis.Text;

            DialogResult dialogResult = MessageBox.Show(message, "MODIFY PATIENT", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                patient.SetDiagnosis(labelNewDiagnosis.Text);
                Patient.JsonWrite(Patient.patientList);
                Close();
            }
        }
    }
}
