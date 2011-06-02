using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace RabiShot.Settings {
    /// <summary>
    /// XML形式で保存する設定クラスの基底クラス
    /// </summary>
    public abstract class XmlSettingBase {
        /// <summary>
        /// Shift_JISの文字コードクラス
        /// </summary>
        private static Encoding _shiftjis = Encoding.GetEncoding("Shift_JIS");

        /// <summary>
        /// 読み込んだ値を保持するディクショナリ。
        /// </summary>
        protected Dictionary<string, string> Dic = new Dictionary<string,string>();

        /// <summary>
        /// 設定を保存する。
        /// </summary>
        protected void Save(string fileName) {
            // 既存の設定ファイルは上書きしている (FileMode.Create)
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
            using (var w = new XmlTextWriter(fs, _shiftjis)) {
                w.Formatting = Formatting.Indented;
                w.WriteStartDocument(true);
                w.WriteStartElement("settings");
                {
                    foreach (var d in Dic) {
                        w.WriteStartElement("setting");
                        w.WriteAttributeString("key", d.Key);
                        w.WriteAttributeString("value", d.Value);
                        w.WriteEndElement();
                    }
                }
                w.WriteEndElement();
                w.WriteEndDocument();
                w.Close();
                fs.Close();
            }
        }

        /// <summary>
        /// 設定を読み込む。
        /// </summary>
        protected void Load(string fileName) {
            if (!File.Exists(fileName)) {
                return;
            }

            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (var r = new XmlTextReader(fs)) {
                while (r.Read()) {
                    r.MoveToContent();
                    if (r.NodeType == XmlNodeType.Element && r.HasAttributes && r.Name == "setting") {
                        var key = string.Empty;
                        var value = string.Empty;
                        for (int i = 0; i < r.AttributeCount; i++) {
                            r.MoveToAttribute(i);
                            if (r.Name == "key") {
                                key = r.Value;
                            }
                            if (r.Name == "value") {
                                value = r.Value;
                            }
                        }
                        if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value)) {
                            Dic[key] = value;
                        }
                    }
                    r.MoveToElement();
                }
            }
            Console.WriteLine(Dic);
        }

    }
}
