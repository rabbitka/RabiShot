using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace RabiShot.SSType {
    /// <summary>
    /// 自由な領域を選択するフォーム。
    /// </summary>
    public sealed partial class FreeAreaForm : Form {
        private bool _isSelection;
        private Rectangle _rect;

        /// <summary>
        /// 画面の領域を指定してインスタンスを初期化する。
        /// </summary>
        /// <param name="rect">Formを表示する画面の領域</param>
        public FreeAreaForm(Rectangle rect) : this() {
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            Location = rect.Location;
            Size = rect.Size;
            BackColor = Color.Black;
            TransparencyKey = Color.AliceBlue;
            Opacity = 0.7;

            MouseDown += (sender, e) => StartSelectionArea(e.X, e.Y);
            MouseMove += (sender, e) => MouseMoving(e.X, e.Y);
            MouseUp += (sender, e) => EndSelectionArea(e.X, e.Y);
        }
        private FreeAreaForm() {
            InitializeComponent();
        }

        public Rectangle GetSelectedRectangle() {
            return _rect;
        }

        private int _x1;
        private int _y1;
        private int _x2;
        private int _y2;

        /// <summary>
        /// ドラッグアンドドロップ開始時の処理。
        /// マウスクリック時、領域選択開始フラグを立てクリックした領域を保存する。
        /// </summary>
        /// <param name="x">クリック開始時の x 座標</param>
        /// <param name="y">クリック開始時の y 座標</param>
        private void StartSelectionArea(int x, int y) {
            _isSelection = true;
            _x1 = x;
            _y1 = y;
        }

        /// <summary>
        /// マウス移動中の処理。
        /// 
        /// </summary>
        private void MouseMoving(int x, int y) {
            if(!_isSelection)
                return;

            using(var g = CreateGraphics()) {
                g.FillRectangle(
                    Brushes.Black,
                    Math.Min(_x1, _x2),
                    Math.Min(_y1, _y2),
                    Math.Abs(_x1 - _x2),
                    Math.Abs(_y1 - _y2));

                _x2 = x;
                _y2 = y;

                g.FillRectangle(
                    Brushes.AliceBlue,
                    Math.Min(_x1, _x2),
                    Math.Min(_y1, _y2),
                    Math.Abs(_x1 - _x2),
                    Math.Abs(_y1 - _y2));
            }
        }

        /// <summary>
        /// ドラッグアンドドロップ終了時の処理。
        /// 
        /// </summary>
        private void EndSelectionArea(int x, int y) {
            _isSelection = false;
            _rect = new Rectangle(
                Math.Min(_x1, _x2),
                Math.Min(_y1, _y2),
                Math.Abs(_x1 - _x2),
                Math.Abs(_y1 - _y2));
            Close();              
        }                         
    }                             
}
