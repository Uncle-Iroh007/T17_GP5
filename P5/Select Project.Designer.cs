namespace P5
{
    partial class selProject
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cncl = new System.Windows.Forms.Button();
            this.selPrjt = new System.Windows.Forms.Button();
            this.AccProject = new System.Windows.Forms.Label();
            this.expnProject = new System.Windows.Forms.Label();
            this.otherPrj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(549, 281);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // cncl
            // 
            this.cncl.Location = new System.Drawing.Point(270, 362);
            this.cncl.Name = "cncl";
            this.cncl.Size = new System.Drawing.Size(137, 32);
            this.cncl.TabIndex = 1;
            this.cncl.Text = "Cancle";
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
            // AccProject
            // 
            this.AccProject.AutoSize = true;
            this.AccProject.Location = new System.Drawing.Point(48, 66);
            this.AccProject.Name = "AccProject";
            this.AccProject.Size = new System.Drawing.Size(147, 17);
            this.AccProject.TabIndex = 3;
            this.AccProject.Text = "1 - Accounting Project";
            this.AccProject.Click += new System.EventHandler(this.AccProject_Click);
            // 
            // expnProject
            // 
            this.expnProject.AutoSize = true;
            this.expnProject.Location = new System.Drawing.Point(48, 100);
            this.expnProject.Name = "expnProject";
            this.expnProject.Size = new System.Drawing.Size(165, 17);
            this.expnProject.TabIndex = 4;
            this.expnProject.Text = "2 - Big Expensive Project";
            this.expnProject.Click += new System.EventHandler(this.expnProject_Click);
            // 
            // otherPrj
            // 
            this.otherPrj.AutoSize = true;
            this.otherPrj.Location = new System.Drawing.Point(48, 135);
            this.otherPrj.Name = "otherPrj";
            this.otherPrj.Size = new System.Drawing.Size(153, 17);
            this.otherPrj.TabIndex = 5;
            this.otherPrj.Text = "3 - Some Other Project";
            this.otherPrj.Click += new System.EventHandler(this.otherPrj_Click);
            // 
            // selProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.otherPrj);
            this.Controls.Add(this.expnProject);
            this.Controls.Add(this.AccProject);
            this.Controls.Add(this.selPrjt);
            this.Controls.Add(this.cncl);
            this.Controls.Add(this.richTextBox1);
            this.Name = "selProject";
            this.Text = "Select Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button cncl;
        private System.Windows.Forms.Button selPrjt;
        private System.Windows.Forms.Label AccProject;
        private System.Windows.Forms.Label expnProject;
        private System.Windows.Forms.Label otherPrj;
    }
}