using System.ComponentModel.DataAnnotations;

namespace VerificaCPF.Validations;

public class VerificaCaracteresAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        char[] valueChar = value.ToString().ToCharArray();

        foreach (var caractere in valueChar)
        {
            if (char.IsLetter(caractere))
            {
                return new ValidationResult("O cpf não deve conter letras!");
            }
        }

        return ValidationResult.Success;
    }
}
