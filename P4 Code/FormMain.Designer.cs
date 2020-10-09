namespace P4_Code
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sel_project = new System.Windows.Forms.ToolStripMenuItem();
            this.crt_project = new System.Windows.Forms.ToolStripMenuItem();
            this.mdfy_project = new System.Windows.Forms.ToolStripMenuItem();
            this.rmv_project = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dsh_brd = new System.Windows.Forms.ToolStripMenuItem();
            this.Rcrd = new System.Windows.Forms.ToolStripMenuItem();
            this.Mdfy = new System.Windows.Forms.ToolStripMenuItem();
            this.Rmv = new System.Windows.Forms.ToolStripMenuItem();
            this.Rprt = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Assign = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Assign = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Atrifact = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Artiface = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_dRange = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_dRange = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_dRange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sel_project,
            this.crt_project,
            this.mdfy_project,
            this.rmv_project});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 24);
            this.toolStripMenuItem1.Text = "Prefrences";
            // 
            // sel_project
            // 
            this.sel_project.Name = "sel_project";
            this.sel_project.Size = new System.Drawing.Size(224, 26);
            this.sel_project.Text = "Select Project";
            this.sel_project.Click += new System.EventHandler(this.sel_project_Click);
            // 
            // crt_project
            // 
            this.crt_project.Name = "crt_project";
            this.crt_project.Size = new System.Drawing.Size(224, 26);
            this.crt_project.Text = "Create Project";
            this.crt_project.Click += new System.EventHandler(this.crt_project_Click);
            // 
            // mdfy_project
            // 
            this.mdfy_project.Name = "mdfy_project";
            this.mdfy_project.Size = new System.Drawing.Size(224, 26);
            this.mdfy_project.Text = "Modify Project";
            this.mdfy_project.Click += new System.EventHandler(this.mdfy_project_Click);
            // 
            // rmv_project
            // 
            this.rmv_project.Name = "rmv_project";
            this.rmv_project.Size = new System.Drawing.Size(224, 26);
            this.rmv_project.Text = "Remove Project";
            this.rmv_project.Click += new System.EventHandler(this.rmv_project_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsh_brd,
            this.Rcrd,
            this.Mdfy,
            this.Rmv,
            this.Rprt});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem2.Text = "Issue";
            // 
            // dsh_brd
            // 
            this.dsh_brd.Name = "dsh_brd";
            this.dsh_brd.Size = new System.Drawing.Size(165, 26);
            this.dsh_brd.Text = "Dashboard";
            // 
            // Rcrd
            // 
            this.Rcrd.Name = "Rcrd";
            this.Rcrd.Size = new System.Drawing.Size(165, 26);
            this.Rcrd.Text = "Record";
            // 
            // Mdfy
            // 
            this.Mdfy.Name = "Mdfy";
            this.Mdfy.Size = new System.Drawing.Size(165, 26);
            this.Mdfy.Text = "Modify";
            // 
            // Rmv
            // 
            this.Rmv.Name = "Rmv";
            this.Rmv.Size = new System.Drawing.Size(165, 26);
            this.Rmv.Text = "Remove";
            // 
            // Rprt
            // 
            this.Rprt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cb_Assign,
            this.lb_Assign,
            this.cb_Atrifact,
            this.lb_Artiface,
            this.cb_dRange,
            this.lb_dRange,
            this.tb_dRange});
            this.Rprt.Name = "Rprt";
            this.Rprt.Size = new System.Drawing.Size(165, 26);
            this.Rprt.Text = "Report";
            // 
            // cb_Assign
            // 
            this.cb_Assign.Name = "cb_Assign";
            this.cb_Assign.Size = new System.Drawing.Size(233, 26);
            this.cb_Assign.Text = "Count by Assignee";
            // 
            // lb_Assign
            // 
            this.lb_Assign.Name = "lb_Assign";
            this.lb_Assign.Size = new System.Drawing.Size(233, 26);
            this.lb_Assign.Text = "List by Assignee";
            // 
            // cb_Atrifact
            // 
            this.cb_Atrifact.Name = "cb_Atrifact";
            this.cb_Atrifact.Size = new System.Drawing.Size(233, 26);
            this.cb_Atrifact.Text = "Count by Artifact";
            // 
            // lb_Artiface
            // 
            this.lb_Artiface.Name = "lb_Artiface";
            this.lb_Artiface.Size = new System.Drawing.Size(233, 26);
            this.lb_Artiface.Text = "List by Artifact";
            // 
            // cb_dRange
            // 
            this.cb_dRange.Name = "cb_dRange";
            this.cb_dRange.Size = new System.Drawing.Size(233, 26);
            this.cb_dRange.Text = "Count by Date Range";
            // 
            // lb_dRange
            // 
            this.lb_dRange.Name = "lb_dRange";
            this.lb_dRange.Size = new System.Drawing.Size(233, 26);
            this.lb_dRange.Text = "List by Date Range";
            // 
            // tb_dRange
            // 
            this.tb_dRange.Name = "tb_dRange";
            this.tb_dRange.Size = new System.Drawing.Size(233, 26);
            this.tb_dRange.Text = "Trend by Date Range";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem3.Text = "Requirement";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(69, 24);
            this.toolStripMenuItem4.Text = "Design";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(49, 24);
            this.toolStripMenuItem5.Text = "Test";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem sel_project;
        private System.Windows.Forms.ToolStripMenuItem crt_project;
        private System.Windows.Forms.ToolStripMenuItem mdfy_project;
        private System.Windows.Forms.ToolStripMenuItem rmv_project;
        private System.Windows.Forms.ToolStripMenuItem dsh_brd;
        private System.Windows.Forms.ToolStripMenuItem Rcrd;
        private System.Windows.Forms.ToolStripMenuItem Mdfy;
        private System.Windows.Forms.ToolStripMenuItem Rmv;
        private System.Windows.Forms.ToolStripMenuItem Rprt;
        private System.Windows.Forms.ToolStripMenuItem cb_Assign;
        private System.Windows.Forms.ToolStripMenuItem lb_Assign;
        private System.Windows.Forms.ToolStripMenuItem cb_Atrifact;
        private System.Windows.Forms.ToolStripMenuItem lb_Artiface;
        private System.Windows.Forms.ToolStripMenuItem cb_dRange;
        private System.Windows.Forms.ToolStripMenuItem lb_dRange;
        private System.Windows.Forms.ToolStripMenuItem tb_dRange;
    }
}