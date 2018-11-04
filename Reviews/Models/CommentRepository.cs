using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Models
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(Context db) : base(db)
        {
        }

        public IEnumerable<Comment> GetCommentsForTodoId(int reviewId)
        {
            return from comment in GetAll()
                   where comment.ReviewId == reviewId
                   orderby comment.CreatedAt
                   select comment;
        }
    }
}
