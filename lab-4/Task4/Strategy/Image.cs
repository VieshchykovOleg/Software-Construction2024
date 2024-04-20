using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Image
    {
        private IImageLoader _loader;

        public Image(IImageLoader loader)
        {
            _loader = loader;
        }

        public byte[] Load(string href)
        {
            return _loader.LoadImage(href);
        }
    }

