using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        //C
        void Create(T obj);
        //R

        //U
        void Update(T obj);
        //D
        void Delete(T obj);
        Toppings GetToppingsByName(string name);
    }
}
