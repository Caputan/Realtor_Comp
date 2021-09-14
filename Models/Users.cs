using System.ComponentModel.DataAnnotations;

namespace RieltorComp.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required] public string Username { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Role { get; set; }
    }
}