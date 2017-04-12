namespace Common.Extensions
{
    using System;

    public static class StringExtensions
    {
        public static bool IsEmpty(this string str) => string.IsNullOrEmpty(str);

        public static bool IsWhitespace(this string str) => string.IsNullOrWhiteSpace(str);

        public static bool IsNotEmpty(this string str) => !string.IsNullOrEmpty(str);

        public static bool IsNotWhitespace(this string str) => !string.IsNullOrWhiteSpace(str);
        
        public static Uri ToUri(this string str) => new Uri(str);

        public static int ToInt(this string str) => str.IsWhitespace() ? 0 : Convert.ToInt32(str);

        public static short ToShort(this string str) => (short)(str.IsWhitespace() ? 0 : Convert.ToInt16(str));

        public static long ToLong(this string str) => str.IsWhitespace() ? 0 : Convert.ToInt64(str);

        public static bool ToBoolean(this string str) => !str.IsEmpty();
    }
}