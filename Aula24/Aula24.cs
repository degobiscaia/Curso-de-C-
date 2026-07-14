using System;

class Aula24
{
    static void Main()
    {
        int v1,v2,r;
        Console.WriteLine("Digite o valor de n1:");
        v1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor de n2:");
        v2=Convert.ToInt32(Console.ReadLine());
        r=Dego(v1,v2);
        Console.WriteLine("A soma de {0} e {1} é: {2}",v1,v2,r);
    }

//Se o metódo não tiver que não tem argumentos nem retorno ele tem que ser void, se não tiver parametros de entrada os parenteses são vazios
    static double Nome(int n1,double n2, string texto)
    {
        double t;
        return t;
    }
    static int Dego(int n1, int n2)
    {
        int res=n1+n2;
        return res;
        //Console.WriteLine("O cmdt Diego é Lindão e Bombadão!");
        //Console.WriteLine("---------------------------------");
        
        //Console.WriteLine("A soma de v1: {0} com v2: {1} é igual a: {2}",n1,n2,res);
    }
}