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
    class Clnfecharvenda
    {
        private double _ValorTotal;
        private int _CodVenda;
        private double _Desconto;
        private string _Forma_pag ;
        private string _Parcelas ;
        private double _Valor_pago ;
        private double _Valor_restante ;
        private double _Troco;
        private string _Datadehoje;
        private int _Excluir;
        private int _linhas;

        public double ValorTotal
        {
            get { return _ValorTotal; }
            set { _ValorTotal = value; }
        }

        public int CodVenda
        {
            get { return _CodVenda; }
            set { _CodVenda = value; }

        }
        public double Desconto
        {
            get { return _Desconto; }
            set { _Desconto = value; }

        }

        public string Forma_pag
        {
            get { return _Forma_pag; }
            set { _Forma_pag = value; }

        }

        public string Parcelas
        {
            get { return _Parcelas; }
            set { _Parcelas = value; }

        }

        public double Valor_pago
        {
            get { return _Valor_pago; }
            set { _Valor_pago = value; }

        }

        public double Valor_restante
        {
            get { return _Valor_restante; }
            set { _Valor_restante = value; }

        }


        public double Troco
        {
            get { return _Troco; }
            set { _Troco = value; }

        }

        public string Datadehoje
        {
            get { return _Datadehoje; }
            set { _Datadehoje = value; }

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

            strQuery = "Select * from fechar_venda where datadehoje like '%" + strDescricao +
                "%'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }

        public OracleDataReader ListarUsuario(string cod)
        {

            string strQuery = "Select * from fechar_venda where cod_Venda='" + CodVenda + "'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }

        public void Gravar()
        {

            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO fechar_venda ";
            strQuery += ("VALUES(");
            strQuery += ("'" + _ValorTotal + "', ");
            strQuery += ("'" + _CodVenda + "', ");
            strQuery += ("'" + _Desconto + "', ");
            strQuery += ("'" + _Forma_pag + "', ");
            strQuery += ("'" + _Parcelas + "', ");
            strQuery += ("'" + _Valor_pago + "', ");
            strQuery += ("'" + _Valor_restante + "', ");
            strQuery += ("'" + _Troco + "', ");
            strQuery += ("'" + _Datadehoje + "' ");
            strQuery += (")");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);
        }
    }
}
