using HH.DB.Models;
using HH.Forms.Forms;

namespace HH.Forms
{
    public partial class VacanciesForm : Form
    {
        public Vacancy? Object;
        public List<int> Skills;
        public List<string> Specs;

        public VacanciesForm()
        {
            InitializeComponent();

            Skills = new List<int>();
            Specs = new List<string>();
        }

        private void LoadInfo()
        {
            if (Object != null)
            {
                VacancyIDTextBox.Text = Object.IdVacancy.ToString();
                AddedAtDatetimeLabel.Text = Object.PublishedAt.ToString();
                VacancyNameTextBox.Text = Object.Name;
                AreaIDTextBox.Text = Object.IdArea.ToString();
                SalaryFromTextBox.Text = Object.SalaryFrom?.ToString() ?? "";
                SalaryToTextBox.Text = Object.SalaryTo?.ToString() ?? "";
                CurrencyTextBox.Text = Object.SalaryCurrency ?? "";
                SkillsIDTextBox.Text = String.Join(", ", Skills);
                SpecializationsIDTextBox.Text = String.Join(", ", Specs);
                ExperienceIDTextBox.Text = Object.IdExperience;
                SnippetRequirementTextBox.Text = Object.SnippetRequirement;
                SnippetResponsibilityTextBox.Text = Object.SnippetResponsibility;
                DescriptionTextBox.Text = Object.Description;
            }
            else
            {
                VacancyIDTextBox.Text             = "";
                AddedAtDatetimeLabel.Text                 = "";
                VacancyNameTextBox.Text           = "";
                AreaIDTextBox.Text                = "";
                SalaryFromTextBox.Text            = "";
                SalaryToTextBox.Text              = "";
                CurrencyTextBox.Text              = "";
                SkillsIDTextBox.Text              = "";
                SpecializationsIDTextBox.Text     = "";
                ExperienceIDTextBox.Text          = "";
                SnippetRequirementTextBox.Text    = "";
                SnippetResponsibilityTextBox.Text = "";
                DescriptionTextBox.Text = "";
            }
        }

        private void Clear()
        {
            Object = null;
            Skills = new List<int>();
            Specs = new List<string>();
            LoadInfo();
        }

        private Vacancy Compile()
        {
            return new Vacancy
            {
                IdVacancy = String.IsNullOrEmpty(VacancyIDTextBox.Text) ? 0 : int.Parse(VacancyIDTextBox.Text)      ,
                PublishedAt = DateTime.Parse(AddedAtDatetimeLabel.Text)                 ,
                Name = VacancyNameTextBox.Text           ,
                IdArea = int.Parse(AreaIDTextBox.Text)                ,
                SalaryFrom = String.IsNullOrEmpty(SalaryFromTextBox.Text) ? null : decimal.Parse(SalaryFromTextBox.Text)           ,
                SalaryTo = String.IsNullOrEmpty(SalaryToTextBox.Text) ? null : decimal.Parse(SalaryToTextBox.Text)          ,
                SalaryCurrency = CurrencyTextBox.Text              ,
                IdExperience = ExperienceIDTextBox.Text          ,
                SnippetRequirement = SnippetRequirementTextBox.Text    ,
                SnippetResponsibility = SnippetResponsibilityTextBox.Text ,
                Description = DescriptionTextBox.Text           ,
            };
        }

        private List<int> CompileSkills()
        {
            return SkillsIDTextBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        }

        private List<string> CompileSpec()
        {
            return SpecializationsIDTextBox.Text.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private void VacanciesForm_Load(object sender, EventArgs e)
        {
            new AreaForm().Show();
            new ExperienceForm().Show();
            new SkillForm().Show();
            new SpecializationForm().Show();
        }

        private async void GetDataButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(VacancyIDTextBox.Text))
                return;

            Object = await Requests.GetVacancy(int.Parse(VacancyIDTextBox.Text));
            Skills = (await Requests.GetVacancySkill(Object.IdVacancy)).Select(x => x.IdSkill).ToList();
            Specs = (await Requests.GetVacancySpecialization(Object.IdVacancy)).Select(x => x.IdSpecialization).ToList();
            LoadInfo();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Object == null)
                return;

            await Requests.DeleteVacancy(Object);
            Clear();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            var vacancy = Compile();
            var skills = CompileSkills();
            var specs = CompileSpec();

            Object = await Requests.AddVacancy(vacancy);

            foreach (var skill in skills)
            {
                await Requests.AddVacancySkill(new VacanciesSkill {IdVacancy = Object.IdVacancy, IdSkill = skill});
            }

            foreach (var spec in specs)
            {
                await Requests.AddVacancySpecialization(new VacanciesSpecialization() { IdVacancy = Object.IdVacancy, IdSpecialization = spec });
            }

            Skills = skills;
            Specs = specs;

            LoadInfo();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            var vacancy = Compile();
            var skills = CompileSkills();
            var specs = CompileSpec();

            vacancy.IdVacancy = Object.IdVacancy;

            Object = await Requests.UpdateVacancy(vacancy);

            foreach (var skill in Skills)
            {
                await Requests.DeleteVacancySkill(new VacanciesSkill { IdVacancy = Object.IdVacancy, IdSkill = skill });
            }

            foreach (var spec in Specs)
            {
                await Requests.DeleteVacancySpecialization(new VacanciesSpecialization() { IdVacancy = Object.IdVacancy, IdSpecialization = spec });
            }

            foreach (var skill in skills)
            {
                await Requests.AddVacancySkill(new VacanciesSkill { IdVacancy = Object.IdVacancy, IdSkill = skill });
            }

            foreach (var spec in specs)
            {
                await Requests.AddVacancySpecialization(new VacanciesSpecialization() { IdVacancy = Object.IdVacancy, IdSpecialization = spec });
            }

            Skills = skills;
            Specs = specs;
        }

        private async void ShowAllButton_Click(object sender, EventArgs e)
        {
            var res = await Requests.GetVacancies();
            var dataFrom = new DataForm();
            dataFrom.dataGridView1.DataSource = res;
            dataFrom.Show();
        }

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            Clear();

        }
    }
}