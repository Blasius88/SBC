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
    public class EFQuestionRepository : IRepository<Question>
    {
        private ApplicationDbContext context;
        private DbSet<Question> table;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="ctx">Контекст базы данных</param>
        public EFQuestionRepository(ApplicationDbContext ctx)
        {
            context = ctx;
            table = context.questions;
        }

        public void Create(Question t)
        {
            table.Add(t);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context
          .Entry(new Question { idQuestion = id })
          .State = EntityState.Deleted;
            context.SaveChanges();
        }

        public IEnumerable<Question> Find(Func<Question, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public Question Get(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<Question> GetAll()
        {
            return table;
        }

        public Task<Question> GetAsync(int id)
        {
            return context.questions.FindAsync(id);
        }

        public void Update(Test t)
        {
            throw new NotImplementedException();
        }

        public void Update(Question t)
        {
            throw new NotImplementedException();
        }

        Question IRepository<Question>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}