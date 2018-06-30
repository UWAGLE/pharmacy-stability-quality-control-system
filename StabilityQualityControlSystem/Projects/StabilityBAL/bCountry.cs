using StabilityDAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Data;


namespace StabilityBAL
{
    public partial class BAL
    {
        public List<Country> bGetCountry(int id, string name)
        {
            List<Country> objListCountry = new List<Country>();
            DataSet ds = oD.dGetCountry(id, name);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Row in ds.Tables[0].Rows) // Loop over the rows.
                {
                    Country ob = new Country();
                    ob.Id = Convert.ToInt16(Row[0]);
                    ob.Name = Row[1].ToString();
                    ob.Code = Row[2].ToString();
                    objListCountry.Add(ob);
                }
            }
            return objListCountry;
        }

        public bool bInsertUpdateCountry(Country o)
        {
            return oD.dInsertUpdateCountry(o);
        }

        public bool bDeleteCountry(int id)
        {
            return oD.dDeleteCountry(id);
        }
        public DataTable bGetddlCountry()
        {
            return oD.dGetddlCountry();
        }
    }
}
