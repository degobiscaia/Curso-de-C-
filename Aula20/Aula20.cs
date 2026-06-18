using System;


//for enquanto eu sei, while enquanto eu não sei
class Aula20{
    static void Main()
    {
        
        int[] nu2=new int[10];

        int i=nu2.Length-1;
        while (i>0)
        {
            nu2[i]=0;
            Console.WriteLine(nu2[i]);
            i--;
        }
        Console.WriteLine("Fim do loop");
    }
}

///Diferente do for no loop while eu preciso certificar que eu tenho a variável de controle da expressão inicializada fora antes de entrar no loop, o unúcio parametro do loop é a expressão lógica de controle, eu preciso me sertificar que eu tenho a variável de incremento e decremento da variável de controle dentro do bloco while