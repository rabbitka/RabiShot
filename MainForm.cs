using System;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RabiShot.SSType;


namespace RabiShot {
    /// <summary>
    /// メイン画面。
    /// </summary>
    public partial class MainForm : Form {
        /// <summary>
        /// コンストラクタ。
        /// </summary>
        public MainForm() {
            InitializeComponent();
        }

        /// <summary>
        /// ウインドウを表示する。
        /// </summary>
        public void ShowWindow() {
            Visible = true;
            if (WindowState == FormWindowState.Minimized) {
                WindowState = FormWindowState.Normal;
            }
            Activate();
        }

        /// <summary>
        /// オプション画面を表示する
        /// </summary>
        public void ShowOption() {
            using(var w = new OptionForm()) {
                w.ShowDialog();
            }
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
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// オプションボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOption_Click(object sender, EventArgs e) {
            ShowOption();
        }

        /// <summary>
        /// 終了ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// ウィンドウサイズ変更時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_ClientSizeChanged(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Hide();
                Program.NotifyIcon.Visible = true;
            }
        }
    }
}
