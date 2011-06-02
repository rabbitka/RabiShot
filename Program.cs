using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using RabiShot.SSType;


namespace RabiShot {
    static class Program {

        internal static NotifyIcon NotifyIcon;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var w = new MainForm();

            RegisterHotKeys(w);

            RegisterNotifyIcon(w);

            Application.Run();
        }

        private static void TakeAll() {
            Take(new DisplayAll());
        }

        private static void TakeCurrentWindow() {
            Take(new CurrentWindow());
        }

        private static void TakeFreeArea() {
            Take(new FreeArea());
        }

        private static void Take(IType t) {
            using (var ss = new ScreenShot(t)) {
                ss.Save();
            }
        }

        #region HoeKeyのインスタンス

        private static HotKey _hkAll;
        private static HotKey _hkWindow;
        private static HotKey _hkFree;

        #endregion

        /// <summary>
        /// ホットキーを登録する
        /// </summary>
        /// <param name="form"></param>
        private static void RegisterHotKeys(Form form) {
            // ホットキー登録
            _hkAll = new HotKey(0, Keys.PrintScreen);
            _hkAll.HotKeyPush += (sender, e) => TakeAll();
            _hkWindow = new HotKey(MOD_KEY.ALT, Keys.PrintScreen);
            _hkWindow.HotKeyPush += (sender, e) => TakeCurrentWindow();
            _hkFree = new HotKey(MOD_KEY.CONTROL, Keys.PrintScreen);
            _hkFree.HotKeyPush += (sender, e) => TakeFreeArea();

            // アプリケーション終了処理
            Application.ApplicationExit += (sender, e) => {
                _hkAll.Dispose();
                _hkWindow.Dispose();
                _hkFree.Dispose();
            };
        }

        #region ContextMenuのインスタンス

        private static ContextMenuStrip _menu;
        private static ToolStripMenuItem _tiShowMainWindow;
        private static ToolStripMenuItem _tiShowOption;
        private static ToolStripMenuItem _tlOpenSaveDirectory;
        private static ToolStripMenuItem _tlShowAbout;
        private static ToolStripMenuItem _tlClose;

        #endregion


        /// <summary>
        /// 通知アイコンを登録する
        /// </summary>
        /// <param name="form">MainFormのインスタンス</param>
        private static void RegisterNotifyIcon(MainForm form) {
            // 通知アイコン設定
            NotifyIcon = new NotifyIcon {
                Icon = new Icon("RabiShot.ico"),
                Visible = true
            };
            NotifyIcon.DoubleClick += (sender, e) => {
                form.ShowWindow();
                NotifyIcon.Visible = false;
            };
            Application.ApplicationExit += (sender, e) => {
                NotifyIcon.Dispose();
            };

            // 右クリックメニューの登録
            _menu = new ContextMenuStrip();

            // ウインドウ表示
            _tiShowMainWindow = new ToolStripMenuItem();
            _tiShowMainWindow.Text = @"ウインドウ表示";
            _tiShowMainWindow.Click += (sender, e) => {
                form.ShowWindow();
            };
            _menu.Items.Add(_tiShowMainWindow);

            // セパレータ
            _menu.Items.Add(new ToolStripSeparator());

            // オプション
            _tiShowOption = new ToolStripMenuItem();
            _tiShowOption.Text = @"オプション";
            _tiShowOption.Click += (sender, e) => {
                form.ShowOption();
            };
            _menu.Items.Add(_tiShowOption);
            
            // 保存先を開く
            _tlOpenSaveDirectory = new ToolStripMenuItem();
            _tlOpenSaveDirectory.Text = @"保存先を開く";
            _tlOpenSaveDirectory.Click += (sender, e) => {
                Process.Start("explorer.exe", @"/n, " + Option.Instance().SaveDirectory);
            };
            _menu.Items.Add(_tlOpenSaveDirectory);

            // セパレータ
            _menu.Items.Add(new ToolStripSeparator());

            // RabiShotについて
            _tlShowAbout = new ToolStripMenuItem();
            _tlShowAbout.Text = @"RabiShotについて";
            _tlShowAbout.Click += (sender, e) => {
                MessageBox.Show("未実装");
            };
            _menu.Items.Add(_tlShowAbout);

            // 終了
            _tlClose = new ToolStripMenuItem();
            _tlClose.Text = @"終了";
            _tlClose.Click += (sender, e) => {
                Application.Exit();
            };
            _menu.Items.Add(_tlClose);

            // アプリケーション終了処理
            Application.ApplicationExit += (sender, e) => {
                _menu.Dispose();
                _tiShowMainWindow.Dispose();
                _tiShowOption.Dispose();
                _tlOpenSaveDirectory.Dispose();
                _tlShowAbout.Dispose();
                _tlClose.Dispose();
            };

            NotifyIcon.ContextMenuStrip = _menu;
        }
    }
}