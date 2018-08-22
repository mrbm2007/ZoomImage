using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    public partial class ZoomImage : UserControl
    {
        public ZoomImage()
        {
            InitializeComponent();
            this.MouseWheel += ZoomImage_MouseWheel;
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox_over);
            pictureBox1.TransparentToMouse = true;
            pictureBox_over.TransparentToMouse = true;
            var t = new Timer { Interval = 100 };
            t.Tick += (s, e) =>
            {
                t.Stop();
                FitAll();
            };
            t.Start();
            DrawGrid();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox_over.Parent = pictureBox1;
        }


        #region Properties
        public Image Image
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public bool Grid
        {
            get { return _grid; }
            set
            {
                _grid = value;
                DrawGrid();
            }
        }
        public int Grid_Rows
        {
            set { _Grid_Rows = value; DrawGrid(); }
            get { return _Grid_Rows; }
        }
        public int Grid_Columns
        {
            set { _Grid_Columns = value; DrawGrid(); }
            get { return _Grid_Columns; }
        }
        public Color Grid_Color
        {
            get { return _Grid_Color; }
            set { _Grid_Color = value; DrawGrid(); }
        }

        public RectangleF VisibleRange
        {
            get
            {
                return new RectangleF(
                    (float)(-pictureBox1.Left / pictureBox1.Width),
                    (float)(-pictureBox1.Top / pictureBox1.Height),
                    (float)((Width - pictureBox1.Left) / pictureBox1.Width),
                    (float)((Height - pictureBox1.Top) / pictureBox1.Height)
                    );
            }
            set
            {
                pictureBox1.Width = (Width - pictureBox1.Left) / value.Width;
                pictureBox1.Height = (Height - pictureBox1.Top) / value.Height;
                pictureBox1.Left = -value.X * pictureBox1.Width;
                pictureBox1.Top = -value.Y * pictureBox1.Height;
                OnRangeChanged?.Invoke(this, null);
            }
        }
        public int selectd_row
        {
            get { return _selectd_row; }
            set
            {
                _selectd_row = value;
                DrawSelection();
            }
        }
        public int selectd_col
        {
            get { return _selectd_col; }
            set
            {
                _selectd_col = value;
                DrawSelection();
            }
        }

        #endregion

        #region Events
        public event EventHandler OnRangeChanged;
        public event EventHandler OnSelectionChanged;
        #endregion

        #region Methods
        public void FitAll()
        {
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
            pictureBox1.Width_ = Width;
            pictureBox1.Height_ = Height;
            OnRangeChanged?.Invoke(this, null);
            DrawSelection();
        }
        private void DrawSelection()
        {
            if (_selectd_col >= 0 && _selectd_row >= 0)
            {
                var w = Width / (double)Grid_Columns;
                var h = Height / (double)Grid_Rows;
                var x = selectd_col * w;
                var y = selectd_row * h;

                panel1.Width = panel3.Width = (int)w + 1;
                panel2.Height = panel4.Height = (int)h + 1;
                panel2.Top = panel1.Top = panel4.Top = (int)y;
                panel3.Left = panel1.Left = panel4.Left = (int)x;
                panel3.Top = (int)(y + h);
                panel2.Left = (int)(x + w);
                pictureBox_over.Width_ = (int)(w + 1);
                pictureBox_over.Height_ = (int)(h + 1);
                pictureBox_over.Left = -pictureBox1.Left + (int)x;
                pictureBox_over.Top = -pictureBox1.Top + (int)y;
                pictureBox_over.Visible = panel1.Visible = panel2.Visible = panel3.Visible = panel4.Visible = true;
            }
            else
                pictureBox_over.Visible = panel1.Visible = panel2.Visible = panel3.Visible = panel4.Visible = false;
        }
        void DrawGrid()
        {
            if (Grid)
            {
                var n_Rpws = Grid_Rows * 1.0;
                var n_Columns = Grid_Columns * 1.0;
                for (int i = 1; i < n_Rpws; i++)
                {
                    Control c;
                    if (i < Rows.Count)
                        c = Rows[i];
                    else
                    {
                        c = new Control();
                        Rows.Add(c);
                        Controls.Add(c);
                    }
                    c.Visible = true;
                    c.Left = 0;
                    c.Top = (int)((i / n_Rpws) * Height);
                    c.Width = this.Width;
                    c.Height = 1;
                    c.BackColor = Grid_Color;

                    Controls.Add(c);
                }
                for (int i = 1; i < n_Columns; i++)
                {
                    Control c;
                    if (i < Columns.Count)
                        c = Columns[i];
                    else
                    {
                        c = new Control();
                        Columns.Add(c);
                        Controls.Add(c);
                    }
                    c.Visible = true;
                    c.Left = (int)((i / n_Columns) * Width);
                    c.Top = 0;
                    c.Width = 1;
                    c.Height = this.Height;
                    c.BackColor = Grid_Color;

                }
                for (int i = (int)n_Rpws; i < Rows.Count; i++)
                    Rows[i].Visible = false;
                for (int i = (int)n_Columns; i < Columns.Count; i++)
                    Columns[i].Visible = false;
            }
            else
            {
                foreach (var c in Rows)
                    if (c != null)
                        c.Visible = false;
                foreach (var c in Columns)
                    if (c != null)
                        c.Visible = false;
            }
            pictureBox1.SendToBack();
        }
        #endregion

        #region Fields
        bool _grid = true ;
        int _Grid_Rows = 5;
        int _Grid_Columns = 5;
        Color _Grid_Color = Color.DarkGray;
        int _selectd_row = -1;
        int _selectd_col = -1;
        List<Control> Rows = new List<Control> { null };
        List<Control> Columns = new List<Control> { null };
        #endregion


        #region Internal Events
        double last_w = -1, last_h = -1;
        private void ZoomImage_Resize(object sender, EventArgs e)
        {
            if (last_h != -1 && last_w != -1)
            {
                pictureBox1.Width_ += Width - last_w;
                pictureBox1.Height_ += Height - last_h;
            }
            last_h = Height;
            last_w = Width;
            DrawGrid();
            DrawSelection();
        }
        private void ZoomImage_MouseWheel(object sender, MouseEventArgs e)
        {
            pictureBox1.ZoomCenterRatio_x = e.X / (double)Width;
            pictureBox1.ZoomCenterRatio_y = e.Y / (double)Height;
            pictureBox1.SuspendLayout();
            pictureBox1.Width = (pictureBox1.Width * (1 + e.Delta / 3000.0));
            pictureBox1.Height = (pictureBox1.Height * (1 + e.Delta / 3000.0));
            pictureBox1.ResumeLayout();
            OnRangeChanged?.Invoke(this, null);
        }

        private void ZoomImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_draging)
            {
                pictureBox1.Left += (e.X - x0);
                pictureBox1.Top += (e.Y - y0);
                if ((Math.Abs(e.X - x0) + Math.Abs(e.Y - y0)) > 0)
                {
                    draged = true;
                    x0 = e.X;
                    y0 = e.Y;
                    DrawSelection();
                    OnRangeChanged?.Invoke(this, null);
                }
            }
        }

        private void ZoomImage_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!draged && e.Button == MouseButtons.Left)
            {
                var w = Width / (double)Grid_Columns;
                var h = Height / (double)Grid_Rows;
                _selectd_col = (int)Math.Floor(e.X / (w));
                _selectd_row = (int)Math.Floor(e.Y / (h));
                DrawSelection();
                OnSelectionChanged?.Invoke(this, null);
            }
            is_draging = false;
        }

        double x0, y0;

        private void fitAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FitAll();
        }

        private void pictureBox_over_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox_over.Visible)
            {
                Brush brush = new SolidBrush(Color.FromArgb(100, 40, 210, 40));
                e.Graphics.FillRectangle(brush, new Rectangle(0, 0, (int)pictureBox_over.Width, (int)pictureBox_over.Height));
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var p = pictureBox_over.PointToClient(Cursor.Position);
            if (new Rectangle(0, 0, (int)pictureBox_over.Width, (int)pictureBox_over.Height).Contains(p))
            {
                zoomThisRegionToolStripMenuItem.Visible = true;
            }
            else
                zoomThisRegionToolStripMenuItem.Visible = false;
        }

        private void zoomThisRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rect = new RectangleF(
                    (float)(pictureBox_over.Left / pictureBox1.Width),
                    (float)(pictureBox_over.Top / pictureBox1.Height),
                    (float)(pictureBox_over.Width / pictureBox1.Width),
                    (float)(pictureBox_over.Height / pictureBox1.Height)
                    );
            VisibleRange = rect;
            selectd_col = -1;
        }

        bool is_draging = false, draged = false;
        private void ZoomImage_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            draged = false;
            x0 = e.X;
            y0 = e.Y;
            if (e.Button == MouseButtons.Left)
                is_draging = true;
        }
        #endregion
    }

    public class MyPic : PictureBox
    {
        public MyPic()
        {
            TransparentToMouse = false;
            ZoomCenterRatio_x = 0.5;
            ZoomCenterRatio_y = 0.5;

        }
        double _width, _height, _top, _left;
        public double ZoomCenterRatio_x { get; set; }
        public double ZoomCenterRatio_y { get; set; }
        public double ZoomCenter_x
        {
            get
            {
                return ZoomCenterRatio_x * _width;
            }
            set
            {
                ZoomCenterRatio_x = value / _width;
            }
        }
        public double ZoomCenter_y
        {
            get
            {
                return ZoomCenterRatio_y * _height;
            }
            set
            {
                ZoomCenterRatio_y = value / _height;
            }
        }
        public new double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (_width > 0)
                    Left -= (value - _width) * (ZoomCenter_x / _width);
                _width = value;
                base.Width = (int)(Math.Round(_width));
            }
        }
        public new double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (_height > 0)
                    Top -= (value - _height) * (ZoomCenter_y / _height);
                _height = value;
                base.Height = (int)(Math.Round(_height));
            }
        }
        public double Width_
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                base.Width = (int)(Math.Round(_width));
            }
        }
        public double Height_
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                base.Height = (int)(Math.Round(_height));
            }
        }
        public new double Top
        {
            get
            {
                return _top;
            }
            set
            {
                _top = value;
                base.Top = (int)(Math.Round(_top));
            }
        }
        public new double Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
                base.Left = (int)(Math.Round(_left));
            }
        }
        public bool TransparentToMouse
        {
            get; set;
        }
        protected override void WndProc(ref Message m)
        {
            if (TransparentToMouse && LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                const int WM_NCHITTEST = 0x0084;
                const int HTTRANSPARENT = (-1);

                if (m.Msg == WM_NCHITTEST)
                {
                    m.Result = (IntPtr)HTTRANSPARENT;
                }
                else
                {
                    base.WndProc(ref m);
                }
            }
        }
    }
}
