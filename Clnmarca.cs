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
    class Clnmarca
    {
        private int _CodMarca;
        private string _Nome;
   
        private int _Excluir;
        private int _linhas;

        public int CodMarca
        {
            get { return _CodMarca; }
            set { _CodMarca = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }

        }
        //=======================
        public int Excluir
        {
            get { return _Excluir; }
            set { _Excluir = value; }
        }


        public int linhas
        {
            get { return _linhas; }
            set { _linhas = value; }
            //======================================
        }

        public DataSet Listar(string strDescricao)
        {
            string strQuery;

            strQuery = "Select * from marca where nome like '%" + strDescricao +
                "%'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }

        public OracleDataReader ListarUsuario(string cod)
        {

            string strQuery = "Select * from marca where cod_marca='" + CodMarca + "'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }

        public void Gravar()
         {

            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO marca ";
            strQuery += ("VALUES(");
            strQuery += ("Seq_Marca.NEXTVAL, ");
            strQuery += ("'" + _Nome + "' ");
            strQuery += (")");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }

        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" delete from marca ");
            strQuery += (" WHERE ");
            strQuery += (" cod_marca = '" + _CodMarca + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }
       
    }
}
