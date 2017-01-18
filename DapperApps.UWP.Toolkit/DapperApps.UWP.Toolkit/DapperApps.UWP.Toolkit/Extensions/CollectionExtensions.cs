using System.Collections.Generic;

namespace DapperApps.UWP.Toolkit.Extensions
{
    public static class CollectionExtensions
    {
        public static bool IsEmpty<T>(this ICollection<T> source)
        {
            return null != source && source.Count == 0;
        }
    }
}
