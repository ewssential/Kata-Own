using System;
using System.Linq;

namespace Isograms
{
    public static class Class1
    {
        public static bool IsIsogram(string str)
        {
            var upperStr = str.ToUpper();
            foreach (var character in upperStr)
            {
                if (upperStr.Count(a => a.Equals(character)) > 1)
                {
                    return false;
                }
            }
            // str
            // Code on you crazy diamond!
            return true;
        }
    }
}
