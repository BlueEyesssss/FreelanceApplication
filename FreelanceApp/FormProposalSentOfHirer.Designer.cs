namespace FreelanceApp
{
    partial class FormProposalSentOfHirer
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
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.txtProposalId = new System.Windows.Forms.TextBox();
            this.txtSeekerId = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.ProposalId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReject
            // 
            this.buttonReject.Location = new System.Drawing.Point(499, 308);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(75, 23);
            this.buttonReject.TabIndex = 31;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Location = new System.Drawing.Point(268, 308);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 30;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // txtProposalId
            // 
            this.txtProposalId.Location = new System.Drawing.Point(225, 89);
            this.txtProposalId.Name = "txtProposalId";
            this.txtProposalId.Size = new System.Drawing.Size(179, 23);
            this.txtProposalId.TabIndex = 29;
            // 
            // txtSeekerId
            // 
            this.txtSeekerId.Location = new System.Drawing.Point(499, 176);
            this.txtSeekerId.Name = "txtSeekerId";
            this.txtSeekerId.Size = new System.Drawing.Size(179, 23);
            this.txtSeekerId.TabIndex = 28;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(499, 132);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Size = new System.Drawing.Size(179, 23);
            this.txtCreatedDate.TabIndex = 27;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(499, 92);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(179, 23);
            this.txtStatus.TabIndex = 26;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(225, 219);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(141, 23);
            this.txtMessage.TabIndex = 25;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(225, 172);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(141, 23);
            this.txtPaymentAmount.TabIndex = 24;
            // 
            // txtProjectId
            // 
            this.txtProjectId.Location = new System.Drawing.Point(225, 129);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(141, 23);
            this.txtProjectId.TabIndex = 23;
            // 
            // ProposalId
            // 
            this.ProposalId.AutoSize = true;
            this.ProposalId.Location = new System.Drawing.Point(156, 92);
            this.ProposalId.Name = "ProposalId";
            this.ProposalId.Size = new System.Drawing.Size(63, 15);
            this.ProposalId.TabIndex = 22;
            this.ProposalId.Text = "ProposalId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "SeekerId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "CreatedDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "PaymentAmount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "ProjectId";
            // 
            // FormProposalSentOfHirer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.txtProposalId);
            this.Controls.Add(this.txtSeekerId);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.txtProjectId);
            this.Controls.Add(this.ProposalId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProposalSentOfHirer";
            this.Text = "FormProposalSentOfHirer";
            this.Load += new System.EventHandler(this.FormProposalSentOfHirer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox txtProposalId;
        private System.Windows.Forms.TextBox txtSeekerId;
        private System.Windows.Forms.TextBox txtCreatedDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.Label ProposalId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}