using StabilityDAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Data;

namespace StabilityBAL
{
    public partial class BAL
    {
        public List<Test> bGetTest(int id, string name)
        {
            List<Test> objListTest = new List<Test>();
            DataSet ds = oD.dGetTest(id, name);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Row in ds.Tables[0].Rows) // Loop over the rows.
                {
                    Test ob = new Test();
                    ob.Id = Convert.ToInt16(Row[0]);
                    ob.Code = Row[1].ToString();
                    ob.Name = Row[2].ToString();
                    ob.Specification = Row[3].ToString();
                    objListTest.Add(ob);
                }
            }
            return objListTest;
        }

        public bool bInsertUpdateTest(Test o)
        {
            return oD.dInsertUpdateTest(o);
        }
        public bool bDeleteTest(int id)
        {
            return oD.dDeleteTest(id);
        }
        public DataTable bGetddlTest()
        {
            return oD.dGetddlTest();
        }
    }
}
