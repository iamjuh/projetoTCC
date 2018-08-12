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
    class Clfuncionario
    {
        private int _CodFuncionario;
        private string _Nome;
        private string _DtNasc;
        private string _Sexo;
        private string _CPF;
        private string _RG;
        private string _Logradouro;
        private string _NumResid;
        private string _Complemento;
        private string _CEP;
        private string _Bairro;
        private string _Cidade;
        private string _UF;
        private string _Telefone;
        private string _Celular;
        private string _Email;
        private string _Cargo;
        private int _Excluir;
        private int _linhas;


        public int CodFuncionario
        {
            get { return _CodFuncionario; }
            set { _CodFuncionario = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value.ToUpper(); }

        }
        //=======================
        public string DtNasc
        {
            get { return _DtNasc; }
            set { _DtNasc = value.ToUpper(); }

        }

        //===========================
        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value.ToUpper(); }

        }
        //======================

        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value.ToUpper(); }

        }
        //======================

        public string RG
        {
            get { return _RG; }
            set { _RG = value.ToUpper(); }

        }
        //======================


        public string Logradouro
        {
            get { return _Logradouro; }
            set { _Logradouro = value.ToUpper(); }

        }
        //======================
        public string NumResid
        {
            get { return _NumResid; }
            set { _NumResid = value.ToUpper(); }

        }
        //======================
        public string Complemento
        {
            get { return _Complemento; }
            set { _Complemento = value.ToUpper(); }

        }
        //======================

        public string CEP
        {
            get { return _CEP; }
            set { _CEP = value.ToUpper(); }

        }
        //======================
        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value.ToUpper(); }

        }
        //======================
        public string Cidade
        {
            get { return _Cidade; }
            set { _Cidade = value.ToUpper(); }

        }
        //======================
        public string UF
        {
            get { return _UF; }
            set { _UF = value.ToUpper(); }

        }
        //======================
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value.ToUpper(); }

        }
        //======================
        public string Celular
        {
            get { return _Celular; }
            set { _Celular = value.ToUpper(); }

        }
        //======================
        public string Email
        {
            get { return _Email; }
            set { _Email = value.ToUpper(); }

        }
        //======================
        public string Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value.ToUpper(); }

        }
        //======================
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

            strQuery = "Select * from Funcionario where nome like '%" + strDescricao +
                "%'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }

        public OracleDataReader ListarUsuario(string cod)
        {

            string strQuery = "Select * from Funcionario where cod_Funcionario='" + CodFuncionario + "'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }

        public void Gravar()
        {

            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO funcionario";
            strQuery += (" VALUES(");
            strQuery += ("Seq_Funcionario.NEXTVAL,");
            strQuery += ("'" + _Nome + "',");
            strQuery += ("'" + _DtNasc + "',");
            strQuery += ("'" + _Sexo + "',");
            strQuery += ("'" + _CPF + "',");
            strQuery += ("'" + _RG + "',");
            strQuery += ("'" + _Logradouro + "',");
            strQuery += ("'" + _NumResid + "',");
            strQuery += ("'" + _Complemento + "',");
            strQuery += ("'" + _CEP + "',");
            strQuery += ("'" + _Bairro + "',");
            strQuery += ("'" + _Cidade + "',");
            strQuery += ("'" + _UF + "',");
            strQuery += ("'" + _Telefone + "',");
            strQuery += ("'" + _Celular + "',");
            strQuery += ("'" + _Email + "',");
            strQuery += ("'" + _Cargo + "'");
            strQuery += (")");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

           }
        public void Alterar()
        {
            string strQuery;//criar a String para alterar
            strQuery = (" UPDATE funcionario ");
            strQuery += (" SET ");
            strQuery += ("nome = '" + _Nome + "',");
            strQuery += ("dt_nasc = '" + _DtNasc + "',");
            strQuery += ("sexo = '" + _Sexo + "',");
            strQuery += ("CPF ='" + _CPF + "',");
            strQuery += ("RG = '" + _RG + "',");
            strQuery += ("logradouro = '" + _Logradouro + "',");
            strQuery += ("num_resid ='" + _NumResid + "',");
            strQuery += ("complemento = '" + _Complemento + "',");
            strQuery += ("CEP = '" + _CEP + "',");
            strQuery += ("bairro = '" + _Bairro + "',");
            strQuery += ("cidade = '" + _Cidade + "',");
            strQuery += ("UF = '" + _UF + "',");
            strQuery += ("telefone = '" + _Telefone + "',");
            strQuery += ("celular = '" + _Celular + "',");
            strQuery += ("email = '" + _Email + "',");
            strQuery += ("cargo = '" + _Cargo + "'"); 
            strQuery += (" WHERE ");
            strQuery += (" cod_Funcionario = '" + _CodFuncionario + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }

        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" delete from funcionario ");
            strQuery += (" WHERE ");
            strQuery += (" cod_Funcionario = '" + _CodFuncionario + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

             }



    }
}
    
