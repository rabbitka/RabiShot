using System.Drawing.Imaging;


namespace RabiShot.Extensions {
    public static class ImageFormatExtensions {

        public static string GetExtension(this ImageFormat fmt) {
            return fmt.ToString().ToLower();
        }

    }
}