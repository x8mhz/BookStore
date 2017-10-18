using BookStore.Domain.Account.Enum;
using System;

namespace BookStore.Domain.Account.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get;set; }
        public string Email { get; set; }
        public ERole Role { get; set; }
        public Guid VerificationCode { get; set; }
        public bool Verification { get; set; }
        public bool Active { get; set; }
        public DateTime LastLoginDate { get; set; }

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