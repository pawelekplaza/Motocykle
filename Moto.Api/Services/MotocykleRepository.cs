using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto.Api.Entities;
using Moto.Api.Models;

namespace Moto.Api.Services
{
    public class MotocykleRepository : IMotocykleRepository
    {
        private MotocyklContext _context;

        public MotocykleRepository(MotocyklContext context)
        {
            _context = context;
        }

        public MotocyklDto GetMotorcycle(int id)
        {
            var entity = _context.Motocykle.Where(value => value.Id == id).FirstOrDefault();
            return new MotocyklDto
            {
                Id = entity.Id,
                Marka = entity.Marka,
                Model = entity.Model,
                Chlodzenie = entity.Chlodzenie,
                Masa = entity.Masa,
                PojemnoscSkokowa = entity.PojemnoscSkokowa,
                PojemnoscZbiornikaPaliwa = entity.PojemnoscZbiornikaPaliwa,
                PredkoscMaksymalna = entity.PredkoscMaksymalna,
                Typ = entity.Typ
            };
        }

        public IEnumerable<MotocyklDto> GetMotorcycles()
        {
            var entities = _context.Motocykle.OrderBy(value => value.Marka).ToList();
            var dtos = new List<MotocyklDto>();

            foreach (var element in entities)
            {
                dtos.Add(new MotocyklDto
                {
                    Id = element.Id,
                    Marka = element.Marka,
                    Model = element.Model,
                    Chlodzenie = element.Chlodzenie,
                    Masa = element.Masa,
                    PojemnoscSkokowa = element.PojemnoscSkokowa,
                    PojemnoscZbiornikaPaliwa = element.PojemnoscZbiornikaPaliwa,
                    PredkoscMaksymalna = element.PredkoscMaksymalna,
                    Typ = element.Typ
                });
            }

            return dtos;
        }
    }
}
