using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Authentication
{
    public interface ICipherService
    {
        string Encrypt(string password);
        string Decrypt(string cipherText);
    }
}
