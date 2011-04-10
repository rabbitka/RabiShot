using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RabiShot.Core;


namespace RabiShot
{
    public partial class MainForm : Form
    {
        private HotKey hotKey;

        public MainForm()
        {
            InitializeComponent();

//            hotKey = new HotKey(MOD_KEY.ALT, Keys.PrintScreen);
//            hotKey.HotKeyPush += btnTake_Click;
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
        private void btnHidden_Click(object sender, EventArgs e)
        {
            SSType.Window.GetScreenShot();

            return;

            int x = 0, y = 0, width = 0, height = 0;

            foreach (var screen in Screen.AllScreens)
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

            var w = new SpecifiedRangeForm(new Rectangle(x, y, width, height));
            w.ShowDialog();
            var rect = w.SelectedRectangle;

            
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

            private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                hotKey.Dispose();
            }

    }
}
