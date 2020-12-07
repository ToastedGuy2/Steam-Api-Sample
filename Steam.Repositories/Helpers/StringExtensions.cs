using System;

namespace Steam.Repositories.Helpers
{
    internal static class StringExtensions
    {
        public static bool EqualsIgnoreCase(this string str1, string str2)
        {
            return String.Equals(str1, str2, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}