using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
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
        private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;
        private ConvMatrixFilters convMatrixFilters;

        private bool copyVideo = false;
        private bool applyGreyscale = false;
        private bool applyInvert = false;
        private bool applySepia = false;

        public ImageProcessing()
        {
            InitializeComponent();
            basicImageOp = new BasicImageManipulation();
            subtractImageOp = new SubtractImage();
            convMatrixFilters = new ConvMatrixFilters();
            this.Load += ImageProcessing_Load;
        }

        private void ImageProcessing_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        private void btn_loadImage_Click(object sender, EventArgs e)
        {

            if (cb_EnableWebCam.Checked)
            {
                MessageBox.Show("Please turn off the webcam first",
                                "Cannot Import Image",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

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
            if ((videoSource == null || !videoSource.IsRunning) && pb_inputImage.Image == null)
            {
                MessageBox.Show("Please load an image or enable the webcam first.",
                                "No Image Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

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
            if ((videoSource == null || !videoSource.IsRunning) && pb_inputImage.Image == null)
            {
                MessageBox.Show("Please load an image or enable the webcam first.",
                                "No Image Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
            {
                copyVideo = true;
                applyGreyscale = false;
                applyInvert = false;
                applySepia = false;
            }

            var image = basicImageOp.CopyImage();
            SetOutputImage(image);
        }

        private void btn_greyscale_Click(object sender, EventArgs e)
        {
            if ((videoSource == null || !videoSource.IsRunning) && pb_inputImage.Image == null)
            {
                MessageBox.Show("Please load an image or enable the webcam first.",
                                "No Image Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
            {
                copyVideo = false;
                applyGreyscale = true;
                applyInvert = false;
                applySepia = false;
            }

            var image = basicImageOp.GreyscaleImage();
            SetOutputImage(image);
        }

        private void btn_invert_Click(object sender, EventArgs e)
        {
            if ((videoSource == null || !videoSource.IsRunning) && pb_inputImage.Image == null)
            {
                MessageBox.Show("Please load an image or enable the webcam first.",
                                "No Image Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
            {
                copyVideo = false;
                applyGreyscale = false;
                applyInvert = true;
                applySepia = false;
            }

            var image = basicImageOp.InvertImage();
            SetOutputImage(image);
        }

        private void btn_histogram_Click(object sender, EventArgs e)
        {
            if ((videoSource == null || !videoSource.IsRunning) && pb_inputImage.Image == null)
            {
                MessageBox.Show("Please load an image first.",
                                "No Image Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
            {
                MessageBox.Show("Histogram is only available for still images. Please load or capture an image first.",
                                "Not Supported in Live Video",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var image = basicImageOp.CreateHistogram();
            SetOutputImage(image);
        }

        private void btn_sepia_Click(object sender, EventArgs e)
        {
            if ((videoSource == null || !videoSource.IsRunning) && pb_inputImage.Image == null)
            {
                MessageBox.Show("Please load an image or enable the webcam first.",
                                "No Image Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
            {
                copyVideo = false;
                applyGreyscale = false;
                applyInvert = false;
                applySepia = true;
            }

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
            cb_fastmode.Checked = false;
            copyVideo = false;
            applyGreyscale = false;
            applyInvert = false;
            applySepia = false;
            cb_EnableWebCam.Checked = false;
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

        private void cb_EnableWebCam_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_EnableWebCam.Checked)
            {
                if (videoDevices != null && videoDevices.Count > 0)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoSource.NewFrame += new AForge.Video.NewFrameEventHandler(videoSource_NewFrame);
                    videoSource.Start();

                    ShowToast("Webcam is ON (filters may be laggy)", 3000);
                }
                else
                {
                    MessageBox.Show("No webcam found!");
                    cb_EnableWebCam.Checked = false;
                }
            }
            else
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource.NewFrame -= new AForge.Video.NewFrameEventHandler(videoSource_NewFrame);
                    videoSource = null;
                    ShowToast("Webcam is OFF", 2000);
                    copyVideo = false;
                    applyGreyscale = false;
                    applyInvert = false;
                    applySepia = false;

                }
                SetOutputImage(null);
                SetInputImage(null);
            }
        }



        // this works sir but is not optimal for real-time video processing due to UI thread blocking (LAG AS HELL!)
        private void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            // Original raw webcam frame
            Bitmap rawframe = (Bitmap)eventArgs.Frame.Clone();
            Bitmap frame = null;

            if (applyGreyscale)
            {
                //experiment ra sa built in haha
                if (cb_fastmode.Checked)
                {
                    Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
                    frame = filter.Apply(rawframe);
                }
                else
                {
                    frame = basicImageOp.GreyscaleImage(rawframe);
                }

                SetOutputImage(frame);
            }
            else if (applyInvert)
            {
                if (cb_fastmode.Checked)
                {
                    Invert filter = new Invert();
                    frame = filter.Apply(rawframe);
                }
                else
                {
                    frame = basicImageOp.InvertImage(rawframe);
                }

                SetOutputImage(frame);
            }
            else if (applySepia)
            {
                if (cb_fastmode.Checked)
                {
                    Sepia filter = new Sepia();
                    frame = filter.Apply(rawframe);
                }
                else
                {
                    frame = basicImageOp.SepiaImage(rawframe);
                }


                SetOutputImage(frame);
            }
            else if (copyVideo)
            {

                if (cb_fastmode.Checked)
                {
                    frame = (Bitmap)rawframe.Clone();
                }
                else
                {
                    //SetOutputImage(rawframe);
                    frame = basicImageOp.CopyImage(rawframe);
                }

                SetOutputImage(frame);
            }

            SetInputImage(rawframe);

        }






        private Label toastLabel;
        private Timer toastTimer;

        private void ShowToast(string message, int durationMs = 3000)
        {
            if (toastLabel == null)
            {
                toastLabel = new Label();
                toastLabel.AutoSize = true;
                toastLabel.BackColor = Color.Black;
                toastLabel.ForeColor = Color.White;
                toastLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                toastLabel.Padding = new Padding(10);
                toastLabel.Visible = false;
                toastLabel.TextAlign = ContentAlignment.MiddleCenter;
                toastLabel.BringToFront();
                this.Controls.Add(toastLabel);
            }

            toastLabel.Text = message;

            // Position bottom center
            toastLabel.Left = (this.ClientSize.Width - toastLabel.PreferredWidth) / 2;
            toastLabel.Top = this.ClientSize.Height - toastLabel.PreferredHeight - 20;

            toastLabel.Visible = true;
            toastLabel.BringToFront();

            if (toastTimer == null)
            {
                toastTimer = new Timer();
                toastTimer.Tick += (s, e) =>
                {
                    toastLabel.Visible = false;
                    toastTimer.Stop();
                };
            }

            toastTimer.Interval = durationMs;
            toastTimer.Start();
        }

        private void cb_fastmode_CheckedChanged(object sender, EventArgs e)
        {

            if (!cb_EnableWebCam.Checked)
            {
                ShowToast("Please turn on the webcam first!", 3000);
                cb_fastmode.Checked = false;
            }
            else if (cb_EnableWebCam.Checked && cb_fastmode.Checked)
            {
                ShowToast("Fast pero di ma save hahaha", 3000);
            }
            else
            {
                ShowToast("Lag naka balik hahaha", 3000);
            }
        }

        //conv matrix

        private void cb_convMatrixWebcamToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_convMatrixWebcamToggle.Checked)
            {
                if (videoDevices != null && videoDevices.Count > 0)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoSource.NewFrame += new AForge.Video.NewFrameEventHandler(convMatrixHandler);
                    videoSource.Start();

                    ShowToast("Webcam is ON (filters may be laggy)", 3000);
                }
                else
                {
                    MessageBox.Show("No webcam found!");
                    cb_convMatrixWebcamToggle.Checked = false;
                }
            }
            else
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource.NewFrame -= new AForge.Video.NewFrameEventHandler(convMatrixHandler);
                    videoSource = null;
                    ShowToast("Webcam is OFF", 2000);
                    currFilter = MatrixFilters.None;
                    cb_convMatrixWebcamToggle.Checked = false;
                }
                pb_convMatrixInput.Image = null;
                pb_convMatrixOuptut.Image = null;
            }
        }

        //__________________________________________________________________//
        private enum MatrixFilters
        {
            None,
            Smooth,
            GaussianBlur,
            Sharpen,
            MeanRemoval,
            Laplascian,
            HorizontalVertical,
            AllDirections,
            Lossy,
            HorizontalOnly,
            VerticalOnly
        }

        private MatrixFilters currFilter = MatrixFilters.None;

        private Bitmap ApplyConvMatrixFilter(Bitmap input)
        {
            if (input == null) return null;

            Bitmap output = (Bitmap)input.Clone();

            switch (currFilter)
            {
                case MatrixFilters.Smooth:
                    ConvMatrixFilters.Smooth(output);
                    break;
                case MatrixFilters.GaussianBlur:
                    ConvMatrixFilters.GaussianBlur(output);
                    break;
                case MatrixFilters.Sharpen:
                    ConvMatrixFilters.Sharpen(output);
                    break;
                case MatrixFilters.MeanRemoval:
                    ConvMatrixFilters.MeanRemoval(output);
                    break;
                case MatrixFilters.Laplascian:
                    ConvMatrixFilters.EmbossLaplascian(output);
                    break;
                case MatrixFilters.HorizontalVertical:
                    ConvMatrixFilters.EmbossHorizontalVertical(output);
                    break;
                case MatrixFilters.AllDirections:
                    ConvMatrixFilters.EmbossAllDirections(output);
                    break;
                case MatrixFilters.Lossy:
                    ConvMatrixFilters.EmbossLossy(output);
                    break;
                case MatrixFilters.HorizontalOnly:
                    ConvMatrixFilters.EmbossHorizontalOnly(output);
                    break;
                case MatrixFilters.VerticalOnly:
                    ConvMatrixFilters.EmbossVerticalOnly(output);
                    break;
                default:
                    return null;
            }

            return output;
        }

        private void convMatrixHandler(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
      
            Bitmap rawframe = (Bitmap)eventArgs.Frame.Clone();
            Bitmap processed = ApplyConvMatrixFilter(rawframe);

            pb_convMatrixInput.Image?.Dispose();
            pb_convMatrixOuptut.Image?.Dispose();

            pb_convMatrixInput.SizeMode = PictureBoxSizeMode.Zoom;
            pb_convMatrixInput.Image = rawframe;

            pb_convMatrixOuptut.SizeMode = PictureBoxSizeMode.Zoom;
            pb_convMatrixOuptut.Image = processed;
        }

        //private void ApplyFilterToLoadedImage(Bitmap image)
        //{
        //    Bitmap processed = ApplyConvMatrixFilter(image);

        //    pb_convMatrixInput.Image?.Dispose();
        //    pb_convMatrixOuptut.Image?.Dispose();

        //    pb_convMatrixInput.SizeMode = PictureBoxSizeMode.Zoom;
        //    pb_convMatrixInput.Image = (Bitmap)image.Clone();

        //    pb_convMatrixOuptut.SizeMode = PictureBoxSizeMode.Zoom;
        //    pb_convMatrixOuptut.Image = processed;
        //}

        private void ApplyFilterToLoadedImage(Bitmap image)
        {
            if (image == null) return;     
            Bitmap inputClone = (Bitmap)image.Clone();

            Bitmap processed = ApplyConvMatrixFilter(inputClone);

            pb_convMatrixInput.Image?.Dispose();
            pb_convMatrixOuptut.Image?.Dispose();

            pb_convMatrixInput.SizeMode = PictureBoxSizeMode.Zoom;
            pb_convMatrixInput.Image = inputClone; 

            pb_convMatrixOuptut.SizeMode = PictureBoxSizeMode.Zoom;
            pb_convMatrixOuptut.Image = processed;
        }



        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currFilter = MatrixFilters.Smooth;
            if (pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image);

        }

        private void gaussianBLurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currFilter = MatrixFilters.GaussianBlur;
            if(pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image); 
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currFilter = MatrixFilters.Sharpen;
            if(pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image); 
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currFilter = MatrixFilters.MeanRemoval;
            if(pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image);
        }

        private void laplasianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currFilter = MatrixFilters.Laplascian;
            if(pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image);
        }

        private void horzVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currFilter = MatrixFilters.HorizontalVertical;
            if(pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image); 
        }

        private void allDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currFilter = MatrixFilters.AllDirections;  
            if(pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image);
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currFilter = MatrixFilters.Lossy;
            if(pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image);
        }

        private void horizonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currFilter = MatrixFilters.HorizontalOnly;
            if(pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image); 
        }

        private void verticalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currFilter = MatrixFilters.VerticalOnly;   
            if(pb_convMatrixInput.Image != null)
                ApplyFilterToLoadedImage((Bitmap)pb_convMatrixInput.Image);
        }

        private void btn_loadMedia_Click(object sender, EventArgs e)
        {

            if (cb_convMatrixWebcamToggle.Checked)
            {
                MessageBox.Show("Please turn off the webcam first",
                                "Cannot Import Image",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

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

                
                pb_convMatrixInput.Image?.Dispose();
                pb_convMatrixInput.SizeMode = PictureBoxSizeMode.Zoom;
                pb_convMatrixInput.Image = image;

            }

        }

        private void btn_saveMedia_Click(object sender, EventArgs e)
        {
            if ((videoSource == null || !videoSource.IsRunning) && pb_convMatrixInput.Image == null)
            {
                MessageBox.Show("Please load an image or enable the webcam first.",
                                "No Image Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if(pb_convMatrixOuptut.Image == null )
            {
                MessageBox.Show("No Ouptput Image.",
                                "No Output Image",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

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

        private void button1_Click(object sender, EventArgs e) //conv matrix clear button kapoy rename
        {
            pb_convMatrixInput.Image?.Dispose();
            pb_convMatrixInput.Image = null;

            pb_convMatrixOuptut.Image?.Dispose();
            pb_convMatrixOuptut.Image = null;

            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource.NewFrame -= convMatrixHandler;
                videoSource = null;
                cb_convMatrixWebcamToggle.Checked = false;
                currFilter = MatrixFilters.None;
                ShowToast("Webcam is OFF", 2000);
            }
        }


        //churva churva

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Stop the webcam if it's running
            if (videoSource != null && videoSource.IsRunning)
            {
                try
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource.NewFrame -= videoSource_NewFrame; // remove event handler
                    videoSource.NewFrame -= convMatrixHandler;
                    videoSource = null;

                    pb_convMatrixInput.Image?.Dispose();
                    pb_convMatrixInput.Image = null;

                    pb_convMatrixOuptut.Image?.Dispose();
                    pb_convMatrixOuptut.Image = null;

                    pb_inputImage.Image?.Dispose();
                    pb_inputImage.Image = null;

                    pb_outputImage.Image?.Dispose();
                    pb_outputImage.Image = null;
                    cb_EnableWebCam.Checked = false;
                    cb_fastmode.Checked = false;

                    cb_convMatrixWebcamToggle.Checked = false;

                    copyVideo = false;
                    applyGreyscale = false;
                    applyInvert = false;
                    applySepia = false;

                    ShowToast("Webcam stopped because you switched tabs.", 2000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error stopping webcam: " + ex.Message);
                }
            }
        }

       
    }
}
