using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Helpers
{
    public static class ExtensionMethods
    {
        public static T PickOne<T>(this IEnumerable<T> col)
        {
            var enumerable = col as T[] ?? col.ToArray();
            return enumerable[RandomService.GetRandom(0, enumerable.Count())];
        }
    }
}