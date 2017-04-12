namespace Common.Extensions
{
    using System.Collections;
    using System.Collections.Generic;

    public static class DictionaryExtensions
    {
        public static T Get<T>(this IDictionary dictionary, object key, T defaultValue = default(T))
        {
            var value = defaultValue;
            if (dictionary == null || !dictionary.Contains(key))
            {
                return value;
            }
            return (T)dictionary[key];
        }

        public static TValue Get<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            var value = default(TValue);
            if (dictionary == null || !dictionary.ContainsKey(key))
            {
                return value;
            }
            return dictionary[key];
        }
    }
}