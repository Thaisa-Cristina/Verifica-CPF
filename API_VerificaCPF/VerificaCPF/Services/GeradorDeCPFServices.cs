namespace VerificaCPF.Services;

public static class GeradorDeCPFServices
{
    public static string GeradorDeCPF()
    {

        Random rnd = new Random();
        string cpf = "";
        for (int i = 0; i < 9; i++)
        {
            cpf += rnd.Next(0, 10).ToString();
        }


        int soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        }

        int resto = soma % 11;
        cpf += resto < 2 ? "0" : (11 - resto).ToString();

        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        }

        resto = soma % 11;
        cpf += resto < 2 ? "0" : (11 - resto).ToString();

        return cpf;

    }
}
