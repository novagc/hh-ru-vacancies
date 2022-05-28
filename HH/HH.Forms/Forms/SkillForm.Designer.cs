namespace HH.Forms
{
    partial class SkillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SkillNameLabel = new System.Windows.Forms.Label();
            this.SkillNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.SkillIDLabel = new System.Windows.Forms.Label();
            this.SkillIDTextBox = new System.Windows.Forms.TextBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Location = new System.Drawing.Point(814, 144);
            this.ClearFormButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(87, 39);
            this.ClearFormButton.TabIndex = 56;
            this.ClearFormButton.Text = "Clear form";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(123, 144);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(87, 39);
            this.UpdateButton.TabIndex = 55;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 144);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 39);
            this.AddButton.TabIndex = 54;
            this.AddButton.Text = "Add to DB";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 207);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip.Size = new System.Drawing.Size(914, 26);
            this.StatusStrip.TabIndex = 53;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(124, 20);
            this.StatusStripLabel.Text = "Status Strip Label";
            // 
            // SkillNameLabel
            // 
            this.SkillNameLabel.AutoSize = true;
            this.SkillNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkillNameLabel.Location = new System.Drawing.Point(16, 79);
            this.SkillNameLabel.Name = "SkillNameLabel";
            this.SkillNameLabel.Size = new System.Drawing.Size(105, 28);
            this.SkillNameLabel.TabIndex = 52;
            this.SkillNameLabel.Text = "Skill Name";
            this.SkillNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkillNameTextBox
            // 
            this.SkillNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkillNameTextBox.Location = new System.Drawing.Point(123, 75);
            this.SkillNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SkillNameTextBox.Name = "SkillNameTextBox";
            this.SkillNameTextBox.Size = new System.Drawing.Size(777, 34);
            this.SkillNameTextBox.TabIndex = 51;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.ForeColor = System.Drawing.Color.Linen;
            this.DeleteButton.Location = new System.Drawing.Point(763, 16);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(137, 39);
            this.DeleteButton.TabIndex = 50;
            this.DeleteButton.Text = "Delete from DB";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // GetDataButton
            // 
            this.GetDataButton.Location = new System.Drawing.Point(442, 16);
            this.GetDataButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(87, 39);
            this.GetDataButton.TabIndex = 49;
            this.GetDataButton.Text = "Get Data";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // SkillIDLabel
            // 
            this.SkillIDLabel.AutoSize = true;
            this.SkillIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkillIDLabel.Location = new System.Drawing.Point(16, 20);
            this.SkillIDLabel.Name = "SkillIDLabel";
            this.SkillIDLabel.Size = new System.Drawing.Size(72, 28);
            this.SkillIDLabel.TabIndex = 48;
            this.SkillIDLabel.Text = "Skill ID";
            this.SkillIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkillIDTextBox
            // 
            this.SkillIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkillIDTextBox.Location = new System.Drawing.Point(123, 16);
            this.SkillIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SkillIDTextBox.Name = "SkillIDTextBox";
            this.SkillIDTextBox.Size = new System.Drawing.Size(311, 34);
            this.SkillIDTextBox.TabIndex = 47;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(232, 144);
            this.ShowAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(87, 39);
            this.ShowAllButton.TabIndex = 57;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click_1);
            // 
            // SkillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 233);
            this.ControlBox = false;
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.SkillNameLabel);
            this.Controls.Add(this.SkillNameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.SkillIDLabel);
            this.Controls.Add(this.SkillIDTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SkillForm";
            this.Text = "Skill";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ClearFormButton;
        private Button UpdateButton;
        private Button AddButton;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel StatusStripLabel;
        private Label SkillNameLabel;
        private TextBox SkillNameTextBox;
        private Button DeleteButton;
        private Button GetDataButton;
        private Label SkillIDLabel;
        private TextBox SkillIDTextBox;
        private Button ShowAllButton;
    }
}