using SiloApplication.Models;

namespace SiloApplication.Data
{
    public interface IDataAccess
    {
        void Insert(Lambda lambda);
    }
}
