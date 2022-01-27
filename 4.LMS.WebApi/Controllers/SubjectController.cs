using _1.LMS.Application.Queries.Subject.GetSubjectByUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4.LMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // ToRemember ^0-0^ :
    // Convention
    // IActionResult Not Generic Retrun OK(obj) so It's Not Recommended
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class SubjectController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SubjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetSubjects")]
        public async Task<ActionResult<IReadOnlyList<GetSubjectByUserDto>>> GetSubjectByUser(int gradeId, int termId)
        {
            var subjects = await _mediator.Send(new GetSubjectByUserQuery() { GradeId = gradeId, TermId = termId });
            return subjects.ToList();
        }
    }
}
