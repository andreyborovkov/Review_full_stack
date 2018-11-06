﻿using Microsoft.AspNetCore.Mvc;
using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ITagRepository tagsRepo;
        private readonly IReviewTagRepository reviewTagRepo;

        public TagsController(ITagRepository tagsRepo, IReviewTagRepository reviewTagRepo)
        {
            this.tagsRepo = tagsRepo;
            this.reviewTagRepo = reviewTagRepo;
        }

        [HttpGet("{reviewId}")]
        public IEnumerable<Tag> Get(int reviewId)
        {
            return tagsRepo.GetTagsForReviewId(reviewId);
        }

        [HttpPost]
        public Tag Post([FromBody]Tag tag, int reviewId)
        {
            tagsRepo.Create(tag);
            reviewTagRepo.Create(new ReviewTag() { ReviewId = reviewId, TagId = tag.Id });
            return tag;
        }
    }
}
