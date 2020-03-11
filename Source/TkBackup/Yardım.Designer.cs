namespace TestAdb_05032020
{
    partial class Yardım
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
            this.viewer = new Spire.PdfViewer.Forms.PdfViewer();
            this.SuspendLayout();
            // 
            // viewer
            // 
            this.viewer.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.viewer.FormFillEnabled = false;
            this.viewer.IgnoreCase = false;
            this.viewer.IsToolBarVisible = true;
            this.viewer.Location = new System.Drawing.Point(-1, 1);
            this.viewer.MultiPagesThreshold = 60;
            this.viewer.Name = "viewer";
            this.viewer.OnRenderPageExceptionEvent = null;
            this.viewer.Size = new System.Drawing.Size(891, 559);
            this.viewer.TabIndex = 0;
            this.viewer.Text = "pdfViewer1";
            this.viewer.Threshold = 60;
            this.viewer.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // Yardım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 560);
            this.Controls.Add(this.viewer);
            this.Name = "Yardım";
            this.Text = "Yardım";
            this.Load += new System.EventHandler(this.Yardım_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Spire.PdfViewer.Forms.PdfViewer viewer;
    }
}