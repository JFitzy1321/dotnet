using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace example.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        public DbContext DbContext { get; }

        public PersonRepository(DbContext dbContext)
        {
            DbContext = dbContext;
        }


        public Person Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return DbContext.Set<Person>().ToList();
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await DbContext.Set<Person>().ToListAsync();
        }

        public List<Person> GetByLinq(Expression<Func<Person, bool>> predicate)
        {
            return DbContext.Set<Person>().Where(predicate).ToList();
        }

        public async Task<List<Person>> GetByLinqAsync(Expression<Func<Person, bool>> predicate)
        {
            return await DbContext.Set<Person>().Where(predicate).ToListAsync();
        }

        public bool Update(Person entity)
        {
            var tracking = DbContext.Set<Person>().Update(entity);
            return DbContext.SaveChanges() > 0;

        }

        public bool Create(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateAsync(Person entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(List<Person> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(List<Person> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}