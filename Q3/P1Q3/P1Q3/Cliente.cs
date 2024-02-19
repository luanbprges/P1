using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q3
{
    internal class Cliente
    {
        //Atributos
        string nome;
        string endereço;
        string telefone;

        public string Nome { get => nome; set => nome = value; }
        public string Endereço { get => endereço; set => endereço = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        //Metodos

        public Cliente() 
        {
            Nome = string.Empty;
            Endereço = string.Empty;
            Telefone = string.Empty;
        }

        public Cliente(string nome, string endereço, string telefone)
        {
            Nome = nome;
            Endereço = endereço;
            Telefone = telefone;
        }
    }
}
