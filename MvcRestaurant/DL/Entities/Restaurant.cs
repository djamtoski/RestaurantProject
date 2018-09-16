using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }



        public virtual Stock Stock { get; set; }

        public virtual User User { get; set; }
    }
}
