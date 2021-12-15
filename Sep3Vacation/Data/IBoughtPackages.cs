using System.Collections.Generic;
using System.Threading.Tasks;
using Sep3Vacation.Models;
using Sep3Vacation.Pages;

namespace Sep3Vacation.Data
{
    public interface IBoughtPackages
    {
        Task<List<BoughtPackage>> GetBoughtPackagesAsync();
        
        Task<BoughtPackage> AddBoughtPackageAsync(BoughtPackage package);
        Task  RemovePackageAsync(int boughtPackageId);
        
        Task<BoughtPackage>UpdateBoughtPackageAsync(BoughtPackage package);
       
        Task <BoughtPackage> GetAsyncById(int boughtPackageId);
    }
}