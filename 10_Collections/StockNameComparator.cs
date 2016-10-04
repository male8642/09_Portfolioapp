using System;
using System.Collections;
using System.Collections.Generic;


namespace _10_Collections
{
   public class StockNameComparator : IComparer <IAsset>
    {
        public int Compare(IAsset A, IAsset B)
        {
            return string.Compare(A.GetName(), B.GetName());
        }
    }
 
}