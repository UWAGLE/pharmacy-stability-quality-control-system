using StabilityDAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Data;


namespace StabilityBAL
{
    public partial class BAL
    {
        public List<Product> bGetProduct(int id, string name)
        {
            List<Product> objListProduct = new List<Product>();
            DataSet ds = oD.dGetProduct(id, name);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Row in ds.Tables[0].Rows) // Loop over the rows.
                {
                    Product ob = new Product();
                    ob.Id = Convert.ToInt16(Row["Id"]);
                    ob.Code = Row["Code"].ToString();
                    ob.Name = Row["Name"].ToString();
                    ob.LabelClaim = Row["LabelClaim"].ToString();
                    ob.APISource = Row["APISource"].ToString();
                    ob.PackingDetails = Row["PackingDetails"].ToString();
                    ob.Pack = Row["Pack"].ToString();
                    ob.ShelfLife = Row["ShelfLife"].ToString();
                    ob.ModifiedById = Convert.ToInt16(Row["ModifiedById"]);
                    ob.ModifiedBy = Row["ModifiedBy"].ToString();

                    objListProduct.Add(ob);
                }
            }
            return objListProduct;
        }

        public bool bInsertUpdateProduct(Product o)
        {
            return oD.dInsertUpdateProduct(o);
        }

        public bool bDeleteProduct(int id)
        {
            return oD.dDeleteProduct(id);
        }
        public DataTable bGetddlProduct()
        {
            return oD.dGetddlProduct();
        }
    }
}
