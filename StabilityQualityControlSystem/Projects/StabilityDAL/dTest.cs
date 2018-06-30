using StabilityInterface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StabilityDAL
{
    public partial class DAL
    {
        public bool dInsertUpdateTest(Test o)
        {
            string strQuery = "dbo.sprAddUpdTest";

            SqlCommand cmd = new SqlCommand(strQuery);


            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = o.Id;
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = o.Code;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = o.Name;
            cmd.Parameters.Add("@Specification", SqlDbType.NVarChar).Value = o.Specification;
            return DMLCommand(cmd);
        }

        public DataSet dGetTest(int id, string name)
        {
            string strQuery = "dbo.sprGetTest";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;

            return GetData(cmd);
        }

        public bool dDeleteTest(int id)
        {
            string strQuery = "dbo.sprDeleteTest";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            return DMLCommand(cmd);
        }
        public DataTable dGetddlTest()
        {
            string strQuery = "SELECT ID = 0, Name = 'Select Test' UNION ALL SELECT [Id],[Name] FROM [dbo].[tblTest]";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.Text;

            return GetData(cmd).Tables[0];
        }
    }
}
