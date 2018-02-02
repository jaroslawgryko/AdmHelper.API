using System;

namespace AdmHelper.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime DataModyfikacji { get; set; }
        public string Email { get; set; }
        public string InstytucjaNazwa { get; set; }        
    }
}