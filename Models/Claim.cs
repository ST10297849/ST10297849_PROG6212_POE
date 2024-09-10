namespace ST10297849_PROG6212_POE
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public int LecturerId { get; set; }
        public DateTime SubmissionDate { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string Status { get; set; } // Pending, Approved, Rejected
    }
}