using System;
using System.Collections.Generic;

namespace AdmHelper.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime DataModyfikacji { get; set; }
        public string Email { get; set; }
        public string JednostkaNazwa { get; set; }     
        public ICollection<JednostkaForDetailedDto> Jednostki { get; set; }          
    }
}