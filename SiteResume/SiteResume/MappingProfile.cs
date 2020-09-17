using AutoMapper;
using SiteResume.DataBase.Entities;
using SiteResume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteResume
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AboutMe, AboutMeVM>();
            CreateMap<AboutMeVM, AboutMe>();
        }
    }
}
