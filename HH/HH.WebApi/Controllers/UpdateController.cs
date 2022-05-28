using HH.DB;
using HH.DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace HH.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/update")]
    public class UpdateController : ControllerBase
    {
        [HttpPost("vacancy")]
        public async Task<IActionResult> UpdateVacancy([FromBody] Vacancy vacancy)
        {
            try
            {
                var res = await HhDbApi.UpdateVacancyAsync(vacancy);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("area")]
        public async Task<IActionResult> UpdateArea([FromBody] Area area)
        {
            try
            {
                var res = await HhDbApi.UpdateAreaAsync(area);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("experience")]
        public async Task<IActionResult> UpdateExperience([FromBody] Experience experience)
        {
            try
            {
                var res = await HhDbApi.UpdateExperienceAsync(experience);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("skill")]
        public async Task<IActionResult> UpdateSkill([FromBody] Skill skill)
        {
            try
            {
                var res = await HhDbApi.UpdateSkillAsync(skill);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("specialization")]
        public async Task<IActionResult> UpdateSpecialization([FromBody] Specialization specialization)
        {
            try
            {
                var res = await HhDbApi.UpdateSpecializationAsync(specialization);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
    }
}
