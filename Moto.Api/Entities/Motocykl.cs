using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Moto.Api.Entities
{
    public class Motocykl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Marka { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [MaxLength(50)]
        public string Typ { get; set; }

        public double PojemnoscSkokowa { get; set; }
        public string Chlodzenie { get; set; }
        public double Masa { get; set; }
        public double PojemnoscZbiornikaPaliwa { get; set; }
        public int PredkoscMaksymalna { get; set; }
    }
}
