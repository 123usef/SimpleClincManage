using System.ComponentModel.DataAnnotations;

namespace SimpleClincManage.Models
{
    public class patients
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string PatientName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
       
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNo { get; set; }
        
        [DataType(DataType.Upload)]
        public string MedicalRec { get; set; }

    }
}
