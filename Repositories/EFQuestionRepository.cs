using SBC.Entities;
using SBC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SBC.Repositories
{
    public class EFQuestionRepository : IRepository<QuestionItem>
    {
        private ApplicationDbContext context;
        private DbSet<QuestionItem> table;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="ctx">Контекст базы данных</param>
        public EFQuestionRepository(ApplicationDbContext ctx)
        {
            context = ctx;
            table = context.questions;
        }

        public void Create(QuestionItem t)
        {
            table.Add(t);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context
          .Entry(new QuestionItem { idQuestion = id })
          .State = EntityState.Deleted;
            context.SaveChanges();
        }

        public IEnumerable<QuestionItem> Find(Func<QuestionItem, bool> predicate)
        {
            return table.Where(predicate).ToList();
        }

        public QuestionItem Get(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<QuestionItem> GetAll()
        {
            return table;
        }

        public Task<QuestionItem> GetAsync(int id)
        {
            return context.questions.FindAsync(id);
        }

        public void Update(TestItem t)
        {
            throw new NotImplementedException();
        }

        public void Update(QuestionItem t)
        {
            throw new NotImplementedException();
        }

        QuestionItem IRepository<QuestionItem>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}