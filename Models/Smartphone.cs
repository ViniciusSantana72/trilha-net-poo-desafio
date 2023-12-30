using System;

// Classe abstrata Smartphone
public abstract class Smartphone
{
    // Atributos protegidos
    protected string numero;
    protected string modelo;
    protected string imei;
    protected int memoria;

    // Construtor
    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        this.numero = numero;
        this.modelo = modelo;
        this.imei = imei;
        this.memoria = memoria;
    }

    // Métodos abstratos
    public abstract void Ligar();
    public abstract void ReceberLigacao();
    public abstract void InstalarAplicativo(string nome);
}
