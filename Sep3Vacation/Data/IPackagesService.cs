using System.Collections.Generic;
using System.Threading.Tasks;
using Sep3Vacation.Models;

namespace Sep3Vacation.Data
{
    public interface IPackagesService
    {
        Task<IList<Package>> GetAllPackagesAsync();
        Task<Package> AddPackageAsync(Package package);
        Task  RemovePackageAsync(int packageId);
        Task<Package> UpdatePackageAsync(Package package);
       
        Task <Package> GetPackageAsync(int packageId);
    }
}