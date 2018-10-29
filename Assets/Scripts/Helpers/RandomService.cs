using System.Linq;
using System.Text;
using UnityEngine;

namespace Helpers
{
    public static class RandomService
    {
        private static char[] letters = new[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g',
            'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q', 'r', 's', 't', 'u',
            'v', 'w', 'x', 'y', 'z', ' '
        };

        public static bool RollD100(int chance) => Random.Range(1, 101) <= chance;

        public static int GetRandom(int min, int max) => Random.Range(min, max);

        public static float GetRandom(float min, float max) => Random.Range(min, max);

        public static string GetRunicName()
        {
            var sb = new StringBuilder();
            foreach (var i in Enumerable.Range(0, GetRandom(3, 12)))
            {
                sb.Append(letters.PickOne());
            }

            return sb.ToString();
        }
    }
}
