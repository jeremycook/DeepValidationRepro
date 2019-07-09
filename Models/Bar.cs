using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepValidationRepro.Models
{
    public class Bar : BarBase
    {
        [Required]
        public string BarField { get; set; }
    }
}
