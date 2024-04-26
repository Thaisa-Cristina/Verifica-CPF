using System.ComponentModel.DataAnnotations;
using VerificaCPF.Validations;

namespace VerificaCPF.Models;

public class Cpf
{
    [Required]
    [StringLength(11, ErrorMessage = "O CPF deve ter 11 digitos",MinimumLength = 11)]
    [VerificaDigitos]
    [VerificaCaracteres]
    public string CPF { get; set; }
}
