using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;

namespace ReviewsSite.Repositories
{
    public class ToppingsRepository : IRepository<Toppings>
    {
        private PizzaContext _db;

        public ToppingsRepository(PizzaContext db)
        {
            this._db = db;
        }

        public void Create(Toppings obj)
        {
            _db.Toppings.Add(obj);
            _db.SaveChanges();
        }

        public void Delete (Toppings obj)
        {
            _db.Toppings.Remove(obj);
            _db.SaveChanges();
        }

        public IEnumerable<Toppings> GetAll()
        {
            return _db.Toppings.ToList();
        }

        public Toppings GetById(int id)
        {
            return _db.Toppings.Find(id);
        }

        public Toppings GetToppingsByName(string name)
        {
            var toppings = _db.Set<Toppings>().Where(t => t.Name == name).FirstOrDefault();
            return toppings;
        }

        public void Update(Toppings obj)
        {
            _db.Toppings.Update(obj);
            _db.SaveChanges();
        }
    }
}
