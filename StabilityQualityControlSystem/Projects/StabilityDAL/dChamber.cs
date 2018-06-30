using StabilityInterface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StabilityDAL
{
    public partial class DAL
    {
        public bool dInsertUpdateChamber(Chamber o)
        {
            string strQuery = "dbo.sprAddUpdChamber";

            SqlCommand cmd = new SqlCommand(strQuery);


            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = o.Id;
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = o.Code;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = o.Name;
            cmd.Parameters.Add("@Temperature", SqlDbType.NVarChar).Value = o.Temperature;
            cmd.Parameters.Add("@Humidity", SqlDbType.NVarChar).Value = o.Humidity;
            cmd.Parameters.Add("@Period", SqlDbType.NVarChar).Value = o.Period;
            cmd.Parameters.Add("@ModifiedBy", SqlDbType.Int).Value = o.ModifiedById;
            return DMLCommand(cmd);
        }

        public DataSet dGetChamber(int id, string name)
        {
            string strQuery = "dbo.sprGetChamber";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
            return GetData(cmd);
        }
        public bool dDeleteChamber(int id)
        {
            string strQuery = "dbo.sprDeleteChamber";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            return DMLCommand(cmd);
        }

        public DataTable dGetddlChamber()
        {
            string strQuery = "SELECT [Id],[Name] FROM [STABILITY].[dbo].[tblChamber]";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.Text;

            return GetData(cmd).Tables[0];
        }

    }
}
