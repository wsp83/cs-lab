using Microsoft.IdentityModel.Tokens;
using System.Numerics;

namespace WebAppHospital.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public long Oib {  get; set; }
        public long Mbo { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public char Sex { get; set; }
        public string Diagnosis { get; set; }
        public bool PremiumInsurance { get; set; }
        public bool CheckedIn {  get; set; }

        public Patient(long oib, long mbo, string fullName, DateTime dob, char sex, string diagnosis, bool premiumInsurance, bool checkedIn)
        {
            this.Oib = oib;
            this.Mbo = mbo;
            this.FullName = fullName;
            this.Dob = dob;
            this.Sex = sex;
            this.Diagnosis = diagnosis;
            this.PremiumInsurance = premiumInsurance;
            this.CheckedIn = checkedIn;
        }

        public bool IsValid()
        {
            if(Oib != 0)
                if (Mbo != 0)
                    if (Oib.ToString().Length == 11)
                        if (Mbo.ToString().Length == 9)
                            if (FullName != "" && FullName != null)
                                if (Sex == 'M' || Sex == 'F')
                                    return true;  
             return false;
        }
    }
}
