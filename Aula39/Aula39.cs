using System;

//Uma classe abstrada serve como ereferência para outra classe.

abstract class Veiculo//Classe base abstrata serve como base para outras classes que irão herdar esta classe, não posso instanciar um objeto de uma classe abstrata., se coloco métodos que não são abastratos eu preciso implementar a funcionalidade do metódo., se forem abstratos não pdem ter implementação servem apenas para dizer que precisam implementar métodos abstratios.
{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo()
    {
        ligado=false;
        velAtual=0;
    }
    public void setLigado(bool ligado)
    {
        this.ligado=ligado;
    }
    public int getVelAtual()
    {
        return velAtual;
    }
    abstract public void aceleracao(int mult);
}




class Carro : Veiculo
{
    public Carro()
    {
        velMaxima=120;
    }
    override public void aceleracao(int mult)
    {
        velAtual+=10*mult;
    }
}

class Aula39
{
    static void Main()
    {
        Carro carro1= new Carro();
        carro1.aceleracao(1);
        carro1.aceleracao(-1);

        Console.WriteLine("Velocidade atual: {0}",carro1.getVelAtual());
    }
}