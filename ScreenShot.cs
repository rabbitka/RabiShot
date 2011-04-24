using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using RabiShot.Extensions;


namespace RabiShot
{
    /// <summary>
    /// スクリーンショットを処理するクラス
    /// </summary>
    public class ScreenShot : IDisposable
    {
        private Bitmap _raw;
        private Bitmap _processed;

        /// <summary>
        /// クラスを初期化する。
        /// </summary>
        public ScreenShot()
        { }
        /// <summary>
        /// スクリーンショットを撮影する範囲を指定してクラスを初期化する。
        /// </summary>
        /// <param name="rect"></param>
        public ScreenShot(Rectangle rect)
        {
            SetRectangle(rect);
        }

        /// <summary>
        /// スクリーンショットを撮影する範囲を指定する。
        /// </summary>
        /// <param name="rect">スクリーンショットの範囲</param>
        /// <remarks>この値を設定された時点で画像を取得する</remarks>
        public void SetRectangle(Rectangle rect)
        {
            _raw = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppPArgb);
            using(var g = Graphics.FromImage(_raw))
            {
                g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
            }
        }

        /// <summary>
        /// スクリーンショットをリサイズする
        /// </summary>
        /// <param name="size">リサイズするサイズ</param>
        public void Resize(Size size)
        {
            if(_disposed)
                throw new ObjectDisposedException("_raw, _processed");

            if(_raw == null)
                throw new InvalidOperationException("_raw のインスタンスが存在しません。");

            _processed = new Bitmap(size.Width, size.Height);
            using(var g = Graphics.FromImage(_processed))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(_raw, 0, 0, size.Width, size.Height);
            }
        }

        /// <summary>
        /// スクリーンショットを保存する
        /// </summary>
        /// <param name="path">保存先のパス</param>
        /// <param name="format">スクリーンショットの保存形式</param>
        public void Save(string path, ImageFormat format)
        {
            if(_disposed)
                throw new ObjectDisposedException("_raw, _processed");

            if(_raw == null)
                throw new InvalidOperationException("_raw のインスタンスが存在しません。");

            // 処理後の画像が存在する場合はそれを保存し、そうでない場合は取得時の画像を保存している
            Bitmap target = _processed ?? _raw;

            string dir = Path.GetDirectoryName(path);
            string fileName = Path.GetFileName(path);
            string extension = format.GetExtension();

            if(File.Exists(CreatePath(dir, fileName, extension)))
            {
                foreach(var i in Enumerable.Range(1, int.MaxValue))
                {
                    fileName = string.Format(
                        "{0} ({1})",
                        Path.GetFileName(path),
                        i);

                    if(!File.Exists(CreatePath(dir, fileName, extension)))
                        break;
                }
            }

            target.Save(CreatePath(dir, fileName, extension), format);
        }

        private static string CreatePath(string dir, string fileName, string extension)
        {
            if(string.IsNullOrEmpty(fileName))
                throw new ArgumentNullException("fileName");
            if(string.IsNullOrEmpty(extension))
                throw new ArgumentNullException("extension");

            return Path.Combine(dir, string.Format("{0}.{1}", fileName, extension));
        }


        #region Disposeパターン

        private bool _disposed;

        void IDisposable.Dispose()
        {
            Close();
        }

        public void Close()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(_disposed)
                return;

            if(disposing)
            {
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
