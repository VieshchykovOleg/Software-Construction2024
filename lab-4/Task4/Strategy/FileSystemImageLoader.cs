using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class FileSystemImageLoader : IImageLoader
    {
        public byte[] LoadImage(string href)
        {
            return File.ReadAllBytes(href);
        }
    }

