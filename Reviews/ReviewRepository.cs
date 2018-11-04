using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(Context db) : base(db)
        {
            //ensures our base constructor runs
        }

    }
}
