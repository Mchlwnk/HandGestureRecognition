namespace HandGestureRecognition
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.splitContainerFrames = new System.Windows.Forms.SplitContainer();
            this.delPhotoButton = new System.Windows.Forms.Button();
            this.movieButton = new System.Windows.Forms.Button();
            this.photoButton = new System.Windows.Forms.Button();
            this.imageBoxSkin = new Emgu.CV.UI.ImageBox();
            this.delMovieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.splitContainerFrames.Panel1.SuspendLayout();
            this.splitContainerFrames.Panel2.SuspendLayout();
            this.splitContainerFrames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxSkin)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(0, 0);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(512, 562);
            this.imageBoxFrameGrabber.TabIndex = 2;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // splitContainerFrames
            // 
            this.splitContainerFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFrames.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFrames.Name = "splitContainerFrames";
            // 
            // splitContainerFrames.Panel1
            // 
            this.splitContainerFrames.Panel1.Controls.Add(this.delMovieButton);
            this.splitContainerFrames.Panel1.Controls.Add(this.delPhotoButton);
            this.splitContainerFrames.Panel1.Controls.Add(this.movieButton);
            this.splitContainerFrames.Panel1.Controls.Add(this.photoButton);
            this.splitContainerFrames.Panel1.Controls.Add(this.imageBoxFrameGrabber);
            // 
            // splitContainerFrames.Panel2
            // 
            this.splitContainerFrames.Panel2.Controls.Add(this.imageBoxSkin);
            this.splitContainerFrames.Size = new System.Drawing.Size(1084, 562);
            this.splitContainerFrames.SplitterDistance = 512;
            this.splitContainerFrames.TabIndex = 3;
            // 
            // delPhotoButton
            // 
            this.delPhotoButton.Location = new System.Drawing.Point(113, 527);
            this.delPhotoButton.Name = "delPhotoButton";
            this.delPhotoButton.Size = new System.Drawing.Size(85, 23);
            this.delPhotoButton.TabIndex = 5;
            this.delPhotoButton.Text = "Usuń zdjęcie";
            this.delPhotoButton.UseVisualStyleBackColor = true;
            this.delPhotoButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // movieButton
            // 
            this.movieButton.Location = new System.Drawing.Point(287, 504);
            this.movieButton.Name = "movieButton";
            this.movieButton.Size = new System.Drawing.Size(86, 23);
            this.movieButton.TabIndex = 4;
            this.movieButton.Text = "Film";
            this.movieButton.UseVisualStyleBackColor = true;
            this.movieButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // photoButton
            // 
            this.photoButton.Location = new System.Drawing.Point(113, 504);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(85, 23);
            this.photoButton.TabIndex = 3;
            this.photoButton.Text = "Zdjęcie";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBoxSkin
            // 
            this.imageBoxSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxSkin.Location = new System.Drawing.Point(0, 0);
            this.imageBoxSkin.Name = "imageBoxSkin";
            this.imageBoxSkin.Size = new System.Drawing.Size(568, 562);
            this.imageBoxSkin.TabIndex = 2;
            this.imageBoxSkin.TabStop = false;
            this.imageBoxSkin.Click += new System.EventHandler(this.imageBoxSkin_Click);
            // 
            // delMovieButton
            // 
            this.delMovieButton.Location = new System.Drawing.Point(287, 527);
            this.delMovieButton.Name = "delMovieButton";
            this.delMovieButton.Size = new System.Drawing.Size(86, 23);
            this.delMovieButton.TabIndex = 6;
            this.delMovieButton.Text = "Usuń film";
            this.delMovieButton.UseVisualStyleBackColor = true;
            this.delMovieButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.splitContainerFrames);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.splitContainerFrames.Panel1.ResumeLayout(false);
            this.splitContainerFrames.Panel2.ResumeLayout(false);
            this.splitContainerFrames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxSkin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.SplitContainer splitContainerFrames;
        private Emgu.CV.UI.ImageBox imageBoxSkin;
        private System.Windows.Forms.Button delPhotoButton;
        private System.Windows.Forms.Button movieButton;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.Button delMovieButton;
    }
}

