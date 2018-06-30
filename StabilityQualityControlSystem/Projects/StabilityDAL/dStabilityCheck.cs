using StabilityInterface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StabilityDAL
{
    public partial class DAL
    {
        public bool dInsertUpdateStabilityCheck(StabilityCheck o)
        {
            string strQuery = "dbo.sprAddUpdStabilityCheck";

            SqlCommand cmd = new SqlCommand(strQuery);


            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = o.Id;
            cmd.Parameters.Add("@BatchId", SqlDbType.Int).Value = o.BatchId;
            cmd.Parameters.Add("@ChamberId", SqlDbType.Int).Value = o.ChamberId;
            cmd.Parameters.Add("@StudyReason", SqlDbType.NVarChar).Value = o.StudyReason;
            cmd.Parameters.Add("@ProtocolNo", SqlDbType.NVarChar).Value = o.ProtocolNo;
            cmd.Parameters.Add("@Remark", SqlDbType.NVarChar).Value = o.Remark;
            cmd.Parameters.Add("@M1", SqlDbType.Date).Value = o.M1;
            cmd.Parameters.Add("@M2", SqlDbType.Date).Value = o.M2;
            cmd.Parameters.Add("@M3", SqlDbType.Date).Value = o.M3;
            cmd.Parameters.Add("@M6", SqlDbType.Date).Value = o.M6;
            cmd.Parameters.Add("@M9", SqlDbType.Date).Value = o.M9;
            cmd.Parameters.Add("@M12", SqlDbType.Date).Value = o.M12;
            cmd.Parameters.Add("@M18", SqlDbType.Date).Value = o.M18;
            cmd.Parameters.Add("@M24", SqlDbType.Date).Value = o.M24;
            cmd.Parameters.Add("@M30", SqlDbType.Date).Value = o.M30;
            cmd.Parameters.Add("@M36", SqlDbType.Date).Value = o.M36;
            cmd.Parameters.Add("@M42", SqlDbType.Date).Value = o.M42;
            cmd.Parameters.Add("@M48", SqlDbType.Date).Value = o.M48;
            cmd.Parameters.Add("@M60", SqlDbType.Date).Value = o.M60;
            cmd.Parameters.Add("@M72", SqlDbType.Date).Value = o.M72;
            return DMLCommand(cmd);
        }

        public DataSet dGetStabilityCheck(int id)
        {
            string strQuery = "dbo.sprGetStabilityCheck";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            return GetData(cmd);
        }

        public bool dDeleteStabilityCheck(int id)
        {
            string strQuery = "dbo.sprDeleteStabilityCheck";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            return DMLCommand(cmd);
        }
    }
}
