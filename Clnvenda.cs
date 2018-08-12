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
    class Clnvenda
    {
        private int _CodVenda;
        private int _CodFuncionairo;
        private int _CodCliente;
        private int _CodProdutos;
        private string _Data;
        private string _Status_venda;

     
    

        public int CodVenda
        {
            get { return _CodVenda; }
            set { _CodVenda = value; }
        }
        //===========================
        public int CodFuncionairo
        {
            get { return _CodFuncionairo; }
            set { _CodFuncionairo = value; }

        }

        public int CodCliente
        {
            get { return _CodCliente; }
            set { _CodCliente = value; }
        }

        //======================

        public int CodProdutos
        {
            get { return _CodProdutos; }
            set { _CodProdutos = value; }

        }


        public string Data
        {
            get { return _Data; }
            set { _Data = value.ToUpper(); }
        }

        public string Status_venda
        {
            get { return _Status_venda; }
            set { Status_venda = value.ToUpper(); }
        }
       
      
    
    }
}
