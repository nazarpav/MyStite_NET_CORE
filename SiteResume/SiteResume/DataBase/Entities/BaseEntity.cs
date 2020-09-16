using System;
using System.ComponentModel.DataAnnotations;
namespace SiteResume.DataBase.Entities
{
    public interface IBaseEntity<T>
    {
        T Id { get; set; }
        DateTime? DateDelete { get; set; }
    }
    public abstract class BaseEntity<T> : IBaseEntity<T>
    {
        [Key]
        public virtual T Id { get; set; }
        public virtual DateTime DateCreate { get; set; }
        public virtual DateTime DateModify { get; set; }
        public virtual DateTime? DateDelete { get; set; }
    }
}
