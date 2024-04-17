using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240417
{
    internal class Conta
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public double saldo { get; set; }

        public Conta(string codigo, string nome, double saldo)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.saldo = saldo;
        }
    }
}
