using System.ComponentModel.DataAnnotations;

namespace AspNetAuthentication.Models
{
    public class UsuarioViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}