using System;
using System.Drawing;
using System.Runtime.InteropServices;


namespace RabiShot.SSType {
    /// <summary>
    /// ウィンドウの領域を取得するクラス。
    /// </summary>
    public class CurrentWindow : IType {
        /// <summary>
        /// スクリーンショットを保存する領域を取得する。
        /// </summary>
        /// <returns>スクリーンショットを保存する領域</returns>
        public Rectangle GetRectangle() {
            RECT r;
            IntPtr active = GetForegroundWindow();
            GetWindowRect(active, out r);

            return new Rectangle(r.left, r.top, r.right - r.left, r.bottom - r.top);
        }

        #region Win32API

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        private struct RECT {
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