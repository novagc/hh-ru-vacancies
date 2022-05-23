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

        public static async Task AddExperienceRange(List<Experience> experiences)
        {
            await using var ctx = new HhContext();
            ctx.Experiences.AddOrSkip(experiences);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddSkillRange(List<Skill> skills)
        {
            await using var ctx = new HhContext();
            ctx.Skills.AddOrSkip(skills);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddSpecializationsRange(List<Specialization> specializations)
        {
            await using var ctx = new HhContext();
            ctx.Specializations.AddOrSkip(specializations);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddVacanciesRange(List<Vacancy> vacancies)
        {
            await using var ctx = new HhContext();
            ctx.Vacancies.AddOrUpdate(vacancies);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddVacanciesSkillsRange(List<VacanciesSkill> links)
        {
            await using var ctx = new HhContext();

            var temp = links.Select(x => x.IdVacancy).ToHashSet();

            ctx.VacanciesSkills
                .RemoveRange(ctx.VacanciesSkills.AsNoTracking().Where(x => temp.Contains(x.IdVacancy)));

            await ctx.SaveChangesAsync();
            await ctx.VacanciesSkills.AddRangeAsync(links);
            await ctx.SaveChangesAsync();
        }

        public static async Task AddVacanciesSpecializationsRange(List<VacanciesSpecialization> links)
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

        public static async Task<List<Specialization>> GetSpecializations()
        {
            await using var ctx = new HhContext();
            return await ctx.Specializations.ToListAsync();
        }
    }
}
