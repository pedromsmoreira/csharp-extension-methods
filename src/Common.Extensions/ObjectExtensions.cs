namespace CsharpUtilitiesExtensions
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object obj) => obj == null;

        public static bool IsNotNull(this object obj) => !obj.IsNull();
    }
}