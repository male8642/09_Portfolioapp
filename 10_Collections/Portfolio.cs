using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;

namespace _10_Collections
{
    internal class Portfolio
    {
        public List<IAsset> Stocks = new List<IAsset>();

        public Portfolio(List<IAsset> stocks)
        {
            Stocks = stocks;
        }

        public Portfolio()
        {

        }


        public void AddAsset(Stock assets)
        {
            Stocks.Add(assets);
        }

        public IList<IAsset> GetAssets()
        {
            return Stocks.AsReadOnly();
        }

        public IAsset GetAssetByName(string Name)
        {
            foreach (IAsset n in Stocks)
            {
                if (n.GetName() == Name)
                {
                    return n;
                }
            }
            return null;
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            Stocks.Sort(new StockValueComparator());
            return Stocks;
        }

        internal IList<IAsset> GetAssetsSortedByName()
        {
            Stocks.Sort(new StockNameComparator());
            return Stocks;
        }
    }
}