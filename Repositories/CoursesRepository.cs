using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SBC.DAL
{
    public class CoursesRepository : IRepository<Courses>
    {
        public void Create(Courses t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Courses> Find(Func<Courses, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Courses Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Courses> GetAll()
        {
            return new List<Courses>
            {
                new Courses
                {
                    id = 1,
                    NameCourses = "Биология",
                    Description =""
                },
                new Courses
                {
                    id = 2,
                    NameCourses ="Химия",
                    Description=""
                }
            };
        }

        public Task<Courses> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Courses t)
        {
            throw new NotImplementedException();
        }
    }
}