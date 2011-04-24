﻿using System;
using System.Drawing;
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
            
        }

        /// <summary>
        /// スクリーンショットをリサイズする
        /// </summary>
        public void Resize()
        {
            if(_disposed)
                throw new ObjectDisposedException("_raw, _processed");
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
