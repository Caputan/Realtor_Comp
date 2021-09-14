using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RieltorComp.Models
{
    public class Properties
    {
        public int Id { get; set; }
        [Required] public string Owner_FIO { get; set; }
        [Required] public string Owner_Passport { get; set; }
        [Required] public string Address { get; set; }
        [Required] public string Living_Area { get; set; }
        [Required] public int Number_Of_Rooms { get; set; }
    }
}