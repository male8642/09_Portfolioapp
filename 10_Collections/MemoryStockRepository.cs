using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;


namespace _10_Collections
{
    public class MemoryStockRepository : IStockRepository
    {
        private long ID = 0;
        Dictionary<long, Stock> Database = new Dictionary<long, Stock>();

        public long NextId()
        {
            this.ID++;
            return ID;
        }
        public void SaveStock(Stock Stock)
        {
            Database.Add(ID, Stock);
            this.NextId();
        }

        public Stock LoadStock(long id)
        {
            if (Database.ContainsKey(id))
            {
                return Database[id];
            }
            else
            {
                return null;
            }
        }

        public ICollection FindAllStocks()
        {
            return Database;
        }

        public void Clear()
        {
            Database.Clear();
        }
        }
    }
