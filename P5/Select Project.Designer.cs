namespace P5
{
    partial class SelProject
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
            this.cncl = new System.Windows.Forms.Button();
            this.selPrjt = new System.Windows.Forms.Button();
            this.ProjectOptions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cncl
            // 
            this.cncl.Location = new System.Drawing.Point(270, 362);
            this.cncl.Name = "cncl";
            this.cncl.Size = new System.Drawing.Size(137, 32);
            this.cncl.TabIndex = 1;
            this.cncl.Text = "Cancel";
            this.cncl.UseVisualStyleBackColor = true;
            this.cncl.Click += new System.EventHandler(this.cncl_Click);
            // 
            // selPrjt
            // 
            this.selPrjt.Location = new System.Drawing.Point(442, 362);
            this.selPrjt.Name = "selPrjt";
            this.selPrjt.Size = new System.Drawing.Size(137, 32);
            this.selPrjt.TabIndex = 2;
            this.selPrjt.Text = "Select Project";
            this.selPrjt.UseVisualStyleBackColor = true;
            this.selPrjt.Click += new System.EventHandler(this.selPrjt_Click);
            // 
            // ProjectOptions
            // 
            this.ProjectOptions.FormattingEnabled = true;
            this.ProjectOptions.ItemHeight = 16;
            this.ProjectOptions.Location = new System.Drawing.Point(40, 28);
            this.ProjectOptions.Name = "ProjectOptions";
            this.ProjectOptions.Size = new System.Drawing.Size(538, 308);
            this.ProjectOptions.TabIndex = 3;
            this.ProjectOptions.SelectedIndexChanged += new System.EventHandler(this.ProjectOptions_SelectedIndexChanged);
            // 
            // SelProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.ProjectOptions);
            this.Controls.Add(this.selPrjt);
            this.Controls.Add(this.cncl);
            this.Name = "SelProject";
            this.Text = "Select Project";
            this.Load += new System.EventHandler(this.SelProject_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cncl;
        private System.Windows.Forms.Button selPrjt;
        private System.Windows.Forms.ListBox ProjectOptions;
    }
}