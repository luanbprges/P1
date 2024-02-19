using P1Q2;

internal class Program
{
    private static void Main(string[] args)
    {
        //letra f)

        NumComplexo z1 = new NumComplexo(1, 1);
        NumComplexo z2 = new NumComplexo(3, (-1));
        NumComplexo somaComplex = new NumComplexo();
        NumComplexo multComplex = new NumComplexo();

        somaComplex = z1.soma(z2);
        multComplex = z1.vezes(z2);

        Console.WriteLine("Soma na forma polar: ");
        somaComplex.ImprimeFormaPolar();

        Console.WriteLine("Multiplicação na forma polar: ");
        multComplex.ImprimeFormaPolar();
    }
}