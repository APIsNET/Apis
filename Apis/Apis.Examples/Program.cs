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
            IFacebookClient client = new FacebookClient("EAADCfA453fMBAJ1paZAXYQbZAJ2eCO2xJ9PHZBSggRK6HmOi9YmAZAfrEH1zOqCIqPgqnh8E8QbmMp6pd5ukK2onre9NN79LVZAXTFNCCZBPgR49ocOMtblEZCcwFYzkIvXAVYZAbG1GAe31aRdGc9JXpHr4LzydWRH09zGKb0KIxndZCCKanDlj4R9KIGtgk2ZCPfB14wKhfEvJmASfJSMG5a9DBonSfWgSyfggZAtZCkVhQ3HBeiT2vWEa");
            //var user = await client.Users.GetMeAsync(UserField.id, UserField.name, UserField.name_format, UserField.languages, UserField.hometown, UserField.birthday, UserField.age_range);
            var user = await client.Users.GetUserByIdAsync("4");
            Console.WriteLine($"Id: {user.Id} {user.Quotes} {user.Religion} {user.Birthday}");
        }
    }
}