using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


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
//        public static readonly SSType Any
//            = new SSType("�͈͎w��", GetAnyRectangle);

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

        #region Rectangle�擾���\�b�h

        /// <summary>
        /// ��ʑS��
        /// </summary>
        /// <returns></returns>
        private static Rectangle GetAllRectangle()
        {
            return Screen.AllScreens[Screen.AllScreens.Length - 1].Bounds;
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
            throw new NotImplementedException();
        }

        #endregion

        #region Win32API

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

        #endregion

    }
}