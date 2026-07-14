using System;

class Aula15
{
    static void Main()
    {
        int num=50;
        Dobrar(ref num);
        //Dobrar2(num);
        Console.WriteLine(num);
    }

    static void Dobrar(ref int valor)
    {
        valor*=2;
    }

    static void Dobrar2(int valor)
    {
        valor*=2;
    }
}

//Utilizando o método de referência "ref", eu passei o valor de num para o endereço do valor Dobrar, é como se fosse endereço de ponteiro ponteiro do c++, a passagem por parâmetro não utiliza o endereço da memória, ele cria outro lugar, enquanto a passagem por referência utiliza o próprio endereço da posição na memória, igual ao endreço do ponteiro. 