using DobrySmaczek.Services.User.Models;


namespace DobrySmaczek.Services.User
{
    public interface IUserService
    {
        GlobalServiceModel<LoginOutputViewModel> Login(string email, string password);
        GlobalServiceModel Register(UserInputViewModel model);
    }
}
