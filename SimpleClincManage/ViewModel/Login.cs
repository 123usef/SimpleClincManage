using System.ComponentModel.DataAnnotations;

namespace SimpleClincManage.ViewModel
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public bool Remmemberme { get; set; }
    }
}
