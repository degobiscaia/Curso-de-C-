using System;


struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public void Info()
    {
        Console.WriteLine("Marca--: {0}",this.marca);
        Console.WriteLine("Modelo-: {0}",this.modelo);
        Console.WriteLine("Cor----: {0}",this.cor);
        Console.WriteLine("--------------------------");
    }
}
class Aula45{
    static void Main()
    {
        int[] numeros= new int[10];

        Carro[] carros= new Carro[5];

        carros[0].marca="Ferrari";
        carros[0].modelo="458 Itália";
        carros[0].cor="Vermelho";

        carros[1].marca="Lamborghini";
        carros[1].modelo="Revuelto";
        carros[1].cor="Preto";

        carros[2].marca="Koenigsegg";
        carros[2].modelo="Jesko Absolute";
        carros[2].cor="Branco";

        carros[3].marca="Bugatti";
        carros[3].modelo="Bolide";
        carros[3].cor="Azul";

        carros[4].marca="Aston Martin";
        carros[4].modelo="Valkyrie";
        carros[4].cor="Verde";

        for(int i = 0; i < carros.Length; i++)
        {
            carros[i].Info();
        }
    }
}