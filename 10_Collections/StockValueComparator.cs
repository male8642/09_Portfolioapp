using System;
using System.Collections.Generic;

namespace _10_Collections
{
    public class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset A, IAsset B)
        {
            return B.GetValue().CompareTo(A.GetValue());
        }
    }
}