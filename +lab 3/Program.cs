using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public enum Diagnoses : int
    {
        Cholera = 0,
        Typhoid = 1,
        Salmonella = 2,
        Shigellosis = 3,
        BacterialInfection = 4,
        BacterialPoisoning = 5,
        Amebiasis = 6,
        Balantidiasis = 7,
        ViralInfection = 8,
        Diarrhea = 9
    }

    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
