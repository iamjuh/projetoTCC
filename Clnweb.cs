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
    class Clnweb
    {
        private int _Codemail;
        private string _Nome;
        private string _Email;
        private string _Mensagem;

        public int Codemail
        {
            get { return _Codemail; }
            set { _Codemail = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value.ToUpper(); }
        }

        public string Mensagem
        {
            get { return _Mensagem; }
            set { _Mensagem = value.ToUpper(); }
        }


        public DataSet Listar2(string strDescricao)
        {
            string strQuery;

            strQuery = "Select * from web where nome like '%" + strDescricao +
                "%'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        //public DataSet Listar(string strDescricao)
        //{
        //    string strQuery;
        //    strQuery = "Select * from web";
        //    clnBancodeDados ObjBancoDados = new clnBancodeDados();
        //    return ObjBancoDados.RetornaDataSet(strQuery);
        //}


        public void Gravar()
        {
            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO web";
            strQuery += (" VALUES(");
            strQuery += ("'" + _Codemail + "',");
            strQuery += ("'" + _Nome + "',");
            strQuery += ("'" + _Email + "',");
            strQuery += ("'" + _Mensagem + "'");
            strQuery += (")");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);
        }

        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" delete from web ");
            strQuery += (" WHERE ");
            strQuery += (" email = '" + _Email + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }
    }
}
