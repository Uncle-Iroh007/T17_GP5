namespace P5
{
    partial class Create_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancelAdd = new System.Windows.Forms.Button();
            this.addPrj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 1;
            // 
            // cancelAdd
            // 
            this.cancelAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.cancelAdd.Location = new System.Drawing.Point(274, 115);
            this.cancelAdd.Name = "cancelAdd";
            this.cancelAdd.Size = new System.Drawing.Size(90, 30);
            this.cancelAdd.TabIndex = 2;
            this.cancelAdd.Text = "Cancel";
            this.cancelAdd.UseVisualStyleBackColor = true;
            this.cancelAdd.Click += new System.EventHandler(this.cancelAdd_Click);
            // 
            // addPrj
            // 
            this.addPrj.Location = new System.Drawing.Point(385, 115);
            this.addPrj.Name = "addPrj";
            this.addPrj.Size = new System.Drawing.Size(90, 30);
            this.addPrj.TabIndex = 3;
            this.addPrj.Text = "Add";
            this.addPrj.UseVisualStyleBackColor = true;
            this.addPrj.Click += new System.EventHandler(this.addPrj_Click);
            // 
            // Create_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 189);
            this.Controls.Add(this.addPrj);
            this.Controls.Add(this.cancelAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Create_Project";
            this.Text = "Create_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancelAdd;
        private System.Windows.Forms.Button addPrj;
    }
}