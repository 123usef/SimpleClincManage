using System.ComponentModel.DataAnnotations;

namespace SimpleClincManage.ViewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password and confirmation Password didn't match ")]
        public String ConfirmPassword { get; set; }

    }
}
