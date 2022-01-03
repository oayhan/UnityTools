using System.Collections.Generic;
using UnityEngine;

namespace OTools.Extensions
{
    public static class ListExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int randomIndex = Random.Range(0, n);
                (list[randomIndex], list[n]) = (list[n], list[randomIndex]);
            }
        }
        
        public static T GetRandomItem<T>(this IList<T> list)
        {
            return list.Count == 0 ? default(T) : list[Random.Range(0, list.Count)];
        }
        
        public static T PopRandomItem<T>(this IList<T> list)
        {
            if (list.Count == 0)
                return default(T);

            int randomIndex = Random.Range(0, list.Count);
            T randomItem = list[randomIndex];
            list.RemoveAt(randomIndex);

            return randomItem;
        }
    }
}