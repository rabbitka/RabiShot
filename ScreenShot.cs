using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using RabiShot.Format;


namespace RabiShot {
    /// <summary>
    /// スクリーンショットを処理するクラス
    /// </summary>
    public class ScreenShot : IDisposable {
        private Bitmap _raw;
        private Bitmap _processed;
        private readonly string _dir;
        private readonly string _fileFmt;
        private readonly ImageFormat _imgFmt;
        private readonly string _ext;
        private readonly MatchCollection _matches;
        private static readonly Regex Rx = new Regex(@"<.+?>");
        private static readonly Regex RxNum = new Regex(@"<[#0]*0>");

        /// <summary>
        /// コンストラクタ。
        /// </summary>
        public ScreenShot() {
            _dir = Option.SaveDirectory;
            _fileFmt = Option.FileNameFormat;
            _imgFmt = Option.ImageFormat;
            // 拡張子を設定する。Jpegの場合は"jpg"、それ以外は名称をそのままに小文字に変換している。
            _ext = _imgFmt.Equals(ImageFormat.Jpeg) ? "jpg" : _imgFmt.ToString().ToLower();
            _matches = Rx.Matches(_fileFmt);
        }
        /// <summary>
        /// スクリーンショットを保存する範囲を指定したコンストラクタ。
        /// </summary>
        /// <param name="rect">スクリーンショットの範囲</param>
        public ScreenShot(Rectangle rect) : this() {
            SetRectangle(rect);
        }

        /// <summary>
        /// スクリーンショットを保存する範囲を指定する。
        /// </summary>
        /// <param name="rect">スクリーンショットの範囲</param>
        /// <remarks>この値を設定された時点で画像を取得する</remarks>
        public void SetRectangle(Rectangle rect) {
            _raw = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppPArgb);
            using(var g = Graphics.FromImage(_raw)) {
                g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
            }
        }

        /// <summary>
        /// TODO:スクリーンショットをファイルに保存する。
        /// </summary>
        public void Save() {
            // Optionクラスから値を取得し、リサイズする場合のみ呼び出す。
            //Resize();

            //保存処理
            var filePath = CreateFilePath();
            var target = _processed ?? _raw;
            target.Save(filePath);

            //ペイントを開く処理
        }

        /// <summary>
        /// TODO:スクリーンショット画像をリサイズする。
        /// </summary>
        private void Resize() {
            if(_disposed)
                throw new ObjectDisposedException("_raw, _processed");

            if(_raw == null)
                throw new InvalidOperationException("_raw のインスタンスが存在しません。");

            // サイズを取得
            var size = GetSize();

            _processed = new Bitmap(size.Width, size.Height);
            using(var g = Graphics.FromImage(_processed)) {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(_raw, 0, 0, size.Width, size.Height);
            }
        }

        /// <summary>
        /// TODO:画像のサイズを取得する
        /// </summary>
        /// <returns></returns>
        private Size GetSize() {
            return new Size();
        }

        /// <summary>
        /// ファイルパスを生成する。
        /// </summary>
        /// <returns>ファイルパス</returns>
        private string CreateFilePath() {
            var name = _fileFmt;
            var hasNum = false;
            var numFmt = @"0";
            var max = int.MaxValue;

            foreach (var match in _matches) {
                if (RxNum.IsMatch(match.ToString())) {
                    hasNum = true;
                    var m = RxNum.Match(match.ToString());
                    numFmt = m.ToString().Substring(1, m.Length - 2);
                    max = int.Parse(new string('9', m.Length - 2));
                    name = name.Replace(match.ToString(), @"{0}");
                } else {
                    name = name.Replace(match.ToString(), new DateTimeFormat().Generate(match.ToString()));
                }
            }

            var path = CreateFilePath(name);
            if (!hasNum && !File.Exists(path)) {
                return path;
            }
            if (!hasNum) {
                name = name + @" ({0})";
            }
            for(int i = 1; i <= max; i++) {
                path = CreateFilePath(string.Format(name, i.ToString(numFmt)));
                if (!File.Exists(path)) {
                    return path;
                }
            }

            throw new InvalidOperationException();
        }
        /// <summary>
        /// ファイルパスを生成する。
        /// </summary>
        /// <param name="name">ファイル名</param>
        /// <returns>ファイルパス</returns>
        private string CreateFilePath(string name) {
            return Path.Combine(_dir, string.Format(@"{0}.{1}", name, _ext));
        }

        #region Disposeパターン

        private bool _disposed;

        void IDisposable.Dispose() {
            Close();
        }

        public void Close() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if(_disposed)
                return;

            if(disposing) {
                if(_raw != null)
                    _raw.Dispose();
                if(_processed != null)
                    _processed.Dispose();
            }

            _disposed = true;
        }

        #endregion
    }
}