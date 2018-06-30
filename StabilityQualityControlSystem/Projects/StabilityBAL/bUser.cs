using StabilityDAL;
using StabilityInterface;
using System;
using System.Collections.Generic;
using System.Data;

namespace StabilityBAL
{
    public partial class BAL
    {
        public List<User> bGetUser(int id, string name, string userName = null, string password = null)
        {
            List<User> objListUser = new List<User>();
            DataSet ds = oD.dGetUser(id, name, userName, password);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow Row in ds.Tables[0].Rows) // Loop over the rows.
                {
                    User ob = new User();
                    ob.Id = Convert.ToInt16(Row["Id"]);
                    ob.UserName = Row["UserName"].ToString();
                    ob.FirstName = Row["FirstName"].ToString();
                    ob.LastName = Row["LastName"].ToString();
                    ob.RoleId = Convert.ToInt16(Row["RoleId"]);
                    ob.Role = Row["Role"].ToString(); ;
                    ob.Password = Cryptography.Encode(Row["Password"].ToString());
                    ob.AddedOn = FormatDate(Row["AddedOn"].ToString());
                    ob.ModifiedOn = FormatDate(Row["ModifiedOn"].ToString());
                    objListUser.Add(ob);
                }
            }
            return objListUser;
        }

        public bool bInsertUpdateUser(User o)
        {
            return oD.dInsertUpdateUser(o);
        }

        public bool bDeleteUser(int id)
        {
            return oD.dDeleteUser(id);
        }

    }
}
