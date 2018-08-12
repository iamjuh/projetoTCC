using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace LojaTCC
{
    class Clnabrirvenda
    {
        private int _CodVenda;
        private string _Data;
        private int _CodFuncionario;
        private string _CPF;
        private int _CodCliente;
        private string _Nome;

        public int CodVenda
        {
            get { return _CodVenda; }
            set { _CodVenda = value; }
        }
        //===========================
        public string Data
        {
            get { return _Data; }
            set { _Data = value.ToUpper(); }
        }
        //================================
        public int CodFuncionario
        {
            get { return _CodFuncionario; }
            set { _CodFuncionario = value; }

        }
        //===========================
        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }

        }
        //=======================================
        public int CodCliente
        {
            get { return _CodCliente; }
            set { _CodCliente = value; }
        }
        //======================
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }
        }





        public void GravarVenda()
        {

            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO venda";
            strQuery += (" VALUES(");
            strQuery += ("Seq_Venda.NEXTVAL,");
            strQuery += ("'" + _CodFuncionario + "',");
            strQuery += ("'" + _CodCliente + "',");
            strQuery += ("'',");
            strQuery += ("'" + _Data + "',");
            strQuery += ("''");
            strQuery += ("'1'");
            strQuery += (")");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);
        }

        public OracleDataReader ProcurarVenda()
        {
            string strQuery = " SELECT MAX (cod_Venda) cod_Venda from venda";
            clnBancodeDados objBancoDados = new clnBancodeDados();
            return objBancoDados.RetornaDataReader
                (strQuery);
        }
        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" delete from venda ");
            strQuery += (" WHERE ");
            strQuery += (" cod_Venda = '" + _CodVenda + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }
    }
}
