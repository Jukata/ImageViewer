namespace ImageViewer
{
    partial class FrmMain
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cbImageFiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.lblHello = new System.Windows.Forms.Label();
            this.gbFolderBrowse = new System.Windows.Forms.GroupBox();
            this.btnImageBrowser = new System.Windows.Forms.Button();
            this.gbImageInfo = new System.Windows.Forms.GroupBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbFolderBrowse.SuspendLayout();
            this.gbImageInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 40);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(352, 309);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(6, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(261, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse Folders";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbImageFiles
            // 
            this.cbImageFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImageFiles.FormattingEnabled = true;
            this.cbImageFiles.Location = new System.Drawing.Point(98, 43);
            this.cbImageFiles.Name = "cbImageFiles";
            this.cbImageFiles.Size = new System.Drawing.Size(169, 21);
            this.cbImageFiles.Sorted = true;
            this.cbImageFiles.TabIndex = 2;
            this.cbImageFiles.SelectedIndexChanged += new System.EventHandler(this.cbImageFiles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select an image:";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHello.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(147, 8);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(378, 20);
            this.lblHello.TabIndex = 4;
            this.lblHello.Text = "Select a folder or a concrete image to display";
            // 
            // gbFolderBrowse
            // 
            this.gbFolderBrowse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbFolderBrowse.Controls.Add(this.label1);
            this.gbFolderBrowse.Controls.Add(this.btnBrowse);
            this.gbFolderBrowse.Controls.Add(this.cbImageFiles);
            this.gbFolderBrowse.Location = new System.Drawing.Point(370, 40);
            this.gbFolderBrowse.Name = "gbFolderBrowse";
            this.gbFolderBrowse.Size = new System.Drawing.Size(273, 73);
            this.gbFolderBrowse.TabIndex = 5;
            this.gbFolderBrowse.TabStop = false;
            this.gbFolderBrowse.Text = "Select a folder to view images";
            // 
            // btnImageBrowser
            // 
            this.btnImageBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageBrowser.Location = new System.Drawing.Point(370, 119);
            this.btnImageBrowser.Name = "btnImageBrowser";
            this.btnImageBrowser.Size = new System.Drawing.Size(273, 25);
            this.btnImageBrowser.TabIndex = 6;
            this.btnImageBrowser.Text = "Browse Images";
            this.btnImageBrowser.UseVisualStyleBackColor = true;
            this.btnImageBrowser.Click += new System.EventHandler(this.btnImageBrowser_Click);
            // 
            // gbImageInfo
            // 
            this.gbImageInfo.BackColor = System.Drawing.Color.DarkGray;
            this.gbImageInfo.Controls.Add(this.tbWidth);
            this.gbImageInfo.Controls.Add(this.tbHeight);
            this.gbImageInfo.Controls.Add(this.tbName);
            this.gbImageInfo.Controls.Add(this.label5);
            this.gbImageInfo.Controls.Add(this.label4);
            this.gbImageInfo.Controls.Add(this.label3);
            this.gbImageInfo.Controls.Add(this.label2);
            this.gbImageInfo.Controls.Add(this.tbLocation);
            this.gbImageInfo.Location = new System.Drawing.Point(370, 150);
            this.gbImageInfo.Name = "gbImageInfo";
            this.gbImageInfo.Size = new System.Drawing.Size(273, 141);
            this.gbImageInfo.TabIndex = 7;
            this.gbImageInfo.TabStop = false;
            this.gbImageInfo.Text = "Image Info";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(60, 111);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.ReadOnly = true;
            this.tbWidth.Size = new System.Drawing.Size(196, 20);
            this.tbWidth.TabIndex = 7;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(60, 82);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.ReadOnly = true;
            this.tbHeight.Size = new System.Drawing.Size(196, 20);
            this.tbHeight.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(60, 53);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(196, 20);
            this.tbName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(60, 24);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.ReadOnly = true;
            this.tbLocation.Size = new System.Drawing.Size(196, 20);
            this.tbLocation.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.FileName = "Select an existing file";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGreen;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(421, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Reset Your Viewer";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(421, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(652, 356);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbImageInfo);
            this.Controls.Add(this.btnImageBrowser);
            this.Controls.Add(this.gbFolderBrowse);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbFolderBrowse.ResumeLayout(false);
            this.gbFolderBrowse.PerformLayout();
            this.gbImageInfo.ResumeLayout(false);
            this.gbImageInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cbImageFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.GroupBox gbFolderBrowse;
        private System.Windows.Forms.Button btnImageBrowser;
        private System.Windows.Forms.GroupBox gbImageInfo;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}