using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.DML
{
    public class Beneficiario
    {
        public Beneficiario()
        {
            Itens = new List<Beneficiario>();
        }

        public long Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public long IdCliente { get; set; }

        public List<Beneficiario> Itens { get; set; }
    }
}
