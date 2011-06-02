using System;
using System.Drawing;
using System.Runtime.InteropServices;


namespace RabiShot.SSType {
    /// <summary>
    /// �E�B���h�E�̗̈���擾����N���X�B
    /// </summary>
    public class CurrentWindow : IType {
        /// <summary>
        /// �X�N���[���V���b�g��ۑ�����̈���擾����B
        /// </summary>
        /// <returns>�X�N���[���V���b�g��ۑ�����̈�</returns>
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