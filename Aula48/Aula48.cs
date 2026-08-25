using System;


//Recursividade é uma função chamando ela mesma;




class Calc
{

    /*  
       Fatorial
    5! = 5*4*3*2*1 
    */

    public int fatorial(int n)
    {
        int res;

        if (n < 1)
        {
            res=1;
        } else
        {
            res=n*fatorial(n-1);
        }
        return res;
    }
}

class Aula48{
    static void Main(){

        Calc calc= new Calc();

        var res=calc.fatorial(10);

        Console.WriteLine(res);
    }
}