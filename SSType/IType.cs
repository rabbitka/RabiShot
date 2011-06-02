using System.Drawing;


namespace RabiShot.SSType {
    /// <summary>
    /// スクリーンショットの種類を定義するインターフェース。
    /// </summary>
    public interface IType {
        /// <summary>
        /// スクリーンショットを保存する領域を取得する。
        /// </summary>
        /// <returns>スクリーンショットを保存する領域</returns>
        Rectangle GetRectangle();
    }
}