using Apis.Facebook.Services.Interfaces;
using Apis.Infra;
namespace Apis.Facebook
{
    public interface IFacebookClient : IClient
    {
        IUserService Users { get; }
    }
}