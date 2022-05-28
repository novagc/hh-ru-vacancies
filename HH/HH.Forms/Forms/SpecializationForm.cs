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
    public partial class SpecializationForm : Form
    {
        public Specialization? Object;

        public SpecializationForm()
        {
            InitializeComponent();
        }

        private void Load()
        {
            if (Object == null)
            {
                SpecializationIDTextBox.Text = "";
                SpecializationNameTextBox.Text = "";
            }
            else
            {
                SpecializationIDTextBox.Text = Object.IdSpecialization;
                SpecializationNameTextBox.Text = Object.Name;
            }
        }

        private void Clear()
        {
            Object = null;
            Load();
        }

        private async void GetDataButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SpecializationIDTextBox.Text))
                return;

            Object = await Requests.GetSpecialization(SpecializationIDTextBox.Text);
            Load();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Object == null)
                return;

            await Requests.DeleteSpecialization(Object);
            Clear();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SpecializationIDTextBox.Text))
                return;

            Object = await Requests.AddSpecialization(new Specialization() { IdSpecialization = SpecializationIDTextBox.Text, Name = SpecializationNameTextBox.Text });
            Load();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            if (Object == null)
                return;

            Object = await Requests.UpdateSpecialization(new Specialization() { IdSpecialization = SpecializationIDTextBox.Text, Name = SpecializationNameTextBox.Text });
            Load();
        }

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void ShowAllButton_Click(object sender, EventArgs e)
        {
            var res = await Requests.GetSpecializations();
            var dataFrom = new DataForm();
            dataFrom.dataGridView1.DataSource = res;
            dataFrom.Show();
        }
    }
}
