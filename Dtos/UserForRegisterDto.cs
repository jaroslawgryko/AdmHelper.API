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
        [Required]
        [StringLength(60)]
        public string JednostkaNazwa { get; set; }
        public string JednostkaOpis { get; set; }
        [Required]
        [StringLength(16)]
        public string Symbol { get; set; }        
    }
}