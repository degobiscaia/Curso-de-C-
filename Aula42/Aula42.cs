using System;


//Indexadores de classe
//Eu posso usar objetos da classe que possuem indexadores como se fossem arrays.
    
class Carro
{
    private int[] velMax=new int[5]{80,120,40,80,200};

    public int this[int i]//Indice do vetor
    {
        get
        {
            return velMax[i];
        }
        set
        {
            if(value < 0)
            {
                velMax[i]=0;
            } else if (value > 300)
            {
                velMax[i]=300;
            } else
            {
                velMax[i]=value;
            }
        }
    }
    public Carro()
    {
    }
}
class Aula42
{
    static void Main()
    {
        Carro c1 = new Carro();

        c1[4]=400;
        Console.WriteLine("Velocidade: {0}", c1[4]);
    }    
}