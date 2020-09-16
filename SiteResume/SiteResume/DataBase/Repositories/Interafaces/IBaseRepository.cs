using SiteResume.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace SiteResume.DataBase.Repositories.Interafaces
{
    public interface IBaseRepository<TEntity, TId> where TEntity : class, IBaseEntity<TId>
    {
        IQueryable<TEntity> GetAll(bool notDeleted = true);
        Task<TId> Add(TEntity entity);
        List<TEntity> GetPageList(int page, int pageSize, Expression<Func<TEntity, bool>> filter = null);
        int GetCountItems();
    }
}
