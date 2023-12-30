public class Nokia : Smartphone
{
    // Construtor
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    // Implementação dos métodos abstratos
    public override void Ligar()
    {
        Console.WriteLine("Nokia ligado.");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação no Nokia.");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando aplicativo {nome} no Nokia.");
    }
}
