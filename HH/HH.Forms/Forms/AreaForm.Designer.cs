namespace HH.Forms
{
    partial class AreaForm
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.AreaIDLabel = new System.Windows.Forms.Label();
            this.AreaIDTextBox = new System.Windows.Forms.TextBox();
            this.AreaNameLabel = new System.Windows.Forms.Label();
            this.AreaNameTextBox = new System.Windows.Forms.TextBox();
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.ForeColor = System.Drawing.Color.Linen;
            this.DeleteButton.Location = new System.Drawing.Point(763, 16);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(137, 39);
            this.DeleteButton.TabIndex = 40;
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
            this.GetDataButton.TabIndex = 39;
            this.GetDataButton.Text = "Get Data";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // AreaIDLabel
            // 
            this.AreaIDLabel.AutoSize = true;
            this.AreaIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AreaIDLabel.Location = new System.Drawing.Point(16, 20);
            this.AreaIDLabel.Name = "AreaIDLabel";
            this.AreaIDLabel.Size = new System.Drawing.Size(76, 28);
            this.AreaIDLabel.TabIndex = 38;
            this.AreaIDLabel.Text = "Area ID";
            this.AreaIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AreaIDTextBox
            // 
            this.AreaIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AreaIDTextBox.Location = new System.Drawing.Point(123, 16);
            this.AreaIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AreaIDTextBox.Name = "AreaIDTextBox";
            this.AreaIDTextBox.Size = new System.Drawing.Size(311, 34);
            this.AreaIDTextBox.TabIndex = 37;
            // 
            // AreaNameLabel
            // 
            this.AreaNameLabel.AutoSize = true;
            this.AreaNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AreaNameLabel.Location = new System.Drawing.Point(16, 79);
            this.AreaNameLabel.Name = "AreaNameLabel";
            this.AreaNameLabel.Size = new System.Drawing.Size(109, 28);
            this.AreaNameLabel.TabIndex = 42;
            this.AreaNameLabel.Text = "Area Name";
            this.AreaNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AreaNameTextBox
            // 
            this.AreaNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AreaNameTextBox.Location = new System.Drawing.Point(123, 75);
            this.AreaNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AreaNameTextBox.Name = "AreaNameTextBox";
            this.AreaNameTextBox.Size = new System.Drawing.Size(777, 34);
            this.AreaNameTextBox.TabIndex = 41;
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Location = new System.Drawing.Point(814, 144);
            this.ClearFormButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(87, 39);
            this.ClearFormButton.TabIndex = 46;
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
            this.UpdateButton.TabIndex = 45;
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
            this.AddButton.TabIndex = 44;
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
            this.StatusStrip.TabIndex = 43;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(124, 20);
            this.StatusStripLabel.Text = "Status Strip Label";
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(232, 144);
            this.ShowAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(87, 39);
            this.ShowAllButton.TabIndex = 47;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // AreaForm
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
            this.Controls.Add(this.AreaNameLabel);
            this.Controls.Add(this.AreaNameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.AreaIDLabel);
            this.Controls.Add(this.AreaIDTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AreaForm";
            this.Text = "Area";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DeleteButton;
        private Button GetDataButton;
        private Label AreaIDLabel;
        private TextBox AreaIDTextBox;
        private Label AreaNameLabel;
        private TextBox AreaNameTextBox;
        private Button ClearFormButton;
        private Button UpdateButton;
        private Button AddButton;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel StatusStripLabel;
        private Button ShowAllButton;
    }
}