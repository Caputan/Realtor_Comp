using System.ComponentModel.DataAnnotations;

namespace RieltorComp.Models
{
    public class Services
    {
        public int Id { get; set; }
        [Required] public string Service_Name { get; set; }
    }
}