using System;

class Aula17
{
    static void Main()
    {
        int n1,n2,n3,n4,n5;
        int[] n=new int[5];
        int[] num=new int[3]{55,77,99};
        int[] num2={66,78,232,543};
        string[] veiculos=new string[4];

        veiculos[0]=("Porsche911");
        veiculos[1]=("GT40");
        veiculos[2]=("Lamborghine");
        veiculos[3]=("Avião");


        n[0]=11;
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;

        Console.WriteLine("Posição 0: {0}",n[0]);
        Console.WriteLine("Posição 1: {0}",n[1]);
        Console.WriteLine("Posição 2: {0}",n[2]);
        Console.WriteLine("Posição 3: {0}",n[3]);
        Console.WriteLine("Posição 4: {0}",n[4]);
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Posição 3 do array num 3: {0}",num[2]);
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Posição 4 do array veiculos: {0}", veiculos[3]);
    }
}