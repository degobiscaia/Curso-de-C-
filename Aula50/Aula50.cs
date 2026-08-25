using System;

//Método Delegate é um ponteiro para um método, ou seja, ele aponta para um método, e quando eu chamar o delegate ele vai chamar o método que ele aponta.

delegate int Operacao(params int[] n);
class Math
{
    public static int Soma(params int[]n)
    {
        int res=0;
        for(int i=0; i<n.Length; i++)
        {
            res+=n[i];
        }
        return res;
    }

    public static int Dobro(params int[] n)
    {
        int res=0;
        for(int i=0; i < n.Length; i++)
        {
            res+=n[i]*2;
        }
        return res;
    }

    public static int Multiplicacao(params int[] n)
    {
        int res=0;
        for(int i=0; i<n.Length; i++)
        {
            res+=n[i]*n[i];
        }
        return res;
    }
    public static int Divisao(params int[] n)
    {
        int res=0;
        for(int i=0; i<n.Length; i++)
        {
            res+=n[i]/n[i];
        }
        return res;
    }
    
}
class Aula50
{
    static void Main()
    {
        int vSoma,vMultiplicacao,vDivisao;

        Operacao d1= new Operacao(Math.Soma);

        vSoma=d1(10,50);

        Console.WriteLine("Soma: {0}",vSoma);
        Console.WriteLine("--------------------------");

        Operacao d2= new Operacao(Math.Multiplicacao);

        vMultiplicacao=d2(10,50);

        Console.WriteLine("Multiplicação: {0}",vMultiplicacao);

        Console.WriteLine("-------------------------");

        Operacao d3= new Operacao(Math.Divisao);
        vDivisao=d3(10,50);
        
        Console.WriteLine("Divisão: {0}",vDivisao);

        Console.WriteLine("-------------------------");
    }
}