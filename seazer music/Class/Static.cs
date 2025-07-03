using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seazer_music.Class
{

    public static class Static
    {
        public static bool HeadphonesConnected { get; private set; }

        public static void Initialize()
        {
            HeadphonesConnected = CheckHeadphones();
        }

        private static bool CheckHeadphones()
        {
            try
            {
                var enumerator = new MMDeviceEnumerator();
                MMDevice device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

                string deviceName = device.FriendlyName.ToLower();

                if (deviceName.Contains("headphone") || deviceName.Contains("kulaklık"))
                {
                    return true;
                }
            }
            catch
            {
                // Hata varsa false dönebilir
            }
            return false;
        }
    }
}
 
