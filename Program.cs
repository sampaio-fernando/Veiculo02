//try
//{
//    Veiculo v1 = new Veiculo();
//    v1._placa = "QBE-8324";
//    v1._modelo = "Saveiro G6";

//    Console.WriteLine("Informe o NIV: ");
//    string niv = Console.ReadLine();
//    v1.Setniv(niv);

//    Console.WriteLine($"\nNúmero cadastrado: { v1.Getniv()}");

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}



try
{
    Cliente c1 = new Cliente();
    c1.Setcpf("123.123.122-12");
    Console.WriteLine($"Número informado: {c1.Getcpf()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}

