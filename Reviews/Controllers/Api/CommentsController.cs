using Microsoft.AspNetCore.Mvc;
using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private ICommentRepository commentRepo;

        public CommentsController(ICommentRepository commentRepo)
        {
            this.commentRepo = commentRepo;
        }

        [HttpGet("{reviewId}")]
        public IEnumerable<Comment> Get(int reviewId)
        {
            return commentRepo.GetCommentsForTodoId(reviewId);
        }

        [HttpPost]
        public bool Post([FromBody] Comment newComment)
        {
            newComment.CreatedAt = DateTime.UtcNow;
            commentRepo.Create(newComment);
            return true;
        }
    }
}
