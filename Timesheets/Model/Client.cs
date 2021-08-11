using System.ComponentModel.DataAnnotations;

namespace Timesheets.Model
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}