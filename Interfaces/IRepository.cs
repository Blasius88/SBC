﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBC.DAL
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        Task<T> GetAsync(int id);
        IEnumerable<T> Find(Func<T, bool> predicate);
        void Create(T t);
        void Update(T t);
        void Delete(int id);
    }
}
