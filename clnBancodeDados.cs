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
    class clnBancodeDados
    {
        public static clnFuncoesGerais.Operacao ObjOperacao;
        public clnFuncoesGerais.Operacao EnumProperty
        {
            get { return ObjOperacao; }
            set { ObjOperacao = value; }
        }
        public static OracleConnection AbreBanco()
        {
            string strConexao = "Data Source=(DESCRIPTION="
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));"
              + "User Id=hr;Password=123456";
            
            try
            {
                OracleConnection conn = new OracleConnection(strConexao);
                conn.Open();
                return conn;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FechaBanco(OracleConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }
            catch (Exception e)
            { throw e; }
        }

        public DataSet RetornaDataSet(string strQuery)
        {
            OracleConnection conn;
            conn = AbreBanco();
            try
            {
                DataSet ds = new DataSet();
                OracleCommand cmdComando = new OracleCommand(strQuery, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmdComando);
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            { throw e; }
            finally { FechaBanco(conn); }
        }

        public OracleDataReader RetornaDataReader(string strQuery)
        {
            try
            {
                OracleDataReader dr;
                OracleCommand sqlComando = new OracleCommand(strQuery, AbreBanco());
                dr = sqlComando.ExecuteReader();
                return dr;
            }

            catch (Exception e)
            {
                throw e;
            }

        }

        public void ExecutaComando(string strQuery)
        {

            OracleConnection conn;
            conn = AbreBanco();
            try
            {
                OracleCommand sqlComm = new OracleCommand(strQuery, conn);
                sqlComm.ExecuteNonQuery();
            }
            catch (OracleException e)
            {

                //throw new Exception(e.Message);
                if (e.ErrorCode == 00001)
                {
                    //throw new Exception(("Registro Já Encontrado"));
               
                    
                    

                }
                
	
                
            }
            finally
            {
                FechaBanco(conn);
            }

        }
    }
}
