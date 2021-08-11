using System.ComponentModel.DataAnnotations;

namespace Timesheets.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}