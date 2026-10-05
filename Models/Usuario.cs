using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppBanco.Models
{
    public class Usuario
    {
        public Guid ID {get; set;} = Guid.NewGuid();
        [Required(ErrorMessage = "E-mail obrigatório")]
        public string Email {get; set;} = string.Empty;
        [Required(ErrorMessage = "A senha Obrigatória")]
        [NotMapped]
        public string Senha {get; set;} = string.Empty;
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome {get; set;} = string.Empty;
        [Required(ErrorMessage = "O cpf é obrigatório")]
        public string CPF {get; set;} = string.Empty;
        
        public string SenhaHash {get; set;} = string.Empty;
        public decimal Saldo {get; set;} = 0;
    }
}