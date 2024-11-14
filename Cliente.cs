public class Cliente()
{
    public string _nome;
    private string _cpf;
    public string _sexo;
    public DateOnly _dtNascimento;

    public void Setcpf(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length == 11)
        {
            _cpf = cpf;
        }
        else
        {
            throw new Exception("Número de caracteres inválidos!");
        }
    }

    public string Getcpf()
    { 
        return _cpf;
    }
}

