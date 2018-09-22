using System;
using System.Collections.Generic;
using System.Linq;
using SmallTasks._2_FilterCollection;

namespace SmallTasks.Extensions
{
    public static class Extensions
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> knownKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (knownKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static IEnumerable<Element> GetUniqueWithAgeMoreThan20(this IEnumerable<Element> source)
        {
            return source.Where(x => x.Age > 20).DistinctBy(x => x.Num);
        }
    }
}
