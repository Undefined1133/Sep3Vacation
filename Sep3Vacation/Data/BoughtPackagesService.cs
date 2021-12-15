using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Sep3Vacation.Models;
using Sep3Vacation.Pages;

namespace Sep3Vacation.Data
{
    public class BoughtPackagesService : IBoughtPackages
    {
        private readonly HttpClient _httpClient;
        private string uri = "http://localhost:5001";

        public BoughtPackagesService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<BoughtPackage>> GetBoughtPackagesAsync()
        {
            Task<string> stringAsync = _httpClient.GetStringAsync(uri + "/BoughtPackages");
            string message = await stringAsync;
            List<BoughtPackage> result = JsonSerializer.Deserialize<List<BoughtPackage>>(message);
            return result;
        }

        public async Task<BoughtPackage> AddBoughtPackageAsync(BoughtPackage boughtPackage)
        {
            string packagesAsJson = JsonSerializer.Serialize(boughtPackage);
            HttpContent content = new StringContent(packagesAsJson,
                Encoding.UTF8,
                "application/json");
            await _httpClient.PostAsync(uri + "/BoughtPackages", content);
            return boughtPackage;
        }

        public async Task RemovePackageAsync(int boughtPackageId)
        {
            await _httpClient.DeleteAsync($"{uri}/BoughtPackages/{boughtPackageId}");
        }

        public async Task<BoughtPackage> UpdateBoughtPackageAsync(BoughtPackage boughtPackage)
        {
            string packagesAsJson = JsonSerializer.Serialize(boughtPackage);
            HttpContent content = new StringContent(packagesAsJson,
                Encoding.UTF8,
                "application/json");
            await _httpClient.PatchAsync($"{uri}/BoughtPackages/{boughtPackage.BoughtPackageId}", content);
            return await GetAsyncById(boughtPackage.BoughtPackageId);
        }

        public async Task<BoughtPackage> GetAsyncById(int boughtPackageId)
        {
            Task<string> stringAsync = _httpClient.GetStringAsync($"{uri}/BoughtPackages/ID?id={boughtPackageId}");
            string message = await stringAsync;
            BoughtPackage result = JsonSerializer.Deserialize<BoughtPackage>(message);
            return result;
        }
    }
}