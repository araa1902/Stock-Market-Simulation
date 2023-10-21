using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace STOCKUI2
{
    internal class UserCredentials : UserCredsDB
    { 
        public static int GetUserId(string username)
        {
            return GetUserIDFromUsername(username);
        
        }
        public static int GetUserWalletID()
        {
            return GetWalletIDFromUsername();
        }
    }
}
