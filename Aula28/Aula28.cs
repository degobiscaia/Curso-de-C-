using System;

//Modificador da classe: define a visibilidade da classe, public: bases para outras classes, sealed: classe não pode ser herdade, static: classe não permite a instanciação de objetos e seus membros são acessados diretamente.
//abstratc: classe base para outras classes, não pode instanciar objetos, mas pode ter membros abstratas


public class Jogador
{
    public int energia=100;
    public bool vivo=true;
}
class Aula28{
    static void Main()
{
    Jogador j1=new Jogador();
    Jogador j2=new Jogador();
    Jogador j3=new Jogador();

    j1.energia=70;
    //O new reserva a memória e vai retornar para quem fez a chamada o endereço da memória que alocou para esse objeto.

    Console.WriteLine("Energia e vida do jogar 1: energia:{0}, vida:{1}",j1.energia,j1.vivo);
    Console.WriteLine("-------------------------------------------------------------------");
    Console.WriteLine("Energia e vida do jogar 2: energia:{0}, vida:{1}",j2.energia,j2.vivo);
}
}


//O new aloca na memoria uma posição de mmoria para o objeto e retorna o endereço de memória, que é armazenado na variável do tipo da classe.