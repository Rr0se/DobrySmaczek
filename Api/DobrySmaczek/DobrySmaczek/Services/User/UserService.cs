using DobrySmaczek.Entities;
using DobrySmaczek.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.User

{
    
    public class UserService :IUserService
    {
            private DataBaseContext _context;

            public UserService(DataBaseContext context)
            {
                _context = context;
            }

            public User Authenticate(string UserName, string password)
            {
                if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(password))
                    return null;

                var user = _context.Users.SingleOrDefault(x => x.UserName == UserName);

                // check if username exists
                if (user == null)
                    return null;

                // check if password is correct
                if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                    return null;

                // authentication successful
                return user;
            }

            public IEnumerable<Users> GetAll()
            {
                return _context.User;
            }

            public Users GetById(int id)
            {
                return _context.User.Find(id);
            }

            public Users Create(User user, string password)
            {
                // validation
                if (string.IsNullOrWhiteSpace(password))
                    throw new AppException("Password is required");

                if (_context.Users.Any(x => x.UserName == user.UserName))
                    throw new AppException("Username \"" + user.UserName + "\" is already taken");

                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                _context.Users.Add(user);
                _context.SaveChanges();

                return user;
            }

            public void Update(User userParam, string password = null)
            {
                var user = _context.Users.Find(userParam.Id);

                if (user == null)
                    throw new AppException("User not found");

                if (userParam.Username != user.UserName)
                {
                    // username has changed so check if the new username is already taken
                    if (_context.Users.Any(x => x.UserName == userParam.Username))
                        throw new AppException("Username " + userParam.Username + " is already taken");
                }

                // update user properties
                user.FirstName = userParam.FirstName;
                user.LastName = userParam.LastName;
                user.UserName = userParam.Username;

                // update password if it was entered
                if (!string.IsNullOrWhiteSpace(password))
                {
                    byte[] passwordHash, passwordSalt;
                    CreatePasswordHash(password, out passwordHash, out passwordSalt);

                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                }

                _context.Users.Update(user);
                _context.SaveChanges();
            }

            public void Delete(int id)
            {
                var user = _context.Users.Find(id);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                }
            }

            // private helper methods

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

        //IEnumerable<Entities.User> IUserService.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //User IUserService.GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public User Create(Entities.User user, string password)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Entities.User user, string password = null)
        //{
        //    throw new NotImplementedException();
        //}

        //void IUserService.Create(User user, string password)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
