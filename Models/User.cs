using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AdmHelper.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }           
        public string Email { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public DateTime DataModyfikacji { get; set; }
        public ICollection<Jednostka> Jednostki { get; set; }
        public User()
        {
            Jednostki = new Collection<Jednostka>();
        }
    }
}