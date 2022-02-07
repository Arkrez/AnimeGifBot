using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeGifBot.Models
{
    public class GifUrls
    {
        public string Url { get; set; }

        public GifUrls(string url)
        {
            Url = url;
        }
    }
}
