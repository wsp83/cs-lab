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
    public partial class AllPatientsForm : Form
    {
        public AllPatientsForm()
        {
            InitializeComponent();
            AutoScroll = true;
        }

        private void AllPatientsForm_Load(object sender, EventArgs e)
        {
            int labelTop = 10;
            int labelHeight = 20;
            int panelLeft = 10;
            int panelWidth = 350;
            bool alternateColor = true;

            foreach (Patient patient in Patient.patientList)
            {
                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Location = new Point(panelLeft, labelTop);
                panel.Size = new Size(panelWidth, labelHeight * 6 + 10);
                panel.BackColor = alternateColor ? Color.BurlyWood : Color.RosyBrown;
                Controls.Add(panel);

                Label labelName = new Label();
                labelName.Text = "Name: " + patient.GetFullName();
                labelName.Location = new Point(5, 5);
                labelName.Size = new Size(panelWidth - 10, labelHeight);
                labelName.Font = new Font(labelName.Font.FontFamily, 12);
                panel.Controls.Add(labelName);

                Label labelDob = new Label();
                labelDob.Text = "Date of birth: " + patient.GetDob().ToString("d.M.yyyy.");
                labelDob.Location = new Point(5, labelHeight + 5);
                labelDob.Size = new Size(panelWidth - 10, labelHeight);
                labelDob.Font = new Font(labelDob.Font.FontFamily, 12);
                panel.Controls.Add(labelDob);

                Label labelOib = new Label();
                labelOib.Text = "OIB: " + patient.GetOib();
                labelOib.Location = new Point(5, labelHeight * 2 + 5);
                labelOib.Size = new Size(panelWidth - 10, labelHeight);
                labelOib.Font = new Font(labelOib.Font.FontFamily, 12);
                panel.Controls.Add(labelOib);

                Label labelMbo = new Label();
                labelMbo.Text = "MBO: " + patient.GetMbo();
                labelMbo.Location = new Point(5, labelHeight * 3 + 5);
                labelMbo.Size = new Size(panelWidth - 10, labelHeight);
                labelMbo.Font = new Font(labelMbo.Font.FontFamily, 12);
                panel.Controls.Add(labelMbo);

                Label labelSex = new Label();
                labelSex.Text = "Sex: " + patient.GetSex();
                labelSex.Location = new Point(5, labelHeight * 4 + 5);
                labelSex.Size = new Size(panelWidth - 10, labelHeight);
                labelSex.Font = new Font(labelSex.Font.FontFamily, 12);
                panel.Controls.Add(labelSex);

                Label labelDiagnosis = new Label();
                labelDiagnosis.Text = "Diagnosis: " + patient.GetDiagnosis();
                labelDiagnosis.Location = new Point(5, labelHeight * 5 + 5);
                labelDiagnosis.Size = new Size(panelWidth - 10, labelHeight);
                labelDiagnosis.Font = new Font(labelDiagnosis.Font.FontFamily, 12);
                panel.Controls.Add(labelDiagnosis);

                labelTop += labelHeight * 6 + 15;
                alternateColor = !alternateColor;
            }
        }
    }
}
