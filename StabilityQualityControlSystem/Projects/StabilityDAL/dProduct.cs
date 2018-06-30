using StabilityInterface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StabilityDAL
{
    public partial class DAL
    {
        public bool dInsertUpdateProduct(Product o)
        {
            string strQuery = "dbo.sprAddUpdProduct";

            SqlCommand cmd = new SqlCommand(strQuery);


            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = o.Id;
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = o.Code;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = o.Name;
            cmd.Parameters.Add("@LabelClaim", SqlDbType.NVarChar).Value = o.LabelClaim;
            cmd.Parameters.Add("@APISource", SqlDbType.NVarChar).Value = o.APISource;
            cmd.Parameters.Add("@PackingDetails", SqlDbType.NVarChar).Value = o.PackingDetails;
            cmd.Parameters.Add("@Pack", SqlDbType.NVarChar).Value = o.Pack;
            cmd.Parameters.Add("@ShelfLife", SqlDbType.NVarChar).Value = o.ShelfLife;
            cmd.Parameters.Add("@ModifiedById", SqlDbType.Int).Value = o.ModifiedById;
            return DMLCommand(cmd);
        }

        public DataSet dGetProduct(int id, string name)
        {
            string strQuery = "dbo.sprGetProduct";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;

            return GetData(cmd);
        }

        public bool dDeleteProduct(int id)
        {
            string strQuery = "dbo.sprDeleteProduct";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = (id != 0 ? (object)id : DBNull.Value);

            return DMLCommand(cmd);
        }
        public DataTable dGetddlProduct()
        {
            string strQuery = "SELECT [Id] = 0, Name = 'Select Product' UNION ALL SELECT [Id],[Name] FROM [STABILITY].[dbo].[tblProduct]";

            SqlCommand cmd = new SqlCommand(strQuery);

            cmd.CommandType = CommandType.Text;

            return GetData(cmd).Tables[0];
        }
    }
}
