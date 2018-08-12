namespace Sorschia.Extensions
{
    public static class EPPlusDefaults
    {
        static EPPlusDefaults()
        {
            FontName = "Calibri";
            FontSize = 9F;
        }

        public static string FontName { get; set; }
        public static float FontSize { get; set; }
    }
}
