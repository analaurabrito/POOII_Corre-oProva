using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240417
{
    internal class Banco
    {
        public Dictionary<string, Conta> cadastroContas { get; set; }

        public Banco()
        {
            this.cadastroContas = new Dictionary<string, Conta>();
        }

        public void inserir(string cod, Conta conta) {
            cadastroContas.Add(cod, conta);
        }

        public Conta buscar(string cod) {
           return cadastroContas[cod];
        }

        public void listarTodos() {
            Console.WriteLine("Contas:");

            foreach (string s in cadastroContas.Keys) {
                Console.WriteLine(cadastroContas[s].nome);
            }

        }

        public void remover(string cod) {
            //cadastroContas.ContainsKey(cod);
            cadastroContas.Remove(cod);
        }
    }
}
