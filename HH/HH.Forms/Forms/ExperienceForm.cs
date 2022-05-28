using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HH.DB.Models;
using HH.Forms.Forms;

namespace HH.Forms
{
    public partial class ExperienceForm : Form
    {
        public Experience? Object;

        public ExperienceForm()
        {
            InitializeComponent();
        }

        private void Load()
        {
            if (Object == null)
            {
                ExperienceIDTextBox.Text = "";
                ExperienceNameTextBox.Text = "";
            }
            else
            {
                ExperienceIDTextBox.Text = Object.IdExperience;
                ExperienceNameTextBox.Text = Object.Name;
            }
        }

        private void Clear()
        {
            Object = null;
            Load();
        }

        private async void GetDataButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ExperienceIDTextBox.Text))
                return;

            Object = await Requests.GetExperience(ExperienceIDTextBox.Text);
            Load();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Object == null)
                return;

            await Requests.DeleteExperience(Object);
            Clear();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ExperienceIDTextBox.Text))
                return;

            Object = await Requests.AddExperience(new Experience() {IdExperience = ExperienceIDTextBox.Text, Name = ExperienceNameTextBox.Text });
            Load();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            if (Object == null)
                return;

            Object = await Requests.UpdateExperience(new Experience() { IdExperience = ExperienceIDTextBox.Text, Name = ExperienceNameTextBox.Text });
            Load();
        }

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void ShowAllButton_Click(object sender, EventArgs e)
        {
            var res = await Requests.GetExperiences();
            var dataFrom = new DataForm();
            dataFrom.dataGridView1.DataSource = res;
            dataFrom.Show();
        }
    }
}
