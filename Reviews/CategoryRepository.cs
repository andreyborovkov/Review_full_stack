using Reviews;
using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppLive;

namespace Categories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(Context db) : base(db)
        {
            //ensures our base constructor runs
        }

    }
}

