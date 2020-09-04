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
    public class EFTestRepository : IRepository<TestItem>
    {
        private ApplicationDbContext context;
        private DbSet<TestItem> table;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="ctx">Контекст базы данных</param>
        public EFTestRepository(ApplicationDbContext ctx)
        {
            context = ctx;
            table = context.test;
        }

        public void Create(TestItem t)
        {
            table.Add(t);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context
          .Entry(new TestItem { idTest = id })
          .State = EntityState.Deleted;
            context.SaveChanges();
        }

        public IEnumerable<TestItem> Find(Func<TestItem, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public TestItem Get(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<TestItem> GetAll()
        {
            return table;
        }

        public Task<TestItem> GetAsync(int id)
        {
            return context.test.FindAsync(id);
        }

        public Task<TestItem> GetFindCourses(int id)
        {
            return context.test.FindAsync(id);
        }

        public void Update(TestItem t)
        {
            throw new NotImplementedException();
        }
    }
}