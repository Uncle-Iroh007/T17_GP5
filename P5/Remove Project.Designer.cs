namespace P5
{
    partial class Remove_Project
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
            this.rmv = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cnclRmv = new System.Windows.Forms.Button();
            this.rmvPrj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rmv
            // 
            this.rmv.AutoSize = true;
            this.rmv.Location = new System.Drawing.Point(64, 49);
            this.rmv.Name = "rmv";
            this.rmv.Size = new System.Drawing.Size(101, 17);
            this.rmv.TabIndex = 0;
            this.rmv.Text = "Project Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 22);
            this.textBox1.TabIndex = 1;
            // 
            // cnclRmv
            // 
            this.cnclRmv.Location = new System.Drawing.Point(331, 94);
            this.cnclRmv.Name = "cnclRmv";
            this.cnclRmv.Size = new System.Drawing.Size(121, 33);
            this.cnclRmv.TabIndex = 2;
            this.cnclRmv.Text = "Cancel";
            this.cnclRmv.UseVisualStyleBackColor = true;
            this.cnclRmv.Click += new System.EventHandler(this.cnclRmv_Click);
            // 
            // rmvPrj
            // 
            this.rmvPrj.Location = new System.Drawing.Point(474, 94);
            this.rmvPrj.Name = "rmvPrj";
            this.rmvPrj.Size = new System.Drawing.Size(121, 33);
            this.rmvPrj.TabIndex = 3;
            this.rmvPrj.Text = "Remove Project";
            this.rmvPrj.UseVisualStyleBackColor = true;
            this.rmvPrj.Click += new System.EventHandler(this.rmvPrj_Click);
            // 
            // Remove_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 185);
            this.Controls.Add(this.rmvPrj);
            this.Controls.Add(this.cnclRmv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rmv);
            this.Name = "Remove_Project";
            this.Text = "Remove_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rmv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cnclRmv;
        private System.Windows.Forms.Button rmvPrj;
    }
}