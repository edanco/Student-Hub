using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using StudentHub_API.Domain.Models;
using StudentHub_API.Domain.Services;
using StudentHub_API.Extensions;
using StudentHub_API.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHub_API.Controllers
{
    [Route("api/tutor")]
    [ApiController]
    public class TutorsController : ControllerBase
    {
        private readonly ITutorService _tutorService;
        private readonly IMapper _mapper;

        public TutorsController(ITutorService tutorService, IMapper mapper)
        {
            _tutorService = tutorService;
            _mapper = mapper;
        }

        [SwaggerOperation(Tags = new[] { "tutors" })]
        [HttpPost("courses/{courseId}/tutors")]
        [ProducesResponseType(typeof(TutorResource), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 404)]
        public async Task<IActionResult> PostAsync(int courseId, [FromBody] SaveTutorResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            var tutor = _mapper.Map<SaveTutorResource, Tutor>(resource);
            var result = await _tutorService.SaveAsync(courseId,tutor);

            if (!result.Success)
                return BadRequest(result.Message);

            var tutorResource = _mapper.Map<Tutor, TutorResource>(result.Resource);
            return Ok(tutorResource);
        }

        [HttpGet("Courses/{courseId}/tutors")]
        public async Task<IEnumerable<TutorResource>> GetAllByInstituteIdAsync(int courseId)
        {
            var tutors = await _tutorService.FindByCourseId(courseId);
            var resources = _mapper.Map<IEnumerable<Tutor>, IEnumerable<TutorResource>>(tutors);

            return resources;
        }

        [SwaggerOperation(Tags = new[] { "tutors" })]
        [HttpPut("{tutorId}")]
        [ProducesResponseType(typeof(TutorResource), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 404)]
        public async Task<IActionResult> PutAsync(int tutorId, [FromBody] SaveTutorResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var tutor = _mapper.Map<SaveTutorResource, Tutor>(resource);
            var result = await _tutorService.UpdateAsync(tutorId, tutor);

            if (!result.Success)
                return BadRequest(result.Message);
            var tutorResource = _mapper.Map<Tutor, TutorResource>(result.Resource);
            return Ok(tutorResource);
        }

        [SwaggerOperation(Tags = new[] { "tutors" })]
        [HttpGet("{tutorId}")]
        [ProducesResponseType(typeof(TutorResource), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 404)]
        public async Task<IActionResult> GetAsync(int tutorId)
        {
            var result = await _tutorService.GetByIdAsync(tutorId);

            if (!result.Success)
                return BadRequest(result.Message);

            var tutorResource = _mapper.Map<Tutor, TutorResource>(result.Resource);

            return Ok(tutorResource);
        }

        [SwaggerOperation(Tags = new[] { "tutors" })]
        [HttpDelete("{tutorId}")]
        [ProducesResponseType(typeof(TutorResource), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 404)]
        public async Task<IActionResult> DeleteAsync(int tutorId)
        {
            var result = await _tutorService.DeleteAsync(tutorId);
            if (!result.Success)
                return BadRequest(result.Message);
            var tutorResource = _mapper.Map<Tutor, TutorResource>(result.Resource);
            return Ok(tutorResource);
        }
    }
}
