using StabilityInterface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StabilityDAL
{
    public partial class DAL
    {
        public bool dInsertUpdateCountry(Country o)
        {
            string strQuery = "dbo.sprAddUpdCountry";

            SqlCommand cmd = new SqlCommand(strQuery);


            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = o.Id;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = o.Name;
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = o.Code;
            return DMLCommand(cmd);
        }

        public DataSet dGetCountry(int id, string name)
        {
            string strQuery = "dbo.sprGetCountry";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;

            return GetData(cmd);
        }
        public bool dDeleteCountry(int id)
        {
            string strQuery = "dbo.sprDeleteCountry";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            return DMLCommand(cmd);
        }

        public DataTable dGetddlCountry()
        {
            string strQuery = "SELECT [Id],[Name] FROM [STABILITY].[dbo].[tblCountry]";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.Text;

            return GetData(cmd).Tables[0];
        }
    }
}
