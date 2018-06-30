using StabilityDAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Data;


namespace StabilityBAL
{
    public partial class BAL
    {
        public List<TestReport> bGetTestReport(int stabilityCheckId, int testId)
        {
            List<TestReport> objListTestReport = new List<TestReport>();
            DataSet ds = oD.dGetTestReport(stabilityCheckId, testId);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Row in ds.Tables[0].Rows) // Loop over the rows.
                {
                    TestReport ob = new TestReport();
                    ob.Id = Convert.ToInt16(Row["Id"]);
                    ob.StabilityCheckId = Convert.ToInt16(Row["StabilityCheckId"]);
                    ob.TestId = Convert.ToInt16(Row["TestId"]);
                    ob.StabilityCheck = Row["StabilityCheck"].ToString();
                    ob.TestCode = Row["TestCode"].ToString();
                    ob.Initial = Row["Initial"].ToString();
                    ob.M1 = Row["M1"].ToString();
                    ob.M2 = Row["M2"].ToString();
                    ob.M3 = Row["M3"].ToString();
                    ob.M6 = Row["M6"].ToString();
                    ob.M9 = Row["M9"].ToString();
                    ob.M12 = Row["M12"].ToString();
                    ob.M18 = Row["M18"].ToString();
                    ob.M24 = Row["M24"].ToString();
                    ob.M30 = Row["M30"].ToString();
                    ob.M36 = Row["M36"].ToString();
                    ob.M42 = Row["M42"].ToString();
                    ob.M48 = Row["M48"].ToString();
                    ob.M60 = Row["M60"].ToString();
                    ob.M72 = Row["M72"].ToString();
                    objListTestReport.Add(ob);
                }
            }
            return objListTestReport;
        }

        public DataTable bGetStabilityPlannerReport(string fromDate, string toDate)
        {
            return oD.dGetStabilityPlannerReport(fromDate, toDate).Tables[0];
        }

        public List<StabilityDueList> bGetStabilityDueReport(string fromDate, string toDate)
        {
            List<StabilityDueList> dueList = new List<StabilityDueList>();
            DataSet ds = oD.dGetStabilityPlannerReport(fromDate, toDate);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Row in ds.Tables[0].Rows) // Loop over the rows.
                {
                    StabilityDueList ob = new StabilityDueList();
                    ob.DueDate = FormatDate(Row["DueDate"].ToString());
                    ob.ProductName = Row["ProductName"].ToString();
                    ob.BatchNo = Row["BatchNo"].ToString();
                    dueList.Add(ob);
                }
            }
            return dueList;
        }
        public bool bInsertUpdateTestReport(TestReport o)
        {
            return oD.dInsertUpdateTestReport(o);
        }

        public bool bDeleteTestReport(int id)
        {
            return oD.dDeleteTestReport(id);
        }
    }
}
