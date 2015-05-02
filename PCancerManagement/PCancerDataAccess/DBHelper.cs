using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCancerDataAccess
{
    public class DBHelper
    {


        /// <summary>
        /// Static Declaration of ConnectionString for the database connectivity
        /// Initilize empty string
        /// </summary>
        public static string ConnectionString = string.Empty;


        /// <summary>
        /// Static void Method for providing ConnectionString
        /// </summary>
        public static void SetConnectionString()
        {
            //ConnectionString = @"Data Source=ROHAN\SCSQL2008;Initial Catalog=RTL;User ID=sa;Password=socialcube";
            ConnectionString = @"Data Source=LOAD\SQLEXPRESS;Initial Catalog=cancer;Integrated Security=True";

            //if (string.IsNullOrEmpty(ConnectionString))
            //{
            //    XmlTextReader reader = null;
            //    string fname = string.Empty, dbserver = string.Empty, dbfile = string.Empty, dbuser = string.Empty, dbpassword = string.Empty;

            //    try
            //    {
            //        fname = Application.StartupPath + "\\dbsetup.conf";

            //        reader = new XmlTextReader(fname);
            //        reader.WhitespaceHandling = WhitespaceHandling.None;

            //        while (reader.Read())
            //        {
            //            if (reader.Name == "Server")
            //            {
            //                reader.Read();
            //                dbserver = reader.Value;
            //                reader.Read();
            //            }
            //            else if (reader.Name == "Database")
            //            {
            //                reader.Read();
            //                dbfile = reader.Value;
            //                reader.Read();
            //            }
            //            else if (reader.Name == "User")
            //            {
            //                reader.Read();
            //                dbuser = reader.Value;
            //                reader.Read();
            //            }
            //            else if (reader.Name == "Password")
            //            {
            //                reader.Read();
            //                dbpassword = reader.Value;
            //                reader.Read();
            //            }
            //        }
            //    }
            //    finally
            //    {
            //        if (reader != null)
            //            reader.Close();
            //    }

            //    ConnectionString = "Data Source=" + dbserver + ";Initial Catalog=" + dbfile + ";User ID=" + dbuser + ";Password=" + dbpassword;
            //}
        }


        /// <summary>
        /// Method to execute stored procedure using the param
        /// </summary>
        /// <param name="sql">string</param>
        /// <param name="param">SqlParameter</param>
        /// <returns>integer</returns>
        public static int ExecuteNonQuery(string sql, SqlParameter[] param)
        {
            int retval = 0;

            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlCommand Command = new SqlCommand(sql, Connection);

                for (int i = 0; i < param.Length; i++)
                    Command.Parameters.Add(param[i]);

                Connection.Open();
                retval = Command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;

            }
            finally
            {
                Connection.Close();
            }

            return retval;
        }

        /// <summary>
        /// Executes query from a List<Type> Object
        /// </summary>
        /// <param name="sql">string</param>
        /// <param name="objList">SqlParameter</param>
        /// <returns>int</returns>
        public static int ExecuteNonQueryList(string sql, List<SqlParameter[]> objList)
        {
            int retval = 0;

            SqlConnection Connection = new SqlConnection();
            try
            {
                Connection.ConnectionString = ConnectionString;
                Connection.Open();
                foreach (SqlParameter[] param in objList)
                {
                    SqlCommand Command = new SqlCommand(sql, Connection);
                    for (int i = 0; i < param.Length; i++)
                        Command.Parameters.Add(param[i]);
                    retval = Command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }

            return retval;
        }


        /// <summary>
        /// Executes stored procedure 
        /// </summary>
        /// <param name="procedure">string</param>
        /// <param name="param">SqlParameter</param>
        /// <returns>int</returns>
        public static int ExecuteStoredProcedure(string procedure, SqlParameter[] param)
        {
            int retval = 0;

            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlCommand Command = new SqlCommand(procedure, Connection);
                Command.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < param.Length; i++)
                    Command.Parameters.Add(param[i]);

                Connection.Open();
                retval = Command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }

            return retval;
        }


        /// <summary>
        /// Executes Stored Procedore list
        /// </summary>
        /// <param name="procedure">string</param>
        /// <param name="paramlist">list</param>
        /// <returns>int</returns>
        public static int ExecuteStoredProcudereList(string procedure, List<SqlParameter[]> paramlist)
        {
            int retval = 0;

            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                Connection.Open();

                foreach (SqlParameter[] param in paramlist)
                {
                    SqlCommand Command = new SqlCommand(procedure, Connection);
                    Command.CommandType = CommandType.StoredProcedure;

                    for (int i = 0; i < param.Length; i++)
                        Command.Parameters.Add(param[i]);

                    retval = Command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }

            return retval;
        }


        /// <summary>
        /// Executes stored procedures and returns as string array
        /// </summary>
        /// <param name="procedure">string</param>
        /// <param name="param"></param>
        /// <returns>SqlParameter</returns>
        public static string[] ExecuteReturnIDStoredProcedureARRAY(string procedure, SqlParameter[] param)
        {
            string[] retval = new string[2];

            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlCommand Command = new SqlCommand(procedure, Connection);
                Command.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < param.Length; i++)
                    Command.Parameters.Add(param[i]);

                Connection.Open();
                Command.ExecuteNonQuery();
                retval[0] = Command.Parameters[Command.Parameters.Count - 2].Value.ToString();
                retval[1] = Command.Parameters[Command.Parameters.Count - 1].Value.ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }

            return retval;
        }

        /// <summary>
        /// Executes Stored Procedure and returns result as string
        /// </summary>
        /// <param name="procedure"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string ExecuteReturnIDStoredProcedure(string procedure, SqlParameter[] param)
        {
            string retval = string.Empty;

            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlCommand Command = new SqlCommand(procedure, Connection);
                Command.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < param.Length; i++)
                    Command.Parameters.Add(param[i]);

                Connection.Open();
                Command.ExecuteNonQuery();
                retval = Command.Parameters[0].Value.ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }

            return retval;
        }


        public static int ExecuteTransactionProcedure(string sql, SqlParameter[] param)
        {
            int retval = 0;

            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = ConnectionString;
            Connection.Open();
            SqlTransaction Transaction = Connection.BeginTransaction();
            try
            {
                SqlCommand Command = new SqlCommand(sql, Connection, Transaction);
                Command.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < param.Length; i++)
                    Command.Parameters.Add(param[i]);

                retval = Command.ExecuteNonQuery();
                Transaction.Commit();
            }
            catch (SqlException ex)
            {
                Transaction.Rollback();
            }
            finally
            {
                Connection.Close();
            }

            return retval;
        }


        public static DataSet ExecuteDataSet(string sql)
        {
            DataSet ds = new DataSet();

            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlDataAdapter DataAdapter = new SqlDataAdapter(sql, Connection);

                Connection.Open();
                DataAdapter.Fill(ds);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }

            return ds;
        }


        public static DataSet ExecuteDataSet(string sql, SqlParameter[] param1)
        {
            DataSet ds = new DataSet();

            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlDataAdapter DataAdapter = new SqlDataAdapter(sql, Connection);

                for (int i = 0; i < param1.Length; i++)
                    DataAdapter.SelectCommand.Parameters.Add(param1[i]);

                Connection.Open();
                DataAdapter.Fill(ds);
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                Connection.Close();
            }

            return ds;
        }



        public static DataSet ExecuteTypedDataSet(string sql, SqlParameter[] param1, DataSet ds, string TableName)
        {
            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlDataAdapter DataAdapter = new SqlDataAdapter(sql, Connection);

                for (int i = 0; i < param1.Length; i++)
                    DataAdapter.SelectCommand.Parameters.Add(param1[i]);

                Connection.Open();
                DataAdapter.Fill(ds, TableName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }

            return ds;
        }



        public static DataSet ExecuteTypedDataSet(string sql, DataSet ds, string TableName)
        {
            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlDataAdapter DataAdapter = new SqlDataAdapter(sql, Connection);

                Connection.Open();
                DataAdapter.Fill(ds, TableName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }

            return ds;
        }



        public static object ExecuteScaller(string sql, SqlParameter[] param)
        {
            object obj = null;

            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlCommand Command = new SqlCommand(sql, Connection);

                for (int i = 0; i < param.Length; i++)
                    Command.Parameters.Add(param[i]);

                Connection.Open();
                SqlDataReader DataReader = Command.ExecuteReader();

                if (DataReader.Read())
                {
                    obj = (object)DataReader[0];
                }
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                Connection.Close();
            }

            return obj;
        }


        public static object ExecuteScaller(string sql)
        {
            object obj = null;

            SqlConnection Connection = new SqlConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                SqlCommand Command = new SqlCommand(sql, Connection);

                Connection.Open();
                SqlDataReader DataReader = Command.ExecuteReader();

                if (DataReader.Read())
                {
                    obj = (object)DataReader[0];
                }
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                Connection.Close();
            }

            return obj;
        }
    }
}
