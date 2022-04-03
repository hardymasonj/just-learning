using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Learning.Extensions.Folders
{
    public static class CollectionExtensions
    {
        public static void AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> collection, TKey key, TValue value)
        {
            if (collection.ContainsKey(key)) 
            {
                collection[key] = value;
                return;
            }
            collection.Add(key, value);
        }
    }
}
