namespace RabiShot
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaveDirectory = new System.Windows.Forms.Label();
            this.txtSaveDirectory = new System.Windows.Forms.TextBox();
            this.btnSaveDirectory = new System.Windows.Forms.Button();
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.lblImageFormat = new System.Windows.Forms.Label();
            this.cmbImageFormat = new System.Windows.Forms.ComboBox();
            this.txtFileNameFormat = new System.Windows.Forms.TextBox();
            this.lblFileNameFormat = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkDoAfterProcessing = new System.Windows.Forms.CheckBox();
            this.chkKeepAspect = new System.Windows.Forms.CheckBox();
            this.chkDoResize = new System.Windows.Forms.CheckBox();
            this.chkDoAfterEdit = new System.Windows.Forms.CheckBox();
            this.btnDoAfterEdit = new System.Windows.Forms.Button();
            this.txtDoAfterEdit = new System.Windows.Forms.TextBox();
            this.lblWidthBigger01 = new System.Windows.Forms.Label();
            this.lblHeightBigger01 = new System.Windows.Forms.Label();
            this.lblWidthBigger02 = new System.Windows.Forms.Label();
            this.lblHeightBigger02 = new System.Windows.Forms.Label();
            this.lblWidthLess01 = new System.Windows.Forms.Label();
            this.lblHeightLess01 = new System.Windows.Forms.Label();
            this.lblKeepAspect01 = new System.Windows.Forms.Label();
            this.lblKeepAspect02 = new System.Windows.Forms.Label();
            this.lblWidthBigger03 = new System.Windows.Forms.Label();
            this.lblHeightBigger03 = new System.Windows.Forms.Label();
            this.lblWidthLess02 = new System.Windows.Forms.Label();
            this.lblHeightLess02 = new System.Windows.Forms.Label();
            this.txtWidthBiggerSrc = new System.Windows.Forms.TextBox();
            this.txtHeightBiggerSrc = new System.Windows.Forms.TextBox();
            this.lblWidthLess03 = new System.Windows.Forms.Label();
            this.lblHeightLess03 = new System.Windows.Forms.Label();
            this.txtWidthLessSrc = new System.Windows.Forms.TextBox();
            this.txtHeightLessSrc = new System.Windows.Forms.TextBox();
            this.txtWidthBiggerDest = new System.Windows.Forms.TextBox();
            this.txtHeightBiggerDest = new System.Windows.Forms.TextBox();
            this.txtWidthLessDest = new System.Windows.Forms.TextBox();
            this.txtHeightLessDest = new System.Windows.Forms.TextBox();
            this.cmbKeepAspect = new System.Windows.Forms.ComboBox();
            this.grpAfter = new System.Windows.Forms.GroupBox();
            this.grpSave.SuspendLayout();
            this.grpAfter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaveDirectory
            // 
            this.lblSaveDirectory.AutoSize = true;
            this.lblSaveDirectory.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSaveDirectory.Location = new System.Drawing.Point(6, 15);
            this.lblSaveDirectory.Name = "lblSaveDirectory";
            this.lblSaveDirectory.Size = new System.Drawing.Size(40, 12);
            this.lblSaveDirectory.TabIndex = 0;
            this.lblSaveDirectory.Text = "フォルダ";
            // 
            // txtSaveDirectory
            // 
            this.txtSaveDirectory.Location = new System.Drawing.Point(8, 30);
            this.txtSaveDirectory.Name = "txtSaveDirectory";
            this.txtSaveDirectory.Size = new System.Drawing.Size(283, 19);
            this.txtSaveDirectory.TabIndex = 1;
            // 
            // btnSaveDirectory
            // 
            this.btnSaveDirectory.Location = new System.Drawing.Point(297, 28);
            this.btnSaveDirectory.Name = "btnSaveDirectory";
            this.btnSaveDirectory.Size = new System.Drawing.Size(48, 23);
            this.btnSaveDirectory.TabIndex = 2;
            this.btnSaveDirectory.Text = "参照...";
            this.btnSaveDirectory.UseVisualStyleBackColor = true;
            // 
            // grpSave
            // 
            this.grpSave.Controls.Add(this.lblImageFormat);
            this.grpSave.Controls.Add(this.cmbImageFormat);
            this.grpSave.Controls.Add(this.txtFileNameFormat);
            this.grpSave.Controls.Add(this.lblFileNameFormat);
            this.grpSave.Controls.Add(this.lblSaveDirectory);
            this.grpSave.Controls.Add(this.btnSaveDirectory);
            this.grpSave.Controls.Add(this.txtSaveDirectory);
            this.grpSave.Location = new System.Drawing.Point(12, 12);
            this.grpSave.Name = "grpSave";
            this.grpSave.Size = new System.Drawing.Size(359, 93);
            this.grpSave.TabIndex = 0;
            this.grpSave.TabStop = false;
            this.grpSave.Text = "保存先";
            // 
            // lblImageFormat
            // 
            this.lblImageFormat.AutoSize = true;
            this.lblImageFormat.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblImageFormat.Location = new System.Drawing.Point(294, 52);
            this.lblImageFormat.Name = "lblImageFormat";
            this.lblImageFormat.Size = new System.Drawing.Size(53, 12);
            this.lblImageFormat.TabIndex = 10;
            this.lblImageFormat.Text = "画像形式";
            // 
            // cmbImageFormat
            // 
            this.cmbImageFormat.FormattingEnabled = true;
            this.cmbImageFormat.Location = new System.Drawing.Point(296, 67);
            this.cmbImageFormat.Name = "cmbImageFormat";
            this.cmbImageFormat.Size = new System.Drawing.Size(48, 20);
            this.cmbImageFormat.TabIndex = 11;
            // 
            // txtFileNameFormat
            // 
            this.txtFileNameFormat.Location = new System.Drawing.Point(8, 68);
            this.txtFileNameFormat.Name = "txtFileNameFormat";
            this.txtFileNameFormat.Size = new System.Drawing.Size(283, 19);
            this.txtFileNameFormat.TabIndex = 5;
            // 
            // lblFileNameFormat
            // 
            this.lblFileNameFormat.AutoSize = true;
            this.lblFileNameFormat.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFileNameFormat.Location = new System.Drawing.Point(6, 52);
            this.lblFileNameFormat.Name = "lblFileNameFormat";
            this.lblFileNameFormat.Size = new System.Drawing.Size(51, 12);
            this.lblFileNameFormat.TabIndex = 3;
            this.lblFileNameFormat.Text = "ファイル名";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(296, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "適用";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkDoAfterProcessing
            // 
            this.chkDoAfterProcessing.AutoSize = true;
            this.chkDoAfterProcessing.Location = new System.Drawing.Point(8, 18);
            this.chkDoAfterProcessing.Name = "chkDoAfterProcessing";
            this.chkDoAfterProcessing.Size = new System.Drawing.Size(206, 16);
            this.chkDoAfterProcessing.TabIndex = 0;
            this.chkDoAfterProcessing.Text = "スクリーンショット取得後、後処理をする";
            this.chkDoAfterProcessing.UseVisualStyleBackColor = true;
            // 
            // chkKeepAspect
            // 
            this.chkKeepAspect.AutoSize = true;
            this.chkKeepAspect.Location = new System.Drawing.Point(44, 144);
            this.chkKeepAspect.Name = "chkKeepAspect";
            this.chkKeepAspect.Size = new System.Drawing.Size(132, 16);
            this.chkKeepAspect.TabIndex = 25;
            this.chkKeepAspect.Text = "アスペクト比を保持する";
            this.chkKeepAspect.UseVisualStyleBackColor = true;
            // 
            // chkDoResize
            // 
            this.chkDoResize.AutoSize = true;
            this.chkDoResize.Location = new System.Drawing.Point(26, 40);
            this.chkDoResize.Name = "chkDoResize";
            this.chkDoResize.Size = new System.Drawing.Size(139, 16);
            this.chkDoResize.TabIndex = 4;
            this.chkDoResize.Text = "画像のサイズを変更する";
            this.chkDoResize.UseVisualStyleBackColor = true;
            // 
            // chkDoAfterEdit
            // 
            this.chkDoAfterEdit.AutoSize = true;
            this.chkDoAfterEdit.Location = new System.Drawing.Point(26, 204);
            this.chkDoAfterEdit.Name = "chkDoAfterEdit";
            this.chkDoAfterEdit.Size = new System.Drawing.Size(174, 16);
            this.chkDoAfterEdit.TabIndex = 29;
            this.chkDoAfterEdit.Text = "サイズ変更後に画像を編集する";
            this.chkDoAfterEdit.UseVisualStyleBackColor = true;
            // 
            // btnDoAfterEdit
            // 
            this.btnDoAfterEdit.Location = new System.Drawing.Point(305, 224);
            this.btnDoAfterEdit.Name = "btnDoAfterEdit";
            this.btnDoAfterEdit.Size = new System.Drawing.Size(48, 23);
            this.btnDoAfterEdit.TabIndex = 31;
            this.btnDoAfterEdit.Text = "参照...";
            this.btnDoAfterEdit.UseVisualStyleBackColor = true;
            // 
            // txtDoAfterEdit
            // 
            this.txtDoAfterEdit.Location = new System.Drawing.Point(44, 226);
            this.txtDoAfterEdit.Name = "txtDoAfterEdit";
            this.txtDoAfterEdit.Size = new System.Drawing.Size(255, 19);
            this.txtDoAfterEdit.TabIndex = 30;
            // 
            // lblWidthBigger01
            // 
            this.lblWidthBigger01.AutoSize = true;
            this.lblWidthBigger01.Location = new System.Drawing.Point(42, 59);
            this.lblWidthBigger01.Name = "lblWidthBigger01";
            this.lblWidthBigger01.Size = new System.Drawing.Size(27, 12);
            this.lblWidthBigger01.TabIndex = 5;
            this.lblWidthBigger01.Text = "幅が";
            // 
            // lblHeightBigger01
            // 
            this.lblHeightBigger01.AutoSize = true;
            this.lblHeightBigger01.Location = new System.Drawing.Point(41, 101);
            this.lblHeightBigger01.Name = "lblHeightBigger01";
            this.lblHeightBigger01.Size = new System.Drawing.Size(35, 12);
            this.lblHeightBigger01.TabIndex = 15;
            this.lblHeightBigger01.Text = "高さが";
            // 
            // lblWidthBigger02
            // 
            this.lblWidthBigger02.AutoSize = true;
            this.lblWidthBigger02.Location = new System.Drawing.Point(118, 59);
            this.lblWidthBigger02.Name = "lblWidthBigger02";
            this.lblWidthBigger02.Size = new System.Drawing.Size(63, 12);
            this.lblWidthBigger02.TabIndex = 7;
            this.lblWidthBigger02.Text = "以上の場合";
            // 
            // lblHeightBigger02
            // 
            this.lblHeightBigger02.AutoSize = true;
            this.lblHeightBigger02.Location = new System.Drawing.Point(118, 101);
            this.lblHeightBigger02.Name = "lblHeightBigger02";
            this.lblHeightBigger02.Size = new System.Drawing.Size(63, 12);
            this.lblHeightBigger02.TabIndex = 17;
            this.lblHeightBigger02.Text = "以上の場合";
            // 
            // lblWidthLess01
            // 
            this.lblWidthLess01.AutoSize = true;
            this.lblWidthLess01.Location = new System.Drawing.Point(41, 80);
            this.lblWidthLess01.Name = "lblWidthLess01";
            this.lblWidthLess01.Size = new System.Drawing.Size(27, 12);
            this.lblWidthLess01.TabIndex = 10;
            this.lblWidthLess01.Text = "幅が";
            // 
            // lblHeightLess01
            // 
            this.lblHeightLess01.AutoSize = true;
            this.lblHeightLess01.Location = new System.Drawing.Point(41, 122);
            this.lblHeightLess01.Name = "lblHeightLess01";
            this.lblHeightLess01.Size = new System.Drawing.Size(35, 12);
            this.lblHeightLess01.TabIndex = 20;
            this.lblHeightLess01.Text = "高さが";
            // 
            // lblKeepAspect01
            // 
            this.lblKeepAspect01.AutoSize = true;
            this.lblKeepAspect01.Location = new System.Drawing.Point(60, 163);
            this.lblKeepAspect01.Name = "lblKeepAspect01";
            this.lblKeepAspect01.Size = new System.Drawing.Size(139, 12);
            this.lblKeepAspect01.TabIndex = 26;
            this.lblKeepAspect01.Text = "複数の条件が一致した場合";
            // 
            // lblKeepAspect02
            // 
            this.lblKeepAspect02.AutoSize = true;
            this.lblKeepAspect02.Location = new System.Drawing.Point(186, 181);
            this.lblKeepAspect02.Name = "lblKeepAspect02";
            this.lblKeepAspect02.Size = new System.Drawing.Size(57, 12);
            this.lblKeepAspect02.TabIndex = 28;
            this.lblKeepAspect02.Text = "を優先する";
            // 
            // lblWidthBigger03
            // 
            this.lblWidthBigger03.AutoSize = true;
            this.lblWidthBigger03.Location = new System.Drawing.Point(229, 59);
            this.lblWidthBigger03.Name = "lblWidthBigger03";
            this.lblWidthBigger03.Size = new System.Drawing.Size(57, 12);
            this.lblWidthBigger03.TabIndex = 9;
            this.lblWidthBigger03.Text = "に縮小する";
            // 
            // lblHeightBigger03
            // 
            this.lblHeightBigger03.AutoSize = true;
            this.lblHeightBigger03.Location = new System.Drawing.Point(229, 101);
            this.lblHeightBigger03.Name = "lblHeightBigger03";
            this.lblHeightBigger03.Size = new System.Drawing.Size(57, 12);
            this.lblHeightBigger03.TabIndex = 19;
            this.lblHeightBigger03.Text = "に縮小する";
            // 
            // lblWidthLess02
            // 
            this.lblWidthLess02.AutoSize = true;
            this.lblWidthLess02.Location = new System.Drawing.Point(118, 80);
            this.lblWidthLess02.Name = "lblWidthLess02";
            this.lblWidthLess02.Size = new System.Drawing.Size(63, 12);
            this.lblWidthLess02.TabIndex = 12;
            this.lblWidthLess02.Text = "以下の場合";
            // 
            // lblHeightLess02
            // 
            this.lblHeightLess02.AutoSize = true;
            this.lblHeightLess02.Location = new System.Drawing.Point(118, 122);
            this.lblHeightLess02.Name = "lblHeightLess02";
            this.lblHeightLess02.Size = new System.Drawing.Size(63, 12);
            this.lblHeightLess02.TabIndex = 22;
            this.lblHeightLess02.Text = "以下の場合";
            // 
            // txtWidthBiggerSrc
            // 
            this.txtWidthBiggerSrc.Location = new System.Drawing.Point(76, 56);
            this.txtWidthBiggerSrc.Name = "txtWidthBiggerSrc";
            this.txtWidthBiggerSrc.Size = new System.Drawing.Size(36, 19);
            this.txtWidthBiggerSrc.TabIndex = 6;
            // 
            // txtHeightBiggerSrc
            // 
            this.txtHeightBiggerSrc.Location = new System.Drawing.Point(76, 98);
            this.txtHeightBiggerSrc.Name = "txtHeightBiggerSrc";
            this.txtHeightBiggerSrc.Size = new System.Drawing.Size(36, 19);
            this.txtHeightBiggerSrc.TabIndex = 16;
            // 
            // lblWidthLess03
            // 
            this.lblWidthLess03.AutoSize = true;
            this.lblWidthLess03.Location = new System.Drawing.Point(229, 80);
            this.lblWidthLess03.Name = "lblWidthLess03";
            this.lblWidthLess03.Size = new System.Drawing.Size(57, 12);
            this.lblWidthLess03.TabIndex = 14;
            this.lblWidthLess03.Text = "に拡大する";
            // 
            // lblHeightLess03
            // 
            this.lblHeightLess03.AutoSize = true;
            this.lblHeightLess03.Location = new System.Drawing.Point(229, 122);
            this.lblHeightLess03.Name = "lblHeightLess03";
            this.lblHeightLess03.Size = new System.Drawing.Size(57, 12);
            this.lblHeightLess03.TabIndex = 24;
            this.lblHeightLess03.Text = "に拡大する";
            // 
            // txtWidthLessSrc
            // 
            this.txtWidthLessSrc.Location = new System.Drawing.Point(76, 77);
            this.txtWidthLessSrc.Name = "txtWidthLessSrc";
            this.txtWidthLessSrc.Size = new System.Drawing.Size(36, 19);
            this.txtWidthLessSrc.TabIndex = 11;
            // 
            // txtHeightLessSrc
            // 
            this.txtHeightLessSrc.Location = new System.Drawing.Point(76, 119);
            this.txtHeightLessSrc.Name = "txtHeightLessSrc";
            this.txtHeightLessSrc.Size = new System.Drawing.Size(36, 19);
            this.txtHeightLessSrc.TabIndex = 21;
            // 
            // txtWidthBiggerDest
            // 
            this.txtWidthBiggerDest.Location = new System.Drawing.Point(187, 56);
            this.txtWidthBiggerDest.Name = "txtWidthBiggerDest";
            this.txtWidthBiggerDest.Size = new System.Drawing.Size(36, 19);
            this.txtWidthBiggerDest.TabIndex = 8;
            // 
            // txtHeightBiggerDest
            // 
            this.txtHeightBiggerDest.Location = new System.Drawing.Point(187, 98);
            this.txtHeightBiggerDest.Name = "txtHeightBiggerDest";
            this.txtHeightBiggerDest.Size = new System.Drawing.Size(36, 19);
            this.txtHeightBiggerDest.TabIndex = 18;
            // 
            // txtWidthLessDest
            // 
            this.txtWidthLessDest.Location = new System.Drawing.Point(187, 77);
            this.txtWidthLessDest.Name = "txtWidthLessDest";
            this.txtWidthLessDest.Size = new System.Drawing.Size(36, 19);
            this.txtWidthLessDest.TabIndex = 13;
            // 
            // txtHeightLessDest
            // 
            this.txtHeightLessDest.Location = new System.Drawing.Point(187, 119);
            this.txtHeightLessDest.Name = "txtHeightLessDest";
            this.txtHeightLessDest.Size = new System.Drawing.Size(36, 19);
            this.txtHeightLessDest.TabIndex = 23;
            // 
            // cmbKeepAspect
            // 
            this.cmbKeepAspect.FormattingEnabled = true;
            this.cmbKeepAspect.Location = new System.Drawing.Point(61, 178);
            this.cmbKeepAspect.Name = "cmbKeepAspect";
            this.cmbKeepAspect.Size = new System.Drawing.Size(120, 20);
            this.cmbKeepAspect.TabIndex = 27;
            // 
            // grpAfter
            // 
            this.grpAfter.Controls.Add(this.cmbKeepAspect);
            this.grpAfter.Controls.Add(this.txtHeightLessDest);
            this.grpAfter.Controls.Add(this.txtWidthLessDest);
            this.grpAfter.Controls.Add(this.txtHeightBiggerDest);
            this.grpAfter.Controls.Add(this.txtWidthBiggerDest);
            this.grpAfter.Controls.Add(this.txtHeightLessSrc);
            this.grpAfter.Controls.Add(this.txtWidthLessSrc);
            this.grpAfter.Controls.Add(this.lblHeightLess03);
            this.grpAfter.Controls.Add(this.lblWidthLess03);
            this.grpAfter.Controls.Add(this.txtHeightBiggerSrc);
            this.grpAfter.Controls.Add(this.txtWidthBiggerSrc);
            this.grpAfter.Controls.Add(this.lblHeightLess02);
            this.grpAfter.Controls.Add(this.lblWidthLess02);
            this.grpAfter.Controls.Add(this.lblHeightBigger03);
            this.grpAfter.Controls.Add(this.lblWidthBigger03);
            this.grpAfter.Controls.Add(this.lblKeepAspect02);
            this.grpAfter.Controls.Add(this.lblKeepAspect01);
            this.grpAfter.Controls.Add(this.lblHeightLess01);
            this.grpAfter.Controls.Add(this.lblWidthLess01);
            this.grpAfter.Controls.Add(this.lblHeightBigger02);
            this.grpAfter.Controls.Add(this.lblWidthBigger02);
            this.grpAfter.Controls.Add(this.lblHeightBigger01);
            this.grpAfter.Controls.Add(this.lblWidthBigger01);
            this.grpAfter.Controls.Add(this.txtDoAfterEdit);
            this.grpAfter.Controls.Add(this.btnDoAfterEdit);
            this.grpAfter.Controls.Add(this.chkDoAfterEdit);
            this.grpAfter.Controls.Add(this.chkDoResize);
            this.grpAfter.Controls.Add(this.chkKeepAspect);
            this.grpAfter.Controls.Add(this.chkDoAfterProcessing);
            this.grpAfter.Location = new System.Drawing.Point(12, 111);
            this.grpAfter.Name = "grpAfter";
            this.grpAfter.Size = new System.Drawing.Size(359, 251);
            this.grpAfter.TabIndex = 1;
            this.grpAfter.TabStop = false;
            this.grpAfter.Text = "後処理";
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 410);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpAfter);
            this.Controls.Add(this.grpSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.Text = "オプション";
            this.grpSave.ResumeLayout(false);
            this.grpSave.PerformLayout();
            this.grpAfter.ResumeLayout(false);
            this.grpAfter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaveDirectory;
        private System.Windows.Forms.TextBox txtSaveDirectory;
        private System.Windows.Forms.Button btnSaveDirectory;
        private System.Windows.Forms.GroupBox grpSave;
        private System.Windows.Forms.Label lblImageFormat;
        private System.Windows.Forms.ComboBox cmbImageFormat;
        private System.Windows.Forms.TextBox txtFileNameFormat;
        private System.Windows.Forms.Label lblFileNameFormat;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkDoAfterProcessing;
        private System.Windows.Forms.CheckBox chkKeepAspect;
        private System.Windows.Forms.CheckBox chkDoResize;
        private System.Windows.Forms.CheckBox chkDoAfterEdit;
        private System.Windows.Forms.Button btnDoAfterEdit;
        private System.Windows.Forms.TextBox txtDoAfterEdit;
        private System.Windows.Forms.Label lblWidthBigger01;
        private System.Windows.Forms.Label lblHeightBigger01;
        private System.Windows.Forms.Label lblWidthBigger02;
        private System.Windows.Forms.Label lblHeightBigger02;
        private System.Windows.Forms.Label lblWidthLess01;
        private System.Windows.Forms.Label lblHeightLess01;
        private System.Windows.Forms.Label lblKeepAspect01;
        private System.Windows.Forms.Label lblKeepAspect02;
        private System.Windows.Forms.Label lblWidthBigger03;
        private System.Windows.Forms.Label lblHeightBigger03;
        private System.Windows.Forms.Label lblWidthLess02;
        private System.Windows.Forms.Label lblHeightLess02;
        private System.Windows.Forms.TextBox txtWidthBiggerSrc;
        private System.Windows.Forms.TextBox txtHeightBiggerSrc;
        private System.Windows.Forms.Label lblWidthLess03;
        private System.Windows.Forms.Label lblHeightLess03;
        private System.Windows.Forms.TextBox txtWidthLessSrc;
        private System.Windows.Forms.TextBox txtHeightLessSrc;
        private System.Windows.Forms.TextBox txtWidthBiggerDest;
        private System.Windows.Forms.TextBox txtHeightBiggerDest;
        private System.Windows.Forms.TextBox txtWidthLessDest;
        private System.Windows.Forms.TextBox txtHeightLessDest;
        private System.Windows.Forms.ComboBox cmbKeepAspect;
        private System.Windows.Forms.GroupBox grpAfter;
    }
}