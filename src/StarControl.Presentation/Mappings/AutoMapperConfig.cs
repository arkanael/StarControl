using AutoMapper;
using starcontrol.Entities;
using StarControl.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarControl.Presentation.Mappings
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ClienteCadastroViewModel, Cliente>();
        }
    }
}