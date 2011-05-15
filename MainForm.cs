using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RabiShot.Core;
using RabiShot.SSType;


namespace RabiShot
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 隠すボタンクリック時
        /// </summary>
        /// <remarks>
        /// プログラムを終了せず、通知領域のみに表示させる。
        /// テスト時にはこのボタンを使用して動作を確認。
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHidden_Click(object sender, EventArgs e) {
            new FreeArea().GetRectangle();
        }
        /// <summary>
        /// オプションボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOption_Click(object sender, EventArgs e)
        {
            var w = new OptionForm();
            w.ShowDialog();
        }
        /// <summary>
        /// 終了ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
