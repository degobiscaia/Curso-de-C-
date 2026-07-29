using System;

class Veiculo{ //Classe Pai
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas)
    {
        this.rodas=rodas;
    }
    public void Ligar()
    {
        ligado = true;
    }
    public void Desligar()
    {
        ligado = false;
    }

    public string Getligado(){
        return (ligado?"Sim":"Não");
    }
    public int getRodas()
    {
        return rodas;
    }

    public void SetRodas(int rodas)
    {
        if (rodas < 0)
        {
            this.rodas=0;
        } else if (rodas > 40)
        {
            this.rodas=40;
        }
        else
        {
            this.rodas=rodas;
        }
    }
}

class Carro:Veiculo //Classe Derivada
{
    public string nome;
    public string cor;
    
    public Carro(string nome, string cor):base(4)
    {
        Desligar();
        velMax=120;
        this.nome = nome;
        this.cor = cor;
    }      
}

class CarroCombate : Carro
{
    public int municao;
    public CarroCombate():base("Carro de Combate","Verde")
    {
        municao = 100;
        SetRodas(6);
    }
}

class Aula35{
    static void Main()
    {
        Carro c1 = new Carro("Rapidão", "Vermelho");
        CarroCombate cc1 = new CarroCombate();

        c1.Ligar();
        
        Console.WriteLine("Cor: {0}",c1.cor);
        Console.WriteLine("Nome: {0}",c1.nome);
        Console.WriteLine("Velocidade Máxima: {0}",c1.velMax);
        Console.WriteLine("Rodas: {0}",c1.getRodas());
        Console.WriteLine("Ligado---------------:{0}",c1.Getligado());
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Cor: {0}",cc1.cor);
        Console.WriteLine("Nome: {0}",cc1.nome);
        Console.WriteLine("Velocidade Máxima: {0}",cc1.velMax);
        Console.WriteLine("Rodas: {0}",cc1.getRodas());
        Console.WriteLine("Munição: {0}",cc1.municao);
        Console.WriteLine("Ligado---------------:{0}",cc1.Getligado());
    }
}