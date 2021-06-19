using Apis.Facebook.Enums;
using Apis.Facebook.Models;
using System.Threading.Tasks;
namespace Apis.Facebook.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetMeAsync();
        Task<User> GetMeAsync(params UserField[] fields);
    }
}