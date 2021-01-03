using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedBackBLL.Provider;
using FeedBackDAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedBackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackCollectionController : ControllerBase
    {
        private VoteInfromationProvider _provider;
        [HttpGet("{post}")]
        public IEnumerable<CustomVoteInfo> Get(string post)
        {
            _provider = new VoteInfromationProvider();
            List<CustomVoteInfo> entityList = _provider.GetCustomVoteInfos(post);
            return entityList;
        }
    }
}
