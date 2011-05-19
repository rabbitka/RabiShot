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
        /// 隠すボタンクリック時
        /// </summary>
        /// <remarks>
        /// プログラムを終了せず、通知領域のみに表示させる。
        /// テスト時にはこのボタンを使用して動作を確認。
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHidden_Click(object sender, EventArgs e) {
            using(var ss = new ScreenShot(new FreeArea().GetRectangle())) {
                ss.Save();
            }
        }
        /// <summary>
        /// オプションボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOption_Click(object sender, EventArgs e) {
            using(var w = new OptionForm()) {
                w.ShowDialog();
            }
        }

        /// <summary>
        /// 終了ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
