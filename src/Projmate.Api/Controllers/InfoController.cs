using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Projmate.Api.Models;

namespace Projmate.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly AccountInfo _Info;

        public InfoController(IOptions<AccountInfo> accountInfoWrapper)
        {
            _Info = accountInfoWrapper.Value;
        }
        
        [HttpGet(Name =nameof(GetAccountInfo))]
        [ProducesResponseType(200)]
        public ActionResult<AccountInfo>GetAccountInfo()
        {                   
            _Info.Href = Url.Link(nameof(GetAccountInfo), null);
             return _Info;
        }
    }
}