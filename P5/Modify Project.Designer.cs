﻿namespace P5
{
    partial class Modify_Project
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
            this.modPName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cnclMod = new System.Windows.Forms.Button();
            this.mdfy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modPName
            // 
            this.modPName.AutoSize = true;
            this.modPName.Location = new System.Drawing.Point(104, 112);
            this.modPName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.modPName.Name = "modPName";
            this.modPName.Size = new System.Drawing.Size(201, 32);
            this.modPName.TabIndex = 0;
            this.modPName.Text = "Project Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(720, 38);
            this.textBox1.TabIndex = 1;
            // 
            // cnclMod
            // 
            this.cnclMod.Location = new System.Drawing.Point(664, 227);
            this.cnclMod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cnclMod.Name = "cnclMod";
            this.cnclMod.Size = new System.Drawing.Size(172, 60);
            this.cnclMod.TabIndex = 2;
            this.cnclMod.Text = "Cancel";
            this.cnclMod.UseVisualStyleBackColor = true;
            this.cnclMod.Click += new System.EventHandler(this.cnclMod_Click);
            // 
            // mdfy
            // 
            this.mdfy.Location = new System.Drawing.Point(896, 227);
            this.mdfy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mdfy.Name = "mdfy";
            this.mdfy.Size = new System.Drawing.Size(172, 60);
            this.mdfy.TabIndex = 3;
            this.mdfy.Text = "Modify";
            this.mdfy.UseVisualStyleBackColor = true;
            this.mdfy.Click += new System.EventHandler(this.mdfy_Click);
            // 
            // Modify_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 417);
            this.Controls.Add(this.mdfy);
            this.Controls.Add(this.cnclMod);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.modPName);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Modify_Project";
            this.Text = "Modify Project";
            this.Load += new System.EventHandler(this.Modify_Project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modPName;
        private System.Windows.Forms.Button cnclMod;
        private System.Windows.Forms.Button mdfy;
        public System.Windows.Forms.TextBox textBox1;
    }
}