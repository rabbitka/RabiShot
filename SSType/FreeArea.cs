using System.Drawing;


namespace RabiShot.SSType {
    /// <summary>
    /// 自由な領域を取得する。
    /// </summary>
    /// <remarks>
    /// 自由な領域を指定するウィンドウを表示している。
    /// </remarks>
    public class FreeArea : IType {
        /// <summary>
        /// 画面全体の領域を取得するクラスを保持する。
        /// </summary>
        private static readonly IType All = new DisplayAll();

        /// <summary>
        /// スクリーンショットを保存する領域を取得する。
        /// </summary>
        /// <returns>スクリーンショットを保存する領域</returns>
        public Rectangle GetRectangle() {
            // 範囲指定用フォームを表示させるため、画面全体の大きさを表す
            // Rectangleを取得している
            using(var w = new FreeAreaForm(All.GetRectangle())) {
                w.ShowDialog();
                return w.GetSelectedRectangle();
            }
        }
    }
}