using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public static class Rand
    {
        private static Random random = new Random();

        public static int Next()
        {
            return Rand.random.Next();
        }

        public static int Next(int maxValue)
        {
            return Rand.random.Next(maxValue);
        }
    }
}
