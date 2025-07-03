using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seazer_music.Connection
{
    class connection
    {
        //firebase bağlantısını ayarlayan sınıf
        IFirebaseConfig fc =new seazer_music.Connection.Config().config();

        public IFirebaseClient client;
        
        public connection()
        {
            try
            {
                client = new FireSharp.FirebaseClient(fc);
            }
            catch (Exception)
            {
                Console.WriteLine("sunucuya bağlanılamadı");
            }
        }
    }
}