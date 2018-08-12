using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace LojaTCC
{
    class Clnbuscaproduto
    {
        private string _BuscaCod;
        private string _BuscaBarra;

        public string BuscaCod
        {
            get { return _BuscaCod; }
            set { _BuscaCod = value; }
        }

        public string BuscaBarra
        {
            get { return _BuscaBarra; }
            set { _BuscaBarra = value; }
        }

        public OracleDataReader BuscaProduto()
        {
            string strQuery = "select * from Produtos Where cod_produtos = '" + _BuscaCod + "'  or cod_barra = '" +_BuscaBarra+"'";
            clnBancodeDados objBancoDados = new clnBancodeDados();
            objBancoDados.EnumProperty = clnFuncoesGerais.Operacao.BuscaProduto;
            return objBancoDados.RetornaDataReader(strQuery);
        }
    }
    
}
