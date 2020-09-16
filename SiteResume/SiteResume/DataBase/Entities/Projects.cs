using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteResume.DataBase.Entities
{
    public class Projects : BaseEntity<int>
    {
        [Required, StringLength(32)]
        public string ProjectName { get; set; }
        [Required, StringLength(32)]
        public string ProjectType { get; set; }
        [Required, StringLength(32)]
        public string EngineOrPlatform { get; set; }
    }
}
