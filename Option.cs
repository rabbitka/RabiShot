using System;
using System.Drawing.Imaging;


namespace RabiShot {
    /// <summary>
    /// 設定を保持するクラス。
    /// </summary>
    public static class Option {

        static Option() {
            if (string.IsNullOrEmpty(SaveDirectory)) {
                SaveDirectory = @".\ss";
            }
            if (string.IsNullOrEmpty(FileNameFormat)) {
                FileNameFormat = @"ss-<000>";
            }
            if (string.IsNullOrEmpty(RabiShot.Default.ImageFormat)) {
                ImageFormat = ImageFormat.Png;
            }
        }

        /// <summary>
        /// 保存先ディレクトリを取得または設定する。
        /// </summary>
        public static string SaveDirectory {
            get { return RabiShot.Default.SaveDirectory; }
            set { RabiShot.Default.SaveDirectory = value; }
        }

        /// <summary>
        /// ファイル名のフォーマットを取得または設定する。
        /// </summary>
        public static string FileNameFormat {
            get { return RabiShot.Default.FileNameFormat; }
            set { RabiShot.Default.FileNameFormat = value; }

        }

        /// <summary>
        /// ファイルのフォーマットを取得または設定する。
        /// </summary>
        public static ImageFormat ImageFormat {
            get { return ImageFormatFromString(RabiShot.Default.ImageFormat); }
            set { RabiShot.Default.ImageFormat = StringFromImageFormat(value); }
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


        /// <summary>
        /// 設定した値を保存する。
        /// </summary>
        public static void Save() {
            RabiShot.Default.Save();
        }
    }
}
