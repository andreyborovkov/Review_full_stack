using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Models
{
    public class Review
    {      
        public int Id { get; set; }
        public string Title { get; set; }  
        public string ImageURL { get; set; }
        public string ReviewCategory { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
}
