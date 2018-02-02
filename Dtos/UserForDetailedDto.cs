using System;
using System.Collections.Generic;

namespace AdmHelper.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public DateTime DataModyfikacji { get; set; }
        public string Email { get; set; }
        public string InstytucjaNazwa { get; set; } 
        public string InstytucjaSymbol { get; set; }
        public string InstytucjaOpis { get; set; }
        public ICollection<JednostkaForDetailedDto> Jednostki { get; set; }          
    }
}