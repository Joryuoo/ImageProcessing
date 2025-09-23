using System;
using System.Drawing;

namespace Ledon_ImageProcessing
{
    internal class SubtractImage
    {
        private Bitmap foregroundImage, backgroundImage, subtractedImage;
        public SubtractImage()
        {
            foregroundImage = null;
            backgroundImage = null;
            subtractedImage = null;
        }

        private void SetForegroundImage(Bitmap img)
        {
            foregroundImage = img;
        }
        private void SetBackgroundImage(Bitmap img)
        {
            backgroundImage = img;
        }
        private void SetOutput(Bitmap img)
        {
            subtractedImage = img;
        }

        public Bitmap LoadForegroundImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return null;

            SetForegroundImage(new Bitmap(filePath));
            return foregroundImage;
        }
        public Bitmap LoadBackgroundImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return null;

            SetBackgroundImage(new Bitmap(filePath));
            return backgroundImage;
        }
        public bool isSubtractedImageNULL()
        {
            return subtractedImage == null;
        }
        public Bitmap SaveImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || subtractedImage == null)
                return null;

            subtractedImage.Save(filePath);
            return subtractedImage;
        }
        public void ClearImages()
        {
            foregroundImage = null;
            backgroundImage = null;
            subtractedImage = null;
        }

        public Bitmap SubtractImages()
        {
            if (foregroundImage == null || backgroundImage == null)
                return null;

            int width = Math.Min(foregroundImage.Width, backgroundImage.Width);
            int height = Math.Min(foregroundImage.Height, backgroundImage.Height);

            Color myColor = Color.FromArgb(0, 255, 0); // green 
            int myColorVal = (myColor.R + myColor.G + myColor.B) / 3;
            int threshold = 5; 

            Bitmap bmp = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = foregroundImage.GetPixel(x, y);
                    Color backpixel = backgroundImage.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractValue = Math.Abs(grey - myColorVal);

                    if (subtractValue > threshold)
                        bmp.SetPixel(x, y, pixel);
                    else
                        bmp.SetPixel(x, y, backpixel);
                }
            }

            SetOutput(bmp);
            return subtractedImage;
        }
    }
}