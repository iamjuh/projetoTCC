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
    class clnLogin
    {
        private int _CodLogin;
        private string _usuario;
        private string _senha;
        private string _usuario2;
        private string _senha2;
        private string _nivelacesso;
        private int _cod_func;


        public int CodLogin
        {
            get { return _CodLogin; }
            set { _CodLogin = value; }
        }
           
    
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        public string nivelacesso
        {
            get { return _nivelacesso; }
            set { _nivelacesso = value; }
        }

              
        public string usuario2
        {
            get { return _usuario2; }
            set { _usuario2 = value; }
        }
        public string senha2
        {
            get { return _senha2; }
            set { _senha2 = value; }
        }

                   
        public int cod_func
        {
            get { return _cod_func; }
            set { _cod_func = value; }
        }
   


        public DataSet Listar(string strDescricao)
        {
            string strQuery;

            strQuery = "Select * from Login where usuario like '%" + strDescricao +
                "%'";
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
      
        public OracleDataReader ListarLogin(string usuario)
        {
            string strQuery = "Select * from Login where usuario='"
                + usuario + "'";

            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }

        public void GravarCadLogin()
        {
            string strQuery;//criar a String para inserir
            strQuery = "INSERT INTO Login";
            strQuery += (" VALUES(");
            strQuery += ("Seq_T_login.NEXTVAL,");
            strQuery += ("'" + _cod_func + "',");
            strQuery += ("'" + _usuario + "',");
            strQuery += ("'" + _senha + "',");
            strQuery += ("'" + _nivelacesso + "',");
            strQuery += ("'1'");
            strQuery += (")");
            clnBancodeDados ObjCldBancoDados = new clnBancodeDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
         public void Alterar()
        {
            string strQuery;//criar a String para alterar
            strQuery = (" UPDATE login ");
            strQuery += (" SET ");
            strQuery += ("cod_Funcionario = '" + _cod_func + "',");
            strQuery += ("usuario = '" + _usuario + "',");
            strQuery += ("senha = '" + _senha + "',");
            strQuery += ("nivel_acesso = '" + _nivelacesso + "',");
            strQuery += ("'1'");
            strQuery += (" WHERE ");
            strQuery += (" cod_login = '" + _CodLogin + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);
        }

        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" delete from login ");
            strQuery += (" WHERE ");
            strQuery += (" cod_login = '" + _CodLogin + "' ");
            clnBancodeDados ObjBancoDados = new clnBancodeDados();
            ObjBancoDados.ExecutaComando(strQuery);

        }
    }
    }
       
