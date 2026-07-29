using System;

//Método virtual
class Base
{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void Info()
    {
        
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe Derivada 1");
    }

    override public void Info()
    {
        Console.WriteLine("Derivada 1 ");
    }             
}
class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe Derivada 2");
    }          
    override public void Info()
    {
        Console.WriteLine("Derivada 2 ");
    }
}

class Aula38
{
    static void Main()
    {
        Base Ref;

        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Ref =derivada2;
        Ref.Info();
    }
}

//È um método que vou dizer que vai ser subescrito, ou seja, vai ser sobrescrito em uma classe derivada. O método virtual é um método que pode ser sobrescrito em uma classe derivada.