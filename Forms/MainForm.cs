﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RabiShot.Core;
using RabiShot.Options;


namespace RabiShot.Forms
{
    public partial class MainForm : Form
    {
        private HotKey hotKey;

        public MainForm()
        {
            InitializeComponent();

            hotKey = new HotKey(MOD_KEY.ALT, Keys.PrintScreen);
            hotKey.HotKeyPush += btnTake_Click;
        }



        /// <summary>
        /// 撮影ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTake_Click(object sender, EventArgs e)
        {

            Rectangle rect = SSType.Window.GetRectangle();
            var bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppPArgb);

            using(var g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
            }

            var dir = Option.Instance().SaveDirectory;
            if(!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            bmp.Save(Option.Instance().SaveDirectory + "\\test.png", ImageFormat.Png);

            // 画像のサイズ変更前に画像を編集する場合、ここで起動

            // 画像のサイズ変更処理

            // 画像のサイズ変更後に画像を編集する場合、ここで起動

        }
        /// <summary>
        /// 隠すボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHidden_Click(object sender, EventArgs e)
        {

            btnTake_Click(sender, e);

        }
        /// <summary>
        /// オプションボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOption_Click(object sender, EventArgs e)
        {
            var w = new OptionForm();
            w.ShowDialog();
        }
        /// <summary>
        /// 終了ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #region Win32API

            [StructLayout(LayoutKind.Sequential, Pack = 4)]
            private struct RECT
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("User32.dll")]
            private static extern int GetWindowRect(IntPtr hWnd, out RECT rect);

            [DllImport("User32.dll")]
            private static extern IntPtr GetForegroundWindow();

        #endregion

            private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                hotKey.Dispose();
            }

    }
}