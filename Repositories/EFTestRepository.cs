using SBC.DAL;
using SBC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SBC.Repositories
{
    public class EFTestRepository : IRepository<Test>
    {
        private ApplicationDbContext context;
        private DbSet<Test> table;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="ctx">Контекст базы данных</param>
        public EFTestRepository(ApplicationDbContext ctx)
        {
            context = ctx;
            table = context.test;
        }

        public void Create(Test t)
        {
            table.Add(t);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context
          .Entry(new Test { idTest = id })
          .State = EntityState.Deleted;
            context.SaveChanges();
        }

        public IEnumerable<Test> Find(Func<Test, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public Test Get(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<Test> GetAll()
        {
            return table;
        }

        public Task<Test> GetAsync(int id)
        {
            return context.test.FindAsync(id);
        }

        public Task<Test> GetFindCourses(int id)
        {
            return context.test.FindAsync(id);
        }

        public void Update(Test t)
        {
            throw new NotImplementedException();
        }
    }
}