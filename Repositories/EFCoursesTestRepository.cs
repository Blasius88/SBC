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
    public class EFCoursesTestRepository : IRepository<CoursesTest>
    {
        private ApplicationDbContext context;
        private DbSet<CoursesTest> table;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="ctx">Контекст базы данных</param>
        public EFCoursesTestRepository(ApplicationDbContext ctx)
        {   
            context = ctx;
            table = context.coursesTest;
        }

        public void Create(CoursesTest t)
        {
            table.Add(t);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context
            .Entry(new CoursesTest { id = id })
            .State = EntityState.Deleted;
            context.SaveChanges();
        }

        public IEnumerable<CoursesTest> Find(Func<CoursesTest, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public CoursesTest Get(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<CoursesTest> GetAll()
        {
            return table;
        }

        public Task<CoursesTest> GetAsync(int id)
        {
            return context.coursesTest.FindAsync(id);
        }

        public void Update(CoursesTest t)
        {
            context.Entry<CoursesTest>(t).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}