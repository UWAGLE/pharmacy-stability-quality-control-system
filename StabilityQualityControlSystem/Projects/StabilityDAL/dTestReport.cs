using StabilityInterface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StabilityDAL
{
    public partial class DAL
    {
        public bool dInsertUpdateTestReport(TestReport o)
        {
            string strQuery = "dbo.sprAddUpdTestReport";

            SqlCommand cmd = new SqlCommand(strQuery);


            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = o.Id;
            cmd.Parameters.Add("@StabilityCheckId", SqlDbType.Int).Value = o.StabilityCheckId;
            cmd.Parameters.Add("@TestId", SqlDbType.Int).Value = o.TestId;
            cmd.Parameters.Add("@Initial", SqlDbType.NVarChar).Value = o.Initial;
            cmd.Parameters.Add("@M1", SqlDbType.NVarChar).Value = o.M1;
            cmd.Parameters.Add("@M2", SqlDbType.NVarChar).Value = o.M2;
            cmd.Parameters.Add("@M3", SqlDbType.NVarChar).Value = o.M3;
            cmd.Parameters.Add("@M6", SqlDbType.NVarChar).Value = o.M6;
            cmd.Parameters.Add("@M9", SqlDbType.NVarChar).Value = o.M9;
            cmd.Parameters.Add("@M12", SqlDbType.NVarChar).Value = o.M12;
            cmd.Parameters.Add("@M18", SqlDbType.NVarChar).Value = o.M18;
            cmd.Parameters.Add("@M24", SqlDbType.NVarChar).Value = o.M24;
            cmd.Parameters.Add("@M30", SqlDbType.NVarChar).Value = o.M30;
            cmd.Parameters.Add("@M36", SqlDbType.NVarChar).Value = o.M36;
            cmd.Parameters.Add("@M42", SqlDbType.NVarChar).Value = o.M42;
            cmd.Parameters.Add("@M48", SqlDbType.NVarChar).Value = o.M48;
            cmd.Parameters.Add("@M60", SqlDbType.NVarChar).Value = o.M60;
            cmd.Parameters.Add("@M72", SqlDbType.NVarChar).Value = o.M72;
            return DMLCommand(cmd);
        }

        public DataSet dGetTestReport(int stabilityCheckId, int testId)
        {
            string strQuery = "dbo.sprGetTestReport";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@StabilityCheckId", SqlDbType.Int).Value = (stabilityCheckId != 0 ? (object)stabilityCheckId : DBNull.Value);
            cmd.Parameters.Add("@TestId", SqlDbType.Int).Value = (testId != 0 ? (object)testId : DBNull.Value);

            return GetData(cmd);
        }

        public DataSet dGetStabilityPlannerReport(string fromDate, string toDate)
        {
            string strQuery = "dbo.sprGetStabilityCheckByDate";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@FromDate", SqlDbType.Date).Value = fromDate;
            cmd.Parameters.Add("@ToDate", SqlDbType.Date).Value = toDate;

            return GetData(cmd);
        }
        public bool dDeleteTestReport(int id)
        {
            string strQuery = "dbo.sprDeleteTestReport";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            return DMLCommand(cmd);
        }

    }
}
