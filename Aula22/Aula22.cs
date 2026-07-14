using System;


class Aula22
{
    static void Main()
    {
      int[] num=new int[5]{11,22,35,44,55};

        
        for (int i=0;i<num.Length;i++)
        {
            num[i]=0;
        }
        
        //O foreach é muito recomendado apenas para ler os elementos, pois ele é muito simples
        foreach (int n in num)
        {
            Console.WriteLine(n);
        }
    }
}