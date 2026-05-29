namespace MiniAlbumViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog = new FolderBrowserDialog();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            BtnFlip = new Button();
            BtnRotate = new Button();
            BtnFolder = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnFolder);
            panel1.Controls.Add(BtnRotate);
            panel1.Controls.Add(BtnFlip);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 108);
            panel1.TabIndex = 0;
            // 
            // BtnFlip
            // 
            BtnFlip.Dock = DockStyle.Bottom;
            BtnFlip.Location = new Point(0, 74);
            BtnFlip.Name = "BtnFlip";
            BtnFlip.Size = new Size(266, 34);
            BtnFlip.TabIndex = 0;
            BtnFlip.Text = "좌우 반전";
            BtnFlip.UseVisualStyleBackColor = true;
            // 
            // BtnRotate
            // 
            BtnRotate.Dock = DockStyle.Bottom;
            BtnRotate.Location = new Point(0, 40);
            BtnRotate.Name = "BtnRotate";
            BtnRotate.Size = new Size(266, 34);
            BtnRotate.TabIndex = 1;
            BtnRotate.Text = "90도 회전";
            BtnRotate.UseVisualStyleBackColor = true;
            // 
            // BtnFolder
            // 
            BtnFolder.Dock = DockStyle.Bottom;
            BtnFolder.Location = new Point(0, 6);
            BtnFolder.Name = "BtnFolder";
            BtnFolder.Size = new Size(266, 34);
            BtnFolder.TabIndex = 2;
            BtnFolder.Text = "폴더 열기";
            BtnFolder.UseVisualStyleBackColor = true;
            BtnFolder.Click += BtnFolder_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(266, 342);
            flowLayoutPanel.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(530, 450);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Button BtnFolder;
        private Button BtnRotate;
        private Button BtnFlip;
        private FlowLayoutPanel flowLayoutPanel;
        private PictureBox pictureBox;
    }
}
