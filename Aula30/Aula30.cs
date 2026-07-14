using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador()
    {
        energia=100;
        vivo=true;
        nome="Jogador";
    }
    public Jogador(string n)
    {
        energia=100;
        vivo=true;
        nome=n;
    }
    public Jogador(string n,int e)
    {
        energia=100;
        vivo=true;
        nome=n;
        energia=e;
    }
    public Jogador(string n,int e,bool v)
    {
        energia=100;
        vivo=true;
        nome=n;
        energia=e;
        vivo=v;
    }

    public void Info()
    {
        Console.WriteLine("Nome Jogador: {0}",nome);
        Console.WriteLine("Status do jogador: {0}",vivo);
        Console.WriteLine("Energia do jogador: {0}", energia);
        Console.WriteLine("---------------------------------");
    }
    public void Info(int n)
    {
        Console.WriteLine("Nome Jogador: {0}",nome);
        Console.WriteLine("Status do jogador: {0}",vivo);
        Console.WriteLine("Energia do jogador: {0}", energia);
        Console.WriteLine("---------------------------------");
    }
}
class Aula30{
    static void Main()
{
    Jogador j1=new Jogador();
    Jogador j2=new Jogador("Diego");
    Jogador j3=new Jogador("Théo",100);
    Jogador j4=new Jogador("Alexa",0,false);
    Jogador j5=new Jogador("Dieguito",50,true);

    j1.Info();
    j2.Info();
    j3.Info();
    j4.Info();
    j5.Info();
}
}

