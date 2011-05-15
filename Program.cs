using System;
using System.Windows.Forms;
using RabiShot.Core;


namespace RabiShot {
    static class Program {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ホットキー登録
            //            var hAll = new HotKey(0, Keys.PrintScreen);
            //            hAll.HotKeyPush += (sender, e) => SSType.All.GetScreenShot();
            //            var hWindow = new HotKey(MOD_KEY.ALT, Keys.PrintScreen);
            //            hWindow.HotKeyPush += (sender, e) => SSType.CurrentWindow.GetScreenShot();
            //            var hAny = new HotKey(MOD_KEY.CONTROL, Keys.PrintScreen);
            //            hAny.HotKeyPush += (sender, e) => SSType.Any.GetScreenShot();
            //            Application.ApplicationExit += (sender, e) =>
            //                                           {
            //                                               hAll.Dispose();
            //                                               hWindow.Dispose();
            //                                               hAny.Dispose();
            //                                           };

            Application.Run(new MainForm());
        }
    }
}