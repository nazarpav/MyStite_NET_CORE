using SiteResume.DataBase.Repositories.Interafaces;
using SiteResume.DataBase.Services.Interfaces;
using SiteResume.Models;
using System;
namespace SiteResume.DataBase.Services.Implement
{
    public class AboutMeService : IAboutMeService
    {
        private readonly IAboutMeRepository _aboutMeRepository;
        public AboutMeService(IAboutMeRepository repository)
        {
            _aboutMeRepository = repository;
        }

        public void AddNews(AboutMeVM newsAdd)
        {
            throw new NotImplementedException();
        }

        public AboutMeVM[] GetAllEntries()
        {
            return _aboutMeRepository.GetAll();
        }
    }
}
