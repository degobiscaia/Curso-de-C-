using System;
using System.Collections.Generic;



class Aula56{
        
    static void Main(){

        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");//Iniico
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta");
        transp.AddLast("1");
        transp.AddLast("2");
        transp.AddLast("3");
        transp.AddLast("4");

        //transp.Clear();
        if(transp.Find("Carro") == null)
        {
            Console.WriteLine("Não encontrado");
        } else
        {
            Console.WriteLine("O elemento foi encontrado.");
        }
        ; 

        //transp.Remove("Navio"); //Remove
        //transp.RemoveFirst(); //Remove o primeiro
        //transp.RemoveLast(); //Remove o ultimo

        LinkedListNode<string>no;
        no=transp.FindLast("Navio").Next; //FindLats "no fim"
        transp.AddAfter(no,"Patinete adcionei depois do Navio");//Depois

        LinkedListNode<string>no2;
        no2=transp.FindLast("Carro");
        transp.AddBefore(no2,"Patins adcionei antes do Carro");

        foreach(string t in transp)
        {
            Console.WriteLine("Transporte: {0}",t);
        }
    }
}