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
    public partial class AreaForm : Form
    {
        public Area? CurrentArea;

        public AreaForm()
        {
            InitializeComponent();
        }

        private void Load()
        {
            if (CurrentArea == null)
            {
                AreaNameTextBox.Text = "";
                AreaIDTextBox.Text = "";
            }
            else
            {
                AreaIDTextBox.Text = CurrentArea.IdArea.ToString();
                AreaNameTextBox.Text = CurrentArea.Name;
            }
        }

        private void Clear()
        {
            CurrentArea = null;
            Load();
        }

        private async void GetDataButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AreaIDTextBox.Text))
                return;

            CurrentArea = await Requests.GetArea(int.Parse(AreaIDTextBox.Text));
            Load();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CurrentArea == null)
                return;

            await Requests.DeleteArea(CurrentArea);
            Clear();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AreaNameTextBox.Text))
                return;

            CurrentArea = await Requests.AddArea(new Area{Name = AreaNameTextBox.Text});
            Load();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CurrentArea == null)
                return;

            CurrentArea = await Requests.UpdateArea(new Area { IdArea = CurrentArea.IdArea, Name = AreaNameTextBox.Text });
            Load();
        }

        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private async void ShowAllButton_Click(object sender, EventArgs e)
        {
            var res = await Requests.GetAreas();
            var dataFrom = new DataForm();
            dataFrom.dataGridView1.DataSource = res;
            dataFrom.Show();
        }
    }
}
