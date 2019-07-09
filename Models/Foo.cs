using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepValidationRepro.Models
{
    public class Foo
    {
        [Required]
        public string FooField { get; set; }

        [Required]
        public BarBase Bar { get; set; }

        [Required]
        public List<BarBase> Bars { get; set; } = new List<BarBase>();
    }
}
