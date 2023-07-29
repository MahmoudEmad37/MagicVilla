namespace MagicVilla_VillaAPI.Models.Dto
{
    public class LoginResponseDTO
    {
        public UserDTO user { get; set; }
        //public string role { get; set; }
        public string token { get; set; }
    }
}
