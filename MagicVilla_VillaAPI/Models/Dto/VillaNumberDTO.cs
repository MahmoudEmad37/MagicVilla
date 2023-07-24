using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class VillaNumberDTO
    {
        [Required]
        public int villaNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string specialDetails { get; set; }
        public VillaDTO Villa { get; set; }
    }
}
