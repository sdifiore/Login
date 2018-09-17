using System.Threading.Tasks;
using Auth0.OidcClient;
using Login.Core;
using Login.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(Authenticate))]

namespace Login.iOS
{
    class Authenticate : IAuthenticate
    {
        public async Task LoginAsync()
        {
            var client = new Auth0Client(new Auth0ClientOptions

            {
                Domain = "difiore.auth0.com",
                ClientId = "VaolrWH9QOZwaW3IyS5Pki9tJ5n7iung"
            });

            var loginResult = await client.LoginAsync();
        }
    }
}