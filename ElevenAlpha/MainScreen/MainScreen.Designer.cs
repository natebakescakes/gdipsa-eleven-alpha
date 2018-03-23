namespace ElevenAlpha
{
    partial class MainScreen
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bookingsTabPage = new System.Windows.Forms.TabPage();
            this.membersTabPage = new System.Windows.Forms.TabPage();
            this.facilitiesTabPage = new System.Windows.Forms.TabPage();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.bookingsTabPage);
            this.tabControl.Controls.Add(this.membersTabPage);
            this.tabControl.Controls.Add(this.facilitiesTabPage);
            this.tabControl.Controls.Add(this.reportsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 150);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(150, 10);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2069, 860);
            this.tabControl.TabIndex = 0;
            // 
            // bookingsTabPage
            // 
            this.bookingsTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsTabPage.Location = new System.Drawing.Point(10, 88);
            this.bookingsTabPage.Name = "bookingsTabPage";
            this.bookingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bookingsTabPage.Size = new System.Drawing.Size(2049, 762);
            this.bookingsTabPage.TabIndex = 0;
            this.bookingsTabPage.Text = "📕 Bookings";
            this.bookingsTabPage.UseVisualStyleBackColor = true;
            // 
            // membersTabPage
            // 
            this.membersTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersTabPage.Location = new System.Drawing.Point(10, 88);
            this.membersTabPage.Name = "membersTabPage";
            this.membersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.membersTabPage.Size = new System.Drawing.Size(2049, 762);
            this.membersTabPage.TabIndex = 1;
            this.membersTabPage.Text = "👪 Members";
            this.membersTabPage.UseVisualStyleBackColor = true;
            // 
            // facilitiesTabPage
            // 
            this.facilitiesTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilitiesTabPage.Location = new System.Drawing.Point(10, 88);
            this.facilitiesTabPage.Name = "facilitiesTabPage";
            this.facilitiesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.facilitiesTabPage.Size = new System.Drawing.Size(2049, 762);
            this.facilitiesTabPage.TabIndex = 2;
            this.facilitiesTabPage.Text = "🎾 Facilities";
            this.facilitiesTabPage.UseVisualStyleBackColor = true;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsTabPage.Location = new System.Drawing.Point(10, 88);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(2049, 762);
            this.reportsTabPage.TabIndex = 3;
            this.reportsTabPage.Text = "📃 Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1719, 129);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2069, 1010);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Name = "MainScreen";
            this.Padding = new System.Windows.Forms.Padding(0, 150, 0, 0);
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage bookingsTabPage;
        private System.Windows.Forms.TabPage membersTabPage;
        private System.Windows.Forms.TabPage facilitiesTabPage;
        private System.Windows.Forms.TabPage reportsTabPage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

