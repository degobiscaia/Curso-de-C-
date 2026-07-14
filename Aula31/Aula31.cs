using System;
using Microsoft.VisualBasic;
//Classes static não pode declarar ou instanciar um objeto desta classe, elas não podem ter construtores;
static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;
    static public void Iniciar(string n)
    {
        energia=100;
        vivo=true;
        nome=n;
    }
    static public void Info()
    {
        Console.WriteLine("Nome Jogador: {0}",nome);
        Console.WriteLine("Status do jogador: {0}",vivo);
        Console.WriteLine("Energia do jogador: {0}", energia);
        Console.WriteLine("---------------------------------");
    }
}

class Enemy
{
    static public bool alerta;
    public string nome;
    public Enemy(string n)
    {
        alerta=false;
        nome=n;
    }
    public void Info()
    {
        Console.WriteLine("Nome do inimigo: {0}",nome);
        Console.WriteLine("Status do alerta do inimigo: {0}",alerta);
        Console.WriteLine("---------------------------------------");
    }
}
class Aula31{
    static void Main()
{
    Jogador.Iniciar("Diego Bombadão, Lindo, Rico, Piloto de Linha Aérea, Desenvovledor Fullstack");
    Jogador.Info();

    Enemy e1=new Enemy("Doidão");
    Enemy e2=new Enemy("Maluco");
    Enemy e3=new Enemy("Pirado");


    Enemy.alerta=true;

    e1.Info();
    e2.Info();
    e3.Info();
}
}

