using System.Drawing.Imaging;
using System.IO;
using RabiShot.Core;


namespace RabiShot
{
    public class Option
    {
        /// <summary>
        /// 設定ファイルのファイル名
        /// </summary>
        private static readonly string OptionFileName = "option.xml";

        private static Option _instance;

        public Option()
        {
            // 初期値
            SaveDirectory = @".\ss";
            FileName = "";
            Format = ImageFormat.Png;
            DoAfterProcessing = true;
            DoResize = true;
            WidthBiggerSrc = 640;
            WidthBiggerDest = 640;
            WidthLessSrc = 0;
            WidthLessDest = 0;
            HeightBiggerSrc = 480;
            HeightBiggerDest = 480;
            HeightLessSrc = 0;
            HeightLessDest = 0;
            KeepAspect = true;
            AspectType = AspectType.Bigger;
            DoAfterEdit = true;
            DoAfterEditPath = "mspaint %1";

            // 設定ファイルから読み込む
            if(!File.Exists(OptionFileName))
            {
                ExistOptionFile = false;
                return;
            }
            ExistOptionFile = true;
            Load();
        }

        public static Option Instance()
        {
            if(_instance == null)
                _instance = new Option();

            return _instance;
        }

        /// <summary>
        /// 設定を保存する
        /// </summary>
        public void Save()
        {
            var xml = new XmlSetting();
            xml.Add("SaveDirectory", SaveDirectory);
            xml.Add("FileName", FileName);
            xml.Add("Format", Format.ToString());
            xml.Add("DoAfterProcessing", DoAfterProcessing.ToString());
            xml.Add("DoResize", DoResize.ToString());
            xml.Add("WidthBiggerSrc", WidthBiggerSrc.ToString());
            xml.Add("WidthBiggerDest", WidthBiggerDest.ToString());
            xml.Add("WidthLessSrc", WidthLessSrc.ToString());
            xml.Add("WidthLessDest", WidthLessDest.ToString());
            xml.Add("HeightBiggerSrc", HeightBiggerSrc.ToString());
            xml.Add("HeightBiggerDest", HeightBiggerDest.ToString());
            xml.Add("HeightLessSrc", HeightLessSrc.ToString());
            xml.Add("HeightLessDest", HeightLessDest.ToString());
            xml.Add("KeepAspect", KeepAspect.ToString());
            xml.Add("AspectType", System.Convert.ToInt32(AspectType).ToString());
            xml.Add("DoAfterEdit", DoAfterEdit.ToString());
            xml.Add("DoAfterEditPath", DoAfterEditPath);
            xml.Save(OptionFileName);
        }
        /// <summary>
        /// 設定を読み込む
        /// </summary>
        public void Load()
        {
            var xml = new XmlSetting();
            xml.Load(OptionFileName);
            SaveDirectory = xml.Get("SaveDirectory");
            FileName = xml.Get("FileName");
            var fmt = xml.Get("Format");
            if(fmt == "Png")
                Format = ImageFormat.Png;
            if(fmt == "Bmp")
                Format = ImageFormat.Bmp;
            if(fmt == "Jpeg")
                Format = ImageFormat.Jpeg;
            DoAfterProcessing = bool.Parse(xml.Get("DoAfterProcessing"));
            DoResize = bool.Parse(xml.Get("DoResize"));
            WidthBiggerSrc = int.Parse(xml.Get("WidthBiggerSrc"));
            WidthBiggerDest = int.Parse(xml.Get("WidthBiggerDest"));
            WidthLessSrc = int.Parse(xml.Get("WidthLessSrc"));
            WidthLessDest = int.Parse(xml.Get("WidthLessDest"));
            HeightBiggerSrc = int.Parse(xml.Get("HeightBiggerSrc"));
            HeightBiggerDest = int.Parse(xml.Get("HeightBiggerDest"));
            HeightLessSrc = int.Parse(xml.Get("HeightLessSrc"));
            HeightLessDest = int.Parse(xml.Get("HeightLessDest"));
            KeepAspect = bool.Parse(xml.Get("KeepAspect"));
            AspectType = (AspectType)int.Parse(xml.Get("AspectType"));
            DoAfterEdit = bool.Parse(xml.Get("DoAfterEdit"));
            DoAfterEditPath = xml.Get("DoAfterEditPath");
        }

        /// <summary>
        /// 設定ファイルが存在するか
        /// </summary>
        public bool ExistOptionFile { get; private set; }

        /// <summary>
        /// 保存先: フォルダ
        /// </summary>
        public string SaveDirectory { get; set; }
        /// <summary>
        /// 保存先: ファイル名: プレフィックス
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 保存先: ファイル名: 画像形式
        /// </summary>
        public ImageFormat Format { get; set; }

        /// <summary>
        /// 後処理: スクリーンショット取得後、後処理をする
        /// </summary>
        public bool DoAfterProcessing { get; set; }
        /// <summary>
        /// 後処理: 画像のサイズを変更する
        /// </summary>
        public bool DoResize { get; set; }
        /// <summary>
        /// 後処理: 幅を縮小する際の基準値
        /// </summary>
        public int WidthBiggerSrc { get; set; }
        /// <summary>
        /// 後処理: 幅を縮小する際の値
        /// </summary>
        public int WidthBiggerDest { get; set; }
        /// <summary>
        /// 後処理: 幅を拡大する際の基準値
        /// </summary>
        public int WidthLessSrc { get; set; }
        /// <summary>
        /// 後処理: 幅を拡大する際の値
        /// </summary>
        public int WidthLessDest { get; set; }
        /// <summary>
        /// 後処理: 高さを縮小する際の基準値
        /// </summary>
        public int HeightBiggerSrc { get; set; }
        /// <summary>
        /// 後処理: 高さを縮小する際の値
        /// </summary>
        public int HeightBiggerDest { get; set; }
        /// <summary>
        /// 後処理: 高さを拡大する際の基準値
        /// </summary>
        public int HeightLessSrc { get; set; }
        /// <summary>
        /// 後処理: 高さを拡大する際の値
        /// </summary>
        public int HeightLessDest { get; set; }
        /// <summary>
        /// 後処理: アスペクト比を保持する
        /// </summary>
        public bool KeepAspect { get; set; }
        /// <summary>
        /// 後処理: アスペクト比を保持した際、複数の条件が一致した際の優先方法
        /// </summary>
        public AspectType AspectType { get; set; }
        /// <summary>
        /// 後処理: サイズ変更後に画像を編集する
        /// </summary>
        public bool DoAfterEdit { get; set; }
        /// <summary>
        /// 後処理: サイズ変更後に画像を編集するパス
        /// </summary>
        public string DoAfterEditPath { get; set; }
　
    }
}
