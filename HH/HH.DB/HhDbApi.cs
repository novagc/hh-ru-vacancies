using HH.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace HH.DB
{
    public static class HhDbApi
    {
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

        public static async Task AddAreasRange(List<Area> areas)
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

        public static async Task<List<Skill>> GetSkills()
        {
            await using var ctx = new HhContext();
            return await ctx.Skills.ToListAsync();
        }

        public static async Task<List<Specialization>> GetSpecializationsAsync()
        {
            await using var ctx = new HhContext();
            return await ctx.Specializations.ToListAsync();
        }
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
