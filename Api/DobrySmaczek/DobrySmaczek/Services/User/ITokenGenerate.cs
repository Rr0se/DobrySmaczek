using DobrySmaczek.Entities;

namespace DobrySmaczek.Services.User
{
    public interface ITokenGenerate
    {
        string TokenAuthenticateGenerate(AppUser user);
    }
}
