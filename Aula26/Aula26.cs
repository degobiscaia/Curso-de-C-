using System;

class Aula26
{
    static void Main()
    {
        int Dividendo1,Divisor2,quoc,rest;
        Dividendo1=10;
        Divisor2=3;
        quoc=Divide(Dividendo1,Divisor2,out rest);
        Console.WriteLine("{0}/{1}:quociente={2} e resto={3}",Dividendo1,Divisor2,quoc,rest);
    }

    static int Divide(int dividendo, int divisor,out int resto)
    {
        int quociente;
        quociente=dividendo/divisor;
        resto=dividendo%divisor;
        return quociente;
    }
}
