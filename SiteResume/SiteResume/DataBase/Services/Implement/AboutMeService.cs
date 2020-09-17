using AutoMapper;
using SiteResume.DataBase.Entities;
using SiteResume.DataBase.Repositories.Interafaces;
using SiteResume.DataBase.Services.Interfaces;
using SiteResume.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SiteResume.DataBase.Services.Implement
{
    public class AboutMeService : IAboutMeService
    {
        private readonly IAboutMeRepository _aboutMeRepository; 
        private readonly IMapper _mapper;
        public AboutMeService(IAboutMeRepository repository, IMapper mapper)
        {
            _aboutMeRepository = repository;
            _mapper = mapper;
        }
        public void Admin_AddNews(Admin_AboutMeVM newsAdd)
        {
            throw new NotImplementedException();
        }
        public Admin_AboutMeVM[] Admin_GetAllEntries()
        {
            throw new NotImplementedException();
        }
        public AboutMeVM GetEntry()
        {
            return _mapper.Map<AboutMe, AboutMeVM> (_aboutMeRepository.GetAll().Where(q => q.IsActive == true).FirstOrDefault()) ;
        }
    }
}
