using SiteResume.DataBase.Context;
using SiteResume.DataBase.Entities;
using SiteResume.DataBase.Repositories.Interafaces;
namespace SiteResume.DataBase.Repositories.Implement
{
    public class AboutMeRepository : BaseRepository<AboutMe, int>, IAboutMeRepository
    {
        public AboutMeRepository(SiteResumeDBContext context) : base(context)
        {
        }
    }
}
