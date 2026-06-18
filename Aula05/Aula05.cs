using System;

class Aula05
{
    static void Main()
    {
        // & and, E
        // | or, ou sá vai ter verdadeiro se um dos dois for verdadeiro

        bool res = (5>3) & (10>5);

        bool res2 = 10 != 5; //Booleano true or false !=,>,<,>=,<=, ==
        int num = 10;

        //num+=1; //Incremento
        num++; //Incremento ambas são semelhantes
        //num=num+1;
        //num=num+2;
        num+=10;
        num-=5;//Decremento
        num*=2;//Multiplicação
        num/=2;//Divisão
        num%=3;//Resto da divisão        

        int res1 = (10 + 5) * 2;


        Console.WriteLine(res);
    }
}