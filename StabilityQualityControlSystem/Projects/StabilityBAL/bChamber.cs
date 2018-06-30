using StabilityDAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Data;


namespace StabilityBAL
{
    public partial class BAL
    {
        public List<Chamber> bGetChamber(int id, string name)
        {
            List<Chamber> objListChamber = new List<Chamber>();
            DataSet ds = oD.dGetChamber(id, name);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Row in ds.Tables[0].Rows) // Loop over the rows.
                {
                    Chamber ob = new Chamber();
                    ob.Id = Convert.ToInt16(Row["Id"]);
                    ob.Code = Row["Code"].ToString();
                    ob.Name = Row["Name"].ToString();
                    ob.Temperature = Row["Temperature"].ToString();
                    ob.Humidity = Row["Humidity"].ToString();
                    ob.Period = Row["Period"].ToString();
                    ob.ModifiedById = Convert.ToInt16(Row["ModifiedById"]);
                    ob.ModifiedBy = Row["ModifiedBy"].ToString();
                    objListChamber.Add(ob);
                }
            }
            return objListChamber;
        }

        public bool bInsertUpdateChamber(Chamber o)
        {
            return oD.dInsertUpdateChamber(o);
        }
        public bool bDeleteChamber(int id)
        {
            return oD.dDeleteChamber(id);
        }

        public DataTable bGetddlChamber()
        {
            return oD.dGetddlChamber();
        }
    }
}
