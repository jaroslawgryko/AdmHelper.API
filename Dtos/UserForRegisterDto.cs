using System;
using System.ComponentModel.DataAnnotations;

namespace AdmHelper.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]        
        [StringLength(16, MinimumLength=4, ErrorMessage="Hasło musi mieć od 4 do 8 znaków.")]
        public string  Password { get; set; }     
        [Required]
        public string  Email { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public DateTime DataModyfikacji { get; set; }        
        [Required]
        [StringLength(60)]
        public string InstytucjaNazwa { get; set; }
        public string InstytucjaOpis { get; set; }
        [Required]
        [StringLength(16)]
        public string InstytucjaSymbol { get; set; }        
        public UserForRegisterDto()
        {
            DataUtworzenia = DateTime.Now;
            DataModyfikacji = DateTime.Now;
        }           
    }
}