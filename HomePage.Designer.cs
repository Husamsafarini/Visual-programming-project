
namespace Prison_Project
{
    partial class HomePage
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
            this.btnOfficersView = new System.Windows.Forms.Button();
            this.btnPrisonersView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOfficersView
            // 
            this.btnOfficersView.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOfficersView.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOfficersView.Location = new System.Drawing.Point(35, 83);
            this.btnOfficersView.Name = "btnOfficersView";
            this.btnOfficersView.Size = new System.Drawing.Size(208, 43);
            this.btnOfficersView.TabIndex = 0;
            this.btnOfficersView.Text = "Officers ";
            this.btnOfficersView.UseVisualStyleBackColor = false;
            this.btnOfficersView.Click += new System.EventHandler(this.btnOfficersView_Click);
            // 
            // btnPrisonersView
            // 
            this.btnPrisonersView.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrisonersView.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrisonersView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrisonersView.Location = new System.Drawing.Point(267, 83);
            this.btnPrisonersView.Name = "btnPrisonersView";
            this.btnPrisonersView.Size = new System.Drawing.Size(208, 43);
            this.btnPrisonersView.TabIndex = 1;
            this.btnPrisonersView.Text = "Prisoners";
            this.btnPrisonersView.UseVisualStyleBackColor = false;
            this.btnPrisonersView.Click += new System.EventHandler(this.btnPrisonersView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "View the Officers\' Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "View the Prisoners\' Database";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 158);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrisonersView);
            this.Controls.Add(this.btnOfficersView);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOfficersView;
        private System.Windows.Forms.Button btnPrisonersView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}