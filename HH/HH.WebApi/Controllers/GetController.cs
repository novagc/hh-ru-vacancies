using HH.DB;
using HH.DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace HH.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/get")]
    public class GetController : ControllerBase
    {
        [HttpGet("vacancy/{vacancyId:int}")]
        public async Task<IActionResult> GetVacancy(int vacancyId)
        {
            var res = await HhDbApi.GetVacancyAsync(vacancyId);
            return res == null ? Problem(title:"Vacancy not founded") : Ok(res);
        }

        [HttpGet("vacancy/{vacancyId:int}/full")]
        public async Task<IActionResult> GetVacancyFull(int vacancyId)
        {
            var res = await HhDbApi.GetVacancyAsync(vacancyId);

            if (res == null)
            {
                return Problem(title: "Vacancy not founded");
            }

            var skillsIds = await HhDbApi.GetVacancySkillsAsync(vacancyId);
            var specializationsIds = await HhDbApi.GetVacancySpecializationsAsync(vacancyId);

            var skills = new List<Skill>();

            foreach (var skillId in skillsIds)
            {
                skills.Add(await HhDbApi.GetSkillAsync(skillId.IdSkill));
            }

            var specializations = new List<Specialization>();

            foreach (var spec in specializationsIds)
            {
                specializations.Add(await HhDbApi.GetSpecializationAsync(spec.IdSpecialization));
            }

            return Ok(new VacancyResponse
            {
                Description = res.Description,
                IdArea = res.IdArea,
                IdExperience = res.IdExperience,
                IdVacancy = res.IdVacancy,
                Name = res.Name,
                PublishedAt = res.PublishedAt,
                SalaryCurrency = res.SalaryCurrency,
                SalaryFrom = res.SalaryFrom,
                SalaryTo = res.SalaryTo,
                Skills = skills,
                Specializations = specializations,
                SnippetRequirement = res.SnippetRequirement,
                SnippetResponsibility = res.SnippetResponsibility
            });
        }

        [HttpGet("vacancies/all")]
        public async Task<IActionResult> GetVacancies()
        {
            var res = await HhDbApi.GetVacanciesAsync();
            return Ok(res);
        }

        [HttpGet("vacancies")]
        public async Task<IActionResult> GetVacanciesWithParams(
            [FromQuery] DateTime? from, [FromQuery] DateTime? to, 
            [FromQuery] string? sort, [FromQuery] int? page,
            [FromQuery] int? perPage)
        {
            var res = await HhDbApi.GetVacanciesWithParamsAsync(from, to, sort, page, perPage);
            return Ok(res);
        }

        [HttpGet("vacancy/{vacancyId:int}/skills")]
        public async Task<IActionResult> GetVacancySkills(int vacancyId)
        {
            var res = await HhDbApi.GetVacancySkillsAsync(vacancyId);
            return Ok(res);
        }

        [HttpGet("vacancy/{vacancyId:int}/specializations")]
        public async Task<IActionResult> GetVacancySpecializations(int vacancyId)
        {
            var res = await HhDbApi.GetVacancySpecializationsAsync(vacancyId);
            return Ok(res);
        }

        [HttpGet("areas")]
        public async Task<IActionResult> GetAreas()
        {
            var res = await HhDbApi.GetAreasAsync();
            return Ok(res);
        }

        [HttpGet("area/{areaId:int}")]
        public async Task<IActionResult> GetArea(int areaId)
        {
            var res = await HhDbApi.GetAreaAsync(areaId);
            return res == null ? Problem(title: "Area not founded") : Ok(res);
        }
        
        [HttpGet("skills")]
        public async Task<IActionResult> GetSkills()
        {
            var res = await HhDbApi.GetSkillsAsync();
            return Ok(res);
        }
        
        [HttpGet("skill/{skillId:int}")]
        public async Task<IActionResult> GetSkill(int skillId)
        {
            var res = await HhDbApi.GetSkillAsync(skillId);
            return res == null ? Problem(title: "Skill not founded") : Ok(res);
        }

        [HttpGet("specializations")]
        public async Task<IActionResult> GetSpecializations()
        {
            var res = await HhDbApi.GetSpecializationsAsync();
            return Ok(res);
        }

        [HttpGet("specialization/{specializationId}")]
        public async Task<IActionResult> GetSpecialization(string specializationId)
        {
            var res = await HhDbApi.GetSpecializationAsync(specializationId);
            return res == null ? Problem(title: "Specialization not founded") : Ok(res);
        }

        [HttpGet("experiences")]
        public async Task<IActionResult> GetExperiences()
        {
            var res = await HhDbApi.GetExperiencesAsync();
            return Ok(res);
        }

        [HttpGet("experience/{experienceId}")]
        public async Task<IActionResult> GetExperience(string experienceId)
        {
            var res = await HhDbApi.GetExperienceAsync(experienceId);
            return res == null ? Problem(title: "Experience not founded") : Ok(res);
        }
    }
}
