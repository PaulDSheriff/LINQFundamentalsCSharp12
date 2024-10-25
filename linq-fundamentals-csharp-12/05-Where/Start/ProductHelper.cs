using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples
{
    public static class ProductHelper 
    {
        public static IEnumerable<Product> ByColour(this IEnumerable<Product> query, string color)
        {
            query = query.Where(p => p.Color == color);
            return query;
        }

    }
}
