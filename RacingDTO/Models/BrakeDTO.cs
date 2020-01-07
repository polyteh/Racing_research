﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingDTO.Models
{
   public class BrakeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EffecientKoef { get; set; }
        public string Manufacurer { get; set; }
        public decimal Price { get; set; }
        ICollection<RacingCarDTO> RacingCar { get; set; }
    }
}
