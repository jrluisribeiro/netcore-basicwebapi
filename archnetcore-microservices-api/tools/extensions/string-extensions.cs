using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

public static class StringExtensions
{
    public static string RemoverAcentos(this string value) { return new string(value.Normalize(NormalizationForm.FormD).Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark).ToArray()); }
    public static string Minify(this string value) { return Regex.Replace(value, @"\s(?=([^""]*""[^""]*"")*[^""]*$)", string.Empty); }
    public static string ApenasLetras(this string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        Regex regexObj = new Regex(@"[^a-zA-Z ]");
        return regexObj.Replace(text, "");
    }

    public static string ApenasNumeros(this string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        Regex regexObj = new Regex(@"[^\d]");
        return regexObj.Replace(text, "");
    }

    public static string Base64Encode(this string plainText) { return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText)); }
    public static string Base64Decode(this string valor) { return System.Text.UTF8Encoding.UTF8.GetString(System.Convert.FromBase64String(valor)); }

    public static bool isNumber(this string number)
    {
        double numberFormat;
        return double.TryParse(number.ApenasNumeros(), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out numberFormat);
    }

    public static decimal toDecimal(this string number)
    {
        decimal numberFormat;
        decimal.TryParse(number.ApenasNumeros(), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out numberFormat);
        return numberFormat;
    }

    public static double toDouble(this string number)
    {
        double numberFormat;
        double.TryParse(number.ApenasNumeros(), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out numberFormat);
        return numberFormat;
    }
}

