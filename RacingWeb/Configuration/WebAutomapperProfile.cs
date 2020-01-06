using AutoMapper;
using RacingDTO.Models;
using RacingWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RacingWeb.Configuration
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<EngineView, EngineDTO>().ReverseMap();
        }
    }
}

