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
    class ClnFornecedor
    {
        private int _CodFornecedor;
        private string _Nome;
        private string _CNPJ;
        private string _IE;
        private string _Representante;
        private string _Telefone;
        private int _Excluir;
        private int _linhas;


        public int CodFornecedor
        {
            get { return _CodFornecedor; }
            set { _CodFornecedor = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }

        }
        //=======================
        public string CNPJ
        {
            get { return _CNPJ; }
            set { _CNPJ = value.ToUpper(); }

        }

        //===========================
        public string IE
        {
            get { return _IE; }
            set { _IE = value.ToUpper(); }

        }
        //======================
        public string Representante
        {
            get { return _Representante; }
            set { _Representante = value.ToUpper(); }

        }

        //============================
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value.ToUpper(); }

        }
        //================================
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

            strQuery = "Select * from Fornecedor where nome_fan like '%" + strDescricao +
                "%'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }

        public OracleDataReader ListarUsuario(string cod)
        {

            string strQuery = "Select * from Fornecedor where cod_Fornecedor='" + CodFornecedor + "'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }

        public void Gravar()
        {
              
            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO fornecedor";
            strQuery += (" VALUES(");
            strQuery += ("Seq_Fornecedor.NEXTVAL,");
            strQuery += ("'" + _Nome + "',");
            strQuery += ("'" + _CNPJ + "',");
            strQuery += ("'" + _IE + "',");
            strQuery += ("'" + _Representante + "',");
            strQuery += ("'" + _Telefone + "'");
            strQuery += (")");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

           }

        public void Alterar()
        {
            string strQuery;//criar a String para alterar
            strQuery = (" UPDATE fornecedor ");
            strQuery += (" SET ");
            strQuery += ("nome_fan = '" + _Nome + "',");
            strQuery += ("cnpj = '" + _CNPJ + "',");
            strQuery += ("ie = '" + _IE + "',");
            strQuery += ("representante ='" + _Representante + "',");
            strQuery += ("tel = '" + _Telefone + "'");
            strQuery += (" WHERE ");
            strQuery += (" cod_Fornecedor = '" + _CodFornecedor + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }

        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" delete from fornecedor ");
            strQuery += (" WHERE ");
            strQuery += (" cod_Fornecedor = '" + _CodFornecedor + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

             }

    }
}
