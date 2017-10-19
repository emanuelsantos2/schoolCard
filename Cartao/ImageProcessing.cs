using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cartao
{
    static class ImageProcessing
    {

        public static Bitmap Screenshot(Form form)
        {
            Graphics myGraphics = form.CreateGraphics();
            Size s = form.Size;
            Bitmap memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(form.Location.X, form.Location.Y, 0, 0, s);

            return memoryImage;
        }

    }
}
