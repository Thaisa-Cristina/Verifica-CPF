namespace VerificaCPF.Services;

public static class ContadorDeCaracteresServices
{
    public static bool ContadorDeCaracteres(string cpf,int tamanho)
    {
        if (string.IsNullOrEmpty(cpf))
        {
            return false;
        }

        if(cpf.Length != tamanho) 
        {
            return false;
        }

        return true;
    }
    
}
