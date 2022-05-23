namespace HH.Forms
{
    partial class SpecializationForm
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
            this.SpecializationNameLabel = new System.Windows.Forms.Label();
            this.SpecializationNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.SpecializationIDLabel = new System.Windows.Forms.Label();
            this.SpecializationIDTextBox = new System.Windows.Forms.TextBox();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Location = new System.Drawing.Point(712, 108);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(76, 29);
            this.ClearFormButton.TabIndex = 56;
            this.ClearFormButton.Text = "Clear form";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(108, 108);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(76, 29);
            this.UpdateButton.TabIndex = 55;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(14, 108);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(76, 29);
            this.AddButton.TabIndex = 54;
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
            this.StatusStrip.TabIndex = 53;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(97, 17);
            this.StatusStripLabel.Text = "Status Strip Label";
            // 
            // SpecializationNameLabel
            // 
            this.SpecializationNameLabel.AutoSize = true;
            this.SpecializationNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecializationNameLabel.Location = new System.Drawing.Point(14, 59);
            this.SpecializationNameLabel.Name = "SpecializationNameLabel";
            this.SpecializationNameLabel.Size = new System.Drawing.Size(151, 21);
            this.SpecializationNameLabel.TabIndex = 52;
            this.SpecializationNameLabel.Text = "Specialization Name";
            this.SpecializationNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpecializationNameTextBox
            // 
            this.SpecializationNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecializationNameTextBox.Location = new System.Drawing.Point(170, 56);
            this.SpecializationNameTextBox.Name = "SpecializationNameTextBox";
            this.SpecializationNameTextBox.Size = new System.Drawing.Size(618, 29);
            this.SpecializationNameTextBox.TabIndex = 51;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.ForeColor = System.Drawing.Color.Linen;
            this.DeleteButton.Location = new System.Drawing.Point(668, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 29);
            this.DeleteButton.TabIndex = 50;
            this.DeleteButton.Text = "Delete from DB";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // GetDataButton
            // 
            this.GetDataButton.Location = new System.Drawing.Point(419, 12);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(76, 29);
            this.GetDataButton.TabIndex = 49;
            this.GetDataButton.Text = "Get Data";
            this.GetDataButton.UseVisualStyleBackColor = true;
            // 
            // SpecializationIDLabel
            // 
            this.SpecializationIDLabel.AutoSize = true;
            this.SpecializationIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecializationIDLabel.Location = new System.Drawing.Point(14, 15);
            this.SpecializationIDLabel.Name = "SpecializationIDLabel";
            this.SpecializationIDLabel.Size = new System.Drawing.Size(124, 21);
            this.SpecializationIDLabel.TabIndex = 48;
            this.SpecializationIDLabel.Text = "Specialization ID";
            this.SpecializationIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpecializationIDTextBox
            // 
            this.SpecializationIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpecializationIDTextBox.Location = new System.Drawing.Point(170, 12);
            this.SpecializationIDTextBox.Name = "SpecializationIDTextBox";
            this.SpecializationIDTextBox.Size = new System.Drawing.Size(243, 29);
            this.SpecializationIDTextBox.TabIndex = 47;
            // 
            // SpecializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 175);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.SpecializationNameLabel);
            this.Controls.Add(this.SpecializationNameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.SpecializationIDLabel);
            this.Controls.Add(this.SpecializationIDTextBox);
            this.Name = "SpecializationForm";
            this.Text = "Specialization";
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
        private Label SpecializationNameLabel;
        private TextBox SpecializationNameTextBox;
        private Button DeleteButton;
        private Button GetDataButton;
        private Label SpecializationIDLabel;
        private TextBox SpecializationIDTextBox;
    }
}