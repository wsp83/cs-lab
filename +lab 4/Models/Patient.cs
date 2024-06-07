namespace HospitalAPI.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public long Oib { get; set; }
        public long Mbo { get; set; }
        public DateTime Dob { get; set; }
        public char Sex { get; set; }
        public required string Diagnosis { get; set; }
        public bool IsCheckedIn { get; set; }
        public bool HasPremiumInsurance { get; set; }
    }
}
