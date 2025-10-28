using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } =null!; 
        [Required]
        public decimal Amount { get; set; }
        [Required]
        [Range(0.01, double.MaxValue)]
        public string Category { get; set; } =null!;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
