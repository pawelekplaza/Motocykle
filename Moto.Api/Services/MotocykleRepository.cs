using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moto.Api.Entities;
using Moto.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Moto.Api.Services
{
    public class MotocykleRepository : IMotocykleRepository
    {
        private MotocyklContext _context;        

        public MotocykleRepository(MotocyklContext context)
        {
            _context = context;
        }

        public void AddMotorcycle(MotocyklForCreationDto motorcycle)
        {
            var entity = AutoMapper.Mapper.Map<Motocykl>(motorcycle);
            _context.Motocykle.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteMotorcycle(Motocykl motorcycle)
        {
            _context.Motocykle.Remove(motorcycle);
            _context.SaveChanges();
        }

        public MotocyklDto GetMotorcycle(int id)
        {
            var entity = _context.Motocykle.AsNoTracking().Where(value => value.Id == id).FirstOrDefault();
            return AutoMapper.Mapper.Map<MotocyklDto>(entity);
        }

        public IEnumerable<MotocyklDto> GetMotorcycles()
        {
            var entities = _context.Motocykle.AsNoTracking().OrderBy(value => value.Marka).ToList();
            var dtos = new List<MotocyklDto>();

            foreach (var element in entities)
            {
                dtos.Add(AutoMapper.Mapper.Map<MotocyklDto>(element));
            }

            return dtos;
        }

        public void UpdateMotorcycle(int id, MotocyklForCreationDto motorcycle)
        {
            var entity = _context.Motocykle.Where(v => v.Id == id).FirstOrDefault();
            var updatedMoto = new Motocykl
            {
                Id = id,
                Marka = motorcycle.Marka ?? entity.Marka,
                Model = motorcycle.Model ?? entity.Model,
                Chlodzenie = motorcycle.Chlodzenie ?? entity.Chlodzenie,
                Masa = motorcycle.Masa ?? entity.Masa,
                PojemnoscSkokowa = motorcycle.PojemnoscSkokowa ?? entity.PojemnoscSkokowa,
                PojemnoscZbiornikaPaliwa = motorcycle.PojemnoscZbiornikaPaliwa ?? entity.PojemnoscZbiornikaPaliwa,
                PredkoscMaksymalna = motorcycle.PredkoscMaksymalna ?? entity.PredkoscMaksymalna,
                Typ = motorcycle.Typ ?? entity.Typ
            };

            _context.Entry(entity).CurrentValues.SetValues(updatedMoto);
            _context.SaveChanges();
        }
    }
}
