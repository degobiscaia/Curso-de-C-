using System;
using System.Collections.Generic;

class Aula59
{
    static void Main()
    {
        //string[] vs={"Carro,","Moto","Navio","Avião"};
        Queue<string> veiculos = new Queue<string>();

        //Adcionando elementos nossa Queue
        veiculos.Enqueue("Carro");//Adciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v="Patinete";
        if (veiculos.Contains(v))
        {
            Console.WriteLine("Veiculo " + v + " encontrado na fila");
        } else
        {
            Console.WriteLine("O veiculo " + v + " não está na fila.");
        }
        //veiculos.Clear(); Limpa dos elemtos da fila
        //Console.WriteLine("Primeiro veiculo " + veiculos.Dequeue());//Ele retorna o primeiro elemento e remove ele da fila.
        //Console.WriteLine("Primeiro veiculo " + veiculos.Dequeue());//Ele retorna o primeiro elemento e remove ele da fila.
        Console.WriteLine("Primeiro veiculo " + veiculos.Peek());//Ele retorna o primeiro elemento e não remove ele.
        /*
        foreach(string veic in veiculos)
        {
            Console.WriteLine("Veiculo: " + veic);
        }
        */
        
       
       //Ele remove todos os elementos maior que zero
        while(veiculos.Count > 0)
        {
            Console.WriteLine(veiculos.Dequeue());
        }
        Console.WriteLine("Tamanho da fila: {0}", veiculos.Count); 
        
    }
}