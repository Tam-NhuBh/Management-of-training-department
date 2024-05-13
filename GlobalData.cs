using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class GlobalData
    {
        public static int GlobalUserID { get; private set; } = 2002202;
        public static int GlobalUserType { get; private set; } = 2;
        public static void SetGlobalUserID(int userId)
        {
            GlobalUserID = userId;
        }
        public static void SetGlobalUserType(int type)
        {
            GlobalUserType = type;
        }
    }
}
