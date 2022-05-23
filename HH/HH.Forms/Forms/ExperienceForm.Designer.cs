namespace HH.Forms
{
    partial class ExperienceForm
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
            this.ExperienceNameLabel = new System.Windows.Forms.Label();
            this.ExperienceNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.ExperienceIDLabel = new System.Windows.Forms.Label();
            this.ExperienceIDTextBox = new System.Windows.Forms.TextBox();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Location = new System.Drawing.Point(712, 108);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(76, 29);
            this.ClearFormButton.TabIndex = 66;
            this.ClearFormButton.Text = "Clear form";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(108, 108);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(76, 29);
            this.UpdateButton.TabIndex = 65;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(14, 108);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(76, 29);
            this.AddButton.TabIndex = 64;
            this.AddButton.Text = "Add to DB";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 153);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip.TabIndex = 63;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(97, 17);
            this.StatusStripLabel.Text = "Status Strip Label";
            // 
            // ExperienceNameLabel
            // 
            this.ExperienceNameLabel.AutoSize = true;
            this.ExperienceNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExperienceNameLabel.Location = new System.Drawing.Point(14, 59);
            this.ExperienceNameLabel.Name = "ExperienceNameLabel";
            this.ExperienceNameLabel.Size = new System.Drawing.Size(130, 21);
            this.ExperienceNameLabel.TabIndex = 62;
            this.ExperienceNameLabel.Text = "Experience Name";
            this.ExperienceNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExperienceNameTextBox
            // 
            this.ExperienceNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExperienceNameTextBox.Location = new System.Drawing.Point(150, 56);
            this.ExperienceNameTextBox.Name = "ExperienceNameTextBox";
            this.ExperienceNameTextBox.Size = new System.Drawing.Size(638, 29);
            this.ExperienceNameTextBox.TabIndex = 61;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.ForeColor = System.Drawing.Color.Linen;
            this.DeleteButton.Location = new System.Drawing.Point(668, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 29);
            this.DeleteButton.TabIndex = 60;
            this.DeleteButton.Text = "Delete from DB";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // GetDataButton
            // 
            this.GetDataButton.Location = new System.Drawing.Point(419, 12);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(76, 29);
            this.GetDataButton.TabIndex = 59;
            this.GetDataButton.Text = "Get Data";
            this.GetDataButton.UseVisualStyleBackColor = true;
            // 
            // ExperienceIDLabel
            // 
            this.ExperienceIDLabel.AutoSize = true;
            this.ExperienceIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExperienceIDLabel.Location = new System.Drawing.Point(14, 15);
            this.ExperienceIDLabel.Name = "ExperienceIDLabel";
            this.ExperienceIDLabel.Size = new System.Drawing.Size(103, 21);
            this.ExperienceIDLabel.TabIndex = 58;
            this.ExperienceIDLabel.Text = "Experience ID";
            this.ExperienceIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExperienceIDTextBox
            // 
            this.ExperienceIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExperienceIDTextBox.Location = new System.Drawing.Point(150, 12);
            this.ExperienceIDTextBox.Name = "ExperienceIDTextBox";
            this.ExperienceIDTextBox.Size = new System.Drawing.Size(263, 29);
            this.ExperienceIDTextBox.TabIndex = 57;
            // 
            // ExperienceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 175);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ExperienceNameLabel);
            this.Controls.Add(this.ExperienceNameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.ExperienceIDLabel);
            this.Controls.Add(this.ExperienceIDTextBox);
            this.Name = "ExperienceForm";
            this.Text = "Experience";
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
        private Label ExperienceNameLabel;
        private TextBox ExperienceNameTextBox;
        private Button DeleteButton;
        private Button GetDataButton;
        private Label ExperienceIDLabel;
        private TextBox ExperienceIDTextBox;
    }
}