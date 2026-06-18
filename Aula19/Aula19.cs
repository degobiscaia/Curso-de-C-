using System;
//Loop For
class Aula19
{
    static void Main()
    {

        int[] nu2=new int[7];

        for (int num=0;num<nu2.Length;num++) //num=num+1 ou  num+=1 ou num++ (incremento) Verificar, incrementar e executar
        {
            nu2[num]=num;
            //Console.WriteLine("O cmdt Diego é Lindão e  Bombadão, e o valor de num é: {0}",num);
        }   

        for(int num = 0; num < nu2.Length; num++)
        {
            Console.WriteLine("Valor de num na posição {0}: {1}", num, nu2[num]);
        }
    }
}