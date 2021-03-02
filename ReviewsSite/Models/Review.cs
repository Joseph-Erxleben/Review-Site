using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewContent { get; set; }
        public string ReviewerName { get; set; }
        public int ReviewScore { get; set; }
        public int ToppingsId { get; set; }
        public virtual Toppings Toppings { get; set; }
    }
}
