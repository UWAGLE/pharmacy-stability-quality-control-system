using StabilityDAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Data;

namespace StabilityBAL
{
    public partial class BAL
    {
        DAL oD;
        public BAL()
        {
            oD = new DAL();
        }
        public void HideGridColumns(dynamic gridview, List<int> columnIndexes)
        {
            foreach (var ColumnIndex in columnIndexes)
            {
                gridview.Columns[ColumnIndex].Visible = false;
            }
            foreach (dynamic row in gridview.Rows)
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
        }

        public string FormatDate(string dateTime)
        {
            return dateTime.Replace(" 12.00.00 AM", string.Empty);
        }
    }
}
