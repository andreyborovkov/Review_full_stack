using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(Context db) : base(db)
        { }

        public IEnumerable<Tag> GetTagsForReviewId(int reviewId)
        {
            var result = from tag in GetAll()
                         from reviewTag in tag.ReviewTags
                         where reviewTag.ReviewId == reviewId
                         select tag;
            return result;
        }
    }
}
