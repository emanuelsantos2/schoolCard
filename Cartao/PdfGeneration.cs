using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfSharp.Drawing;
using System.IO;

namespace Cartao
{
    static class PdfGeneration
    {

            static public void GeneratePDF(string filename, string folderLoc)
            {
            PdfDocument document = new PdfDocument();
            int margin = 20;
            int width = 300;
            int height = 180;

            //Gets files inside chosen Folder
            string[] files = Directory.GetFiles(folderLoc, "*.jpg", SearchOption.AllDirectories);
            double pagesCalc = Convert.ToDouble(files.Length) / 4.0;
            double pagesN = Math.Ceiling(pagesCalc);
            int _pagesN = int.Parse(pagesN.ToString());
            XGraphics[] gfx = new XGraphics[_pagesN];
            PdfPage[] pages = new PdfPage[_pagesN];
            // Create an empty page or load existing
            for (int b = 0; b < _pagesN; b++)
            {
                pages[b] = document.AddPage();
                gfx[b] = XGraphics.FromPdfPage(pages[b]);
            }

            // Get an XGraphics object for drawing

            int i = 0;
            int fileN = 0;
            for (int currentPage = 1; currentPage <= 4;)
            {
                for (i = 0; fileN < files.Length; i++, fileN++)
                {

                    DrawImage(gfx[currentPage-1], files[fileN], 0 + margin, (height * i) + margin + 10, width, height);


                }
                if(fileN / 4 < currentPage)
                {
                    currentPage++;
                    i = 0;
                }

            }


            // Save and start View
            document.Save(filename);
            Process.Start(filename);
            }

        static void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }

        static public double RoundUpValue(double value, int decimalpoint)
        {
            var result = Math.Round(value, decimalpoint);
            if (result < value)
            {
                result += Math.Pow(10, -decimalpoint);
            }
            return result;
        }

    }

    
}
