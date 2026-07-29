using System;

//struct não é classe.
//Os membros são acessados diretamente e não por referência e ela não pode ser herdada

struct Carro
{
    public string marca;
    public int velocidade;
    public string modelo;
    public string cor;
    public bool ligado;

    public Carro(string marca, int velocidade, string modelo, string cor, bool ligado)
    {
        this.marca=marca;
        this.velocidade=velocidade;
        this.modelo=modelo;
        this.cor=cor;
        this.ligado=ligado;
    }

    public void Info()
    {
        Console.WriteLine("Marca--: {0}",this.marca);
        Console.WriteLine("Modelo-: {0}",this.modelo);
        Console.WriteLine("Cor----: {0}",this.cor);
        Console.WriteLine("--------------------------");
    }
}

class Aula44
{
    static void Main()
    {

        Carro c1=new Carro("Honda",300,"Type R","Vermelho",true);
        Carro c2=new Carro("Ferrari",350,"458 Itália","Vermelho",true);


        c1.Info();
        c2.Info();

    }
}