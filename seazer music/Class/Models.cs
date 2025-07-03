using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seazer_music.Class
{
   
        public class BasicList
        {
            public string Image { get; set; }
            public string Title { get; set; }
            public string Url { get; set; }
       
    }
    public class MediumList
    {
        public string uptext { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
    public class FooterList
    {
       
        public string Image { get; set; }
        public string Title { get; set; }
        public int Code { get; set; }
    }
    public class VideoList
        {
        public List<string> Author { get; set; }
        public string Image { get; set; }
            public string Title { get; set; }
            public string Url { get; set; }
        public string AuthorDisplay
        {
            get
            {
                if (Author == null || Author.Count == 0)
                    return "";

                if (Author.Count == 1)
                    return Author[0];

                if (Author.Count == 2)
                    return $"{Author[0]} ve {Author[1]}";

                // 3+ isim varsa: A, B ve C
                var allButLast = Author.Take(Author.Count - 1);
                return string.Join(", ", allButLast) + " ve " + Author.Last();
            }
        }
    }
    }
