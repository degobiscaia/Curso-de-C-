using System;
using System.ComponentModel;

class Aula16
{
    static void Main()
    {
        int tempo=0;
        char escolha;

        inicio:

        Console.Clear();

        Console.WriteLine("Curitiba/PR a Rio De Janeiro/RJ");
        Console.WriteLine("Escolha o transporte: [a]-Avião | [c]-Carro | [o]-Onibus");
        escolha=char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo=60;
                break;
            case 'c':
            case 'C':
                tempo=120;
                break;
            case 'o':
            case 'O':
                tempo=240;
                break;
            default:
                tempo=-1;
                break;
        }
        if(tempo < 0)
        {
            Console.WriteLine("Transporte Indisponível");
        } else
        {
            Console.WriteLine("Tempo da Viagem: {0} minutos",tempo);
        }

        Console.Write("Calcular outro transporte? [s/n]");
        escolha=char.Parse(Console.ReadLine());
        if(escolha == 's' || escolha == 'S' || escolha == 'y' || escolha == 'Y')
        {
            goto inicio;
        } else {
            Console.Clear();
            Console.WriteLine("Fim do programa");
        }
    }
}