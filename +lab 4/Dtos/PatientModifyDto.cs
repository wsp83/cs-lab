namespace HospitalAPI.Dtos
{
    public class PatientModifyDto
    {
        public bool IsCheckedIn { get; set; }
        public bool HasPremiumInsurance { get; set; }
        public string Diagnosis { get; set; }
    }
}
