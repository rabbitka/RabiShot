using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace RabiShot.Core
{
    /// <summary>
    /// スクリーンショットの種類
    /// </summary>
    public class SSType
    {
        /// <summary>
        /// 画面全体
        /// </summary>
        public static readonly SSType All
            = new SSType("画面全体", GetAllRectangle);
        /// <summary>
        /// ウィンドウ
        /// </summary>
        public static readonly SSType Window
            = new SSType("ウィンドウ", GetWindowRectangle);
        /// <summary>
        /// 範囲指定
        /// </summary>
//        public static readonly SSType Any
//            = new SSType("範囲指定", GetAnyRectangle);

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

        #region Rectangle取得メソッド

        /// <summary>
        /// 画面全体
        /// </summary>
        /// <returns></returns>
        private static Rectangle GetAllRectangle()
        {
            return Screen.AllScreens[Screen.AllScreens.Length - 1].Bounds;
        }
        /// <summary>
        /// ウィンドウ
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
        /// 範囲指定
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