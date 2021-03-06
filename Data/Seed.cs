using System;
using System.Collections.Generic;
using AdmHelper.API.Dtos;
using AdmHelper.API.Models;
using Newtonsoft.Json;

namespace AdmHelper.API.Data
{
    public class Seed
    {

        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            _context = context;

        }
        public void SeedUsers()
        {
            // _context.Users.RemoveRange(_context.Users);
            // _context.SaveChanges();

            var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");

            var usersForRegister = JsonConvert.DeserializeObject<List<UserForRegisterDto>>(userData);
            foreach (var userForRegister in usersForRegister)
            {
                //create the password hash
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash("password", out passwordHash, out passwordSalt);

                var user = new User() {
                    Username = userForRegister.Username.ToLower(),
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Email = userForRegister.Email,
                    DataUtworzenia = DateTime.Now,
                    DataModyfikacji = DateTime.Now
                };                

                var u = _context.Users.Add(user);

                var jednostka = new Jednostka()  {
                    Nazwa = userForRegister.InstytucjaNazwa,
                    Opis = userForRegister.InstytucjaOpis,
                    Symbol = userForRegister.InstytucjaSymbol,                    
                    DataModyfikacji = DateTime.Now,
                    User = u.Entity,
                    IsMain = true
                };
                _context.Jednostki.Add(jednostka);
            }            
            _context.SaveChanges();
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()){
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }         
    }
}