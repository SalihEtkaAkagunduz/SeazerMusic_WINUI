using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Storage;

namespace seazer_music.Storage
{
   public class UserStorage
    {
      public static bool checkUser()
        {
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("user_token"))
            {
            return true;
            }
            else
            {
 //TODO
                ApplicationData.Current.LocalSettings.Values["user_token"] = "SalihDeneme";
                return true;
 
            }
        }
        public static string getUser()
        {
            return ApplicationData.Current.LocalSettings.Values["user_token"] as string;
        }
    }
}
