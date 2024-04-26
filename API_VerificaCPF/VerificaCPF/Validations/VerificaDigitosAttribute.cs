using System.ComponentModel.DataAnnotations;

namespace VerificaCPF.Validations;

public class VerificaDigitosAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        int digitoVerificador1 = 0;
        int digitoVerificador2 = 0;
        int indice = 0;
        int soma = 0;
        int resto = 0;
        const int tamanhoCpf = 11;

        string cpf = value.ToString();
        
        string subCpf = cpf.Substring(0, 9);
        char[] subCpfChar = subCpf.ToCharArray();

        for (int i = 10; i >= 2; i--)
        {
            int digito = subCpfChar[indice] - '0';
            soma += digito * i;
            indice++;
        }

        resto = soma % tamanhoCpf;

        if (resto >= 2)
        {
            digitoVerificador1 = tamanhoCpf - resto;
        }

        char[] incluiDigito1 = new char[10];
        subCpfChar.CopyTo(incluiDigito1, 0);
        incluiDigito1[incluiDigito1.Length - 1] = digitoVerificador1.ToString()[0];
        indice = 0;
        soma = 0;

        for (int i = 11; i >= 2; i--)
        {
            int digito = incluiDigito1[indice] - '0';
            soma += digito * i;
            indice++;
        }

        resto = 0;
        resto = soma % tamanhoCpf;

        if (resto >= 2)
        {
            digitoVerificador2 = tamanhoCpf - resto;
        }

        char[] cpfCompleto = cpf.ToCharArray();

        if (cpfCompleto[9] - '0' != digitoVerificador1 || cpfCompleto[10] - '0' != digitoVerificador2 || subCpf == "123456789")
        {
            return new ValidationResult($"O CPF: {cpf} é inválido!");
        }

        return ValidationResult.Success;
    }
}
