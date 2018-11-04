using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetCommentsForTodoId(int reviewId);
        void Create(Comment comment);
    }
}
