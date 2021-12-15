using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Sep3Vacation.Models;

namespace Sep3Vacation.Data
{
    public class CloudPackageService: IPackagesService
    {
        
        private readonly HttpClient client;
        private string uri = "http://localhost:5001";

        public CloudPackageService()
        {
            client = new HttpClient();
        }
        public async Task<IList<Package>> GetAllPackagesAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri+ "/packages");
            string message =  await stringAsync;
            List<Package> result = JsonSerializer.Deserialize<List<Package>>(message);
            return result;
        }

        public async Task<Package> AddPackageAsync(Package package)
        {
            string packagesAsJson = JsonSerializer.Serialize(package);
            HttpContent content = new StringContent(packagesAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri+"/Packages", content);
            return package;
        }

        public async Task RemovePackageAsync(int packageId)
        {
            await client.DeleteAsync($"{uri}/Packages/{packageId}");
        }

        public async Task<Package> UpdatePackageAsync(Package package)
        {
            string packagesAsJson = JsonSerializer.Serialize(package);
            HttpContent content = new StringContent(packagesAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PatchAsync($"{uri}/Packages/{package.ID}", content);
            return await GetPackageAsync(package.ID);
        }

        public async Task<Package> GetPackageAsync(int packageId)
        {
            Task<string> stringAsync = client.GetStringAsync($"{uri}/Packages/ID?id={packageId}");
            string message = await stringAsync;
            Package result = JsonSerializer.Deserialize<Package>(message);
            return result;
        }
    }
}