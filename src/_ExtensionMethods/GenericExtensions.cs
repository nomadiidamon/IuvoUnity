using System.Collections.Generic;
using System;
using UnityEngine;


namespace IuvoUnity
{
    namespace _ExtensionMethods
    {
        public static class GenericExtensions
        {

            public static bool IsSubclassOf<T, TBase>(this T obj) where T : TBase
            {
                return obj is TBase;
            }

            public static string GetTypeName<T>(this T obj)
            {
                return typeof(T).Name;
            }

            public static bool IsInterface<T>(this T obj)
            {
                return typeof(T).IsInterface;
            }

            public static bool IsOfType<T>(this object obj)
            {
                return obj is T;
            }

            public static bool IsNull<T>(this T obj)
            {
                return obj == null;
            }

            public static bool IsNotNull<T>(this T obj)
            {
                return obj != null;
            }

            public static bool IsNullOrEmpty<T>(this T obj)
            {
                return obj == null || obj.Equals("");
            }

            public static void RemoveAll<T>(this List<T> collection, System.Func<T, bool> predicate)
            {
                collection.RemoveAll(new System.Predicate<T>(predicate));
            }

            public static T Clone<T>(this T obj)
            {
                var serializedObj = JsonUtility.ToJson(obj);
                return JsonUtility.FromJson<T>(serializedObj);
            }

            public static void SafeInvoke<T>(this T obj, System.Action<T> action)
            {
                if (obj != null)
                {
                    action(obj);
                }
            }

            public static bool IsEqualTo<T>(this T obj, T otherObj)
            {
                return obj.Equals(otherObj);
            }


            public static void AddOrUpdate<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
            {
                dictionary[key] = value;
            }



            public static System.Collections.Specialized.OrderedDictionary ToOrderedDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> collection)
            {
                var orderedDict = new System.Collections.Specialized.OrderedDictionary();
                foreach (var kvp in collection)
                {
                    orderedDict.Add(kvp.Key, kvp.Value);
                }
                return orderedDict;
            }

            public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
            {
                foreach (var item in collection)
                {
                    action(item);
                }
            }

  
            public static bool AreEqual<T>(this T obj, T otherObj)
            {
                return EqualityComparer<T>.Default.Equals(obj, otherObj);
            }

            public static string ToSeparatedString(this IEnumerable<string> collection, string separator = ", ")
            {
                return string.Join(separator, collection);
            }

            public static string ToJson<T>(this T obj)
            {
                return JsonUtility.ToJson(obj);
            }

            public static T FromJson<T>(this string json)
            {
                return JsonUtility.FromJson<T>(json);
            }


            public static string ToConcatenatedString(this IEnumerable<string> collection, string separator = ", ")
            {
                return string.Join(separator, collection);
            }





        }
    }
}