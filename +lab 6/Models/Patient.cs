namespace WebApp.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public required string Oib { get; set; }
        public required string Mbo { get; set; }
        public required string FullName { get; set; }
        public required DateTime Dob { get; set; }
        public required DateTime AdmissionDate { get; set; }
        public required DateTime DischargeDate { get; set; }
        public required string Sex { get; set; }
        public required bool HasInsurance { get; set; }
        public required bool IsCheckedIn { get; set; }
        public required string Diagnosis { get; set; }
    }
}
