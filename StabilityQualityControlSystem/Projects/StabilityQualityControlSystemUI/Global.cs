using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StabilityQualityControlSystemUI
{
    static class Global
    {
        private static string _userName;
        private static int _role;
        private static int _userId;

        public static int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }


        public static int Role
        {
            get { return _role; }
            set { _role = value; }
        }


        public static string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

    }
}
