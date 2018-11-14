using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobrySmaczek.Services.Email
{
    public interface IEmailService
    {
        void SendEmail(string userEmail, string bodyContent, string subject);
    }
}
