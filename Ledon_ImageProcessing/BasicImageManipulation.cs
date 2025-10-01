using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ledon_ImageProcessing
{
    
    internal class BasicImageManipulation
    {
        private Bitmap inputImage, outputImage;
        public BasicImageManipulation()
        {
            inputImage = null;
            outputImage = null;
        }

        //private void SetInputImage(Bitmap img)
        //{
        //    inputImage = img;
        //}
        //private void SetOutputImage(Bitmap img)
        //{
        //    outputImage = img;
        //}

        private void SetInputImage(Bitmap img)
        {
            if (inputImage != null) inputImage.Dispose();
            inputImage = (Bitmap)img.Clone(); // always store a clone
        }

        private void SetOutputImage(Bitmap img)
        {
            if (outputImage != null) outputImage.Dispose();
            outputImage = (Bitmap)img.Clone(); // always store a clone
        }

        public Bitmap LoadImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return null;

            SetInputImage(new Bitmap(filePath));
            return inputImage;
        }

        public bool isOutputNull()
        {
            return outputImage == null;
        }

        public Bitmap SaveImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || outputImage == null) return null;
            outputImage.Save(filePath);
            return outputImage;
        }

        public void ClearImages()
        {
            inputImage = null;
            outputImage = null;
        }

        public Bitmap CopyImage()
        {
            if (inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    System.Drawing.Color pixel = inputImage.GetPixel(x, y);
                    bmp.SetPixel(x, y, pixel);
                }
            }

            SetOutputImage(bmp);
            return outputImage;
        }

        public Bitmap InvertImage()
        {
            if (inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    System.Drawing.Color pixel = inputImage.GetPixel(x, y);
                    int r = 255 - pixel.R;
                    int g = 255 - pixel.G;
                    int b = 255 - pixel.B;
                    bmp.SetPixel(x, y, System.Drawing.Color.FromArgb(r, g, b));
                }
            }

            SetOutputImage(bmp);
            return outputImage;
        }

        public Bitmap GreyscaleImage()
        {
            if (inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    System.Drawing.Color pixel = inputImage.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    bmp.SetPixel(x, y, System.Drawing.Color.FromArgb(gray, gray, gray));
                }
            }

            SetOutputImage(bmp);
            return outputImage;
        }

        public Bitmap SepiaImage()
        {
            if (inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage  .Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    System.Drawing.Color pixel = inputImage.GetPixel(x, y);

                    int tr = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int tg = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int tb = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    int r = Math.Min(255, tr);
                    int g = Math.Min(255, tg);
                    int b = Math.Min(255, tb);

                    bmp.SetPixel(x, y, System.Drawing.Color.FromArgb(r, g, b));
                }
            }

            SetOutputImage(bmp);
            return outputImage;
        }

        public Bitmap CreateHistogram()
        {
            if (inputImage == null)
                return null;
            int histWidth = 256;
            int histHeight = 120; 

            Bitmap histBmp = new Bitmap(histWidth, histHeight);
            int[] histogram = new int[256];
            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    System.Drawing.Color pixel = inputImage.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    histogram[gray]++;
                }
            }
            int max = histogram.Max();
            using (Graphics g = Graphics.FromImage(histBmp))
            {
                g.Clear(Color.White);

                // histogram bars
                for (int x = 0; x < histWidth; x++)
                {
                    int h = (int)((histogram[x] / (float)max) * 100);
                    g.DrawLine(Pens.Black, x, histHeight - 20, x, histHeight - 20 - h);
                }

                // X axis
                g.DrawLine(Pens.Black, 0, histHeight - 20, histWidth - 1, histHeight - 20);

                //Y axis
                g.DrawLine(Pens.Black, 0, histHeight - 20, 0, 0);

                // Draw X axis markers and labels (0, 64, 128, 192, 255)
                int[] xLabels = { 0, 64, 128, 192, 255 };
                foreach (int label in xLabels)
                {
                    int x = label;
                    g.DrawLine(Pens.Gray, x, histHeight - 20, x, histHeight - 15);
                    g.DrawString(label.ToString(), new Font("Arial", 7), Brushes.Black, x - 10, histHeight - 15);
                }

                // Draw Y axis markers and labels (0, max/2, max)
                int[] yLabels = { 0, max / 2, max };
                for (int i = 0; i < yLabels.Length; i++)
                {
                    int y = histHeight - 20 - (int)((yLabels[i] / (float)max) * 100);
                    g.DrawLine(Pens.Gray, 0, y, 5, y);
                    g.DrawString(yLabels[i].ToString(), new Font("Arial", 7), Brushes.Black, 7, y - 7);
                }

                // Axis titles
                g.DrawString("Gray Level", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, histWidth / 2 - 30, histHeight - 10);
                g.DrawString("Frequency", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, 0, 0);
            }

            // Scale the histogram image to 500x500 for the PictureBox
            Bitmap scaledBmp = new Bitmap(500, 420);
            using (Graphics g = Graphics.FromImage(scaledBmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.Clear(Color.White);
                g.DrawImage(histBmp, 0, 0, 500, 420);
            }

            SetOutputImage(scaledBmp);
            return outputImage;
        }



        //overloaded methods to accept frame hahaha bobo ako ihh sorry 

        public Bitmap CopyImage(Bitmap inputImage)
        {
            if (inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    System.Drawing.Color pixel = inputImage.GetPixel(x, y);
                    bmp.SetPixel(x, y, pixel);
                }
            }

            SetOutputImage(bmp);
            return outputImage;
        }

        public Bitmap InvertImage(Bitmap inputImage)
        {
            if (inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    System.Drawing.Color pixel = inputImage.GetPixel(x, y);
                    int r = 255 - pixel.R;
                    int g = 255 - pixel.G;
                    int b = 255 - pixel.B;
                    bmp.SetPixel(x, y, System.Drawing.Color.FromArgb(r, g, b));
                }
            }

            SetOutputImage(bmp);
            return outputImage;
        }

        public Bitmap GreyscaleImage(Bitmap inputImage)
        {
            if (inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    System.Drawing.Color pixel = inputImage.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    bmp.SetPixel(x, y, System.Drawing.Color.FromArgb(gray, gray, gray));
                }
            }

            SetOutputImage(bmp);
            return outputImage;
        }

        public Bitmap SepiaImage(Bitmap inputImage)
        {
            if (inputImage == null)
                return null;

            Bitmap bmp = new Bitmap(inputImage.Width, inputImage.Height);

            for (int y = 0; y < inputImage.Height; y++)
            {
                for (int x = 0; x < inputImage.Width; x++)
                {
                    System.Drawing.Color pixel = inputImage.GetPixel(x, y);

                    int tr = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int tg = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int tb = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    int r = Math.Min(255, tr);
                    int g = Math.Min(255, tg);
                    int b = Math.Min(255, tb);

                    bmp.SetPixel(x, y, System.Drawing.Color.FromArgb(r, g, b));
                }
            }

            SetOutputImage(bmp);
            return outputImage;
        }
    }
}