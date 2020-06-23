using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public interface IRepository<TEntity>
{
    DbContext DbContext { get; }

    bool Create(TEntity entity);
    Task<bool> CreateAsync(TEntity entity);
    TEntity Get(Guid id);
    List<TEntity> GetAll();
    Task<List<TEntity>> GetAllAsync();
    bool Update(TEntity entity);
    bool Update(List<TEntity> entities);
    Task<bool> UpdateAsync(TEntity entity);
    Task<bool> UpdateAsync(List<TEntity> entities);
    void Delete(TEntity entity);
    Task DeleteAsync(TEntity entity);
    List<TEntity> GetByLinq(Expression<Func<TEntity, bool>> predicate);
    Task<List<TEntity>> GetByLinqAsync(Expression<Func<TEntity, bool>> predicate);
}
