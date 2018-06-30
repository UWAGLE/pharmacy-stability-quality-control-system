using StabilityDAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Data;

namespace StabilityBAL
{
    public partial class BAL
    {
        public List<Batch> bGetBatch(int id, string BatchNo)
        {
            List<Batch> objListBatch = new List<Batch>();
            DataSet ds = oD.dGetBatch(id, BatchNo);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Row in ds.Tables[0].Rows) // Loop over the rows.
                {
                    Batch ob = new Batch();
                    ob.Id = Convert.ToInt16(Row["Id"]);
                    ob.ProductId = Convert.ToInt16(Row["ProductId"]);
                    ob.CountryId = Convert.ToInt16(Row["CountryId"]);
                    ob.Type = Convert.ToInt16(Row["Type"]);
                    ob.BatchNo = Row["BatchNo"].ToString();
                    ob.ProductName = Row["ProductName"].ToString();
                    ob.MfgDate = FormatDate(Row["MfgDate"].ToString());
                    ob.ExpDate = FormatDate(Row["ExpDate"].ToString());
                    ob.BatchSize = Row["BatchSize"].ToString();
                    ob.ReleaseDate = FormatDate(Row["ReleaseDate"].ToString());
                    ob.IncubationDate = FormatDate(Row["IncubationDate"].ToString());
                    ob.CountryCode = Row["CountryCode"].ToString();
                    ob.TypeName = Row["TypeName"].ToString();
                    ob.OtherInfo = Row["OtherInfo"].ToString();
                    objListBatch.Add(ob);
                }
            }
            return objListBatch;
        }

        public bool bInsertUpdateBatch(Batch o)
        {
            return oD.dInsertUpdateBatch(o);
        }

        public bool bDeleteBatch(int id)
        {
            return oD.dDeleteBatch(id);
        }
        public DataTable bGetddlBatch(string productId)
        {
            return oD.dGetddlBatch(productId);
        }
    }
}
