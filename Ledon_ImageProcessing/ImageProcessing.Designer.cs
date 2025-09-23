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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_outputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inputImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_subtractedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_backgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foregroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1142, 731);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.btn_saveImage.Location = new System.Drawing.Point(737, 516);
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
            this.btn_loadImage.Location = new System.Drawing.Point(224, 516);
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
            this.pb_outputImage.Location = new System.Drawing.Point(591, 110);
            this.pb_outputImage.Name = "pb_outputImage";
            this.pb_outputImage.Size = new System.Drawing.Size(444, 400);
            this.pb_outputImage.TabIndex = 3;
            this.pb_outputImage.TabStop = false;
            // 
            // pb_inputImage
            // 
            this.pb_inputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_inputImage.Location = new System.Drawing.Point(88, 110);
            this.pb_inputImage.Name = "pb_inputImage";
            this.pb_inputImage.Size = new System.Drawing.Size(444, 400);
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
            // ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 733);
            this.Controls.Add(this.tabControl1);
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
    }
}

