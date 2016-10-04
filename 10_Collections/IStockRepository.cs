using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;

namespace _10_Collections
{
    public interface IStockRepository
    {
       long NextId();
        void SaveStock(Stock yhoo);
        Stock LoadStock(long id);
        ICollection FindAllStocks();
        void Clear();
    }
}