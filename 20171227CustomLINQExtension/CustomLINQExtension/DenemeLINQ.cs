using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomLINQExtension
{
    public static class DenemeLINQ
    {
        public static T SelectGivenElement<T>(this IEnumerable<T> numbers, Func<T, bool> filter)
        {
            
            foreach (T item in numbers)
            {
                if (filter(item))
                {
                    return item;
                }
            }
            return default(T);
        }

    }
}
