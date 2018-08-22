namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox_grid = new System.Windows.Forms.CheckBox();
            this.comboBox_rows = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_range = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_image = new System.Windows.Forms.Button();
            this.comboBox_cols = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label_selected = new System.Windows.Forms.Label();
            this.zoomImage1 = new ClassLibrary1.ZoomImage();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_grid
            // 
            this.checkBox_grid.AutoSize = true;
            this.checkBox_grid.Checked = true;
            this.checkBox_grid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_grid.Location = new System.Drawing.Point(6, 28);
            this.checkBox_grid.Name = "checkBox_grid";
            this.checkBox_grid.Size = new System.Drawing.Size(53, 17);
            this.checkBox_grid.TabIndex = 1;
            this.checkBox_grid.Text = "GRID";
            this.checkBox_grid.UseVisualStyleBackColor = true;
            this.checkBox_grid.CheckedChanged += new System.EventHandler(this.checkBox_grid_CheckedChanged);
            // 
            // comboBox_rows
            // 
            this.comboBox_rows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_rows.FormattingEnabled = true;
            this.comboBox_rows.Items.AddRange(new object[] {
            "5",
            "2",
            "5 ",
            "10",
            "15",
            "20"});
            this.comboBox_rows.Location = new System.Drawing.Point(65, 49);
            this.comboBox_rows.Name = "comboBox_rows";
            this.comboBox_rows.Size = new System.Drawing.Size(72, 21);
            this.comboBox_rows.TabIndex = 3;
            this.comboBox_rows.SelectedIndexChanged += new System.EventHandler(this.comboBox_rows_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label_selected);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_range);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_image);
            this.groupBox1.Controls.Add(this.comboBox_cols);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_color);
            this.groupBox1.Controls.Add(this.comboBox_rows);
            this.groupBox1.Controls.Add(this.checkBox_grid);
            this.groupBox1.Location = new System.Drawing.Point(414, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 394);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label_range
            // 
            this.label_range.AutoSize = true;
            this.label_range.Location = new System.Drawing.Point(41, 202);
            this.label_range.Name = "label_range";
            this.label_range.Size = new System.Drawing.Size(72, 13);
            this.label_range.TabIndex = 11;
            this.label_range.Text = "Visibla Range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Visibla Range";
            // 
            // button_image
            // 
            this.button_image.Location = new System.Drawing.Point(18, 139);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(119, 23);
            this.button_image.TabIndex = 9;
            this.button_image.Text = "Image...";
            this.button_image.UseVisualStyleBackColor = true;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // comboBox_cols
            // 
            this.comboBox_cols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cols.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_cols.FormattingEnabled = true;
            this.comboBox_cols.Items.AddRange(new object[] {
            "5",
            "2",
            "5",
            "10",
            "15",
            "20"});
            this.comboBox_cols.Location = new System.Drawing.Point(65, 73);
            this.comboBox_cols.Name = "comboBox_cols";
            this.comboBox_cols.Size = new System.Drawing.Size(72, 21);
            this.comboBox_cols.TabIndex = 8;
            this.comboBox_cols.SelectedIndexChanged += new System.EventHandler(this.comboBox_cols_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rows";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color";
            // 
            // comboBox_color
            // 
            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Items.AddRange(new object[] {
            "Black",
            "Gray",
            "White",
            "Red",
            "Blue",
            "Green",
            "DarkGray"});
            this.comboBox_color.Location = new System.Drawing.Point(65, 97);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(72, 21);
            this.comboBox_color.TabIndex = 4;
            this.comboBox_color.SelectedIndexChanged += new System.EventHandler(this.comboBox_color_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "image";
            this.openFileDialog1.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|GIF|*.gif|All files|*.*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Selected grid";
            // 
            // label_selected
            // 
            this.label_selected.AutoSize = true;
            this.label_selected.Location = new System.Drawing.Point(41, 288);
            this.label_selected.Name = "label_selected";
            this.label_selected.Size = new System.Drawing.Size(34, 13);
            this.label_selected.TabIndex = 13;
            this.label_selected.Text = "-1 , -1";
            // 
            // zoomImage1
            // 
            this.zoomImage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomImage1.BackColor = System.Drawing.Color.White;
            this.zoomImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomImage1.Grid = true;
            this.zoomImage1.Grid_Color = System.Drawing.Color.DarkGray;
            this.zoomImage1.Grid_Columns = 5;
            this.zoomImage1.Grid_Rows = 5;
            this.zoomImage1.Image = global::WindowsFormsApplication1.Properties.Resources.at_the_beach_hd_wallpaper_1920x1200;
            this.zoomImage1.Location = new System.Drawing.Point(12, 12);
            this.zoomImage1.Name = "zoomImage1";
            this.zoomImage1.selectd_col = -1;
            this.zoomImage1.selectd_row = -1;
            this.zoomImage1.Size = new System.Drawing.Size(396, 394);
            this.zoomImage1.TabIndex = 0;
            this.zoomImage1.VisibleRange = ((System.Drawing.RectangleF)(resources.GetObject("zoomImage1.VisibleRange")));
            this.zoomImage1.OnRangeChanged += new System.EventHandler(this.zoomImage1_OnRangeChanged);
            this.zoomImage1.OnSelectionChanged += new System.EventHandler(this.zoomImage1_OnSelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zoomImage1);
            this.Name = "Form1";
            this.Text = "Form_test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.ZoomImage zoomImage1;
        private System.Windows.Forms.CheckBox checkBox_grid;
        private System.Windows.Forms.ComboBox comboBox_rows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_cols;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_range;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_selected;
        private System.Windows.Forms.Label label5;
    }
}

