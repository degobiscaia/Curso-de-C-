using System;
using System.ComponentModel.DataAnnotations;


class Area
{
    public static float Quadrado(float lado,float altura)
    {
        if(lado<=0 || altura <= 0)
        {
            throw new Exception("Base ou altura não podem ser menores ou iguais a zero.");
        }
        return lado * altura;
        
    }    
}

class Aula53
{
    static void Main()
    {
        
        float area=0;

        try{
           area=Area.Quadrado(10F,0F);
           Console.WriteLine("Área do quadrado: {0}",area);
        }
        catch(Exception e){
            Console.WriteLine("ERRO: {0}",e.Message);
        }
        finally
        {
            Console.WriteLine("Fim do Programa");
        }
    }
}