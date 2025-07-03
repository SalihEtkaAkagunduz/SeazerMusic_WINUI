using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using seazer_music.Class;
using seazer_music.Connection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace seazer_music.Crud
{
    public class MainPageCrud
    {
        //String userId = Storage.UserStorage.getUser();
        static connection conn = new connection();
        IFirebaseConfig config = new Config().config();

        public static List<BasicList> GetMods()
        {
            try
            {
                FirebaseResponse response = conn.client.Get("DesktopApp/MainPage/Mods");

                var modList = JsonConvert.DeserializeObject<List<BasicList>>(response.Body);

                return modList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"bir hata ile karşılaşıldı: {ex.Message}");
                return new List<BasicList>()
                 ; // null yerine boş liste döndür
            }
        }
        public static List<BasicList> GetSadTurkishMusic()
        {
            try
            {
                FirebaseResponse response = conn.client.Get("DesktopApp/MainPage/Turkish_Sad");

                var modList = JsonConvert.DeserializeObject<List<BasicList>>(response.Body);

                return modList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"bir hata ile karşılaşıldı: {ex.Message}");
                return new List<BasicList>(); // null yerine boş liste döndür
            }
        }
        public static List<BasicList> GetHitMusic()
        {
            try
            {
                FirebaseResponse response = conn.client.Get("DesktopApp/MainPage/Hit_Music");

                var modList = JsonConvert.DeserializeObject<List<BasicList>>(response.Body);

                return modList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"bir hata ile karşılaşıldı: {ex.Message}");
                return new List<BasicList>(); // null yerine boş liste döndür
            }
        }
        public static List<BasicList> GetPopularYoutubeLists()
        {
            try
            {
                FirebaseResponse response = conn.client.Get("DesktopApp/MainPage/Youtube_Music_Popular");

                var modList = JsonConvert.DeserializeObject<List<BasicList>>(response.Body);

                return modList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"bir hata ile karşılaşıldı: {ex.Message}");
                return new List<BasicList>(); // null yerine boş liste döndür
            }
        }
        public static List<MediumList> GetSpecialNewLists()
        {
            try
            {
                FirebaseResponse response = conn.client.Get("DesktopApp/MainPage/Special_new");

                var modList = JsonConvert.DeserializeObject<List<MediumList>>(response.Body);

                return modList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"bir hata ile karşılaşıldı: {ex.Message}");
                var aa = new MediumList();
                aa.Url = "aa";
                aa.Title = "Title";
                aa.uptext = "Title";
                aa.Image = "/Assets/logoo.png";
                var bb= new List<MediumList>(); bb.Add(aa);
                return bb; // null yerine boş liste döndür
            }
        }
        public static List<VideoList> GetpopularClips()
        {
            try
            {
                FirebaseResponse response = conn.client.Get("DesktopApp/MainPage/Populer_clips");

                var modList = JsonConvert.DeserializeObject<List<VideoList>>(response.Body);

                return modList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"bir hata ile karşılaşıldı: {ex.Message}");
                return new List<VideoList>(); // null yerine boş liste döndür
            }
        }
        public static List<FooterList> GetFooterList()
        {
            try
            {
                FirebaseResponse response = conn.client.Get("DesktopApp/MainPage/FooterItems");

                var modList = JsonConvert.DeserializeObject<List<FooterList>>(response.Body);

                return modList;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"bir hata ile karşılaşıldı: {ex.Message}");
                return new List<FooterList>(); // null yerine boş liste döndür
            }
        }
    }
}