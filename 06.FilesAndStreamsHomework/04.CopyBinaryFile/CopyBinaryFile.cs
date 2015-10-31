using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            var image = new FileStream("image.png", FileMode.Open);
            var newImage = new FileStream("newImage.png", FileMode.Create);

            image.CopyTo(newImage);
            newImage.Flush();
        }
    }
}
