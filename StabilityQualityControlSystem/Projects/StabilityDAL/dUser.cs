using StabilityInterface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StabilityDAL
{
    public partial class DAL : SQLUtility
    {
        public bool dInsertUpdateUser(User o)
        {
            string strQuery = "dbo.sprAddUpdUser";

            SqlCommand cmd = new SqlCommand(strQuery);


            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = o.Id;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = o.UserName;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = o.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = o.LastName;
            cmd.Parameters.Add("@RoleId", SqlDbType.Int).Value = o.RoleId;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = o.Password;
            return DMLCommand(cmd);
        }

        public DataSet dGetUser(int id, string name, string userName, string Password)
        {
            string strQuery = "dbo.sprGetUser";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
            return GetData(cmd);
        }
        public bool dDeleteUser(int id)
        {
            string strQuery = "dbo.sprDeleteUser";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            return DMLCommand(cmd);
        }
    }
}
