using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Toppings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegetarian { get; set; }
        public string Img { get; set; } = "Default.png";

        public virtual ICollection<Review> Reviews { get; set; }

        public Toppings()
        {

        }

        public Toppings(int id, string name, string description, bool isVegetarian)
        {
            Id = id;
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
        }


        public double AverageReview()
        {
            double zeroCounter = Reviews.Where(r => r.ReviewScore == 0).Count();
            double oneCounter = Reviews.Where(r => r.ReviewScore == 1).Count();
            double twoCounter = Reviews.Where(r => r.ReviewScore == 2).Count();
            double threeCounter = Reviews.Where(r => r.ReviewScore == 3).Count();
            double fourCounter = Reviews.Where(r => r.ReviewScore == 4).Count();
            double fiveCounter = Reviews.Where(r => r.ReviewScore == 5).Count();

            double sum = zeroCounter + oneCounter + twoCounter + threeCounter + fourCounter + fiveCounter;

            double averageReview = ((1 * oneCounter) + (2 * twoCounter) + (3 * threeCounter) + (4 * fourCounter) + (5 * fiveCounter)) / sum;
            averageReview = Math.Round(averageReview, 2);
            return averageReview;
        }

    }
}
