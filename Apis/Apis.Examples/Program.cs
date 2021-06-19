using Apis.Facebook;
using Apis.Facebook.Enums;
using Apis.Infra;
using System;
using System.Threading.Tasks;

namespace Apis.Examples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IFacebookClient client = new FacebookClient("EAADCfA453fMBAJXNzX4Hy5RozefsZBje9Uel6c7G1d1jHLZCtK8nYB73VvcuStrVXqC3DodE8t4J2advVw2kMzTRiljxg21e7sNbPVbKmiE1LFYaJwPB9n1RttKHYNbZBbkoNpsFgNTrxhuEYnBwyp7sz1MrdJKYvu6QRmZAvqalI29b9N4jEZBqfYZAuranqBigek8g23iAZDZD");
            var user = await client.Users.GetMeAsync(Field.id, Field.first_name, Field.name);
        }
    }
}