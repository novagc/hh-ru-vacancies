using System.Diagnostics;
using HH.DB;
using HH.DB.Models;
using HH.Net.Models;
using HH.Net.Models.VacancyModel;
using HH.Net.Requests;
using Area = HH.DB.Models.Area;
using Experience = HH.DB.Models.Experience;
using Specialization = HH.DB.Models.Specialization;

namespace HH.Downloader
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Enabled = false;

            var waitingForm = new WaitingForm();

            waitingForm.Show();

            var fullVacancies = await SaveBasicInfo();
            
            var skills = await HhDbApi.GetSkillsAsync();
            var specializations = await HhDbApi.GetSpecializationsAsync();
            
            await SaveVacanciesReferences(skills, specializations, fullVacancies);

            waitingForm.Close();

            Enabled = true;
        }

        private async Task<List<FullVacancyResponse>> SaveBasicInfo()
        {
            var areasRequest = new AreaRequest();
            var experienceRequest = new ExperienceRequest();
            var specializationRequest = new SpecializationRequest();
            var fullVacancyRequest = new FullVacancyRequest();
            var vacancyRequest = new VacancyRequest(
                String.IsNullOrEmpty(textBox1.Text) ? null : textBox1.Text,
                (int)numericUpDown1.Value == -1 ? null : (int)numericUpDown1.Value,
                (int)numericUpDown2.Value == -1 ? null : (int)numericUpDown2.Value);
            
            var areas = (await areasRequest.Send()).Select(Convert).ToList();
            var experiences = (await experienceRequest.Send()).Select(Convert).ToList();
            var specializations = (await specializationRequest.Send()).Select(Convert).ToList();
            var shortVacancies = await vacancyRequest.Send();
            
            var vacanciesInfo = new List<KeyValuePair<VacancyItem, FullVacancyResponse>>();

            foreach (var x in shortVacancies)
            {
                vacanciesInfo.Add(new KeyValuePair<VacancyItem, FullVacancyResponse>(x, await fullVacancyRequest.Send(int.Parse(x.Id!))));
            }
            
            var fullVacancies = vacanciesInfo.Select(x => x.Value).ToList();
            var vacancies = vacanciesInfo.Select(Convert).ToList();
            var keySkills = GetKeySkills(vacanciesInfo).Select(Convert).ToList();
            
            await HhDbApi.AddAreasRangeAsync(areas);
            await HhDbApi.AddExperienceRangeAsync(experiences);
            await HhDbApi.AddSpecializationsRangeAsync(specializations);
            await HhDbApi.AddSkillRangeAsync(keySkills);
            await HhDbApi.AddVacanciesRangeAsync(vacancies);

            return fullVacancies;
        }

        private async Task SaveVacanciesReferences(List<Skill> skills, List<Specialization> specializations, List<FullVacancyResponse> vacancies)
        {
            var tempSpec = new List<VacanciesSpecialization>();
            var tempSkills = new List<VacanciesSkill>();

            foreach (var vacancy in vacancies)
            {
                foreach (var specialization in vacancy.Specializations)
                {
                    tempSpec.Add(new VacanciesSpecialization
                    {
                        IdVacancy = int.Parse(vacancy.Id),
                        IdSpecialization = specialization.Id
                    });
                }

                foreach (var keySkill in vacancy.KeySkills)
                {
                    var skill = skills.First(x => x.Name == keySkill.Name);
                    tempSkills.Add(new VacanciesSkill
                    {
                        IdVacancy = int.Parse(vacancy.Id),
                        IdSkill = skill.IdSkill
                    });
                }
            }

            await HhDbApi.AddVacanciesSpecializationsRangeAsync(tempSpec);
            await HhDbApi.AddVacanciesSkillsRangeAsync(tempSkills);
        }

        private Area Convert(Net.Models.AreaModel.AreaItem area)
        {
            return new Area
            {
                IdArea = int.Parse(area.Id),
                Name = area.Name
            };
        }

        private Experience Convert(Net.Models.ExperienceModel.ExperienceItem experience)
        {
            return new Experience
            {
                IdExperience = experience.Id,
                Name = experience.Name
            };
        }

        private Skill Convert(string skill)
        {
            return new Skill
            {
                Name = skill
            };
        }

        private Specialization Convert(Net.Models.SpecializationModel.SpecializationItem specialization)
        {
            return new Specialization
            {
                IdSpecialization = specialization.Id,
                Name = specialization.Name
            };
        }

        private Vacancy Convert(
            KeyValuePair<VacancyItem, FullVacancyResponse> vacancy)
        {
            return new Vacancy
            {
                IdVacancy = int.Parse(vacancy.Value.Id),
                Name = vacancy.Value.Name,
                IdArea = int.Parse(vacancy.Value.Area.Id),
                SalaryFrom = vacancy.Value.Salary?.From,
                SalaryTo = vacancy.Value.Salary?.To,
                SalaryCurrency = vacancy.Value.Salary?.Currency,
                PublishedAt = vacancy.Value.PublishedAt,
                SnippetRequirement = vacancy.Key.Snippet.Requirement,
                SnippetResponsibility = vacancy.Key.Snippet.Responsibility,
                Description = vacancy.Value.Description,
                IdExperience = vacancy.Value.Experience.Id,
            };
        }

        private List<string> GetKeySkills(List<KeyValuePair<VacancyItem, FullVacancyResponse>> vacanciesInfo)
        {
            var result = new HashSet<string>();

            foreach (var vacancy in vacanciesInfo)
            {
                foreach (var keySkill in vacancy.Value.KeySkills)
                {
                    result.Add(keySkill.Name);
                }
            }

            return result.ToList();
        }
    }
}