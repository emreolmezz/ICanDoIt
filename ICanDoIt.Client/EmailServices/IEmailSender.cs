﻿using System.Threading.Tasks;

namespace ICanDoIt.Client.EmailServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
