public class Veiculo
{
    private string _niv;
    public string _modelo;
    public string _placa;

    public void Setniv(string niv)
    {

         if (niv.Length == 17)
         {
             _niv = niv;
         }
         else
         {
           throw new Exception("\nNúmeros inválidos");
         }
        

    }

    public string Getniv()
    { 
        return _niv;
    }
}
