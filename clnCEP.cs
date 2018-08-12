using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace LojaTCC
{
    class clnCEP
    {
        private string _CEP;
        public string CEP
        {
            get { return _CEP; }
            set { _CEP = value; }
        }

        public OracleDataReader ProcurarCEP()
        {
            string strQuery = "select * from TABELACEP where CEP='" + _CEP + "'";
            clnBancodeDados objBancoDados = new clnBancodeDados();
            objBancoDados.EnumProperty = clnFuncoesGerais.Operacao.TabelaCep;
            return objBancoDados.RetornaDataReader(strQuery);
        }
    }
}
