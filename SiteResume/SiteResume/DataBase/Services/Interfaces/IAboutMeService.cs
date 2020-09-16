using SiteResume.Models;
namespace SiteResume.DataBase.Services.Interfaces
{
    public interface IAboutMeService
    {
        AboutMeVM GetEntry();
        Admin_AboutMeVM[] Admin_GetAllEntries();
        void Admin_AddNews(Admin_AboutMeVM newsAdd);
    }
}
