using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RabiShot.Options;

namespace RabiShot.Forms
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// 画面の初期化
        /// </summary>
        protected void Initialize()
        {

            var formatList = new KeyValuePair<string, ImageFormat>[]
            {
                new KeyValuePair<string, ImageFormat>(".png", ImageFormat.Png), 
                new KeyValuePair<string, ImageFormat>(".bmp", ImageFormat.Bmp), 
                new KeyValuePair<string, ImageFormat>(".jpg", ImageFormat.Jpeg), 
            };
            cmbImageFormat.DataSource = formatList;
            cmbImageFormat.DisplayMember = "Key";
            cmbImageFormat.ValueMember = "Value";

            var aspectList = new KeyValuePair<string, AspectType>[]
            {
                new KeyValuePair<string, AspectType>(AspectType.Width.GetName(), AspectType.Width),
                new KeyValuePair<string, AspectType>(AspectType.Height.GetName(), AspectType.Height),
                new KeyValuePair<string, AspectType>(AspectType.Bigger.GetName(), AspectType.Bigger),
                new KeyValuePair<string, AspectType>(AspectType.Smaller.GetName(), AspectType.Smaller)
            };
            cmbKeepAspect.DataSource = aspectList;
            cmbKeepAspect.DisplayMember = "Key";
            cmbKeepAspect.ValueMember = "Value";

            var op = Option.Instance();
            // 保存先
            txtSaveDirectory.Text = op.SaveDirectory;
            txtPrefix.Text = op.FilePrefix;
            txtSerial.Text = op.SerialFormat;
            txtSuffix.Text = op.FileSuffix;
            cmbImageFormat.SelectedItem = op.Format;
            // 後処理
            chkDoAfterProcessing.Checked = op.DoAfterProcessing;
            chkDoBeforeEdit.Checked = op.DoBeforeEdit;
            txtDoBeforeEdit.Text = op.DoBeforeEditPath;
            chkDoResize.Checked = op.DoResize;
            txtWidthBiggerSrc.Text = op.WidthBiggerSrc.ToString();
            txtWidthBiggerDest.Text = op.WidthBiggerDest.ToString();
            txtWidthLessSrc.Text = op.WidthLessSrc.ToString();
            txtWidthLessDest.Text = op.WidthLessDest.ToString();
            txtHeightBiggerSrc.Text = op.HeightBiggerSrc.ToString();
            txtHeightBiggerDest.Text = op.HeightBiggerDest.ToString();
            txtHeightLessSrc.Text = op.HeightLessSrc.ToString();
            txtHeightLessDest.Text = op.HeightLessDest.ToString();
            chkKeepAspect.Checked = op.KeepAspect;
            cmbKeepAspect.SelectedItem = op.AspectType;
            chkDoAfterEdit.Checked = op.DoAfterEdit;
            txtDoAfterEdit.Text = op.DoAfterEditPath;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // データチェック

            var op = Option.Instance();
            // 保存先
            op.SaveDirectory = txtSaveDirectory.Text;
            op.FilePrefix = txtPrefix.Text;
            op.SerialFormat = txtSerial.Text;
            op.FileSuffix = txtSuffix.Text;
            op.Format = ((KeyValuePair<string, ImageFormat>)cmbImageFormat.SelectedItem).Value;
            // 後処理
            op.DoAfterProcessing = chkDoAfterProcessing.Checked;
            op.DoBeforeEdit = chkDoBeforeEdit.Checked;
            op.DoBeforeEditPath = txtDoBeforeEdit.Text;
            op.DoResize = chkDoResize.Checked;
            op.WidthBiggerSrc = int.Parse(txtWidthBiggerSrc.Text);
            op.WidthBiggerDest = int.Parse(txtWidthBiggerDest.Text);
            op.WidthLessSrc = int.Parse(txtWidthLessSrc.Text);
            op.WidthLessDest = int.Parse(txtWidthLessDest.Text);
            op.HeightBiggerSrc = int.Parse(txtHeightBiggerSrc.Text);
            op.HeightBiggerDest = int.Parse(txtHeightBiggerDest.Text);
            op.HeightLessSrc = int.Parse(txtHeightLessSrc.Text);
            op.HeightLessDest = int.Parse(txtHeightLessDest.Text);
            op.KeepAspect = chkKeepAspect.Checked;
            op.AspectType = ((KeyValuePair<string, AspectType>)cmbKeepAspect.SelectedItem).Value;
            op.DoAfterEdit = chkDoAfterEdit.Checked;
            op.DoAfterEditPath = txtDoAfterEdit.Text;
            op.Save();
            btnCancel_Click(sender, e);
        }

    }
}
