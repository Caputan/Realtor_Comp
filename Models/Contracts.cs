using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RieltorComp.Models
{
    public class Contracts
    {
        public int Id { get; set; }
        
        [ForeignKey("UsersId")]
        [Required] public Users Realtor { get; set; }
        
        [ForeignKey("PropertyId")]
        [Required] public Properties Property { get; set; }
     
        [ForeignKey("ClientsId")]
        [Required] public Clients Client { get; set; }
        
        [ForeignKey("ServicesId")]
        [Required] public Services Service_Done { get; set; }
        public string Service_Date { get; set; }
        [Required] public double Service_Price { get; set; }
        public string Service_Period { get; set; }
        public string Service_Persent { get; set; }
    }
}