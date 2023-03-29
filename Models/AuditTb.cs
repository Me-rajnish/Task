namespace Task2.Models
{
    public class AuditTb
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime UpdatedDate { get; set; }
        public DateTime DeleteBy { get; set; }
    }
}
