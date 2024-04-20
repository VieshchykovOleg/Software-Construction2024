using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


    public class NetworkImageLoader : IImageLoader
    {
        public byte[] LoadImage(string href)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadData(href);
            }
        }
    }

