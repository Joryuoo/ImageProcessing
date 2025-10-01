namespace Ledon_ImageProcessing
{
    partial class ImageProcessing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_fastmode = new System.Windows.Forms.CheckBox();
            this.cb_EnableWebCam = new System.Windows.Forms.CheckBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lb_tabPageLabel = new System.Windows.Forms.Label();
            this.btn_sepia = new System.Windows.Forms.Button();
            this.btn_histogram = new System.Windows.Forms.Button();
            this.btn_invert = new System.Windows.Forms.Button();
            this.btn_greyscale = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_saveImage = new System.Windows.Forms.Button();
            this.btn_loadImage = new System.Windows.Forms.Button();
            this.pb_outputImage = new System.Windows.Forms.PictureBox();
            this.pb_inputImage = new System.Windows.Forms.PictureBox();
            this.lb_outputImageLabel = new System.Windows.Forms.Label();
            this.lb_inputImageLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_clearImages = new System.Windows.Forms.Button();
            this.btn_saveSubtractedImage = new System.Windows.Forms.Button();
            this.btn_loadBackgroundImage = new System.Windows.Forms.Button();
            this.btn_loadForegroundImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_subtractedImage = new System.Windows.Forms.PictureBox();
            this.pb_backgroundImage = new System.Windows.Forms.PictureBox();
            this.pb_foregroundImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_convMatrixWebcamToggle = new System.Windows.Forms.CheckBox();
            this.pb_convMatrixOuptut = new System.Windows.Forms.PictureBox();
            this.pb_convMatrixInput = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBLurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplasianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horzVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDirectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lossyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_saveMedia = new System.Windows.Forms.Button();
            this.btn_loadMedia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_outputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inputImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_subtractedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_backgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foregroundImage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_convMatrixOuptut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_convMatrixInput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1142, 731);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_fastmode);
            this.tabPage1.Controls.Add(this.cb_EnableWebCam);
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.lb_tabPageLabel);
            this.tabPage1.Controls.Add(this.btn_sepia);
            this.tabPage1.Controls.Add(this.btn_histogram);
            this.tabPage1.Controls.Add(this.btn_invert);
            this.tabPage1.Controls.Add(this.btn_greyscale);
            this.tabPage1.Controls.Add(this.btn_copy);
            this.tabPage1.Controls.Add(this.btn_saveImage);
            this.tabPage1.Controls.Add(this.btn_loadImage);
            this.tabPage1.Controls.Add(this.pb_outputImage);
            this.tabPage1.Controls.Add(this.pb_inputImage);
            this.tabPage1.Controls.Add(this.lb_outputImageLabel);
            this.tabPage1.Controls.Add(this.lb_inputImageLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1134, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Image Manipulation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_fastmode
            // 
            this.cb_fastmode.AutoSize = true;
            this.cb_fastmode.Location = new System.Drawing.Point(246, 565);
            this.cb_fastmode.Name = "cb_fastmode";
            this.cb_fastmode.Size = new System.Drawing.Size(93, 20);
            this.cb_fastmode.TabIndex = 14;
            this.cb_fastmode.Text = "Fast Mode";
            this.cb_fastmode.UseVisualStyleBackColor = true;
            this.cb_fastmode.CheckedChanged += new System.EventHandler(this.cb_fastmode_CheckedChanged);
            // 
            // cb_EnableWebCam
            // 
            this.cb_EnableWebCam.AutoSize = true;
            this.cb_EnableWebCam.Location = new System.Drawing.Point(246, 539);
            this.cb_EnableWebCam.Name = "cb_EnableWebCam";
            this.cb_EnableWebCam.Size = new System.Drawing.Size(132, 20);
            this.cb_EnableWebCam.TabIndex = 13;
            this.cb_EnableWebCam.Text = "Enable WebCam";
            this.cb_EnableWebCam.UseVisualStyleBackColor = true;
            this.cb_EnableWebCam.CheckedChanged += new System.EventHandler(this.cb_EnableWebCam_CheckedChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(857, 602);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 37);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lb_tabPageLabel
            // 
            this.lb_tabPageLabel.AutoSize = true;
            this.lb_tabPageLabel.Font = new System.Drawing.Font("Roboto Lt", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tabPageLabel.Location = new System.Drawing.Point(380, 18);
            this.lb_tabPageLabel.Name = "lb_tabPageLabel";
            this.lb_tabPageLabel.Size = new System.Drawing.Size(366, 34);
            this.lb_tabPageLabel.TabIndex = 11;
            this.lb_tabPageLabel.Text = "Basic Image Manipulation";
            // 
            // btn_sepia
            // 
            this.btn_sepia.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sepia.Location = new System.Drawing.Point(720, 602);
            this.btn_sepia.Name = "btn_sepia";
            this.btn_sepia.Size = new System.Drawing.Size(112, 37);
            this.btn_sepia.TabIndex = 10;
            this.btn_sepia.Text = "Sepia";
            this.btn_sepia.UseVisualStyleBackColor = true;
            this.btn_sepia.Click += new System.EventHandler(this.btn_sepia_Click);
            // 
            // btn_histogram
            // 
            this.btn_histogram.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_histogram.Location = new System.Drawing.Point(578, 602);
            this.btn_histogram.Name = "btn_histogram";
            this.btn_histogram.Size = new System.Drawing.Size(112, 37);
            this.btn_histogram.TabIndex = 9;
            this.btn_histogram.Text = "Histogram";
            this.btn_histogram.UseVisualStyleBackColor = true;
            this.btn_histogram.Click += new System.EventHandler(this.btn_histogram_Click);
            // 
            // btn_invert
            // 
            this.btn_invert.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invert.Location = new System.Drawing.Point(436, 602);
            this.btn_invert.Name = "btn_invert";
            this.btn_invert.Size = new System.Drawing.Size(112, 37);
            this.btn_invert.TabIndex = 8;
            this.btn_invert.Text = "Invert";
            this.btn_invert.UseVisualStyleBackColor = true;
            this.btn_invert.Click += new System.EventHandler(this.btn_invert_Click);
            // 
            // btn_greyscale
            // 
            this.btn_greyscale.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_greyscale.Location = new System.Drawing.Point(298, 602);
            this.btn_greyscale.Name = "btn_greyscale";
            this.btn_greyscale.Size = new System.Drawing.Size(112, 37);
            this.btn_greyscale.TabIndex = 7;
            this.btn_greyscale.Text = "Greyscale";
            this.btn_greyscale.UseVisualStyleBackColor = true;
            this.btn_greyscale.Click += new System.EventHandler(this.btn_greyscale_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(165, 602);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(112, 37);
            this.btn_copy.TabIndex = 6;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_saveImage
            // 
            this.btn_saveImage.BackColor = System.Drawing.Color.Green;
            this.btn_saveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveImage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveImage.ForeColor = System.Drawing.Color.White;
            this.btn_saveImage.Location = new System.Drawing.Point(720, 475);
            this.btn_saveImage.Name = "btn_saveImage";
            this.btn_saveImage.Size = new System.Drawing.Size(166, 47);
            this.btn_saveImage.TabIndex = 5;
            this.btn_saveImage.Text = "Save Image";
            this.btn_saveImage.UseVisualStyleBackColor = false;
            this.btn_saveImage.Click += new System.EventHandler(this.btn_saveImage_Click);
            // 
            // btn_loadImage
            // 
            this.btn_loadImage.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_loadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadImage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_loadImage.Location = new System.Drawing.Point(232, 475);
            this.btn_loadImage.Name = "btn_loadImage";
            this.btn_loadImage.Size = new System.Drawing.Size(166, 47);
            this.btn_loadImage.TabIndex = 4;
            this.btn_loadImage.Text = "Load Image";
            this.btn_loadImage.UseVisualStyleBackColor = false;
            this.btn_loadImage.Click += new System.EventHandler(this.btn_loadImage_Click);
            // 
            // pb_outputImage
            // 
            this.pb_outputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_outputImage.Location = new System.Drawing.Point(630, 110);
            this.pb_outputImage.Name = "pb_outputImage";
            this.pb_outputImage.Size = new System.Drawing.Size(350, 350);
            this.pb_outputImage.TabIndex = 3;
            this.pb_outputImage.TabStop = false;
            // 
            // pb_inputImage
            // 
            this.pb_inputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_inputImage.Location = new System.Drawing.Point(149, 110);
            this.pb_inputImage.Name = "pb_inputImage";
            this.pb_inputImage.Size = new System.Drawing.Size(350, 350);
            this.pb_inputImage.TabIndex = 2;
            this.pb_inputImage.TabStop = false;
            // 
            // lb_outputImageLabel
            // 
            this.lb_outputImageLabel.AutoSize = true;
            this.lb_outputImageLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_outputImageLabel.Location = new System.Drawing.Point(746, 73);
            this.lb_outputImageLabel.Name = "lb_outputImageLabel";
            this.lb_outputImageLabel.Size = new System.Drawing.Size(131, 24);
            this.lb_outputImageLabel.TabIndex = 1;
            this.lb_outputImageLabel.Text = "Output Image";
            // 
            // lb_inputImageLabel
            // 
            this.lb_inputImageLabel.AutoSize = true;
            this.lb_inputImageLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inputImageLabel.Location = new System.Drawing.Point(262, 73);
            this.lb_inputImageLabel.Name = "lb_inputImageLabel";
            this.lb_inputImageLabel.Size = new System.Drawing.Size(116, 24);
            this.lb_inputImageLabel.TabIndex = 0;
            this.lb_inputImageLabel.Text = "Input Image";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_subtract);
            this.tabPage2.Controls.Add(this.btn_clearImages);
            this.tabPage2.Controls.Add(this.btn_saveSubtractedImage);
            this.tabPage2.Controls.Add(this.btn_loadBackgroundImage);
            this.tabPage2.Controls.Add(this.btn_loadForegroundImage);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pb_subtractedImage);
            this.tabPage2.Controls.Add(this.pb_backgroundImage);
            this.tabPage2.Controls.Add(this.pb_foregroundImage);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1134, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image Subtraction";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_subtract
            // 
            this.btn_subtract.BackColor = System.Drawing.Color.Black;
            this.btn_subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subtract.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtract.ForeColor = System.Drawing.Color.White;
            this.btn_subtract.Location = new System.Drawing.Point(422, 557);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(300, 47);
            this.btn_subtract.TabIndex = 23;
            this.btn_subtract.Text = "Subtract Images";
            this.btn_subtract.UseVisualStyleBackColor = false;
            this.btn_subtract.Click += new System.EventHandler(this.btn_subtract_Click);
            // 
            // btn_clearImages
            // 
            this.btn_clearImages.BackColor = System.Drawing.Color.Red;
            this.btn_clearImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearImages.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearImages.ForeColor = System.Drawing.Color.White;
            this.btn_clearImages.Location = new System.Drawing.Point(978, 21);
            this.btn_clearImages.Name = "btn_clearImages";
            this.btn_clearImages.Size = new System.Drawing.Size(112, 37);
            this.btn_clearImages.TabIndex = 22;
            this.btn_clearImages.Text = "Clear";
            this.btn_clearImages.UseVisualStyleBackColor = false;
            this.btn_clearImages.Click += new System.EventHandler(this.btn_clearImages_Click);
            // 
            // btn_saveSubtractedImage
            // 
            this.btn_saveSubtractedImage.BackColor = System.Drawing.Color.Green;
            this.btn_saveSubtractedImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveSubtractedImage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveSubtractedImage.ForeColor = System.Drawing.Color.White;
            this.btn_saveSubtractedImage.Location = new System.Drawing.Point(790, 469);
            this.btn_saveSubtractedImage.Name = "btn_saveSubtractedImage";
            this.btn_saveSubtractedImage.Size = new System.Drawing.Size(300, 47);
            this.btn_saveSubtractedImage.TabIndex = 21;
            this.btn_saveSubtractedImage.Text = "Save Image";
            this.btn_saveSubtractedImage.UseVisualStyleBackColor = false;
            this.btn_saveSubtractedImage.Click += new System.EventHandler(this.btn_saveSubtractedImage_Click);
            // 
            // btn_loadBackgroundImage
            // 
            this.btn_loadBackgroundImage.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_loadBackgroundImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadBackgroundImage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadBackgroundImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_loadBackgroundImage.Location = new System.Drawing.Point(422, 469);
            this.btn_loadBackgroundImage.Name = "btn_loadBackgroundImage";
            this.btn_loadBackgroundImage.Size = new System.Drawing.Size(300, 47);
            this.btn_loadBackgroundImage.TabIndex = 20;
            this.btn_loadBackgroundImage.Text = "Load Background Image";
            this.btn_loadBackgroundImage.UseVisualStyleBackColor = false;
            this.btn_loadBackgroundImage.Click += new System.EventHandler(this.btn_loadBackgroundImage_Click);
            // 
            // btn_loadForegroundImage
            // 
            this.btn_loadForegroundImage.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_loadForegroundImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadForegroundImage.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadForegroundImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_loadForegroundImage.Location = new System.Drawing.Point(52, 469);
            this.btn_loadForegroundImage.Name = "btn_loadForegroundImage";
            this.btn_loadForegroundImage.Size = new System.Drawing.Size(300, 47);
            this.btn_loadForegroundImage.TabIndex = 19;
            this.btn_loadForegroundImage.Text = "Load Foreground Image";
            this.btn_loadForegroundImage.UseVisualStyleBackColor = false;
            this.btn_loadForegroundImage.Click += new System.EventHandler(this.btn_loadForegroundImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(859, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Subtracted Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(480, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Background Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Foreground Image";
            // 
            // pb_subtractedImage
            // 
            this.pb_subtractedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_subtractedImage.Location = new System.Drawing.Point(790, 152);
            this.pb_subtractedImage.Name = "pb_subtractedImage";
            this.pb_subtractedImage.Size = new System.Drawing.Size(300, 300);
            this.pb_subtractedImage.TabIndex = 15;
            this.pb_subtractedImage.TabStop = false;
            // 
            // pb_backgroundImage
            // 
            this.pb_backgroundImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_backgroundImage.Location = new System.Drawing.Point(422, 152);
            this.pb_backgroundImage.Name = "pb_backgroundImage";
            this.pb_backgroundImage.Size = new System.Drawing.Size(300, 300);
            this.pb_backgroundImage.TabIndex = 14;
            this.pb_backgroundImage.TabStop = false;
            // 
            // pb_foregroundImage
            // 
            this.pb_foregroundImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foregroundImage.Location = new System.Drawing.Point(52, 152);
            this.pb_foregroundImage.Name = "pb_foregroundImage";
            this.pb_foregroundImage.Size = new System.Drawing.Size(300, 300);
            this.pb_foregroundImage.TabIndex = 13;
            this.pb_foregroundImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Image Subtraction";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btn_saveMedia);
            this.tabPage3.Controls.Add(this.btn_loadMedia);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cb_convMatrixWebcamToggle);
            this.tabPage3.Controls.Add(this.pb_convMatrixOuptut);
            this.tabPage3.Controls.Add(this.pb_convMatrixInput);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.menuStrip1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1134, 702);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convolution Matrix";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Lt", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 34);
            this.label7.TabIndex = 15;
            this.label7.Text = "DIP Convolution Matrix";
            // 
            // cb_convMatrixWebcamToggle
            // 
            this.cb_convMatrixWebcamToggle.AutoSize = true;
            this.cb_convMatrixWebcamToggle.Location = new System.Drawing.Point(250, 614);
            this.cb_convMatrixWebcamToggle.Name = "cb_convMatrixWebcamToggle";
            this.cb_convMatrixWebcamToggle.Size = new System.Drawing.Size(132, 20);
            this.cb_convMatrixWebcamToggle.TabIndex = 14;
            this.cb_convMatrixWebcamToggle.Text = "Enable WebCam";
            this.cb_convMatrixWebcamToggle.UseVisualStyleBackColor = true;
            this.cb_convMatrixWebcamToggle.CheckedChanged += new System.EventHandler(this.cb_convMatrixWebcamToggle_CheckedChanged);
            // 
            // pb_convMatrixOuptut
            // 
            this.pb_convMatrixOuptut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_convMatrixOuptut.Location = new System.Drawing.Point(627, 146);
            this.pb_convMatrixOuptut.Name = "pb_convMatrixOuptut";
            this.pb_convMatrixOuptut.Size = new System.Drawing.Size(400, 400);
            this.pb_convMatrixOuptut.TabIndex = 7;
            this.pb_convMatrixOuptut.TabStop = false;
            // 
            // pb_convMatrixInput
            // 
            this.pb_convMatrixInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_convMatrixInput.Location = new System.Drawing.Point(106, 146);
            this.pb_convMatrixInput.Name = "pb_convMatrixInput";
            this.pb_convMatrixInput.Size = new System.Drawing.Size(400, 400);
            this.pb_convMatrixInput.TabIndex = 6;
            this.pb_convMatrixInput.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(803, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Input";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothToolStripMenuItem,
            this.gaussianBLurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.meanRemovalToolStripMenuItem,
            this.embossToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smoothToolStripMenuItem
            // 
            this.smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            this.smoothToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.smoothToolStripMenuItem.Text = "Smooth";
            this.smoothToolStripMenuItem.Click += new System.EventHandler(this.smoothToolStripMenuItem_Click);
            // 
            // gaussianBLurToolStripMenuItem
            // 
            this.gaussianBLurToolStripMenuItem.Name = "gaussianBLurToolStripMenuItem";
            this.gaussianBLurToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.gaussianBLurToolStripMenuItem.Text = "Gaussian BLur";
            this.gaussianBLurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBLurToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // meanRemovalToolStripMenuItem
            // 
            this.meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            this.meanRemovalToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.meanRemovalToolStripMenuItem.Text = "Mean Removal";
            this.meanRemovalToolStripMenuItem.Click += new System.EventHandler(this.meanRemovalToolStripMenuItem_Click);
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplasianToolStripMenuItem,
            this.horzVerticalToolStripMenuItem,
            this.allDirectionsToolStripMenuItem,
            this.lossyToolStripMenuItem,
            this.horizonToolStripMenuItem,
            this.verticalOnlyToolStripMenuItem});
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.embossToolStripMenuItem.Text = "Embossing";
            // 
            // laplasianToolStripMenuItem
            // 
            this.laplasianToolStripMenuItem.Name = "laplasianToolStripMenuItem";
            this.laplasianToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.laplasianToolStripMenuItem.Text = "Laplasian";
            this.laplasianToolStripMenuItem.Click += new System.EventHandler(this.laplasianToolStripMenuItem_Click);
            // 
            // horzVerticalToolStripMenuItem
            // 
            this.horzVerticalToolStripMenuItem.Name = "horzVerticalToolStripMenuItem";
            this.horzVerticalToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.horzVerticalToolStripMenuItem.Text = "Horz/Vertical";
            this.horzVerticalToolStripMenuItem.Click += new System.EventHandler(this.horzVerticalToolStripMenuItem_Click);
            // 
            // allDirectionsToolStripMenuItem
            // 
            this.allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            this.allDirectionsToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.allDirectionsToolStripMenuItem.Text = "All Directions";
            this.allDirectionsToolStripMenuItem.Click += new System.EventHandler(this.allDirectionsToolStripMenuItem_Click);
            // 
            // lossyToolStripMenuItem
            // 
            this.lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            this.lossyToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.lossyToolStripMenuItem.Text = "Lossy";
            this.lossyToolStripMenuItem.Click += new System.EventHandler(this.lossyToolStripMenuItem_Click);
            // 
            // horizonToolStripMenuItem
            // 
            this.horizonToolStripMenuItem.Name = "horizonToolStripMenuItem";
            this.horizonToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.horizonToolStripMenuItem.Text = "Horizontal Only";
            this.horizonToolStripMenuItem.Click += new System.EventHandler(this.horizonToolStripMenuItem_Click);
            // 
            // verticalOnlyToolStripMenuItem
            // 
            this.verticalOnlyToolStripMenuItem.Name = "verticalOnlyToolStripMenuItem";
            this.verticalOnlyToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.verticalOnlyToolStripMenuItem.Text = "Vertical Only";
            this.verticalOnlyToolStripMenuItem.Click += new System.EventHandler(this.verticalOnlyToolStripMenuItem_Click);
            // 
            // btn_saveMedia
            // 
            this.btn_saveMedia.BackColor = System.Drawing.Color.Green;
            this.btn_saveMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveMedia.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveMedia.ForeColor = System.Drawing.Color.White;
            this.btn_saveMedia.Location = new System.Drawing.Point(723, 561);
            this.btn_saveMedia.Name = "btn_saveMedia";
            this.btn_saveMedia.Size = new System.Drawing.Size(166, 47);
            this.btn_saveMedia.TabIndex = 17;
            this.btn_saveMedia.Text = "Save Media";
            this.btn_saveMedia.UseVisualStyleBackColor = false;
            this.btn_saveMedia.Click += new System.EventHandler(this.btn_saveMedia_Click);
            // 
            // btn_loadMedia
            // 
            this.btn_loadMedia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_loadMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadMedia.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadMedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_loadMedia.Location = new System.Drawing.Point(235, 561);
            this.btn_loadMedia.Name = "btn_loadMedia";
            this.btn_loadMedia.Size = new System.Drawing.Size(166, 47);
            this.btn_loadMedia.TabIndex = 16;
            this.btn_loadMedia.Text = "Load Media";
            this.btn_loadMedia.UseVisualStyleBackColor = false;
            this.btn_loadMedia.Click += new System.EventHandler(this.btn_loadMedia_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(723, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 733);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImageProcessing";
            this.Text = "Ledon - Image Processing";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_outputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inputImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_subtractedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_backgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foregroundImage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_convMatrixOuptut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_convMatrixInput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lb_outputImageLabel;
        private System.Windows.Forms.Label lb_inputImageLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_invert;
        private System.Windows.Forms.Button btn_greyscale;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_saveImage;
        private System.Windows.Forms.Button btn_loadImage;
        private System.Windows.Forms.PictureBox pb_outputImage;
        private System.Windows.Forms.PictureBox pb_inputImage;
        private System.Windows.Forms.Button btn_sepia;
        private System.Windows.Forms.Button btn_histogram;
        private System.Windows.Forms.Label lb_tabPageLabel;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_subtractedImage;
        private System.Windows.Forms.PictureBox pb_backgroundImage;
        private System.Windows.Forms.PictureBox pb_foregroundImage;
        private System.Windows.Forms.Button btn_loadBackgroundImage;
        private System.Windows.Forms.Button btn_loadForegroundImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_saveSubtractedImage;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_clearImages;
        private System.Windows.Forms.CheckBox cb_EnableWebCam;
        private System.Windows.Forms.CheckBox cb_fastmode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBLurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanRemovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplasianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horzVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDirectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lossyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalOnlyToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_convMatrixOuptut;
        private System.Windows.Forms.PictureBox pb_convMatrixInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_convMatrixWebcamToggle;
        private System.Windows.Forms.Button btn_saveMedia;
        private System.Windows.Forms.Button btn_loadMedia;
        private System.Windows.Forms.Button button1;
    }
}

