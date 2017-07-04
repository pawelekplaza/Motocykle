using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Moto.Api.Models
{
    public class MotocyklForCreationDto
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Za długa nazwa marki.")]        
        public string Marka { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Za długa nazwa modelu.")]
        public string Model { get; set; }
        
        [MaxLength(50, ErrorMessage = "Za długa nazwa typu.")]
        public string Typ { get; set; }
        
        public double PojemnoscSkokowa { get; set; }       
        public string Chlodzenie { get; set; }
        public double Masa { get; set; }
        public double PojemnoscZbiornikaPaliwa { get; set; }
        public int PredkoscMaksymalna { get; set; }
    }
}
