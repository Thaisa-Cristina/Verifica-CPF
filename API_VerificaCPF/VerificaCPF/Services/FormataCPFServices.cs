namespace VerificaCPF.Services;

public static class FormataCPFServices
{
    public static string FormataCPF(string cpf)
    {
        cpf = cpf.Replace(".","");
        cpf = cpf.Replace("-", "");

        return cpf;
    }

    public static string FormataCPFMascara(string cpf)
    {
        var cpfMascara1 = cpf.Insert(3, ".");
        var cpfMascara2 = cpfMascara1.Insert(7, ".");
        var cpfMascara3 = cpfMascara2.Insert(11, "-");

        return cpfMascara3;
    }
}
