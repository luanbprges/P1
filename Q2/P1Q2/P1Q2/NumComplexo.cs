using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace P1Q2
{
    internal class NumComplexo
    {
        //Atributos

        double re;
        double im;

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }


        //Metodos

        public NumComplexo()
        {
            Re = 0;
            Im = 0;
        }

        public NumComplexo(double re, double im)
        {
            Re = re;
            Im = im;
        }

        //letra a)

        public NumComplexo soma(NumComplexo complexo)
        {
            NumComplexo somaComplexa = new NumComplexo();

            somaComplexa.Re = Re + complexo.Re;
            somaComplexa.Im = Im + complexo.Im;

            return somaComplexa;
        }

        //letra b)

        public NumComplexo vezes(NumComplexo complexo)
        {
            NumComplexo multComplexa = new NumComplexo();

            multComplexa.Re = (Re * complexo.Re) - (Im * complexo.Im);
            multComplexa.Im = (Re * complexo.Im) + (complexo.Re * Im);

            return multComplexa;
        }

        //letra c)

        public double modulo(NumComplexo complexo)
        {
            double modComplex = 0;

            modComplex = Math.Sqrt((Im * Im) + (Re * Re));

            return modComplex;
        }

        //letra d)

        public double Argumento()
        {
            double angulo = Math.Acos(Re / Math.Sqrt((Im * Im) + (Re * Re)));

            return angulo;
        }

        //letra e)

        public void ImprimeFormaPolar()
        {
            double p = Math.Sqrt((Im * Im) + (Re * Re));
            double angulo = Math.Acos(Re / Math.Sqrt((Im * Im) + (Re * Re)));

            Console.WriteLine(p + "(cos(" + angulo + ") + isen(" + angulo + ")) \n");
        }
    }
}
