using System.ComponentModel.DataAnnotations;

namespace WebApi2.Models
{
    public class Student
    {
        [Key]
        public Guid ID { get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime StudentBirth { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Batch { get; set; }
    }
}
