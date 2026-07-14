using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n)
    {
        energia=100;
        vivo=true;
        nome=n;
    }
    ~Jogador()
    {
      Console.WriteLine("O jogador {0}foi detruido da memória.", nome);  
    }
}
class Aula28{
    static void Main()
{
    string nome1;
    Console.WriteLine("Digite o nome do jogador 2: ");
    nome1=Console.ReadLine();    
    Jogador j1=new Jogador(nome1);
    Jogador j2=new Jogador("Alice");
    Jogador j3=new Jogador("Bruno");

    j2.energia=70;

    Console.WriteLine("Energia e vida do jogar 1: energia:{0}, vida:{1}, nome do jogador: {2}",j1.energia,j1.vivo,j1.nome);
    Console.WriteLine("-------------------------------------------------------------------");
    Console.WriteLine("Energia e vida do jogar 2: energia:{0}, vida:{1}, nome do jogador: {2}",j2.energia,j2.vivo,j2.nome);
}
}

//É padrão que toda classe tenha um construtor