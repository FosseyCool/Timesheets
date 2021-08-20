using System.ComponentModel.DataAnnotations;

namespace Timesheets.Model
{
    public class Entity<TUniqueId> where TUniqueId : struct
    {
        [Key]
        public TUniqueId Id { get; set; }

        public bool IsDeleted { get; set; }
    }
}