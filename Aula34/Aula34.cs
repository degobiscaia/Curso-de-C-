using System;

class Veiculo{ //Classe Pai
    public int rodas;
    public int velMax;
    private bool ligado;
    public void Ligar()
    {
        ligado = true;
    }
    public void Desligar()
    {
        ligado = false;
    }

    public string Getligado(){
        if(ligado == true)
        {
            return "Sim";
        } else
        {
            return "Não";
        }
    }
}

class Carro:Veiculo //Classe Derivada
{
    public string nome;
    public string cor;
    
    public Carro(string nome, string cor)
    {
        Desligar();
        rodas=4;
        velMax=120;
        this.nome = nome;
        this.cor = cor;
    }
       
}

class Aula34{
    static void Main()
    {
        Carro c1 = new Carro("Rapidão", "Vermelho");
        
        Console.WriteLine("Cor: {0}",c1.cor);
        Console.WriteLine("Nome: {0}",c1.nome);
        Console.WriteLine("Velocidade Máxima: {0}",c1.velMax);
        Console.WriteLine("Rodas: {0}",c1.rodas);
        Console.WriteLine("Ligado---------------:{0}.",c1.Getligado());
        Console.WriteLine("---------------------------------");
    }
}