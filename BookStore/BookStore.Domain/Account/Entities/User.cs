using BookStore.Domain.Account.Enum;
using System;

namespace BookStore.Domain.Account.Entities
{
    public class User
    {
        public User(string username, string password, string email)
        {
            Id = Guid.NewGuid();
            Username = username;
            Password = password;
            Email = email;
            Role = ERole.User;
            VerificationCode = Guid.NewGuid();
            Verification = false;
            Active = false;
            LastLoginDate = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public ERole Role { get; private set; }
        public Guid VerificationCode { get; private set; }
        public bool Verification { get; private set; }
        public bool Active { get; private set; }
        public DateTime LastLoginDate { get; private set; }

        public string CodeToEmail()
        {
            return VerificationCode.ToString().Substring(0, 6).ToUpper();
        }

        public void Verify(string verification)
        {
            if (verification == VerificationCode.ToString().ToUpper())
            {
                Verification = true;
            }
        }

        public void ConfirmPassword(string confirmPassword)
        {
            if (confirmPassword == Password)
            {
                Active = true;
            }
        }
    }
}