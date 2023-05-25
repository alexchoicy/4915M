using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using Server.Model.Dto;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestCpntroller : ControllerBase
    {
        private readonly IUserServices _UserServices;
        public RequestCpntroller(IUserServices userServices)
        {
            _UserServices = userServices;
        }
        

    }
}
