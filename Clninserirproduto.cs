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
    class Clninserirproduto
    {
        private int _CodItem;
        private int _CodVenda;
        private int _Quantidade;
        private int _CodProdutos;
        private string _Nome;
        private double _Valor;
        private double _Total;

        public int CodItem
        {
            get { return _CodItem; }
            set { _CodItem = value; }
        }

        public int CodVenda
        {
            get { return _CodVenda; }
            set { _CodVenda = value; }
        }

        public int CodProdutos
        {
            get { return _CodProdutos; }
            set { _CodProdutos = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public int Quantidade
        {
            get { return _Quantidade; }
            set { _Quantidade = value; }
        }

        public double Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        public double Total
        {
            get { return _Total; }
            set { _Total = value; }
        }


        public void GravarProduto()
        {

            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO Itens_venda";
            strQuery += (" VALUES(");
            strQuery += ("Seq_Itens_venda.NEXTVAL,");
            strQuery += ("'" + _CodVenda + "',");
            strQuery += ("'" + _CodProdutos + "',");
            strQuery += ("'" + _Nome + "',");
            strQuery += ("'" + _Quantidade + "',");
            strQuery += ("'" + _Valor + "',");
            strQuery += ("'" + _Total + "'");
            strQuery += (")");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);
        }

        public DataSet ListarProduto(string CodVenda)
        {
            string strQuery;

            strQuery = "Select * from Itens_venda where cod_Venda like '%" + CodVenda +
             "%'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" delete from Itens_venda ");
            strQuery += (" WHERE ");
            strQuery += (" cod_Item = '" + _CodItem + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }




    }
}
