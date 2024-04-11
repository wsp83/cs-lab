using System;
using System.Numerics;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
        }

        private void comboBoxDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDiagnosis.Text = ((Diagnoses)comboBoxDiagnosis.SelectedIndex).ToString();
        }

        private bool isValidForm()
        {
            BigInteger oib;
            BigInteger mbo;

            if (String.IsNullOrEmpty(textBoxName.Text))
                return false;
            else if (dateBoxDob.Value == DateTimePicker.MinimumDateTime)
                return false;
            else if (!radioBtnSexM.Checked && !radioBtnSexF.Checked)
                return false;
            else if (String.IsNullOrEmpty(textBoxOIB.Text))
                return false;
            else if (String.IsNullOrEmpty(textBoxMBO.Text))
                return false;
            else if (comboBoxDiagnosis.SelectedIndex == -1)
                return false;

            if (BigInteger.TryParse(textBoxOIB.Text, out oib))
                if (Patient.IsValidOib(oib))
                    if (BigInteger.TryParse(textBoxMBO.Text, out mbo))
                        if (Patient.IsValidMbo(mbo))
                            return true;
                        else return false;
                    else return false;
                else return false;
            else return false;

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (isValidForm())
            {
                string name = textBoxName.Text;
                BigInteger oib = BigInteger.Parse(textBoxOIB.Text);
                BigInteger mbo = BigInteger.Parse(textBoxMBO.Text);
                char sex = (radioBtnSexM.Checked) ? 'M' : 'F';
                DateTime dob = DateTime.Parse(dateBoxDob.Text);
                string diagnosis = ((Diagnoses)comboBoxDiagnosis.SelectedIndex).ToString();

                Patient patient = new Patient(oib, mbo, name, dob, sex, diagnosis);

                Patient.patientList.Add(patient);
                Patient.JsonWrite(Patient.patientList);
                
                Close();
            }
        }
    }
}
