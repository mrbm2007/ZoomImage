using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_grid_CheckedChanged(object sender, EventArgs e)
        {
            zoomImage1.Grid = checkBox_grid.Checked;
        }

        private void comboBox_rows_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                zoomImage1.Grid_Rows = Convert.ToInt16(comboBox_rows.Text);
                checkBox_grid.Checked = true;
            }
            catch { }
        }
        private void comboBox_cols_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                zoomImage1.Grid_Columns = Convert.ToInt16(comboBox_cols.Text);
                checkBox_grid.Checked = true;
            }
            catch { }
        }

        private void comboBox_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                zoomImage1.Grid_Color = Color.FromName(comboBox_color.Text);
                checkBox_grid.Checked = true;
            }
            catch { }
        }

        private void button_image_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                zoomImage1.Image = new Bitmap(openFileDialog1.FileName);
        }

        private void zoomImage1_OnRangeChanged(object sender, EventArgs e)
        {
            var rec = zoomImage1.VisibleRange;
            label_range.Text =
                "X: "+(rec.X * 100).ToString("0.0") + " %" + "\r\n" +
                "Y: " + (rec.Y * 100).ToString("0.0") + " %" + "\r\n" +
                "W: " + (rec.Width * 100).ToString("0.0") + " %" + "\r\n" +
                "H: " + (rec.Height * 100).ToString("0.0") + " %";
        }

        private void zoomImage1_OnSelectionChanged(object sender, EventArgs e)
        {
            label_selected.Text = zoomImage1.selectd_row + " , " + zoomImage1.selectd_col;
        }
    }
}
