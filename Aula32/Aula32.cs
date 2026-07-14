using System;


class Calculos
{
    public int v1;
    public int v2;

    public Calculos(int a, int b)
    {
        this.v1=a;
        this.v2=b;
    }

    public int Somar()
    {
        return v1+v2;
    }
}
class Aula32
{
    static void Main()
    {
        Calculos c = new Calculos(10,20);
        Console.WriteLine(c.Somar());
    }
}