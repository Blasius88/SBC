using SBC.Models;
using SBC.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SBC.Repositories
{
    public class EFCoursesTestRepository : IRepository<CoursesItem>
    {
        private ApplicationDbContext context;
        private DbSet<CoursesItem> table;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="ctx">Контекст базы данных</param>
        public EFCoursesTestRepository(ApplicationDbContext ctx)
        {
            context = ctx;
            table = context.Courses;
        }

        public void Create(CoursesItem t)
        {
            table.Add(t);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context
            .Entry(new CoursesItem { id = id })
            .State = EntityState.Deleted;
            context.SaveChanges();
        }

        public IEnumerable<CoursesItem> Find(Func<CoursesItem, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public CoursesItem Get(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<CoursesItem> GetAll()
        {
            return table;
        }

        public Task<CoursesItem> GetAsync(int id)
        {
            return context.Courses.FindAsync(id);
        }

        public void Update(CoursesItem t)
        {
            if (t.Image == null)
            {
                var dish = context.Courses
                    .AsNoTracking()
                    .Where(d => d.id == t.id)
                    .FirstOrDefault();
                t.Image = dish.Image;
                t.MineType = dish.MineType;
            }
            context.Entry<CoursesItem>(t).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}