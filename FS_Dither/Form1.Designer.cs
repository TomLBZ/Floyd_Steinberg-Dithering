namespace FS_Dither
{
    partial class frmDither
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "RGB(255,255,255)"}, -1, System.Drawing.Color.Black, System.Drawing.Color.White, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "RGB(0,0,0)"}, -1, System.Drawing.Color.White, System.Drawing.Color.Black, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDither));
            this.picSource = new System.Windows.Forms.PictureBox();
            this.picMask = new System.Windows.Forms.PictureBox();
            this.picDest = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.fileLoadPic = new System.Windows.Forms.OpenFileDialog();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.colorSelect = new System.Windows.Forms.ColorDialog();
            this.btnRemoveColor = new System.Windows.Forms.Button();
            this.lstPallet = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).BeginInit();
            this.SuspendLayout();
            // 
            // picSource
            // 
            this.picSource.Location = new System.Drawing.Point(12, 12);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(350, 350);
            this.picSource.TabIndex = 0;
            this.picSource.TabStop = false;
            // 
            // picMask
            // 
            this.picMask.Location = new System.Drawing.Point(368, 12);
            this.picMask.Name = "picMask";
            this.picMask.Size = new System.Drawing.Size(350, 350);
            this.picMask.TabIndex = 1;
            this.picMask.TabStop = false;
            // 
            // picDest
            // 
            this.picDest.Location = new System.Drawing.Point(724, 12);
            this.picDest.Name = "picDest";
            this.picDest.Size = new System.Drawing.Size(350, 350);
            this.picDest.TabIndex = 2;
            this.picDest.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(612, 399);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 50);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(768, 399);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(150, 50);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(924, 399);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(150, 50);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // fileLoadPic
            // 
            this.fileLoadPic.FileName = "SourcePic";
            this.fileLoadPic.Filter = "JPEG files | *.jpg";
            this.fileLoadPic.Title = "Load a picture file";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 365);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(73, 13);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "Source Image";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(365, 365);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(65, 13);
            this.lblMask.TabIndex = 7;
            this.lblMask.Text = "Mask Image";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(721, 365);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(69, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result Image";
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(367, 380);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(239, 30);
            this.btnAddColor.TabIndex = 10;
            this.btnAddColor.Text = "Add Color To Palett";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // btnRemoveColor
            // 
            this.btnRemoveColor.Location = new System.Drawing.Point(367, 419);
            this.btnRemoveColor.Name = "btnRemoveColor";
            this.btnRemoveColor.Size = new System.Drawing.Size(239, 30);
            this.btnRemoveColor.TabIndex = 11;
            this.btnRemoveColor.Text = "Remove Selected Color From Palett";
            this.btnRemoveColor.UseVisualStyleBackColor = true;
            this.btnRemoveColor.Click += new System.EventHandler(this.btnRemoveColor_Click);
            // 
            // lstPallet
            // 
            this.lstPallet.HideSelection = false;
            this.lstPallet.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lstPallet.Location = new System.Drawing.Point(12, 381);
            this.lstPallet.Name = "lstPallet";
            this.lstPallet.Size = new System.Drawing.Size(349, 68);
            this.lstPallet.TabIndex = 12;
            this.lstPallet.UseCompatibleStateImageBehavior = false;
            this.lstPallet.View = System.Windows.Forms.View.List;
            // 
            // frmDither
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.lstPallet);
            this.Controls.Add(this.btnRemoveColor);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.picDest);
            this.Controls.Add(this.picMask);
            this.Controls.Add(this.picSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDither";
            this.Text = "Floyd–Steinberg dithering";
            this.Load += new System.EventHandler(this.frmDither_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.PictureBox picMask;
        private System.Windows.Forms.PictureBox picDest;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.OpenFileDialog fileLoadPic;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.ColorDialog colorSelect;
        private System.Windows.Forms.Button btnRemoveColor;
        private System.Windows.Forms.ListView lstPallet;
    }
}

