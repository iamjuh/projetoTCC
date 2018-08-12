using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace LojaTCC
{
    class Clncpf
    {
        
        private string _CPF;
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        public OracleDataReader ProcurarCPF()
        {
            string strQuery = "select * from Cliente Where cpf ='" + _CPF + "'";
            clnBancodeDados objBancoDados = new clnBancodeDados();
            objBancoDados.EnumProperty = clnFuncoesGerais.Operacao.CPF;
            return objBancoDados.RetornaDataReader(strQuery);
        }
    }
}
