using Reviews.Models;
using System.Collections.Generic;

namespace Reviews
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetTagsForReviewId(int reviewId);
        void Create(Tag tag);
        Tag GetById(int tagId);
    }
}
