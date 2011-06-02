namespace RabiShot.Format {
    /// <summary>
    /// フォーマットのインターフェース
    /// </summary>
    public interface IFormat {
        /// <summary>
        /// フォーマットから文字列を生成する。
        /// </summary>
        /// <param name="fmt">フォーマット</param>
        /// <returns>生成した文字列</returns>
        string Generate(string fmt);
    }
}
