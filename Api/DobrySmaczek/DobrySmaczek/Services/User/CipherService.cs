using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Authentication
{
    public class CipherService
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;

        public CipherService(IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtectionProvider = dataProtectionProvider;
        }

        public string Encrypt(string password)
        {
            var protector = _dataProtectionProvider.CreateProtector(AppSettingsService.AppSettingsService.CipherKey);
            var hash = protector.Protect(password);
            return hash;
        }

        public string Decrypt(string cipherText)
        {
            var protector = _dataProtectionProvider.CreateProtector(AppSettingsService.AppSettingsService.CipherKey);
            var response = protector.Unprotect(cipherText);
            return response;
        }
    }
}
