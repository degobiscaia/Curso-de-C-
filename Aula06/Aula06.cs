using System;

class Aula06
{
    static void Main()
    {

        double ValorCompra=5.50;
        double ValorVenda;
        double lucro=0.1;
        string produto="Pasteu";

        ValorVenda=ValorCompra+(ValorCompra*lucro);

        Console.WriteLine("Produto............................:{0,15}",produto);
        Console.WriteLine("Valor de Compra....................:{0,15:c}",ValorCompra);//espaço 15 formato moeda
        Console.WriteLine("Lucro..............................:{0,15:p}",lucro);//espaço 15 formato porcentagem
        Console.WriteLine("Valor de venda.....................:{0,15:c}",ValorVenda);//espaço 15 formato moeda
    }
}

/*
class Aula06
{
    static void Main()
    {

        int n1,n2,n3;
        n1=10;
        n2=20;
        n3=30;

        Console.WriteLine("n1=\t{0}\nn n2=\t{1}\nn n3=\t{2} ",n1,n2,n3);//Quebra linha no final, eo Write não quebra linha
        // \nn quebra linha é um "enter"
        //\t da uma "tabulação"
    }
}


*/