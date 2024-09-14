using System.ComponentModel.DataAnnotations;

namespace Seesion.Models
{
    public class UserLogin
    {
        [Required]
        [DataType(DataType.EmailAddress)]
       public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }    
        public bool Remember {  get; set; }
    }
}
