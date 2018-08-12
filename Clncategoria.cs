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
    class Clncategoria
    {
        private int _CodCategoria;
        private string _Nome;
   
        private int _Excluir;
        private int _linhas;

        public int CodCategoria
        {
            get { return _CodCategoria; }
            set { _CodCategoria = value; }
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

            strQuery = "Select * from Categoria where nome like '%" + strDescricao +
                "%'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }

        public OracleDataReader ListarUsuario(string cod)
        {

            string strQuery = "Select * from Categoria where cod_categoria='" + CodCategoria + "'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }

        public void Gravar()
        {

            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO categoria ";
            strQuery += ("VALUES(");
            strQuery += ("Seq_categoria.NEXTVAL, ");
            strQuery += ("'" + _Nome + "' ");
            strQuery += (")");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }
        public void Alterar()
        {
            string strQuery;//criar a String para alterar
            strQuery = (" UPDATE categoria ");
            strQuery += (" SET ");
            strQuery += ("nome = '" + _Nome + "'");
            strQuery += (" WHERE ");
            strQuery += (" cod_categoria = '" + _CodCategoria + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }

        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" delete from categoria ");
            strQuery += (" WHERE ");
            strQuery += (" cod_categoria = '" + _CodCategoria + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }
       
    }
}
