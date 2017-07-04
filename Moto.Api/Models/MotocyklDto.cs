using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto.Api.Models
{
    public class MotocyklDto
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Typ { get; set; }
        public double PojemnoscSkokowa { get; set; }
        public string Chlodzenie { get; set; }
        public double Masa { get; set; }
        public double PojemnoscZbiornikaPaliwa { get; set; }
        public int PredkoscMaksymalna { get; set; }
    }
}
