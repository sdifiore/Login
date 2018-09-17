using System.Threading.Tasks;

namespace Login.Core
{
    public interface IAuthenticate
    {
        Task LoginAsync();
    }
}
