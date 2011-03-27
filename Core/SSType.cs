using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RabiShot.Extensions;
using RabiShot.Forms;
using RabiShot.Options;


namespace RabiShot.Core
{
    /// <summary>
    /// �X�N���[���V���b�g�̎��
    /// </summary>
    public class SSType
    {
        /// <summary>
        /// ��ʑS��
        /// </summary>
        public static readonly SSType All
            = new SSType("��ʑS��", GetAllRectangle);
        /// <summary>
        /// �E�B���h�E
        /// </summary>
        public static readonly SSType Window
            = new SSType("�E�B���h�E", GetWindowRectangle);
        /// <summary>
        /// �͈͎w��
        /// </summary>
        public static readonly SSType Any
            = new SSType("�͈͎w��", GetAnyRectangle);

        private SSType(string key, Func<Rectangle> getRect)
        {
            Key = key;
            _getRect = getRect;
        }

        private readonly Func<Rectangle> _getRect;

        public string Key { get; set; }

        public Rectangle GetRectangle()
        {
            return _getRect();
        }

        public string GetScreenShot()
        {
            return GetScreenShot(_getRect());
        }
        private static string GetScreenShot(Rectangle rect)
        {
            var bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppPArgb);

            using(var g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
            }

            var dir = Option.Instance().SaveDirectory;
            if(!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            //bmp.Save(Option.Instance().SaveDirectory + "\\test.png", ImageFormat.Png);
            bmp.Save(Option.Instance().SaveDirectory + @"\" + CreateFileName(), Option.Instance().Format);
            return string.Empty;
        }

        #region Option����t�@�C�����𐶐�

        private static string CreateFileName()
        {
            var o = Option.Instance();
            return string.Format(
                "{0}{1}{2}.{3}",
                o.FilePrefix,
                CreateSerial(o.SerialFormat),
                o.FileSuffix,
                o.Format.GetExtension());
        }
        private static string CreateSerial(string fmt)
        {

            return "serial";
        }

        #endregion

        #region Rectangle�擾���\�b�h

        /// <summary>
        /// ��ʑS��
        /// </summary>
        /// <returns></returns>
        private static Rectangle GetAllRectangle()
        {
            int x = 0, y = 0, width = 0, height = 0;

            foreach(var screen in Screen.AllScreens)
            {
                if(x > screen.Bounds.X)
                    x = screen.Bounds.X;
                if(y > screen.Bounds.Y)
                    y = screen.Bounds.Y;
                if(screen.Bounds.X == 0 && screen.Bounds.Y == 0)
                {
                    width += screen.Bounds.Width;
                    height += screen.Bounds.Height;
                }
                else
                {
                    width += Math.Abs(screen.Bounds.X);
                    height += Math.Abs(screen.Bounds.Y);
                }
            }

            return new Rectangle(x, y, width, height);
        }
        /// <summary>
        /// �E�B���h�E
        /// </summary>
        /// <returns></returns>
        private static Rectangle GetWindowRectangle()
        {
            RECT r;
            IntPtr active = GetForegroundWindow();
            GetWindowRect(active, out r);

            return new Rectangle(r.left, r.top, r.right - r.left, r.bottom - r.top);
        }
        /// <summary>
        /// �͈͎w��
        /// </summary>
        /// <returns></returns>
        private static Rectangle GetAnyRectangle()
        {
            // �͈͎w��p�t�H�[����\�������邽�߁A��ʑS�̂̑傫����\��
            // Rectangle���擾���Ă���
            var w = new TransparentForm(GetAllRectangle());
            w.ShowDialog();
            return w.SelectedRectangle;
        }

        #endregion

        #region Win32API
// ReSharper disable FieldCanBeMadeReadOnly.Local
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("User32.dll")]
        private static extern int GetWindowRect(IntPtr hWnd, out RECT rect);

        [DllImport("User32.dll")]
        private static extern IntPtr GetForegroundWindow();
// ReSharper restore FieldCanBeMadeReadOnly.Local
        #endregion

    }
}