using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExtensions
{
    public static class ExtensionLINQ
    {
        public static IEnumerable<T> NotSelect<T>(this IEnumerable<T> numbers, Func<T, bool> filter)
        {
            List<T> returnToList = new List<T>();

            foreach (T item in numbers)
            {
                if(!filter(item)){
                    returnToList.Add(item);
                }
            }
            return returnToList;
        }
    }
}
