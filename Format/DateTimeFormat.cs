using System;


namespace RabiShot.Format {
    /// <summary>
    /// 日時関連のフォーマット
    /// </summary>
    public class DateTimeFormat : IFormat {
        /// <summary>
        /// フォーマットから文字列を生成する。
        /// </summary>
        /// <param name="fmt">フォーマット</param>
        /// <returns>生成した文字列</returns>
        public string Generate(string fmt) {
            var f = fmt.Substring(1, fmt.Length - 2);
            return DateTime.Now.ToString(f);
        }
    }
}
