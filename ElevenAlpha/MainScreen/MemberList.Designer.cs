namespace ElevenAlpha
{
    partial class MemberList
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
            this.MemberListCRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MemberListCRV
            // 
            this.MemberListCRV.ActiveViewIndex = -1;
            this.MemberListCRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemberListCRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.MemberListCRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberListCRV.Location = new System.Drawing.Point(0, 0);
            this.MemberListCRV.Name = "MemberListCRV";
            this.MemberListCRV.Size = new System.Drawing.Size(800, 450);
            this.MemberListCRV.TabIndex = 0;
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MemberListCRV);
            this.Name = "MemberList";
            this.Text = "MemberList";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MemberListCRV;
    }
}