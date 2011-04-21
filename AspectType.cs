using System;


namespace RabiShot
{
    public enum AspectType
    {
        Width = 0,
        Height = 1,
        Bigger = 2,
        Smaller = 3
    }

    public static class AspectTypeExtensions
    {
        public static string GetName(this AspectType type)
        {
            const string width = "幅";
            const string height = "高さ";
            const string bigger = "より大きいサイズ";
            const string smaller  = "より小さいサイズ";

            switch (type)
            {
                case AspectType.Width:
                    return width;
                case AspectType.Height:
                    return height;
                case AspectType.Bigger:
                    return bigger;
                case AspectType.Smaller:
                    return smaller;
            }

            throw new ArgumentException("type");
        }
    }
}
