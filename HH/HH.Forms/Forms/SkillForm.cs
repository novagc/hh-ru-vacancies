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
    public partial class SkillForm : Form
    {
        public Skill? Object;

        public SkillForm()
        {
            InitializeComponent();
        }

        private void Load()
        {
            if (Object == null)
            {
                SkillIDTextBox.Text = "";
                SkillNameTextBox.Text = "";
            }
            else
            {
                SkillIDTextBox.Text = Object.IdSkill.ToString();
                SkillNameTextBox.Text = Object.Name;
            }
        }

        private void Clear()
        {
            Object = null;
            Load();
        }

        private async void GetDataButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SkillIDTextBox.Text))
                return;

            Object = await Requests.GetSkill(int.Parse(SkillIDTextBox.Text));
            Load();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Object == null)
                return;

            await Requests.DeleteSkill(Object);
            Clear();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SkillIDTextBox.Text))
                return;

            Object = await Requests.AddSkill(new Skill() { Name = SkillNameTextBox.Text });
            Load();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            if (Object == null)
                return;

            Object = await Requests.UpdateSkill(new Skill() { IdSkill = Object.IdSkill, Name = SkillNameTextBox.Text });
            Load();
        }

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void ShowAllButton_Click_1(object sender, EventArgs e)
        {
            var res = await Requests.GetSkills();
            var dataFrom = new DataForm();
            dataFrom.dataGridView1.DataSource = res;
            dataFrom.Show();
        }
    }
}
