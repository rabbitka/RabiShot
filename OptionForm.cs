using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RabiShot.Format;


namespace RabiShot {
    /// <summary>
    /// オプション画面
    /// </summary>
    public partial class OptionForm : Form {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public OptionForm() {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// 画面の初期化
        /// </summary>
        private void Initialize() {
            var formatList = new[]
                             {
                                 new KeyValuePair<string, ImageFormat>(".png", ImageFormat.Png),
                                 new KeyValuePair<string, ImageFormat>(".bmp", ImageFormat.Bmp),
                                 new KeyValuePair<string, ImageFormat>(".jpg", ImageFormat.Jpeg),
                             };
            cmbImageFormat.DataSource = formatList;
            cmbImageFormat.DisplayMember = "Key";
            cmbImageFormat.ValueMember = "Value";

            //var aspectList = new[]
            //                 {
            //                     new KeyValuePair<string, AspectType>(AspectType.Width.GetName(), AspectType.Width),
            //                     new KeyValuePair<string, AspectType>(AspectType.Height.GetName(), AspectType.Height),
            //                     new KeyValuePair<string, AspectType>(AspectType.Bigger.GetName(), AspectType.Bigger),
            //                     new KeyValuePair<string, AspectType>(AspectType.Smaller.GetName(), AspectType.Smaller)
            //                 };
            //cmbKeepAspect.DataSource = aspectList;
            //cmbKeepAspect.DisplayMember = "Key";
            //cmbKeepAspect.ValueMember = "Value";

            // 保存先
            txtSaveDirectory.Text = Option.SaveDirectory;
            txtFileNameFormat.Text = Option.FileNameFormat;
            cmbImageFormat.SelectedItem = Option.ImageFormat;
            // 後処理
            //            chkDoAfterProcessing.Checked = op.DoAfterProcessing;
            //            chkDoResize.Checked = op.DoResize;
            //            txtWidthBiggerSrc.Text = op.WidthBiggerSrc.ToString();
            //            txtWidthBiggerDest.Text = op.WidthBiggerDest.ToString();
            //            txtWidthLessSrc.Text = op.WidthLessSrc.ToString();
            //            txtWidthLessDest.Text = op.WidthLessDest.ToString();
            //            txtHeightBiggerSrc.Text = op.HeightBiggerSrc.ToString();
            //            txtHeightBiggerDest.Text = op.HeightBiggerDest.ToString();
            //            txtHeightLessSrc.Text = op.HeightLessSrc.ToString();
            //            txtHeightLessDest.Text = op.HeightLessDest.ToString();
            //            chkKeepAspect.Checked = op.KeepAspect;
            //            cmbKeepAspect.SelectedItem = op.AspectType;
            //            chkDoAfterEdit.Checked = op.DoAfterEdit;
            //            txtDoAfterEdit.Text = op.DoAfterEditPath;

            //実装していない機能を隠す
            grpAfter.Visible = false;
            btnCancel.Location = new Point(btnCancel.Location.X, 115);
            btnOK.Location = new Point(btnOK.Location.X, 111);
            Height = 181;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            // データチェック
            if (!Directory.Exists(txtSaveDirectory.Text)) {
                var err = new StringBuilder();
                err.AppendLine(@"以下のフォルダは存在しません。作成しますか？");
                err.Append(txtSaveDirectory.Text);
                var result =
                    MessageBox.Show(
                        err.ToString(),
                        @"保存先フォルダ",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Information);
                if (result == DialogResult.Yes) {
                    Directory.CreateDirectory(txtSaveDirectory.Text);
                } else if (result == DialogResult.No) {
                    MessageBox.Show(@"「保存先ディレクトリ」には存在するフォルダを指定してください。");
                    return;
                } else {
                    return;
                }
            }
            if (IsInvalidFileNameFormat()) {
                MessageBox.Show(
                    @"ファイル名のフォーマットが間違っています。",
                    @"ファイル名",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            
            Option.SaveDirectory = txtSaveDirectory.Text;
            Option.FileNameFormat = txtFileNameFormat.Text;
            Option.ImageFormat = ((KeyValuePair<string, ImageFormat>)cmbImageFormat.SelectedItem).Value;
            // 後処理
            //            op.DoAfterProcessing = chkDoAfterProcessing.Checked;
            //            op.DoResize = chkDoResize.Checked;
            //            op.WidthBiggerSrc = int.Parse(txtWidthBiggerSrc.Text);
            //            op.WidthBiggerDest = int.Parse(txtWidthBiggerDest.Text);
            //            op.WidthLessSrc = int.Parse(txtWidthLessSrc.Text);
            //            op.WidthLessDest = int.Parse(txtWidthLessDest.Text);
            //            op.HeightBiggerSrc = int.Parse(txtHeightBiggerSrc.Text);
            //            op.HeightBiggerDest = int.Parse(txtHeightBiggerDest.Text);
            //            op.HeightLessSrc = int.Parse(txtHeightLessSrc.Text);
            //            op.HeightLessDest = int.Parse(txtHeightLessDest.Text);
            //            op.KeepAspect = chkKeepAspect.Checked;
            //            op.AspectType = ((KeyValuePair<string, AspectType>)cmbKeepAspect.SelectedItem).Value;
            //            op.DoAfterEdit = chkDoAfterEdit.Checked;
            //            op.DoAfterEditPath = txtDoAfterEdit.Text;
            //            op.Save();
            Close();
        }

        /// <summary>
        /// ファイル名のフォーマットが無効でないかチェックする。
        /// </summary>
        /// <returns>無効ならtrueを返す。</returns>
        private bool IsInvalidFileNameFormat() {
            var rx = new Regex(@"<.+?>");
            var rxNum = new Regex(@"<[#0]*0>");

            try {
                var ms = rx.Matches(txtFileNameFormat.Text);
                foreach (var m in ms) {
                    if(rxNum.IsMatch(m.ToString())) {
                        1.ToString(m.ToString().Substring(1, m.ToString().Length - 2));
                        continue;
                    }
                    new DateTimeFormat().Generate(m.ToString());
                }
            } catch {
                return true;
            }
            return false;
        }
    }
}
