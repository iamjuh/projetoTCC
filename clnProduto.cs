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
    class clnProduto
    {
        private int _CodProduto;
        private int _CodFornecedor;
        private int _CodCategoria;
        private string _Faixa;
        private string _CodBarra;
        private string _Nome;
        private string _Marca;
        private double   _Valor;
        public int _Excluir;
        public int _linhas;


        public int CodProduto
        {
            get { return _CodProduto; }
            set { _CodProduto = value; }
        }

        public int CodFornecedor
        {
            get { return _CodFornecedor; }
            set { _CodFornecedor = value; }
        }

        public int CodCategoria
        {
            get { return _CodCategoria; }
            set { _CodCategoria = value; }
        }

        public string Faixa
        {
            get { return _Faixa; }
            set { _Faixa = value.ToUpper(); }

        }

        public string CodBarra
        {
            get { return _CodBarra; }
            set { _CodBarra = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }

        }

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value.ToUpper(); }
        }


        public double  Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

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

            strQuery = "Select * from Produtos where nome like '%" + strDescricao +
                "%'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }

        public OracleDataReader ListarUsuario(string cod)
        {

            string strQuery = "Select * from Produtos where cod_Produtos='" + CodProduto + "'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }

        public OracleDataReader ListarUsuario2(string cod)
        {


            string strQuery = "Select * from Produtos where cod_Produtos='" + CodProduto + "'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }


        public void Gravar()
        {

            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO produtos";
            strQuery += (" VALUES(");
            strQuery += ("seq_Produto.NEXTVAL,");
            strQuery += ("'" + _CodFornecedor + "',");
            strQuery += ("'" + _CodCategoria + "',");
            strQuery += ("'" + _Faixa + "',");
            strQuery += ("'" + _CodBarra + "',");
            strQuery += ("'" + _Nome + "',");
            strQuery += ("'" + _Marca + "',");
            strQuery += ("'" + _Valor + "'");
            strQuery += (")");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);
        }
        public void Alterar()
        {
            string strQuery;//criar a String para alterar
            strQuery = (" UPDATE produtos ");
            strQuery += (" SET ");
            strQuery += ("cod_Fornecedor = '" + _CodFornecedor + "',");
            strQuery += ("cod_categoria = '" + _CodCategoria + "',");
            strQuery += ("faixa_etaria = '" + _Faixa + "',");
            strQuery += ("cod_barra = '" + _CodBarra + "',");
            strQuery += ("nome = '" + _Nome + "',");
            strQuery += ("marca = '" + _Marca + "',");
            strQuery += ("valor ='" + _Valor + "'");
            strQuery += (" WHERE ");
            strQuery += (" cod_Produtos = '" + _CodProduto + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);
        }

        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" delete from produtos ");
            strQuery += (" WHERE ");
            strQuery += (" cod_Produtos = '" + _CodProduto + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }
    }
    }

