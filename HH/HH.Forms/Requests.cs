using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HH.DB.Models;
using Newtonsoft.Json;
using Req=HH.Net.Requests.Requests;

namespace HH.Forms
{
    public static class Requests
    {
        public static readonly string BaseUrl = "https://localhost:5001";
        public static readonly string ApiPrefix = "api/v1";

        #region Get

        public static async Task<List<Vacancy>> GetVacancies()
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/vacancies/all");
            return JsonConvert.DeserializeObject<List<Vacancy>>(res)!;
        }

        public static async Task<Vacancy?> GetVacancy(int vacancyId)
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/vacancy/{vacancyId}");
            return JsonConvert.DeserializeObject<Vacancy>(res);
        }

        public static async Task<List<VacanciesSkill>> GetVacancySkill(int vacancyId)
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/vacancy/{vacancyId}/skills");
            return JsonConvert.DeserializeObject<List<VacanciesSkill>>(res)!;
        }

        public static async Task<List<VacanciesSpecialization>> GetVacancySpecialization(int vacancyId)
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/vacancy/{vacancyId}/specializations");
            return JsonConvert.DeserializeObject<List<VacanciesSpecialization>>(res)!;
        }

        public static async Task<List<Area>> GetAreas()
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/areas");
            return JsonConvert.DeserializeObject<List<Area>>(res)!;
        }

        public static async Task<Area> GetArea(int areaId)
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/area/{areaId}");
            return JsonConvert.DeserializeObject<Area>(res)!;
        }

        public static async Task<List<Skill>> GetSkills()
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/skills");
            return JsonConvert.DeserializeObject<List<Skill>>(res)!;
        }

        public static async Task<Skill> GetSkill(int skillId)
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/skill/{skillId}");
            return JsonConvert.DeserializeObject<Skill>(res)!;
        }

        public static async Task<List<Specialization>> GetSpecializations()
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/specializations");
            return JsonConvert.DeserializeObject<List<Specialization>>(res)!;
        }

        public static async Task<Specialization> GetSpecialization(string id)
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/specialization/{id}");
            return JsonConvert.DeserializeObject<Specialization>(res)!;
        }

        public static async Task<List<Experience>> GetExperiences()
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/experiences");
            return JsonConvert.DeserializeObject<List<Experience>>(res)!;
        }

        public static async Task<Experience> GetExperience(string id)
        {
            var res = await Req.SendGet($"{BaseUrl}/{ApiPrefix}/get/experience/{id}");
            return JsonConvert.DeserializeObject<Experience>(res)!;
        }

        #endregion

        #region Delete

        public static async Task DeleteVacancy(Vacancy obj)
        {
            var res = await Req.SendDelete($"{BaseUrl}/{ApiPrefix}/delete/vacancy/{obj.IdVacancy}");
        }
        public static async Task DeleteVacancySkill(VacanciesSkill obj)
        {
            var res = await Req.SendDelete($"{BaseUrl}/{ApiPrefix}/delete/vacancy/{obj.IdVacancy}/skill/{obj.IdSkill}");
        }
        public static async Task DeleteVacancySpecialization(VacanciesSpecialization obj)
        {
            var res = await Req.SendDelete($"{BaseUrl}/{ApiPrefix}/delete/vacancy/{obj.IdVacancy}/specialization/{obj.IdSpecialization}");
        }
        public static async Task DeleteArea(Area obj)
        {
            var res = await Req.SendDelete($"{BaseUrl}/{ApiPrefix}/delete/area/{obj.IdArea}");
        }
        public static async Task DeleteExperience(Experience obj)
        {
            var res = await Req.SendDelete($"{BaseUrl}/{ApiPrefix}/delete/experience/{obj.IdExperience}");
        }
        public static async Task DeleteSkill(Skill obj)
        {
            var res = await Req.SendDelete($"{BaseUrl}/{ApiPrefix}/delete/skill/{obj.IdSkill}");
        }
        public static async Task DeleteSpecialization(Specialization obj)
        {
            var res = await Req.SendDelete($"{BaseUrl}/{ApiPrefix}/delete/specialization/{obj.IdSpecialization}");
        }

        #endregion

        #region Add

        public static async Task<Vacancy> AddVacancy(Vacancy obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/add/vacancy", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Vacancy>(res)!;
        }
        public static async Task<VacanciesSkill> AddVacancySkill(VacanciesSkill obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/add/vacancy/skill", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<VacanciesSkill>(res)!;
        }
        public static async Task<VacanciesSpecialization> AddVacancySpecialization(VacanciesSpecialization obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/add/vacancy/specialization", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<VacanciesSpecialization>(res)!;
        }
        public static async Task<Area> AddArea(Area obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/add/area", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Area>(res)!;
        }
        public static async Task<Experience> AddExperience(Experience obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/add/experience", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Experience>(res)!;
        }
        public static async Task<Skill> AddSkill(Skill obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/add/skill", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Skill>(res)!;
        }
        public static async Task<Specialization> AddSpecialization(Specialization obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/add/specialization", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Specialization>(res)!;
        }

        #endregion

        #region Update

        public static async Task<Vacancy> UpdateVacancy(Vacancy obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/update/vacancy", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Vacancy>(res)!;
        }
        public static async Task<VacanciesSkill> UpdateVacancySkill(VacanciesSkill obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/update/vacancy/skill", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<VacanciesSkill>(res)!;
        }
        public static async Task<VacanciesSpecialization> UpdateVacancySpecialization(VacanciesSpecialization obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/update/vacancy/specialization", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<VacanciesSpecialization>(res)!;
        }
        public static async Task<Area> UpdateArea(Area obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/update/area", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Area>(res)!;
        }
        public static async Task<Experience> UpdateExperience(Experience obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/update/experience", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Experience>(res)!;
        }
        public static async Task<Skill> UpdateSkill(Skill obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/update/skill", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Skill>(res)!;
        }
        public static async Task<Specialization> UpdateSpecialization(Specialization obj)
        {
            var res = await Req.SendPost($"{BaseUrl}/{ApiPrefix}/update/specialization", JsonConvert.SerializeObject(obj));
            return JsonConvert.DeserializeObject<Specialization>(res)!;
        }

        #endregion
    }
}
