namespace FreelanceApp
{
    partial class FormDirection
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
            this.buttonCreateHirer = new System.Windows.Forms.Button();
            this.buttonCreateSeeker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateHirer
            // 
            this.buttonCreateHirer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateHirer.Location = new System.Drawing.Point(115, 184);
            this.buttonCreateHirer.Name = "buttonCreateHirer";
            this.buttonCreateHirer.Size = new System.Drawing.Size(173, 91);
            this.buttonCreateHirer.TabIndex = 0;
            this.buttonCreateHirer.Text = "Hier";
            this.buttonCreateHirer.UseVisualStyleBackColor = true;
            this.buttonCreateHirer.Click += new System.EventHandler(this.buttonCreateHirer_Click);
            // 
            // buttonCreateSeeker
            // 
            this.buttonCreateSeeker.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateSeeker.Location = new System.Drawing.Point(472, 186);
            this.buttonCreateSeeker.Name = "buttonCreateSeeker";
            this.buttonCreateSeeker.Size = new System.Drawing.Size(173, 89);
            this.buttonCreateSeeker.TabIndex = 1;
            this.buttonCreateSeeker.Text = "Seeker";
            this.buttonCreateSeeker.UseVisualStyleBackColor = true;
            this.buttonCreateSeeker.Click += new System.EventHandler(this.buttonCreateSeeker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose roles you want to create:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateSeeker);
            this.Controls.Add(this.buttonCreateHirer);
            this.Name = "FormDirection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDirection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateHirer;
        private System.Windows.Forms.Button buttonCreateSeeker;
        private System.Windows.Forms.Label label1;
    }
}