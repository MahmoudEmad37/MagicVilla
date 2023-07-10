using MagicVilla_VillaAPI.Models.DTO;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>(){
            new VillaDTO{ id=1,name="Pool View",occupancy=4,sqft=100},
            new VillaDTO{ id=2,name="Beach View",occupancy=3,sqft=300}
            };
    }
}
