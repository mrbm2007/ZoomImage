using System;

namespace ClassLibrary1
{
    partial class ZoomImage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.fitAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new ClassLibrary1.MyPic();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox_over = new ClassLibrary1.MyPic();
            this.zoomThisRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_over)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitAllToolStripMenuItem,
            this.zoomThisRegionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // fitAllToolStripMenuItem
            // 
            this.fitAllToolStripMenuItem.Name = "fitAllToolStripMenuItem";
            this.fitAllToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fitAllToolStripMenuItem.Text = "Fit all";
            this.fitAllToolStripMenuItem.Click += new System.EventHandler(this.fitAllToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Height = 157D;
            this.pictureBox1.Height_ = 157D;
            this.pictureBox1.Left = -37D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Top = 84D;
            this.pictureBox1.TransparentToMouse = false;
            this.pictureBox1.Width = 212D;
            this.pictureBox1.Width_ = 212D;
            this.pictureBox1.ZoomCenter_x = 106D;
            this.pictureBox1.ZoomCenter_y = 78.5D;
            this.pictureBox1.ZoomCenterRatio_x = 0.5D;
            this.pictureBox1.ZoomCenterRatio_y = 0.5D;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(56, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 41);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(72, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 2);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(130, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 37);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(72, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 2);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            // 
            // pictureBox_over
            // 
            this.pictureBox_over.Height = 0D;
            this.pictureBox_over.Height_ = 0D;
            this.pictureBox_over.Left = 0D;
            this.pictureBox_over.Location = new System.Drawing.Point(72, 0);
            this.pictureBox_over.Name = "pictureBox_over";
            this.pictureBox_over.Size = new System.Drawing.Size(0, 84);
            this.pictureBox_over.TabIndex = 8;
            this.pictureBox_over.TabStop = false;
            this.pictureBox_over.Top = 0D;
            this.pictureBox_over.TransparentToMouse = false;
            this.pictureBox_over.Visible = false;
            this.pictureBox_over.Width = 0D;
            this.pictureBox_over.Width_ = 0D;
            this.pictureBox_over.ZoomCenter_x = 0D;
            this.pictureBox_over.ZoomCenter_y = 0D;
            this.pictureBox_over.ZoomCenterRatio_x = 0.5D;
            this.pictureBox_over.ZoomCenterRatio_y = 0.5D;
            this.pictureBox_over.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_over_Paint);
            // 
            // zoomThisRegionToolStripMenuItem
            // 
            this.zoomThisRegionToolStripMenuItem.Name = "zoomThisRegionToolStripMenuItem";
            this.zoomThisRegionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zoomThisRegionToolStripMenuItem.Text = "Zoom this region";
            this.zoomThisRegionToolStripMenuItem.Click += new System.EventHandler(this.zoomThisRegionToolStripMenuItem_Click);
            // 
            // ZoomImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "ZoomImage";
            this.Size = new System.Drawing.Size(497, 394);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZoomImage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ZoomImage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ZoomImage_MouseUp);
            this.Resize += new System.EventHandler(this.ZoomImage_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_over)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private MyPic pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fitAllToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MyPic pictureBox_over;
        private System.Windows.Forms.ToolStripMenuItem zoomThisRegionToolStripMenuItem;
    }
}
