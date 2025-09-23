using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ledon_ImageProcessing
{
    public partial class ImageProcessing : Form
    {
        private BasicImageManipulation basicImageOp;
        private SubtractImage subtractImageOp;
        public ImageProcessing()
        {
            InitializeComponent();
            basicImageOp = new BasicImageManipulation();
            subtractImageOp = new SubtractImage();
        }

        private void btn_loadImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;"
            };

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                var image = new Bitmap(filePath);
                basicImageOp.LoadImage(filePath);

                SetInputImage(image);

            }
        }

        private void btn_saveImage_Click(object sender, EventArgs e)
        {
            if (basicImageOp.isOutputNull())
                return;

            var sfd = new SaveFileDialog
            {
                Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg"
            };

            DialogResult res = sfd.ShowDialog();

            if (res == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                basicImageOp.SaveImage(filePath);
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            var image = basicImageOp.CopyImage();
            SetOutputImage(image);
        }

        private void btn_greyscale_Click(object sender, EventArgs e)
        {
            var image = basicImageOp.GreyscaleImage();
            SetOutputImage(image);
        }

        private void btn_invert_Click(object sender, EventArgs e)
        {
            var image = basicImageOp.InvertImage();
            SetOutputImage(image);
        }

        private void btn_histogram_Click(object sender, EventArgs e)
        {
            var image = basicImageOp.CreateHistogram();
            SetOutputImage(image);
        }

        private void btn_sepia_Click(object sender, EventArgs e)
        {
            var image = basicImageOp.SepiaImage();
            SetOutputImage(image);
        }

        private void SetInputImage(Bitmap bmp)
        {
            pb_inputImage.SizeMode = PictureBoxSizeMode.Zoom;
            pb_inputImage.Image = bmp;
        }

        private void SetOutputImage(Bitmap bmp)
        {
            pb_outputImage.SizeMode = PictureBoxSizeMode.Zoom;
            pb_outputImage.Image = bmp;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            basicImageOp.ClearImages();
            SetInputImage(null);
            SetOutputImage(null);
        }

        // SUBTRACT IMAGE OPERATIONS

        private void SetForegroundImage(Bitmap bmp)
        {
            pb_foregroundImage.SizeMode = PictureBoxSizeMode.Zoom;
            pb_foregroundImage.Image = bmp;
        }
        private void SetBackgroundImage(Bitmap bmp)
        {
            pb_backgroundImage.SizeMode = PictureBoxSizeMode.Zoom;
            pb_backgroundImage.Image = bmp;
        }


        private void btn_loadForegroundImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg"
            };

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = ofd.FileName;

                var image = new Bitmap(filePath);
                subtractImageOp.LoadForegroundImage(filePath);

                SetForegroundImage(image);
            }
        }


        private void SetSubtractedImageResult(Bitmap bmp)
        {
            pb_subtractedImage.SizeMode = PictureBoxSizeMode.Zoom;
            pb_subtractedImage.Image = bmp;
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            var image = subtractImageOp.SubtractImages();

            SetSubtractedImageResult(image);
        }

        private void btn_clearImages_Click(object sender, EventArgs e)
        {
            subtractImageOp.ClearImages();
            SetForegroundImage(null);
            SetBackgroundImage(null);
            SetSubtractedImageResult(null);
        }

        private void btn_saveSubtractedImage_Click(object sender, EventArgs e)
        {
            if (subtractImageOp.isSubtractedImageNULL())
                return;

            var dialog = new SaveFileDialog
            {
                Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg"
            };

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                subtractImageOp.SaveImage(filePath);
            }
        }

        private void btn_loadBackgroundImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.png;*.jpg;*.jpeg"
            };
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                var image = new Bitmap(filePath);
                subtractImageOp.LoadBackgroundImage(filePath);
                SetBackgroundImage(image);
            }
        }

    }
}
