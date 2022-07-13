namespace FreelanceApp
{
    partial class FormApplyJob
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
            this.label2 = new System.Windows.Forms.Label();
            this.btApplying = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment amount";
            // 
            // btApplying
            // 
            this.btApplying.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btApplying.Location = new System.Drawing.Point(168, 168);
            this.btApplying.Name = "btApplying";
            this.btApplying.Size = new System.Drawing.Size(75, 23);
            this.btApplying.TabIndex = 2;
            this.btApplying.Text = "Applying";
            this.btApplying.UseVisualStyleBackColor = true;
            this.btApplying.Click += new System.EventHandler(this.btApplying_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(360, 167);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(194, 67);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(241, 23);
            this.txtMessage.TabIndex = 4;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(194, 116);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(100, 23);
            this.txtPaymentAmount.TabIndex = 5;
            // 
            // FormApplyJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 288);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btApplying);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormApplyJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply job";
            this.Load += new System.EventHandler(this.FormApplyJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btApplying;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtPaymentAmount;
    }
}