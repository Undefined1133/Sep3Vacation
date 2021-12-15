using System.Text.Json.Serialization;

namespace Sep3Vacation.Models
{
    public class BoughtPackage
    {
        [JsonPropertyName("id")]
        public int BoughtPackageId { get; set; }
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("packageId")]
        public int PackageId { get; set; }

        public BoughtPackage()
        {
            
        }

        public BoughtPackage(int boughtPackageId, int userId, int packageId)
        {
            BoughtPackageId = boughtPackageId;
            UserId = userId;
            PackageId = packageId;
        }

        public override string ToString()
        {
            return BoughtPackageId + " " + UserId + " " + PackageId +"'";
        }
    }
}