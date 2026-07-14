using System;

class Aula27{
    static void Main()
{
    Soma(7,10,5,2,3,4,5,6);
}
//No array params entra 1 evalor, nenhum valor ou mais de um, se for mais de de 1 eu vou percorrer o array e somar cada valor de cada posição do array
   static void Soma(params int[]n)
    {
        int res=0;//Isso aqui é apenas para garantir que se inicia com valor 0 e não um qualquer valor que possa estar na memória.
        if (n.Length < 1)
        {
            Console.WriteLine("Não existem valores a serem somados");
        }
        else if(n.Length <2)
        {
            Console.WriteLine("Não tem soma,pois so existe uma valor: {0}",n[0]);
        }
        else
        {
            for(int i = 0; i < n.Length; i++)
            {
                res += n[i];
                //O res recebe um incremento o valor da posição atual do array que eu esteja percorrendo
            }
            Console.WriteLine("A soma dos valores é: {0}", res);
        }
    }
}