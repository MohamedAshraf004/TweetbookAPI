using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetbook.Services;

namespace Tweetbook.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosmosPostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public CosmosPostsController(IPostService postService)
        {
            this._postService = postService;
        }
    }
}
