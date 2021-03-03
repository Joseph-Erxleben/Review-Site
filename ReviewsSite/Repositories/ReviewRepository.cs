using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;

namespace ReviewsSite.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        private PizzaContext _db;

        public ReviewRepository(PizzaContext db)
        {
            this._db = db;
        }
        public void Create(Review obj)
        {
            _db.Reviews.Add(obj);
            _db.SaveChanges();
        }

        public void Delete(Review obj)
        {
            _db.Reviews.Remove(obj);
            _db.SaveChanges();
        }

        public IEnumerable<Review> GetAll()
        {
            return _db.Reviews.ToList();
        }

        public Review GetById(int id)
        {
            return _db.Reviews.Find(id);
        }

        public Toppings GetToppingsByName(string name)
        {
            var toppings = _db.Set<Toppings>().Where(t => t.Name == name).FirstOrDefault();
            return toppings;
        }

        public void Update(Review obj)
        {
            _db.Reviews.Update(obj);
            _db.SaveChanges();
        }

    }
}
