using StabilityDAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Data;


namespace StabilityBAL
{
    public partial class BAL
    {
        public List<StabilityCheck> bGetStabilityCheck(int id)
        {
            List<StabilityCheck> objListStabilityCheck = new List<StabilityCheck>();
            DataSet ds = oD.dGetStabilityCheck(id);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Row in ds.Tables[0].Rows) // Loop over the rows.
                {
                    StabilityCheck ob = new StabilityCheck();
                    ob.Id = Convert.ToInt16(Row["Id"]);
                    ob.BatchId = Convert.ToInt16(Row["BatchId"]);
                    ob.ChamberId = Convert.ToInt16(Row["ChamberId"]);
                    ob.ProductId = Convert.ToInt16(Row["ProductId"]);
                    ob.BatchNo = Row["BatchNo"].ToString();
                    ob.ChamberName = Row["ChamberName"].ToString();
                    ob.StudyReason = Row["StudyReason"].ToString();
                    ob.ProtocolNo = Row["ProtocolNo"].ToString();
                    ob.Remark = Row["Remark"].ToString();
                    ob.M1 = FormatDate(Row["M1"].ToString());
                    ob.M2 = FormatDate(Row["M2"].ToString());
                    ob.M3 = FormatDate(Row["M3"].ToString());
                    ob.M6 = FormatDate(Row["M6"].ToString());
                    ob.M9 = FormatDate(Row["M9"].ToString());
                    ob.M12 = FormatDate(Row["M12"].ToString());
                    ob.M18 = FormatDate(Row["M18"].ToString());
                    ob.M24 = FormatDate(Row["M24"].ToString());
                    ob.M30 = FormatDate(Row["M30"].ToString());
                    ob.M36 = FormatDate(Row["M36"].ToString());
                    ob.M42 = FormatDate(Row["M42"].ToString());
                    ob.M48 = FormatDate(Row["M48"].ToString());
                    ob.M60 = FormatDate(Row["M60"].ToString());
                    ob.M72 = FormatDate(Row["M72"].ToString());
                    objListStabilityCheck.Add(ob);
                }
            }
            return objListStabilityCheck;
        }

        public bool bInsertUpdateStabilityCheck(StabilityCheck o)
        {
            return oD.dInsertUpdateStabilityCheck(o);
        }

        public bool bDeleteStabilityCheck(int id)
        {
            return oD.dDeleteStabilityCheck(id);
        }
    }
}
