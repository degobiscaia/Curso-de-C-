using System;

class Formulario
{
    static void Main()
    {
        string nome;
        string sobrenome;
        string cidade;
        string endereco;
        int n_residencia;
        string complemento;
        string contato;

        Console.Write("Digite o nome:   ");
        nome=Console.ReadLine();
        Console.Write("Digite o sobrenome:   ");
        sobrenome=Console.ReadLine();
        Console.Write("Digite a cidade:   ");
        cidade=Console.ReadLine();
        Console.Write("Digite o endereço:   ");
        endereco=Console.ReadLine();
        Console.Write("Digite o número da residência:  ");
        n_residencia=int.Parse(Console.ReadLine());
        Console.Write("Digite o complemento:   ");
        complemento=Console.ReadLine();
        Console.Write("Digite o número de contato:   ");
        contato=Console.ReadLine();

        Console.WriteLine("\nDados do usuário:");
        Console.WriteLine("Nome completo:  {0} {1}",nome,sobrenome);
        Console.WriteLine("Cidade: {0}",cidade);
        Console.WriteLine("Endereço:   {0}, numero: {1}, complemento: {2}",endereco,n_residencia,complemento);
        Console.WriteLine("Contato:  {0}",contato);
    }
}