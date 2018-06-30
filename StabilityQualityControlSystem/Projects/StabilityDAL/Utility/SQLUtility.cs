using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StabilityDAL
{
    public class SQLUtility : IDisposable
    {
        string constr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        public SqlConnection Conn { get { return new SqlConnection(constr); } }

        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public DataSet GetData(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataSet ds = new DataSet())
                    {
                        sda.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public Boolean DMLCommand(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                try
                {
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }


        public SqlDataReader GetDataReader(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                try
                {
                    con.Open();
                    return cmd.ExecuteReader();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        //public void BindDD(DropDownList dd, string query, string key)
        //{
        //    DataTable dtTable = new DataTable();
        //    try
        //    {
        //        using (SqlConnection sqlConnection = new SqlConnection(constr))
        //        {
        //            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
        //            {
        //                sqlConnection.Open();

        //                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
        //                {
        //                    dtTable.Load(sqlDataReader);
        //                    sqlDataReader.Close();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception error)
        //    {
        //        throw error;
        //    }

        //    dd.DataSource = dtTable;
        //    dd.DataValueField = "id";
        //    dd.DataTextField = "item";
        //    dd.DataBind();
        //    dd.Items.Insert(0, new ListItem("Select " + key, "0"));
        //}

        public void Dispose()
        {
            this.Dispose();
        }
    }
}