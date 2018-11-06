using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews
{
    public class ReviewTagRepository : Repository<ReviewTag>, IReviewTagRepository
    {
        public ReviewTagRepository(Context db) : base(db)
        { }
    }
}
