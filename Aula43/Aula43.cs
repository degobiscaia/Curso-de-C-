using System;
using System.Security.Cryptography.X509Certificates;

//Interface apenas implementa métodos ou protótipos dos métodos, não usa os campos na interfaces apenas a assinatura dos métodos

public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface Combate
{
    void disparar();
}

class Carro: Veiculo,Combate
{
    public bool ligado;
    private int monicao;
    public Carro()
    {
        setMonicao(100);
    }

    public void setMonicao(int qtde)
    {
        this.monicao=qtde;
    }

    public void ligar()
    {
        this.ligado=true;
    }
    public void desligar()
    {
        this.ligado=false;
    }
    public void disparar()
    {
        
    }
    public void info()
    {
        
    }
}

class Aula43{
    static void Main()
    {
        Carro c1= new Carro();
    }
}