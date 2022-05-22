using HH.Net.Models.ExperienceModel;

namespace HH.Net.Requests
{
    public class ExperienceRequest
    {
        public Task<List<ExperienceItem>> Send()
        {
            return Task<List<ExperienceItem>>.Factory.StartNew(() => new List<ExperienceItem>
            {
                new ()
                {
                    Id="noExperience",
                    Name="Нет опыта" 
                },
                new ()
                {
                    Id="between1And3",
                    Name="От 1 года до 3 лет"
                },
                new ()
                {
                    Id="between3And6",
                    Name="От 3 до 6 лет"
                },
                new ()
                {
                    Id="moreThan6",
                    Name="Более 6 лет"
                }
            });
        }
    }
}
