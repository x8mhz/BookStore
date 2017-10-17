using System;

namespace BookStore.Domain.Account.Entities
{
    public class User
    {
        public User(string username, string password, bool active)
        {
            Username = username;
            Password = password;
            Active = active;
            RegisterDate = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }
        public DateTime RegisterDate { get; private set; } 
    }
}