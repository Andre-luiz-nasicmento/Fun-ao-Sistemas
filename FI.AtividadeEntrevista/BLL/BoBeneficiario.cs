using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiario
    {

        public long Incluir(DML.Beneficiario beneficiario)
        {
            DAL.Beneficiario.DaoBeneficiario bnf = new DAL.Beneficiario.DaoBeneficiario();
            return bnf.Incluir(beneficiario);
        }

        public void Alterar(DML.Beneficiario beneficiario)
        {
            DAL.Beneficiario.DaoBeneficiario bnf = new DAL.Beneficiario.DaoBeneficiario();
            bnf.Alterar(beneficiario);
        }

        public List<DML.Beneficiario> Consultar(long id)
        {
            DAL.Beneficiario.DaoBeneficiario bnf = new DAL.Beneficiario.DaoBeneficiario();
            return bnf.Consultar(id);
        }

        public void Excluir(long id)
        {
            DAL.Beneficiario.DaoBeneficiario cli = new DAL.Beneficiario.DaoBeneficiario();
            cli.Excluir(id);
        }

        public List<DML.Beneficiario> Listar()
        {
            DAL.Beneficiario.DaoBeneficiario bnf = new DAL.Beneficiario.DaoBeneficiario();
            return bnf.Listar();
        }

        public List<DML.Beneficiario> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, out int qtd)
        {
            DAL.Beneficiario.DaoBeneficiario bnf = new DAL.Beneficiario.DaoBeneficiario();
            return bnf.Pesquisa(iniciarEm, quantidade, campoOrdenacao, crescente, out qtd);
        }

        public bool VerificarExistencia(string CPF)
        {
            DAL.Beneficiario.DaoBeneficiario bnf = new DAL.Beneficiario.DaoBeneficiario();
            return bnf.VerificarExistencia(CPF);
        }
    }
}
