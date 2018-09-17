using System.Threading.Tasks;
using Auth0.OidcClient;
using Login.Droid;
using Xamarin.Forms;
using Login.Core;

[assembly: Dependency(typeof(Authenticate))]

namespace Login.Droid
{
    public class Authenticate : IAuthenticate
    {
        public async Task LoginAsync()
        {
            var client = new Auth0Client(new Auth0ClientOptions

            {
                Domain = "difiore.auth0.com",
                ClientId = "Key goes here"
            });

            var loginResult = await client.LoginAsync();
        }
    }
}