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
    public class EFLernenReposytory: IRepository<LernenItem>
    {
        private ApplicationDbContext context;
        private DbSet<LernenItem> table;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="ctx">Контекст базы данных</param>
        public EFLernenReposytory(ApplicationDbContext ctx)
        {
            context = ctx;
            table = context.lernens;
        }

        public void Create(LernenItem t)
        {
            table.Add(t);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context
            .Entry(new LernenItem { idLernen = id })
            .State = EntityState.Deleted;
            context.SaveChanges();
        }

        public IEnumerable<LernenItem> Find(Func<LernenItem, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public LernenItem Get(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<LernenItem> GetAll()
        {
            return table;
        }

        public Task<LernenItem> GetAsync(int id)
        {
            return context.lernens.FindAsync(id);
        }

        public void Update(LernenItem t)
        {
            context.Entry<LernenItem>(t).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
