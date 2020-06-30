using SiloModel;
using System;
using System.Collections.Generic;

namespace SiloData
{
    public interface IDataRepository
    {
        IEnumerable<Data> GetAll();

        Data LastInsert();

        IEnumerable<Data> GetCurrentDay(DateTime date);

        IEnumerable<Data> SelectDate(DateTime dateFrom, DateTime dateTo);
    }
}
