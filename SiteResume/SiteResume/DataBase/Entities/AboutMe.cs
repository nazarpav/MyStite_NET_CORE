using System;
using System.ComponentModel.DataAnnotations;
namespace SiteResume.DataBase.Entities
{
    public class AboutMe:BaseEntity<int>
    {
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Surname { get; set; }
        [Required, StringLength(255)]
        public string Patronimic { get; set; }
        [Required, StringLength(255)]
        public string UrlSlug { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required, StringLength(64)]
        public string Email { get; set; }
        [Required, StringLength(255)]
        public string GitHubLink { get; set; }
        [Required, StringLength(255)]
        public string LinkedInLink { get; set; }
        [Required, StringLength(255)]
        public string TelegramLink { get; set; }
        [Required]
        public string Skills { get; set; }
        [Required]
        public string EmploymentHistory { get; set; }
        [Required, StringLength(16)]
        public string EnglishLevel { get; set; }
        [Required]
        public string Educations { get; set; }
        [Required]
        public string AdditionalEducations { get; set; }
        [Required]
        public string CareerObjective { get; set; }
    }
}
