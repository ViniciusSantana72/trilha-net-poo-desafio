public class iPhone : Smartphone
{
    // Construtor
    public iPhone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    // Implementação dos métodos abstratos
    public override void Ligar()
    {
        Console.WriteLine("iPhone ligado.");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação no iPhone.");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando aplicativo {nome} no iPhone.");
    }
}

// Classe principal para testar o código
class Program
{
    static void Main()
    {
        // Exemplo de uso
        Smartphone nokia = new Nokia("123456789", "Nokia 7", "IMEI123", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Smartphone iphone = new iPhone("987654321", "iPhone 12", "IMEI456", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
