using System;
using Windows.Storage;

namespace seazer_music.Storage
{
    public static class DoubleStorage
    {
        public static void setStorage(double a, string key)
        {
            ApplicationData.Current.LocalSettings.Values[key] = a.ToString();
        }

        public static double getStorage(string key)
        {
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey(key))
            {
                string raw = ApplicationData.Current.LocalSettings.Values[key] as string;
                if (double.TryParse(raw, out double value))
                {
                    return value;
                }
            }
 
            return 90;
        }
    }
}
