using System;

class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    static public int totalOvos;
    public Galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo =0;
    }    

    public Ovo botar()
    {
        numOvo++;
        totalOvos++;
        return new Ovo(numOvo,nomeGalinha);
    }

}
class Ovo
{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        Console.WriteLine("A galinha: {0} botou {1} ovo.",minhaGalinha, numOvo);
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Total de ovos: {0}",Galinha.totalOvos);
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("A galinha: {0}, botou no total {1} ovos.", minhaGalinha, numOvo);
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
    }
}


class Aula46{
    static void Main()
    {
        Galinha g1= new Galinha("Gertrudes");
        Galinha g2 = new Galinha("Feliciana");
        Galinha g3 = new Galinha("Maristela");

        g1.botar();
        g1.botar();
        g1.botar();



        g2.botar();
        g2.botar();

        g3.botar();
        g3.botar();
        g3.botar();


    }
}