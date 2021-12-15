using System.Threading.Tasks;

namespace Sep3Vacation.Data
{
    public interface ICryptoService
    {
        Task<string> Encrypt(string toEncrypt);
        Task<string> Decrypt(string toDecrypt);
    }
}