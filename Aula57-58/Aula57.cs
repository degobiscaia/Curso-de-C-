using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Aula57
{
    static void Main()
    {
        
        List<string> carros= new List<string>();
        string[] carros2= new string[10];

        carros.Add("Civic");
        carros.Add("Porsche");
        carros.Add("Ferrari");
        carros.Add("Aston Martin");
        carros.Add("Aston Martin");
        carros.Add("Argo");

        //carros2.AddRange(carros);
        //carros2.Clear();




        if (carros.Contains("Porsche"))
        {
            Console.WriteLine("Está na lista.");
        } else
        {
            Console.WriteLine("Não está na lista.");
        }

        carros.CopyTo(carros2,2);

        //carros.Remove("Argo");

        //carros.RemoveAt(5);

        carros.Insert(4,"Buggatti");

        //carros.Reverse(); //Reverte
        carros.Sort(); //Ordena
        

        int tamanho = carros.Count; //Retorna a quantidade de elementos da lista
        carros.Capacity=15; //Definida a capacidade(vagas) de elementos na lista
        int capacidade=carros.Capacity; //Retorna a capacidade de elementos na lista

        Console.WriteLine("Tamanho da lista de carros: {0}",tamanho);
        Console.WriteLine("Capacidade de armazenamento de carros: {0}",capacidade);

        int pos2=carros.LastIndexOf("Aston Martin");

        foreach(string e in carros)
        {
          Console.WriteLine("Carro: {0}", e);  
        }

        string c="Aston Martin";
        int pos=0;
        pos=carros.IndexOf(c);
        Console.WriteLine("Carro {0} está na posição {1}",c,pos);
        Console.WriteLine("Ultimo Aston Martin esta na posição: {0}",pos2);      
    }
}