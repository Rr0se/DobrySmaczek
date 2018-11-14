using DobrySmaczek.Entities;
using DobrySmaczek.Services.User.Models;
using System;
using System.Linq;

namespace DobrySmaczek.Services.User
{

    public class UserService : IUserService
    {
        private readonly DataBaseContext _context;
        private readonly ITokenGenerate _tokenService;

        public UserService(DataBaseContext context, ITokenGenerate tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public GlobalServiceModel<LoginOutputViewModel> Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                return null;

            var user = _context.AppUsers.FirstOrDefault(x => x.Email == email);

            // check if username exists
            if (user == null)
                return new GlobalServiceModel<LoginOutputViewModel> { ServiceResponse = ServiceResponseEnum.Failed, Message = "User not found"};

            // check if password is correct
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return new GlobalServiceModel<LoginOutputViewModel> { ServiceResponse = ServiceResponseEnum.Failed, Message = "Wrong password" };

            var token = _tokenService.TokenAuthenticateGenerate(user);

            return new GlobalServiceModel<LoginOutputViewModel>
            {
                ServiceResponse = ServiceResponseEnum.Ok,
                Response = new LoginOutputViewModel
                {
                    Token = token
                }
            };
        }

        public GlobalServiceModel Register(UserInputViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Password))
                return new GlobalServiceModel { ServiceResponse = ServiceResponseEnum.Failed, Message = "Password is required" };

            if (_context.AppUsers.Any(x => x.Email == model.Email))
                return new GlobalServiceModel { ServiceResponse = ServiceResponseEnum.Failed, Message = "Username \"" + model.Email + "\" is already taken" };

            CreatePasswordHash(model.Password, out var passwordHash, out var passwordSalt);

            var userEntity = new AppUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                PhoneNumber = model.PhoneNumber,
                PostCode = model.PostCode,
                City = model.City,
                Street = model.Street,
                HouseNumber = model.HouseNumber,
                UserType = UserType.User
            };

            _context.AppUsers.Add(userEntity);
            _context.SaveChanges();

            return new GlobalServiceModel { ServiceResponse = ServiceResponseEnum.Ok };
        }


        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }
        
    }
}
