using HH.DB;
using Microsoft.AspNetCore.Mvc;

namespace HH.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/delete")]
    public class DeleteController : ControllerBase
    {
        [HttpDelete("vacancy/{vacancyId:int}")]
        public async Task<IActionResult> DeleteVacancy(int vacancyId)
        {
            var res = await HhDbApi.DeleteVacancyAsync(vacancyId);
            return res ? Ok() : Problem(title:"Vacancy not deleted");
        }

        [HttpDelete("vacancy/{vacancyId:int}/skill/{skillId:int}")]
        public async Task<IActionResult> DeleteVacancySkill(int vacancyId, int skillId)
        {
            var res = await HhDbApi.DeleteVacancySkillsAsync(vacancyId, skillId);
            return res ? Ok() : Problem(title: "Vacancy's skill not deleted");
        }

        [HttpDelete("vacancy/{vacancyId:int}/specialization/{specializationId}")]
        public async Task<IActionResult> DeleteVacancySpecialization(int vacancyId, string specializationId)
        {
            var res = await HhDbApi.DeleteVacancySpecializationAsync(vacancyId, specializationId);
            return res ? Ok() : Problem(title: "Vacancy's specialization not deleted");
        }

        [HttpDelete("area/{areaId:int}")]
        public async Task<IActionResult> DeleteArea(int areaId)
        {
            var res = await HhDbApi.DeleteAreaAsync(areaId);
            return res ? Ok() : Problem(title: "Area not deleted");
        }

        [HttpDelete("experience/{experienceId}")]
        public async Task<IActionResult> DeleteArea(string experienceId)
        {
            var res = await HhDbApi.DeleteExperienceAsync(experienceId);
            return res ? Ok() : Problem(title: "Experience not deleted");
        }

        [HttpDelete("skill/{skillId:int}")]
        public async Task<IActionResult> DeleteSkill(int skillId)
        {
            var res = await HhDbApi.DeleteSkillAsync(skillId);
            return res ? Ok() : Problem(title: "Skill not deleted");
        }

        [HttpDelete("specialization/{specializationId}")]
        public async Task<IActionResult> DeleteSpecialization(string specializationId)
        {
            var res = await HhDbApi.DeleteSpecializationAsync(specializationId);
            return res ? Ok() : Problem(title: "Specialization not deleted");
        }
    }
}
