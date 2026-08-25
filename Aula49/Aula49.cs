using System;

//Eu declaro apenas o membros como static

class Math
{
    public static double pi=3.14;

    public static int dobro(int n)
    {
        return n* 2;
    }
}

class Aula49
{
    static void Main()
    {
        double vpi= Math.pi;
        int num=10;

    //Eu não precisei declarar o objeto Math, para usar os membros dele que são static, de qualquer lugar posso chamar os membros static.
    //X Math m1= new Math();

        Console.WriteLine("O valor de pi é:{0}",vpi);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("O dobro de {0} é: {1}.",num,Math.dobro(num));
    }
}