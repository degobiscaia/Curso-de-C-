using System;
class Aula03
{
    static void Main()
    {
        int num1,num2,res,mult,berli;
        num1=10;
        num2=2;
        res= num1 + num2;
        mult= num1 * num2;
        berli=num1%num2;
        
        byte n=10;//Tamanho de 8 bits de dados
        int num=0;//Tamanho de 32 bits de dados
        char letra='d';
        float valorReal=5.0f;
        string nome="Diego";

        var aux="CFB Cursos"; //Não especifica o tipo de dado, o compilador define o tipo de dado automaticamente
        var aux01=nome;

        Console.WriteLine("Valor da variável nome: " + aux01 + " Cmdt Lindão");
        Console.WriteLine("A soma de " + num1 + " + " + num2 + " é igual a: " + res);
        Console.WriteLine("A multiplicação de " + num1 + " * " + num2 + " é igual a: " + mult);//Também da para efetuar a multiplicação no ato da impressão também sem declarar uma variável para isso.
        Console.WriteLine("E o resto da divisão de " + num1 + " por " + num2 + " é: " + berli);
    }
}