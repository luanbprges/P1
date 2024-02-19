using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q3
{
    internal class Emprestimo
    {
        //Atributos
        string nome;
        Carro carroEmprest;
        double preçoDia;
        int dias;
        double preçoFinal;

        public string Nome { get => nome; set => nome = value; }
        public double PreçoDia { get => preçoDia; set => preçoDia = value; }
        public int Dias { get => dias; set => dias = value; }
        public double PreçoFinal { get => preçoFinal; set => preçoFinal = value; }
        internal Carro CarroEmprest { get => carroEmprest; set => carroEmprest = value; }


        //Metodos
        
        public Emprestimo() 
        {
            Nome = string.Empty;
            CarroEmprest = new Carro();
            PreçoDia = 0;
            Dias = 0;
            PreçoFinal = 0;

        }

        public Emprestimo(string nome, double preçoDia, int dias, double preçoFinal, Carro carroEmprest)
        {
            Nome = nome;
            CarroEmprest = carroEmprest;
            PreçoDia = preçoDia;
            Dias = dias;
            PreçoFinal = preçoFinal;
        }

        public void ImprimeRelatorio()
        {
            Console.WriteLine("Nome do cliente: " + Nome);
            Console.WriteLine("Modelo do carro emprestado: " + carroEmprest.Modelo);
            Console.WriteLine("Preço por dia: " + preçoDia);
            Console.WriteLine("Quantidade de dias: " + Dias);
            Console.WriteLine("Preço final: " + preçoFinal);
        }
    }
}
