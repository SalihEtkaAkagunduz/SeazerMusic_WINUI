using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seazer_music.Connection
{
    public class Config
    {
        public IFirebaseConfig config()
        {
               IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "sy3XV4C4MoNK62SVdm2r9yWwxwl4DeYOfNfOxJdR",
            BasePath = "https://seazer-music-default-rtdb.firebaseio.com/"
        };
            return config;
        }
      
    }
}
