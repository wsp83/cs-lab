using System;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            NewPatientForm newPatientForm = new NewPatientForm();
            newPatientForm.Show();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            DeletePatientForm deletePatientForm = new DeletePatientForm();
            deletePatientForm.Show();
        }

        private void btnModifyPatient_Click(object sender, EventArgs e)
        {
            ModifyPatientForm modifyPatientForm = new ModifyPatientForm();
            modifyPatientForm.Show();
        }

        private void btnAllPatients_Click(object sender, EventArgs e)
        {
            AllPatientsForm allPatientsForm = new AllPatientsForm();
            allPatientsForm.Show();
        }
    }
}
