using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q3
{
    internal class Carro
    {
        //Atributos
        string categoria;
        string marcaEmpresa;
        string modelo;
        int ano;

        public string Categoria { get => categoria; set => categoria = value; }
        public string MarcaEmpresa { get => marcaEmpresa; set => marcaEmpresa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Ano { get => ano; set => ano = value; }


        //metodos

        public Carro() 
        { 
            Categoria = string.Empty;
            MarcaEmpresa = string.Empty;
            Modelo = string.Empty;
            Ano = 0;
        }

        public Carro(string categoria, string marcaEmpresa, string modelo, int ano)
        {
            Categoria = categoria;
            MarcaEmpresa = marcaEmpresa;
            Modelo = modelo;
            Ano = ano;
        }
    }
}
