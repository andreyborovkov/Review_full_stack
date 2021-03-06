﻿using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAll();
        Review GetById(int id);
    }
}
