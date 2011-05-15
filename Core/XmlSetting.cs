using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RabiShot.Core {
    /// <summary>
    /// 設定をXMLファイルで保存するクラス
    /// </summary>
    public class XmlSetting {

        private Dictionary<string, string> paramList;

        public XmlSetting() {
            paramList = new Dictionary<string, string>();
        }

        /// <summary>
        /// 設定ファイルを読み込む。
        /// </summary>
        /// <param name="path">読み込む設定ファイルのパス</param>
        public void Load(string path) {
            var doc = XDocument.Load(path);
            var elParams = doc.Element("params");
            if(elParams == null) {
                throw new NullReferenceException("elParams");
            }
            var paramz = from p in elParams.Elements("param")
                         select p;
            foreach(var p in paramz) {
                var atKey = p.Attribute("key");
                var atValue = p.Attribute("value");
                if(atKey == null) {
                    throw new NullReferenceException("atKey");
                }
                if(atValue == null) {
                    throw new NullReferenceException("atValue");
                }
                paramList.Add(atKey.Value, atValue.Value);
            }
        }
        /// <summary>
        /// 設定ファイルを書き込む。
        /// </summary>
        /// <param name="path">書き込む設定ファイルのパス</param>
        public void Save(string path) {
            var prms = new XElement("params");
            foreach(var param in paramList) {
                prms.Add(new XElement("param",
                    new XAttribute("key", param.Key),
                    new XAttribute("value", param.Value)));
            }
            var doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), prms);

            doc.Save(path);
        }

        /// <summary>
        /// 設定を追加する
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        public void Add(string key, string value) {
            paramList.Add(key, value);
        }
        /// <summary>
        /// 設定を取得する
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Get(string key) {
            return paramList[key];
        }
    }
}