using App.Domain.Interface;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data.Common;

namespace App.Infrastructure
{
    public class Database : IDatabaseConfiguration
    {
        protected DbConnection conn;
        public Database()
        {
            string db_host = Environment.GetEnvironmentVariable("DB_HOST") ?? "db";
            string db_user = Environment.GetEnvironmentVariable("DB_USER") ?? "sysdba";
            string db_password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "masterkey";
            string db_name = Environment.GetEnvironmentVariable("DB_NAME") ?? "/firebird/data/sender.fdb"; //"/firebird/data/email_sender.fdb";
            string connectionString = $"server={db_host};user={db_user};password={db_password};database={db_name}";
            conn = new FbConnection(connectionString);
        }

        public void Insert(string assunto, string mensagem)
        {
            string cmdText = $"INSERT INTO EMAILS (ASSUNTO, MENSAGEM) VALUES ('{assunto}','{mensagem}');";

            conn.Open();
            FbTransaction tran = (FbTransaction)conn.BeginTransaction();
            try
            {
                FbCommand comm = new FbCommand(cmdText, (conn as FbConnection), tran);

                comm.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
