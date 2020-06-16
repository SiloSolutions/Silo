using SiloUserModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiloUserData
{
    public interface IActivityRepository
    {
        IEnumerable<BoredApi> GetCategories();

        IEnumerable<BoredApi> SelectDate(DateTime dateFrom, DateTime dateTo);
    }
}
