using System;
using System.Drawing.Imaging;
using RabiShot.Settings;


namespace RabiShot {
    /// <summary>
    /// 設定を保持するクラス。
    /// </summary>
    public class Option : XmlSettingBase {
        /// <summary>
        /// 設定ファイルのファイル名。
        /// </summary>
        private static string FileName = @"Option.xml";

        /// <summary>
        /// Optionクラスのインスタンス。
        /// </summary>
        private static Option _instance;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Option() {
            Dic.Add("SaveDirectory", ".\\ss");
            Dic.Add("FileNameFormat", "ss-<000>");
            Dic.Add("ImageFormat", StringFromImageFormat(ImageFormat.Png));
        }

        /// <summary>
        /// Optionクラスのインスタンスを取得する。
        /// </summary>
        /// <returns></returns>
        public static Option Instance() {
            if (_instance == null) {
                _instance = new Option();
                Load();
            }
            return _instance;
        }

        /// <summary>
        /// 保存先ディレクトリを取得または設定する。
        /// </summary>
        public string SaveDirectory {
            get { return Dic["SaveDirectory"]; }
            set { Dic["SaveDirectory"] = value; }
        }

        /// <summary>
        /// ファイル名のフォーマットを取得または設定する。
        /// </summary>
        public string FileNameFormat {
            get { return Dic["FileNameFormat"]; }
            set { Dic["FileNameFormat"] = value; }
        }

        /// <summary>
        /// ファイルのフォーマットを取得または設定する。
        /// </summary>
        public ImageFormat ImageFormat {
            get { return ImageFormatFromString(Dic["ImageFormat"]); }
            set { Dic["ImageFormat"] = StringFromImageFormat(value); }
        }

        /// <summary>
        /// 設定ファイルを読み込む。
        /// </summary>
        public static void Load() {
            if (_instance == null) {
                throw new InvalidOperationException("インスタンスが生成されていません。");
            }
            _instance.Load(FileName);
        }

        /// <summary>
        /// 設定した値を保存する。
        /// </summary>
        public static void Save() {
            if (_instance == null) {
                throw new InvalidOperationException("インスタンスが生成されていません。");
            }
            _instance.Save(FileName);
        }

        #region ImageFormat support.

        private static ImageFormat ImageFormatFromString(string fmt) {
            if(string.IsNullOrEmpty(fmt)) {
                return ImageFormat.Png;
            }
            switch(fmt) {
                case "png":
                    return ImageFormat.Png;
                case "jpg":
                    return ImageFormat.Jpeg;
                case "bmp":
                    return ImageFormat.Bmp;
                case "gif":
                    return ImageFormat.Gif;
            }
            throw new ArgumentException("fmt");
        }
        private static string StringFromImageFormat(ImageFormat fmt) {
            if(fmt == null) {
                return ImageFormat.Png.ToString().ToLower();
            }
            return fmt == ImageFormat.Jpeg ? "jpg" : fmt.ToString().ToLower();
        }

        #endregion
    }
}
