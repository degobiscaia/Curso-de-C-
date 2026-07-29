using System;

//Abstract tem que ser obrigatorios na nas classes derivadas
//o Sealed não pode ser usado o conceito de herança
sealed class Veiculo//Não pode ser herdada, não pode ser usada nas classes derivadas
{
    
}

public class Aviao
{
    public string modelo;
}


class Airbus : Aviao
{
    public void Aviao()
    { 
        modelo="Airbus";
    }
}

class Aula40{
    static void Main()
    {

        Aviao a1 = new Aviao();
        Console.WriteLine("Este avião é um: {0}", a1.modelo);
    }
}