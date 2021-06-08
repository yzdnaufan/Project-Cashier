using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_n_data
{
    public static class LoginHandler
    {
        private static string username;

        private static bool loginstatus;

        private static bool isadmin;



        public static bool Loginstatus {
            get => loginstatus;
            set => loginstatus = value; }

        public static string Username {
            get => username;
            set => username = value; }
        public static bool Isadmin {
            get => isadmin;
            set => isadmin = value; }
    }
}
