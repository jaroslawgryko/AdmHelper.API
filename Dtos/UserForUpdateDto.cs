using System;
using System.ComponentModel.DataAnnotations;

namespace AdmHelper.API.Dtos
{
    public class UserForUpdateDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(60)]        
        public string InstytucjaNazwa { get; set; }          
        [Required]
        [StringLength(16)]        
        public string InstytucjaSymbol { get; set;}
        public string InstytucjaOpis { get; set; }
    }
}