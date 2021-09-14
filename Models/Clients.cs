using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RieltorComp.Models
{
    public class Clients
    {
        [Key]
        public int Id { get; set; }
        [Required] public string FIO { get; set; }
        [Required] public string Passport { get; set; }
        
        public ICollection<Contracts> ToDoItems { get; set; }
    }
}