using System.Drawing.Imaging;


namespace RabiShot {
    /// <summary>
    /// 設定を保持するクラス。
    /// </summary>
    public class Option {
        /// <summary>
        /// 設定ファイルのファイル名
        /// </summary>
        private static readonly string OptionFileName = "option.xml";

        /// <summary>
        /// Optionクラスのインスタンスを保持する。
        /// </summary>
        private static Option _instance;

        /// <summary>
        /// 保存先ディレクトリを取得または設定する。
        /// </summary>
        public string SaveDirectory { get; set; }

        /// <summary>
        /// ファイル名のフォーマットを取得または設定する。
        /// </summary>
        public string FileNameFormat { get; set; }

        /// <summary>
        /// ファイルのフォーマットを取得または設定する。
        /// </summary>
        public ImageFormat ImageFormat { get; set; }

        /// <summary>
        /// Optionクラスのインスタンスを取得する。
        /// </summary>
        /// <returns></returns>
        public static Option Instance() {
            if (_instance == null) {
                _instance = new Option();
            }

            return _instance;
        }
    }
}
