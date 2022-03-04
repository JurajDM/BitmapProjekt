using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace BitmapProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var color = new Bitmap("C:/Users/Reroot/source/repos/BitmapProjekt/BitmapProjekt/bitmap/hamburg.bmp");
            var bw = color.Clone(new Rectangle(0, 0, color.Width, color.Height), PixelFormat.Format1bppIndexed);
            bw.Save("C:/Users/Reroot/source/repos/BitmapProjekt/BitmapProjekt/bitmap/hamburg_bw.bmp", ImageFormat.Bmp);
          
        }
       

    }
}

