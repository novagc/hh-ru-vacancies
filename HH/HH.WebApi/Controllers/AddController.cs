using HH.DB;
using HH.DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace HH.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/add")]
    public class AddController : ControllerBase
    {
        [HttpPost("vacancy")]
        public async Task<IActionResult> AddVacancy([FromBody] Vacancy vacancy)
        {
            try
            {
                var res = await HhDbApi.AddVacancyAsync(vacancy);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("vacancy/skill")]
        public async Task<IActionResult> AddVacancySkill([FromBody] VacanciesSkill vacancySkill)
        {
            try
            {
                var res = await HhDbApi.AddVacancySkillAsync(vacancySkill);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("vacancy/specialization")]
        public async Task<IActionResult> AddVacancySpecialization([FromBody] VacanciesSpecialization vacancySpecialization)
        {
            try
            {
                var res = await HhDbApi.AddVacancySpecializationAsync(vacancySpecialization);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("area")]
        public async Task<IActionResult> AddArea([FromBody] Area area)
        {
            try
            {
                var res = await HhDbApi.AddAreaAsync(area);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("experience")]
        public async Task<IActionResult> AddExperience([FromBody] Experience experience)
        {
            try
            {
                var res = await HhDbApi.AddExperienceAsync(experience);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
        
        [HttpPost("skill")]
        public async Task<IActionResult> AddSkill([FromBody] Skill skill)
        {
            try
            {
                var res = await HhDbApi.AddSkillAsync(skill);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpPost("specialization")]
        public async Task<IActionResult> AddSpecialization([FromBody] Specialization specialization)
        {
            try
            {
                var res = await HhDbApi.AddSpecializationAsync(specialization);
                return Ok(res);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
    }
}
