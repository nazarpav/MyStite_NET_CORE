using System.ComponentModel.DataAnnotations;
namespace SiteResume.DataBase.Entities
{
    public class _Layout:BaseEntity<int>
    {
        [Required]
        public string Footer { get; set; }
    }
}
