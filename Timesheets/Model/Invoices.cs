using System;
using System.ComponentModel.DataAnnotations;

namespace Timesheets.Model
{
    public class Invoices
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int ContractId { get; set; }
        
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        public DateTimeOffset Date { get; set; }
        
        [Required]
        public int Total { get; set; }
    }
}