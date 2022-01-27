using _1.LMS.Application.Commands.User.LogInUser;
using _1.LMS.Application.Commands.User.SignUpUser;
using _1.LMS.Application.Queries.User.GetUserByName;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace _4.LMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // ToRemember ^0-0^ :
    // Convention
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // ToRemember ^0-0^ :
        // IActionResult Not Generic Retrun OK(obj) so It's Not Recommended
        [HttpPost("signUp")]
        public async Task<ActionResult<UserForReturnDto>> SignUp(SignUpUserCommand signUpUserCommand)
        {
            var result = await _mediator.Send(signUpUserCommand);
            if (!result.Succeeded) return BadRequest(result.Errors);
            return await _mediator.Send(new GetUserByNameQuery() { UserName = signUpUserCommand.UserName });
        }
        [HttpPost("logIn")]
        public async Task<ActionResult<LogInUserForReturnDto>> LogIn(LogInUserCommand logInUserCommand)
        {
            return await _mediator.Send(logInUserCommand);
        }
    }
}