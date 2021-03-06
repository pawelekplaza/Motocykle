﻿using Moto.Api.Entities;
using Moto.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moto.Api.Services
{
    public interface IMotocykleRepository
    {
        IEnumerable<MotocyklDto> GetMotorcycles();
        MotocyklDto GetMotorcycle(int id);
        void AddMotorcycle(MotocyklForCreationDto motorcycle);
        void DeleteMotorcycle(Motocykl motorcycle);
        void UpdateMotorcycle(int id, MotocyklForCreationDto motorcycle);
    }
}
