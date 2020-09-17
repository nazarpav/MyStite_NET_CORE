using System;
namespace SiteResume.Models
{
    public class Admin_AboutMeVM
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronimic { get; set; }
        public string UrlSlug { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string RegisteredSocialNetworksWithPhone { get; set; }
        public string GitHubLink { get; set; }
        public string LinkedInLink { get; set; }
        public string TelegramLink { get; set; }
        public string Skills { get; set; }
        public string EmploymentHistory { get; set; }
        public string EnglishLevel { get; set; }
        public string Educations { get; set; }
        public string AdditionalEducations { get; set; }
        public string CareerObjective { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateModify { get; set; }
        public DateTime? DateDelete { get; set; }
    }
}
