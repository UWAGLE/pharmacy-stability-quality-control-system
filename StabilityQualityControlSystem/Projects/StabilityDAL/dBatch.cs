using StabilityInterface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StabilityDAL
{
    public partial class DAL
    {
        public bool dInsertUpdateBatch(Batch o)
        {
            string strQuery = "dbo.sprAddUpdBatch";

            SqlCommand cmd = new SqlCommand(strQuery);


            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = o.Id;
            cmd.Parameters.Add("@BatchNo", SqlDbType.NVarChar).Value = o.BatchNo;
            cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = o.ProductId;
            cmd.Parameters.Add("@MfgDate", SqlDbType.Date).Value = o.MfgDate;
            cmd.Parameters.Add("@ExpDate", SqlDbType.Date).Value = o.ExpDate;
            cmd.Parameters.Add("@BatchSize", SqlDbType.NVarChar).Value = o.BatchSize;
            cmd.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = o.ReleaseDate;
            cmd.Parameters.Add("@IncubationDate", SqlDbType.Date).Value = o.IncubationDate;
            cmd.Parameters.Add("@CountryId", SqlDbType.Int).Value = o.CountryId;
            cmd.Parameters.Add("@Type", SqlDbType.Int).Value = o.Type;
            cmd.Parameters.Add("@OtherInfo", SqlDbType.NVarChar).Value = o.OtherInfo;
            return DMLCommand(cmd);
        }

        public DataSet dGetBatch(int id, string BatchNo)
        {
            string strQuery = "dbo.sprGetBatch";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            cmd.Parameters.Add("@BatchNo", SqlDbType.NVarChar).Value = BatchNo;
            return GetData(cmd);
        }
        public bool dDeleteBatch(int id)
        {
            string strQuery = "dbo.sprDeleteBatch";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            return DMLCommand(cmd);
        }
        public DataTable dGetddlBatch(string productId)
        {
            string strQuery = string.Format("SELECT [Id],[BatchNo] FROM [STABILITY].[dbo].[tblBatch] WHERE ProductId = {0}", productId);

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.Text;

            return GetData(cmd).Tables[0];
        }
    }
}
