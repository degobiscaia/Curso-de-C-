using System;
using System.Collections.Generic;



class Aula55
{
    static void Main()
    {
        Dictionary <int,string> veiculos = new Dictionary <int,string>();


        veiculos.Add(4,"Carro");
        veiculos.Add(01,"Avião");
        veiculos.Add(0,"Navio");
        veiculos.Add(15,"Motocicleta");
        veiculos.Add(25,"Patinete");


        //veiculos.Clear();
        veiculos.Remove(15);

        Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count);
        int chave=15;
        if (veiculos.ContainsKey(chave))
        {
            Console.WriteLine("A chave {0} está na coleção",chave);
        }
        else
        {
            Console.WriteLine("A chave {0} não esta na coleção", chave);
        }
        ;

        Console.WriteLine("----------------------------------------");

        veiculos[25]="Bicicleta";

        string valor="Bicicleta";
        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine("O valor {0} está na coleção",valor);
        }
        else
        {
            Console.WriteLine("O valor {0} não esta na coleção", valor);
        }
        ;

        Console.WriteLine("-----------------------------------------");

        Dictionary<int,string>.ValueCollection valores=veiculos.Values;

        foreach(string v in valores)
        {
            Console.WriteLine(v);
        }

        /*
        foreach(KeyValuePair<int,string> v in veiculos)
        {
            Console.WriteLine(v.Key);
            Console.WriteLine(v.Value);
        }
        */

    }
}
















/*class Deego
{
    public static int Bombadao = 100;
    public static bool Rico = true;
    public static bool PilotodeAviao = true;
    public static bool DesenvolvdorFullStack= true;
    public void Info()
    {
        if (Bombadao == 100)
        {
            Console.WriteLine("Sim");
        } else if(Rico == true)
        {
            Console.WriteLine("Sim");
        } else if(PilotodeAviao == true)
        {
            Console.WriteLine("Sim");
        } else if (DesenvolvdorFullStack == true)
        {
            Console.WriteLine("Sim");
        }
        
    }
}


class Aula55
    {
    static void Main()
    {
        Deego.Bombadao=100;
        Deego.Rico=true;
        Deego.PilotodeAviao=true;
        Deego.DesenvolvdorFullStack=true;


        Console.WriteLine("---------------- About Deego ---------------");
        Console.WriteLine("Is Strength? {0}",Deego.Bombadao);
        Console.WriteLine("Is Rich? {0}",Deego.Rico);
        Console.WriteLine("Is an Airline Pilot? {0}",Deego.PilotodeAviao);
        Console.WriteLine("Is an Fullstack Developer? {0}",Deego.DesenvolvdorFullStack);
    }
}



*/