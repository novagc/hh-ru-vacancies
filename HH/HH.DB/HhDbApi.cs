using System.Text.RegularExpressions;
using HH.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace HH.DB
{
    public static class HhDbApi
    {
        #region Tools

        private static string[] _goodParams = {"date", "id", "name", "area"};

        private static void AddOrUpdate<T>(this DbSet<T> set, List<T> items) where T : class, IEquatable<T>
        {
            var nonTrackingSet = set.AsNoTracking().ToList();
            var temp = items.Select(x => new Pair<T, bool>(x, nonTrackingSet.Any(y => y.Equals(x))));

            foreach (var pair in temp)
            {
                if (pair.Second)
                {
                    set.Update(pair.First);
                }
                else
                {
                    set.Add(pair.First);
                }
            }
        }

        private static void AddOrSkip<T>(this DbSet<T> set, List<T> items) where T : class, IEquatable<T>
        {
            var nonTrackingSet = set.AsNoTracking().ToList();
            var temp = items.Where(x => !nonTrackingSet.Any(y => y.Equals(x))).ToList();
            set.AddRange(temp);
        }

        private static IQueryable<T> GetPage<T>(this IQueryable<T> set, int? perPage, int? page) where T : class
        {
            if (perPage == null)
            {
                return set;
            }
            else
            {
                page ??= 0;
                return set.Skip(perPage.Value * page.Value).Take(perPage.Value);
            }
        }

        #endregion

        #region AddRange

        public static async Task AddAreasRangeAsync(List<Area> areas)
        {
            await using var ctx = new HhContext();
            ctx.Areas.AddOrSkip(areas);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddExperienceRangeAsync(List<Experience> experiences)
        {
            await using var ctx = new HhContext();
            ctx.Experiences.AddOrSkip(experiences);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddSkillRangeAsync(List<Skill> skills)
        {
            await using var ctx = new HhContext();
            ctx.Skills.AddOrSkip(skills);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddSpecializationsRangeAsync(List<Specialization> specializations)
        {
            await using var ctx = new HhContext();
            ctx.Specializations.AddOrSkip(specializations);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddVacanciesRangeAsync(List<Vacancy> vacancies)
        {
            await using var ctx = new HhContext();
            ctx.Vacancies.AddOrUpdate(vacancies);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddVacanciesSkillsRangeAsync(List<VacanciesSkill> links)
        {
            await using var ctx = new HhContext();

            var temp = links.Select(x => x.IdVacancy).ToHashSet();

            ctx.VacanciesSkills
                .RemoveRange(ctx.VacanciesSkills.AsNoTracking().Where(x => temp.Contains(x.IdVacancy)));

            await ctx.SaveChangesAsync();
            await ctx.VacanciesSkills.AddRangeAsync(links);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddVacanciesSpecializationsRangeAsync(List<VacanciesSpecialization> links)
        {
            await using var ctx = new HhContext();

            var temp = links.Select(x => x.IdVacancy).ToHashSet();

            ctx.VacanciesSpecializations
                .RemoveRange(ctx.VacanciesSpecializations.AsNoTracking().Where(x => temp.Contains(x.IdVacancy)));

            await ctx.SaveChangesAsync();
            await ctx.VacanciesSpecializations.AddRangeAsync(links);
            await ctx.SaveChangesAsync();
        }

        #endregion

        #region Add

        public static async Task<Area> AddAreaAsync(Area area)
        {
            await using var ctx = new HhContext();
            var obj = await ctx.Areas.FindAsync(area.IdArea);

            if (obj != null)
            {
                return obj;
            }

            ctx.Areas.Add(area);
            await ctx.SaveChangesAsync();
            return area;
        }

        public static async Task<Experience> AddExperienceAsync(Experience obj)
        {
            await using var ctx = new HhContext();
            var temp = await ctx.Experiences.FindAsync(obj.IdExperience);

            if (temp != null)
            {
                return temp;
            }

            ctx.Experiences.Add(obj);
            await ctx.SaveChangesAsync();
            return obj;
        }

        public static async Task<Skill> AddSkillAsync(Skill obj)
        {
            await using var ctx = new HhContext();
            ctx.Skills.Add(obj);
            await ctx.SaveChangesAsync();
            return obj;
        }

        public static async Task<Specialization> AddSpecializationAsync(Specialization obj)
        {
            await using var ctx = new HhContext();
            ctx.Specializations.Add(obj);
            await ctx.SaveChangesAsync();
            return obj;
        }

        public static async Task<Vacancy> AddVacancyAsync(Vacancy obj)
        {
            await using var ctx = new HhContext();
            var temp = await ctx.Vacancies.FindAsync(obj.IdVacancy);

            if (temp != null)
            {
                return temp;
            }
            
            ctx.Vacancies.Add(obj);
            await ctx.SaveChangesAsync();
            return obj;
        }

        public static async Task<VacanciesSkill> AddVacancySkillAsync(VacanciesSkill obj)
        {
            await using var ctx = new HhContext();
            var temp = await ctx.VacanciesSkills.FindAsync(obj.IdVacancy, obj.IdSkill);

            if (temp != null)
            {
                return temp;
            }

            ctx.VacanciesSkills.Add(obj);
            await ctx.SaveChangesAsync();
            return obj;
        }

        public static async Task<VacanciesSpecialization> AddVacancySpecializationAsync(VacanciesSpecialization obj)
        {
            await using var ctx = new HhContext();
            var temp = await ctx.VacanciesSpecializations.FindAsync(obj.IdVacancy, obj.IdSpecialization);

            if (temp != null)
            {
                return temp;
            }

            ctx.VacanciesSpecializations.Add(obj);
            await ctx.SaveChangesAsync();
            return obj;
        }

        #endregion

        #region Get

        public static async Task<List<Skill>> GetSkillsAsync()
        {
            await using var ctx = new HhContext();
            return await ctx.Skills.ToListAsync();
        }

        public static async Task<List<Specialization>> GetSpecializationsAsync()
        {
            await using var ctx = new HhContext();
            return await ctx.Specializations.ToListAsync();
        }

        public static async Task<List<Area>> GetAreasAsync()
        {
            await using var ctx = new HhContext();
            return await ctx.Areas.ToListAsync();
        }

        public static async Task<List<Experience>> GetExperiencesAsync()
        {
            await using var ctx = new HhContext();
            return await ctx.Experiences.ToListAsync();
        }

        public static async Task<List<Vacancy>> GetVacanciesAsync()
        {
            await using var ctx = new HhContext();
            return await ctx.Vacancies.ToListAsync();
        }

        public static async Task<List<VacanciesSkill>> GetVacanciesSkillsAsync()
        {
            await using var ctx = new HhContext();
            return await ctx.VacanciesSkills.ToListAsync();
        }

        public static async Task<List<VacanciesSpecialization>> GetVacanciesSpecializationsAsync()
        {
            await using var ctx = new HhContext();
            return await ctx.VacanciesSpecializations.ToListAsync();
        }

        #endregion

        #region Get With Params

        public static async Task<Vacancy?> GetVacancyAsync(int id)
        {
            await using var ctx = new HhContext();
            return await ctx.Vacancies.FindAsync(id);
        }

        public static async Task<List<Vacancy>> GetVacanciesWithParamsAsync(DateTime? from, DateTime? to, string? sort, int? page, int? perPage)
        {
            from ??= DateTime.MinValue;
            to ??= DateTime.MaxValue;
            page ??= 0;
            perPage ??= 50;

            var reg = new Regex("([\\+-][\\w]+)");
            var sortingParams = new List<Pair<string, bool>>();

            if (sort != null)
            {
                var t = reg.Matches(sort).Select(x => x.Value);
                sortingParams = t
                    .Where(x => _goodParams.Contains(x.Substring(1)) )
                    .Select(x => new Pair<string, bool>(x.Substring(1), x[0] == '+'))
                    .ToList();
            }

            await using var ctx = new HhContext();
            var temp = ctx.Vacancies.Where(x => x.PublishedAt >= from && x.PublishedAt <= to);
            var sorted = false;

            foreach (var pair in sortingParams)
            {
                if (!sorted)
                {
                    if (pair.First == _goodParams[0])
                    {
                        temp = pair.Second ? temp.OrderBy(x => x.PublishedAt) : temp.OrderByDescending(x => x.PublishedAt);
                    }
                    else if (pair.First == _goodParams[1])
                    {
                        temp = pair.Second ? temp.OrderBy(x => x.IdVacancy) : temp.OrderByDescending(x => x.IdVacancy);
                    }
                    else if (pair.First == _goodParams[2])
                    {
                        temp = pair.Second ? temp.OrderBy(x => x.Name) : temp.OrderByDescending(x => x.Name);
                    }
                    else
                    {
                        temp = pair.Second ? temp.OrderBy(x => x.IdArea) : temp.OrderByDescending(x => x.IdArea);
                    }

                    sorted = true;
                }
                else
                {

                    if (pair.First == _goodParams[0])
                    {
                        temp = pair.Second ? ((IOrderedQueryable<Vacancy>)temp).ThenBy(x => x.PublishedAt) : ((IOrderedQueryable<Vacancy>)temp).ThenByDescending(x => x.PublishedAt);
                    }
                    else if (pair.First == _goodParams[1])
                    {
                        temp = pair.Second ? ((IOrderedQueryable<Vacancy>)temp).ThenBy(x => x.IdVacancy) : ((IOrderedQueryable<Vacancy>)temp).ThenByDescending(x => x.IdVacancy);
                    }
                    else if (pair.First == _goodParams[2])
                    {
                        temp = pair.Second ? ((IOrderedQueryable<Vacancy>)temp).ThenBy(x => x.Name) : ((IOrderedQueryable<Vacancy>)temp).ThenByDescending(x => x.Name);
                    }
                    else
                    {
                        temp = pair.Second ? ((IOrderedQueryable<Vacancy>)temp).ThenBy(x => x.IdArea) : ((IOrderedQueryable<Vacancy>)temp).ThenByDescending(x => x.IdArea);
                    }
                }
            }

            temp = temp.Skip(page.Value * perPage.Value).Take(perPage.Value);
            return await temp.ToListAsync();
        }

        public static async Task<Area?> GetAreaAsync(int id)
        {
            await using var ctx = new HhContext();
            return await ctx.Areas.FindAsync(id);
        }

        public static async Task<Skill?> GetSkillAsync(int id)
        {
            await using var ctx = new HhContext();
            return await ctx.Skills.FindAsync(id);
        }

        public static async Task<Specialization?> GetSpecializationAsync(string id)
        {
            await using var ctx = new HhContext();
            return await ctx.Specializations.FindAsync(id);
        }

        public static async Task<Experience?> GetExperienceAsync(string id)
        {
            await using var ctx = new HhContext();
            return await ctx.Experiences.FindAsync(id);
        }

        public static async Task<List<VacanciesSkill>> GetVacancySkillsAsync(int vacancyId)
        {
            await using var ctx = new HhContext();
            return await ctx.VacanciesSkills.AsNoTracking().Where(x => x.IdVacancy == vacancyId).ToListAsync();
        }

        public static async Task<List<VacanciesSpecialization>> GetVacancySpecializationsAsync(int vacancyId)
        {
            await using var ctx = new HhContext();
            return await ctx.VacanciesSpecializations.AsNoTracking().Where(x => x.IdVacancy == vacancyId).ToListAsync();
        }

        #endregion

        #region Update

        public static async Task<Vacancy> UpdateVacancyAsync(Vacancy obj)
        {
            await using var ctx = new HhContext();
            var res = ctx.Vacancies.Update(obj);
            await ctx.SaveChangesAsync();
            return res.Entity;
        }

        public static async Task<Area> UpdateAreaAsync(Area obj)
        {
            await using var ctx = new HhContext();
            var res = ctx.Areas.Update(obj);
            await ctx.SaveChangesAsync();
            return res.Entity;
        }

        public static async Task<Experience> UpdateExperienceAsync(Experience obj)
        {
            await using var ctx = new HhContext();
            var res = ctx.Experiences.Update(obj);
            await ctx.SaveChangesAsync();
            return res.Entity;
        }

        public static async Task<Skill> UpdateSkillAsync(Skill obj)
        {
            await using var ctx = new HhContext();
            var res = ctx.Skills.Update(obj);
            await ctx.SaveChangesAsync();
            return res.Entity;
        }

        public static async Task<Specialization> UpdateSpecializationAsync(Specialization obj)
        {
            await using var ctx = new HhContext();
            var res = ctx.Specializations.Update(obj);
            await ctx.SaveChangesAsync();
            return res.Entity;
        }

        #endregion

        #region Delete

        public static async Task<bool> DeleteVacancyAsync(int id)
        {
            await using var ctx = new HhContext();

            var vacancy = await ctx.Vacancies.FindAsync(id);

            if (vacancy == null)
                return false;

            var skills = await ctx.VacanciesSkills.AsNoTracking().Where(x => x.IdVacancy == id).ToListAsync();
            var specials = await ctx.VacanciesSpecializations.AsNoTracking().Where(x => x.IdVacancy == id).ToListAsync();

            if (skills.Any())
            {
                ctx.VacanciesSkills.RemoveRange(skills);
                await ctx.SaveChangesAsync();
            }

            if (specials.Any())
            {
                ctx.VacanciesSpecializations.RemoveRange(specials);
                await ctx.SaveChangesAsync();
            }

            ctx.Vacancies.Remove(vacancy);
            await ctx.SaveChangesAsync();

            return true;
        }

        public static async Task<bool> DeleteSkillAsync(int id)
        {
            await using var ctx = new HhContext();

            var skill = await ctx.Skills.FindAsync(id);

            if (skill == null)
                return false;

            var skills = await ctx.VacanciesSkills.AsNoTracking().Where(x => x.IdSkill == id).ToListAsync();

            if (skills.Any())
            {
                ctx.VacanciesSkills.RemoveRange(skills);
                await ctx.SaveChangesAsync();
            }

            ctx.Skills.Remove(skill);
            await ctx.SaveChangesAsync();

            return true;
        }

        public static async Task<bool> DeleteSpecializationAsync(string id)
        {
            await using var ctx = new HhContext();

            var specialization = await ctx.Specializations.FindAsync(id);

            if (specialization == null)
                return false;

            var skills = await ctx.VacanciesSpecializations.AsNoTracking().Where(x => x.IdSpecialization == id).ToListAsync();

            if (skills.Any())
            {
                ctx.VacanciesSpecializations.RemoveRange(skills);
                await ctx.SaveChangesAsync();
            }

            ctx.Specializations.Remove(specialization);
            await ctx.SaveChangesAsync();

            return true;
        }

        public static async Task<bool> DeleteVacancySpecializationAsync(int vacancyId, string specializationId)
        {
            await using var ctx = new HhContext();

            var obj = await ctx.VacanciesSpecializations.FindAsync(vacancyId, specializationId);

            if (obj == null)
            {
                return false;
            }

            ctx.VacanciesSpecializations.Remove(obj);
            await ctx.SaveChangesAsync();

            return true;
        }

        public static async Task<bool> DeleteVacancySkillsAsync(int vacancyId, int skillId)
        {
            await using var ctx = new HhContext();

            var obj = await ctx.VacanciesSkills.FindAsync(vacancyId, skillId);

            if (obj == null)
            {
                return false;
            }

            ctx.VacanciesSkills.Remove(obj);
            await ctx.SaveChangesAsync();

            return true;
        }

        public static async Task<bool> DeleteExperienceAsync(string id)
        {
            await using var ctx = new HhContext();
            var obj = await ctx.Experiences.Include(x => x.Vacancies).FirstOrDefaultAsync(x => x.IdExperience == id);
            if (obj == null || obj.Vacancies!.Any())
                return false;
            ctx.Experiences.Remove(obj);
            await ctx.SaveChangesAsync();
            return true;
        }

        public static async Task<bool> DeleteAreaAsync(int id)
        {
            await using var ctx = new HhContext();
            var obj = await ctx.Areas.Include(x => x.Vacancies).FirstOrDefaultAsync(x => x.IdArea == id);
            if (obj == null || obj.Vacancies!.Any())
                return false;
            ctx.Areas.Remove(obj);
            await ctx.SaveChangesAsync();
            return true;
        }

        #endregion
    }
}
