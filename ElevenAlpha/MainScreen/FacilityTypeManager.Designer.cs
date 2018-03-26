namespace ElevenAlpha
{
    partial class FacilityTypeManager
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
            this.InputTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FacilityDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FacilityDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InputTypeNameTextBox
            // 
            this.InputTypeNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InputTypeNameTextBox.Location = new System.Drawing.Point(99, 648);
            this.InputTypeNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.InputTypeNameTextBox.Name = "InputTypeNameTextBox";
            this.InputTypeNameTextBox.Size = new System.Drawing.Size(638, 38);
            this.InputTypeNameTextBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddButton.Location = new System.Drawing.Point(99, 698);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 48);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateButton.Location = new System.Drawing.Point(261, 698);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(150, 48);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(423, 698);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 48);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(585, 698);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(150, 48);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FacilityDataGrid
            // 
            this.FacilityDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FacilityDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacilityDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacilityDataGrid.Location = new System.Drawing.Point(100, 50);
            this.FacilityDataGrid.Margin = new System.Windows.Forms.Padding(6);
            this.FacilityDataGrid.Name = "FacilityDataGrid";
            this.FacilityDataGrid.RowTemplate.Height = 27;
            this.FacilityDataGrid.Size = new System.Drawing.Size(637, 586);
            this.FacilityDataGrid.TabIndex = 8;
            this.FacilityDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // FacilityTypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 786);
            this.Controls.Add(this.FacilityDataGrid);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputTypeNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FacilityTypeManager";
            this.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            this.Text = "Facility Type Manager";
            this.Load += new System.EventHandler(this.FacilityTypeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacilityDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputTypeNameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView FacilityDataGrid;
    }
}