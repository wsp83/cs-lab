namespace HospitalAPI.Dtos
{
    public class PatientDto
    {
        public string FullName { get; set; }
        public long Oib { get; set; }
        public long Mbo { get; set; }
        public DateTime Dob { get; set; }
        public char Sex { get; set; }
        public string Diagnosis { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool HasPremiumInsurance { get; set; }
    }
}
