using System.Drawing;

public static class ColorHelper
{
    public static Color GetColor(string hexColor, Color defaultColor)
    {
        if (string.IsNullOrWhiteSpace(hexColor))
            return defaultColor;

        try
        {
            return ColorTranslator.FromHtml(hexColor);
        }
        catch
        {
            return defaultColor;
        }
    }
}