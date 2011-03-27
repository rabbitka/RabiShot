using System.Drawing;
using System.Windows.Forms;

namespace RabiShot.Forms
{
    public sealed partial class SpecifiedRangeForm : Form
    {
        public SpecifiedRangeForm(Rectangle rect)
            :this()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(rect.X, rect.Y);
            Size = rect.Size;
            BackColor = Color.Black;
            TransparencyKey = Color.AliceBlue;
            Opacity = 0.7;
        }
        private SpecifiedRangeForm()
        {
            InitializeComponent();
        }

        public Rectangle SelectedRectangle { get; set; }

        private bool _isDrawing;
        private int _p1X;
        private int _p1Y;
        private int _p2X;
        private int _p2Y;
        private Rectangle _drawingRect;
        private string _drawingRectString;

        private void SpecifiedRangeForm_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
            _p1X = e.X;
            _p1Y = e.Y;
            _p2X = e.X;
            _p2Y = e.Y;
        }

        private void SpecifiedRangeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(!_isDrawing)
                return;

            var g = CreateGraphics();
            g.FillRectangle(Brushes.Black, _drawingRect);

            _p2X = e.X;
            _p2Y = e.Y;
            _drawingRect = GetRectangle();
            _drawingRectString =
                string.Format("Width: {0}px, Height: {1}px",
                              _drawingRect.Width,
                              _drawingRect.Height);

            g.FillRectangle(Brushes.AliceBlue, _drawingRect);
        }

        private void SpecifiedRangeForm_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;

            _p2X = e.X;
            _p2Y = e.Y;
            SelectedRectangle = GetRectangle();
            Close();
        }

        private Rectangle GetRectangle()
        {
            int x, y, width, height;

            if(_p2X < _p1X)
            {
                x = _p2X;
                width = _p1X - _p2X;
            }
            else
            {
                x = _p1X;
                width = _p2X - _p1X;
            }

            if(_p2Y < _p1Y)
            {
                y = _p2Y;
                height = _p1Y - _p2Y;
            }
            else
            {
                y = _p1Y;
                height = _p2Y - _p1Y;
            }

            return new Rectangle(x, y, width, height);
        }

    }
}
