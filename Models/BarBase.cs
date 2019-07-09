using System.ComponentModel.DataAnnotations;

namespace DeepValidationRepro.Models
{
    public abstract class BarBase
    {
        [Required]
        public string BarBaseField { get; set; }
    }
}
