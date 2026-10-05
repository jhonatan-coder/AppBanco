using System.ComponentModel.DataAnnotations;
namespace AppBanco.Models
{
    
    public class LoginModel
    {
        [Required(ErrorMessage = "E-mail obrigatório")]
        public string Email {get; set;} = string.Empty;
        [Required(ErrorMessage = "A senha Obrigatória")]
        public string Senha {get; set;} = string.Empty;
    }
}