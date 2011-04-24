using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace RabiShot
{
    /// <summary>
    /// スクリーンショットを処理するクラス
    /// </summary>
    public class ScreenShot : IDisposable
    {
        private Bitmap _raw;
        private Bitmap _processed;


        public ScreenShot()
        {
            
        }
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
        public void Resize(Size size)
        {
            if(_disposed)
                throw new ObjectDisposedException("_raw, _processed");

            _processed = new Bitmap(size.Width, size.Height);
            using(var g = Graphics.FromImage(_processed))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(_raw, 0, 0, size.Width, size.Height);
            }
        }

        public void Open(string path)
        {
            
        }

        public void Save(string path, ImageFormat format)
        {
            if(_disposed)
                throw new ObjectDisposedException("_raw, _processed");


        }

        #region Disposeパターン

        private bool _disposed;

        public void Dispose()
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
