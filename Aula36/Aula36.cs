using System;
//Private : é acessado apenas pela classe
//O membro protected só é acessivel dentro da classe base e nas derivadas dela.
class Veiculo //Base
{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax)
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado =false;
    }
    public int getVelMax()
    {
        return velMax;
    }
}

class Carro : Veiculo //Derivada de Veiculo
{
    public string nome;
    public Carro(string nome, int vm) : base(vm)
    {
        this.nome=nome;
        ligado=true;
    }
    public bool getLigado()
    {
        return ligado;
    }
}
class Aula36
{
    static void Main()
    {
        Carro carro1=new Carro("Fusca",120);

        Console.WriteLine("Nome do carro: {0}",carro1.nome);
        Console.WriteLine("Velocidade máxima: {0}",carro1.getVelMax());
        Console.WriteLine("Ligado: {0}",carro1.getLigado());
    }
}