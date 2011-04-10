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
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.grpAfter = new System.Windows.Forms.GroupBox();
            this.cmbKeepAspect = new System.Windows.Forms.ComboBox();
            this.txtHeightLessDest = new System.Windows.Forms.TextBox();
            this.txtWidthLessDest = new System.Windows.Forms.TextBox();
            this.txtHeightBiggerDest = new System.Windows.Forms.TextBox();
            this.txtWidthBiggerDest = new System.Windows.Forms.TextBox();
            this.txtHeightLessSrc = new System.Windows.Forms.TextBox();
            this.txtWidthLessSrc = new System.Windows.Forms.TextBox();
            this.lblHeightLess03 = new System.Windows.Forms.Label();
            this.lblWidthLess03 = new System.Windows.Forms.Label();
            this.txtHeightBiggerSrc = new System.Windows.Forms.TextBox();
            this.txtWidthBiggerSrc = new System.Windows.Forms.TextBox();
            this.lblHeightLess02 = new System.Windows.Forms.Label();
            this.lblWidthLess02 = new System.Windows.Forms.Label();
            this.lblHeightBigger03 = new System.Windows.Forms.Label();
            this.lblWidthBigger03 = new System.Windows.Forms.Label();
            this.lblKeepAspect02 = new System.Windows.Forms.Label();
            this.lblKeepAspect01 = new System.Windows.Forms.Label();
            this.lblHeightLess01 = new System.Windows.Forms.Label();
            this.lblWidthLess01 = new System.Windows.Forms.Label();
            this.lblHeightBigger02 = new System.Windows.Forms.Label();
            this.lblWidthBigger02 = new System.Windows.Forms.Label();
            this.lblHeightBigger01 = new System.Windows.Forms.Label();
            this.lblWidthBigger01 = new System.Windows.Forms.Label();
            this.txtDoAfterEdit = new System.Windows.Forms.TextBox();
            this.btnDoAfterEdit = new System.Windows.Forms.Button();
            this.txtDoBeforeEdit = new System.Windows.Forms.TextBox();
            this.chkDoAfterEdit = new System.Windows.Forms.CheckBox();
            this.chkDoBeforeEdit = new System.Windows.Forms.CheckBox();
            this.chkDoResize = new System.Windows.Forms.CheckBox();
            this.chkKeepAspect = new System.Windows.Forms.CheckBox();
            this.chkDoAfterProcessing = new System.Windows.Forms.CheckBox();
            this.btnDoBeforeEdit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.TextBox();
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
            this.grpSave.Controls.Add(this.txtSerial);
            this.grpSave.Controls.Add(this.txtSuffix);
            this.grpSave.Controls.Add(this.txtPrefix);
            this.grpSave.Controls.Add(this.lblSerial);
            this.grpSave.Controls.Add(this.lblSuffix);
            this.grpSave.Controls.Add(this.lblPrefix);
            this.grpSave.Controls.Add(this.lblFile);
            this.grpSave.Controls.Add(this.lblSaveDirectory);
            this.grpSave.Controls.Add(this.btnSaveDirectory);
            this.grpSave.Controls.Add(this.txtSaveDirectory);
            this.grpSave.Location = new System.Drawing.Point(12, 12);
            this.grpSave.Name = "grpSave";
            this.grpSave.Size = new System.Drawing.Size(359, 105);
            this.grpSave.TabIndex = 0;
            this.grpSave.TabStop = false;
            this.grpSave.Text = "保存先";
            // 
            // lblImageFormat
            // 
            this.lblImageFormat.AutoSize = true;
            this.lblImageFormat.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblImageFormat.Location = new System.Drawing.Point(294, 64);
            this.lblImageFormat.Name = "lblImageFormat";
            this.lblImageFormat.Size = new System.Drawing.Size(53, 12);
            this.lblImageFormat.TabIndex = 10;
            this.lblImageFormat.Text = "画像形式";
            // 
            // cmbImageFormat
            // 
            this.cmbImageFormat.FormattingEnabled = true;
            this.cmbImageFormat.Location = new System.Drawing.Point(296, 79);
            this.cmbImageFormat.Name = "cmbImageFormat";
            this.cmbImageFormat.Size = new System.Drawing.Size(48, 20);
            this.cmbImageFormat.TabIndex = 11;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(200, 79);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(90, 19);
            this.txtSuffix.TabIndex = 9;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(8, 79);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(90, 19);
            this.txtPrefix.TabIndex = 5;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSerial.Location = new System.Drawing.Point(102, 64);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(59, 12);
            this.lblSerial.TabIndex = 6;
            this.lblSerial.Text = "連番/日時";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSuffix.Location = new System.Drawing.Point(198, 64);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(54, 12);
            this.lblSuffix.TabIndex = 8;
            this.lblSuffix.Text = "サフィックス";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrefix.Location = new System.Drawing.Point(6, 64);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(62, 12);
            this.lblPrefix.TabIndex = 4;
            this.lblPrefix.Text = "プレフィックス";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFile.Location = new System.Drawing.Point(6, 52);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(51, 12);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "ファイル名";
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
            this.grpAfter.Controls.Add(this.txtDoBeforeEdit);
            this.grpAfter.Controls.Add(this.chkDoAfterEdit);
            this.grpAfter.Controls.Add(this.chkDoBeforeEdit);
            this.grpAfter.Controls.Add(this.chkDoResize);
            this.grpAfter.Controls.Add(this.chkKeepAspect);
            this.grpAfter.Controls.Add(this.chkDoAfterProcessing);
            this.grpAfter.Controls.Add(this.btnDoBeforeEdit);
            this.grpAfter.Location = new System.Drawing.Point(12, 123);
            this.grpAfter.Name = "grpAfter";
            this.grpAfter.Size = new System.Drawing.Size(359, 300);
            this.grpAfter.TabIndex = 1;
            this.grpAfter.TabStop = false;
            this.grpAfter.Text = "後処理";
            // 
            // cmbKeepAspect
            // 
            this.cmbKeepAspect.FormattingEnabled = true;
            this.cmbKeepAspect.Location = new System.Drawing.Point(61, 225);
            this.cmbKeepAspect.Name = "cmbKeepAspect";
            this.cmbKeepAspect.Size = new System.Drawing.Size(120, 20);
            this.cmbKeepAspect.TabIndex = 27;
            // 
            // txtHeightLessDest
            // 
            this.txtHeightLessDest.Location = new System.Drawing.Point(188, 166);
            this.txtHeightLessDest.Name = "txtHeightLessDest";
            this.txtHeightLessDest.Size = new System.Drawing.Size(36, 19);
            this.txtHeightLessDest.TabIndex = 23;
            // 
            // txtWidthLessDest
            // 
            this.txtWidthLessDest.Location = new System.Drawing.Point(188, 124);
            this.txtWidthLessDest.Name = "txtWidthLessDest";
            this.txtWidthLessDest.Size = new System.Drawing.Size(36, 19);
            this.txtWidthLessDest.TabIndex = 13;
            // 
            // txtHeightBiggerDest
            // 
            this.txtHeightBiggerDest.Location = new System.Drawing.Point(188, 145);
            this.txtHeightBiggerDest.Name = "txtHeightBiggerDest";
            this.txtHeightBiggerDest.Size = new System.Drawing.Size(36, 19);
            this.txtHeightBiggerDest.TabIndex = 18;
            // 
            // txtWidthBiggerDest
            // 
            this.txtWidthBiggerDest.Location = new System.Drawing.Point(188, 103);
            this.txtWidthBiggerDest.Name = "txtWidthBiggerDest";
            this.txtWidthBiggerDest.Size = new System.Drawing.Size(36, 19);
            this.txtWidthBiggerDest.TabIndex = 8;
            // 
            // txtHeightLessSrc
            // 
            this.txtHeightLessSrc.Location = new System.Drawing.Point(77, 166);
            this.txtHeightLessSrc.Name = "txtHeightLessSrc";
            this.txtHeightLessSrc.Size = new System.Drawing.Size(36, 19);
            this.txtHeightLessSrc.TabIndex = 21;
            // 
            // txtWidthLessSrc
            // 
            this.txtWidthLessSrc.Location = new System.Drawing.Point(77, 124);
            this.txtWidthLessSrc.Name = "txtWidthLessSrc";
            this.txtWidthLessSrc.Size = new System.Drawing.Size(36, 19);
            this.txtWidthLessSrc.TabIndex = 11;
            // 
            // lblHeightLess03
            // 
            this.lblHeightLess03.AutoSize = true;
            this.lblHeightLess03.Location = new System.Drawing.Point(230, 169);
            this.lblHeightLess03.Name = "lblHeightLess03";
            this.lblHeightLess03.Size = new System.Drawing.Size(57, 12);
            this.lblHeightLess03.TabIndex = 24;
            this.lblHeightLess03.Text = "に拡大する";
            // 
            // lblWidthLess03
            // 
            this.lblWidthLess03.AutoSize = true;
            this.lblWidthLess03.Location = new System.Drawing.Point(230, 127);
            this.lblWidthLess03.Name = "lblWidthLess03";
            this.lblWidthLess03.Size = new System.Drawing.Size(57, 12);
            this.lblWidthLess03.TabIndex = 14;
            this.lblWidthLess03.Text = "に拡大する";
            // 
            // txtHeightBiggerSrc
            // 
            this.txtHeightBiggerSrc.Location = new System.Drawing.Point(77, 145);
            this.txtHeightBiggerSrc.Name = "txtHeightBiggerSrc";
            this.txtHeightBiggerSrc.Size = new System.Drawing.Size(36, 19);
            this.txtHeightBiggerSrc.TabIndex = 16;
            // 
            // txtWidthBiggerSrc
            // 
            this.txtWidthBiggerSrc.Location = new System.Drawing.Point(77, 103);
            this.txtWidthBiggerSrc.Name = "txtWidthBiggerSrc";
            this.txtWidthBiggerSrc.Size = new System.Drawing.Size(36, 19);
            this.txtWidthBiggerSrc.TabIndex = 6;
            // 
            // lblHeightLess02
            // 
            this.lblHeightLess02.AutoSize = true;
            this.lblHeightLess02.Location = new System.Drawing.Point(119, 169);
            this.lblHeightLess02.Name = "lblHeightLess02";
            this.lblHeightLess02.Size = new System.Drawing.Size(63, 12);
            this.lblHeightLess02.TabIndex = 22;
            this.lblHeightLess02.Text = "以下の場合";
            // 
            // lblWidthLess02
            // 
            this.lblWidthLess02.AutoSize = true;
            this.lblWidthLess02.Location = new System.Drawing.Point(119, 127);
            this.lblWidthLess02.Name = "lblWidthLess02";
            this.lblWidthLess02.Size = new System.Drawing.Size(63, 12);
            this.lblWidthLess02.TabIndex = 12;
            this.lblWidthLess02.Text = "以下の場合";
            // 
            // lblHeightBigger03
            // 
            this.lblHeightBigger03.AutoSize = true;
            this.lblHeightBigger03.Location = new System.Drawing.Point(230, 148);
            this.lblHeightBigger03.Name = "lblHeightBigger03";
            this.lblHeightBigger03.Size = new System.Drawing.Size(57, 12);
            this.lblHeightBigger03.TabIndex = 19;
            this.lblHeightBigger03.Text = "に縮小する";
            // 
            // lblWidthBigger03
            // 
            this.lblWidthBigger03.AutoSize = true;
            this.lblWidthBigger03.Location = new System.Drawing.Point(230, 106);
            this.lblWidthBigger03.Name = "lblWidthBigger03";
            this.lblWidthBigger03.Size = new System.Drawing.Size(57, 12);
            this.lblWidthBigger03.TabIndex = 9;
            this.lblWidthBigger03.Text = "に縮小する";
            // 
            // lblKeepAspect02
            // 
            this.lblKeepAspect02.AutoSize = true;
            this.lblKeepAspect02.Location = new System.Drawing.Point(186, 228);
            this.lblKeepAspect02.Name = "lblKeepAspect02";
            this.lblKeepAspect02.Size = new System.Drawing.Size(57, 12);
            this.lblKeepAspect02.TabIndex = 28;
            this.lblKeepAspect02.Text = "を優先する";
            // 
            // lblKeepAspect01
            // 
            this.lblKeepAspect01.AutoSize = true;
            this.lblKeepAspect01.Location = new System.Drawing.Point(60, 210);
            this.lblKeepAspect01.Name = "lblKeepAspect01";
            this.lblKeepAspect01.Size = new System.Drawing.Size(139, 12);
            this.lblKeepAspect01.TabIndex = 26;
            this.lblKeepAspect01.Text = "複数の条件が一致した場合";
            // 
            // lblHeightLess01
            // 
            this.lblHeightLess01.AutoSize = true;
            this.lblHeightLess01.Location = new System.Drawing.Point(42, 169);
            this.lblHeightLess01.Name = "lblHeightLess01";
            this.lblHeightLess01.Size = new System.Drawing.Size(35, 12);
            this.lblHeightLess01.TabIndex = 20;
            this.lblHeightLess01.Text = "高さが";
            // 
            // lblWidthLess01
            // 
            this.lblWidthLess01.AutoSize = true;
            this.lblWidthLess01.Location = new System.Drawing.Point(42, 127);
            this.lblWidthLess01.Name = "lblWidthLess01";
            this.lblWidthLess01.Size = new System.Drawing.Size(27, 12);
            this.lblWidthLess01.TabIndex = 10;
            this.lblWidthLess01.Text = "幅が";
            // 
            // lblHeightBigger02
            // 
            this.lblHeightBigger02.AutoSize = true;
            this.lblHeightBigger02.Location = new System.Drawing.Point(119, 148);
            this.lblHeightBigger02.Name = "lblHeightBigger02";
            this.lblHeightBigger02.Size = new System.Drawing.Size(63, 12);
            this.lblHeightBigger02.TabIndex = 17;
            this.lblHeightBigger02.Text = "以上の場合";
            // 
            // lblWidthBigger02
            // 
            this.lblWidthBigger02.AutoSize = true;
            this.lblWidthBigger02.Location = new System.Drawing.Point(119, 106);
            this.lblWidthBigger02.Name = "lblWidthBigger02";
            this.lblWidthBigger02.Size = new System.Drawing.Size(63, 12);
            this.lblWidthBigger02.TabIndex = 7;
            this.lblWidthBigger02.Text = "以上の場合";
            // 
            // lblHeightBigger01
            // 
            this.lblHeightBigger01.AutoSize = true;
            this.lblHeightBigger01.Location = new System.Drawing.Point(42, 148);
            this.lblHeightBigger01.Name = "lblHeightBigger01";
            this.lblHeightBigger01.Size = new System.Drawing.Size(35, 12);
            this.lblHeightBigger01.TabIndex = 15;
            this.lblHeightBigger01.Text = "高さが";
            // 
            // lblWidthBigger01
            // 
            this.lblWidthBigger01.AutoSize = true;
            this.lblWidthBigger01.Location = new System.Drawing.Point(42, 106);
            this.lblWidthBigger01.Name = "lblWidthBigger01";
            this.lblWidthBigger01.Size = new System.Drawing.Size(27, 12);
            this.lblWidthBigger01.TabIndex = 5;
            this.lblWidthBigger01.Text = "幅が";
            // 
            // txtDoAfterEdit
            // 
            this.txtDoAfterEdit.Location = new System.Drawing.Point(44, 273);
            this.txtDoAfterEdit.Name = "txtDoAfterEdit";
            this.txtDoAfterEdit.Size = new System.Drawing.Size(255, 19);
            this.txtDoAfterEdit.TabIndex = 30;
            // 
            // btnDoAfterEdit
            // 
            this.btnDoAfterEdit.Location = new System.Drawing.Point(305, 271);
            this.btnDoAfterEdit.Name = "btnDoAfterEdit";
            this.btnDoAfterEdit.Size = new System.Drawing.Size(48, 23);
            this.btnDoAfterEdit.TabIndex = 31;
            this.btnDoAfterEdit.Text = "参照...";
            this.btnDoAfterEdit.UseVisualStyleBackColor = true;
            // 
            // txtDoBeforeEdit
            // 
            this.txtDoBeforeEdit.Location = new System.Drawing.Point(44, 62);
            this.txtDoBeforeEdit.Name = "txtDoBeforeEdit";
            this.txtDoBeforeEdit.Size = new System.Drawing.Size(255, 19);
            this.txtDoBeforeEdit.TabIndex = 2;
            // 
            // chkDoAfterEdit
            // 
            this.chkDoAfterEdit.AutoSize = true;
            this.chkDoAfterEdit.Location = new System.Drawing.Point(26, 251);
            this.chkDoAfterEdit.Name = "chkDoAfterEdit";
            this.chkDoAfterEdit.Size = new System.Drawing.Size(174, 16);
            this.chkDoAfterEdit.TabIndex = 29;
            this.chkDoAfterEdit.Text = "サイズ変更後に画像を編集する";
            this.chkDoAfterEdit.UseVisualStyleBackColor = true;
            // 
            // chkDoBeforeEdit
            // 
            this.chkDoBeforeEdit.AutoSize = true;
            this.chkDoBeforeEdit.Location = new System.Drawing.Point(26, 40);
            this.chkDoBeforeEdit.Name = "chkDoBeforeEdit";
            this.chkDoBeforeEdit.Size = new System.Drawing.Size(174, 16);
            this.chkDoBeforeEdit.TabIndex = 1;
            this.chkDoBeforeEdit.Text = "サイズ変更前に画像を編集する";
            this.chkDoBeforeEdit.UseVisualStyleBackColor = true;
            // 
            // chkDoResize
            // 
            this.chkDoResize.AutoSize = true;
            this.chkDoResize.Location = new System.Drawing.Point(26, 87);
            this.chkDoResize.Name = "chkDoResize";
            this.chkDoResize.Size = new System.Drawing.Size(139, 16);
            this.chkDoResize.TabIndex = 4;
            this.chkDoResize.Text = "画像のサイズを変更する";
            this.chkDoResize.UseVisualStyleBackColor = true;
            // 
            // chkKeepAspect
            // 
            this.chkKeepAspect.AutoSize = true;
            this.chkKeepAspect.Location = new System.Drawing.Point(44, 191);
            this.chkKeepAspect.Name = "chkKeepAspect";
            this.chkKeepAspect.Size = new System.Drawing.Size(132, 16);
            this.chkKeepAspect.TabIndex = 25;
            this.chkKeepAspect.Text = "アスペクト比を保持する";
            this.chkKeepAspect.UseVisualStyleBackColor = true;
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
            // btnDoBeforeEdit
            // 
            this.btnDoBeforeEdit.Location = new System.Drawing.Point(305, 60);
            this.btnDoBeforeEdit.Name = "btnDoBeforeEdit";
            this.btnDoBeforeEdit.Size = new System.Drawing.Size(48, 23);
            this.btnDoBeforeEdit.TabIndex = 3;
            this.btnDoBeforeEdit.Text = "参照...";
            this.btnDoBeforeEdit.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(296, 429);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "適用";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(104, 79);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(90, 19);
            this.txtSerial.TabIndex = 9;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 471);
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
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.GroupBox grpAfter;
        private System.Windows.Forms.CheckBox chkDoAfterProcessing;
        private System.Windows.Forms.CheckBox chkKeepAspect;
        private System.Windows.Forms.CheckBox chkDoBeforeEdit;
        private System.Windows.Forms.TextBox txtWidthBiggerSrc;
        private System.Windows.Forms.Label lblWidthBigger02;
        private System.Windows.Forms.Label lblWidthBigger01;
        private System.Windows.Forms.TextBox txtDoAfterEdit;
        private System.Windows.Forms.Button btnDoAfterEdit;
        private System.Windows.Forms.TextBox txtDoBeforeEdit;
        private System.Windows.Forms.CheckBox chkDoAfterEdit;
        private System.Windows.Forms.CheckBox chkDoResize;
        private System.Windows.Forms.Button btnDoBeforeEdit;
        private System.Windows.Forms.ComboBox cmbKeepAspect;
        private System.Windows.Forms.TextBox txtHeightLessDest;
        private System.Windows.Forms.TextBox txtWidthLessDest;
        private System.Windows.Forms.TextBox txtHeightBiggerDest;
        private System.Windows.Forms.TextBox txtWidthBiggerDest;
        private System.Windows.Forms.TextBox txtHeightLessSrc;
        private System.Windows.Forms.TextBox txtWidthLessSrc;
        private System.Windows.Forms.Label lblHeightLess03;
        private System.Windows.Forms.Label lblWidthLess03;
        private System.Windows.Forms.TextBox txtHeightBiggerSrc;
        private System.Windows.Forms.Label lblHeightLess02;
        private System.Windows.Forms.Label lblWidthLess02;
        private System.Windows.Forms.Label lblHeightBigger03;
        private System.Windows.Forms.Label lblWidthBigger03;
        private System.Windows.Forms.Label lblKeepAspect01;
        private System.Windows.Forms.Label lblHeightLess01;
        private System.Windows.Forms.Label lblWidthLess01;
        private System.Windows.Forms.Label lblHeightBigger02;
        private System.Windows.Forms.Label lblHeightBigger01;
        private System.Windows.Forms.Label lblKeepAspect02;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSerial;
    }
}