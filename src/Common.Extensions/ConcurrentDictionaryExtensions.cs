namespace Common.Extensions
{
    using System.Collections.Concurrent;
    using System.Runtime.InteropServices.ComTypes;

    public static class ConcurrentDictionaryExtensions
    {
        public static void Add<T1, T2>(this ConcurrentDictionary<T1, T2> dictionary, T1 key, T2 value)
        {
            while (!dictionary.TryAdd(key, value))
            {
            }
        }

        public static void Remove<T1, T2>(this ConcurrentDictionary<T1, T2> dictionary, T1 key)
        {
            var value = default(T2);
            while (!dictionary.TryRemove(key, out value))
            {
            }
            value = default(T2);
        }
    }
}