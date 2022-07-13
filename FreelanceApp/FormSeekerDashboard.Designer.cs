namespace FreelanceApp
{
    partial class FormSeekerDashboard
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
            this.dataGridViewListJob = new System.Windows.Forms.DataGridView();
            this.btViewSubmitedProposal = new System.Windows.Forms.Button();
            this.dtpCreateday = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtComplexity = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.dataGridViewListProposal = new System.Windows.Forms.DataGridView();
            this.dataGridViewReceivedJobList = new System.Windows.Forms.DataGridView();
            this.btViewReceivedJob = new System.Windows.Forms.Button();
            this.btViewListJob = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpExpedtedDay = new System.Windows.Forms.TextBox();
            this.txtSkillNeed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHirerID = new System.Windows.Forms.TextBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btViewProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProposal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceivedJobList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListJob
            // 
            this.dataGridViewListJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListJob.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewListJob.Name = "dataGridViewListJob";
            this.dataGridViewListJob.RowTemplate.Height = 25;
            this.dataGridViewListJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListJob.Size = new System.Drawing.Size(481, 289);
            this.dataGridViewListJob.TabIndex = 0;
            this.dataGridViewListJob.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListJob_CellClick);
            this.dataGridViewListJob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListJob_CellContentClick);
            // 
            // btViewSubmitedProposal
            // 
            this.btViewSubmitedProposal.Location = new System.Drawing.Point(567, 296);
            this.btViewSubmitedProposal.Name = "btViewSubmitedProposal";
            this.btViewSubmitedProposal.Size = new System.Drawing.Size(180, 23);
            this.btViewSubmitedProposal.TabIndex = 2;
            this.btViewSubmitedProposal.Text = "View submited proposal";
            this.btViewSubmitedProposal.UseVisualStyleBackColor = true;
            this.btViewSubmitedProposal.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpCreateday
            // 
            this.dtpCreateday.Location = new System.Drawing.Point(444, 138);
            this.dtpCreateday.Name = "dtpCreateday";
            this.dtpCreateday.Size = new System.Drawing.Size(200, 23);
            this.dtpCreateday.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "payment amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "major";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "complexity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "create date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "expected duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Project name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 62);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 23);
            this.txtDescription.TabIndex = 42;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(120, 96);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 23);
            this.txtLocation.TabIndex = 41;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(120, 135);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(100, 23);
            this.txtPaymentAmount.TabIndex = 40;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(444, 22);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 23);
            this.txtMajor.TabIndex = 38;
            // 
            // txtComplexity
            // 
            this.txtComplexity.Location = new System.Drawing.Point(444, 62);
            this.txtComplexity.Name = "txtComplexity";
            this.txtComplexity.Size = new System.Drawing.Size(100, 23);
            this.txtComplexity.TabIndex = 37;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(120, 22);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 23);
            this.txtProjectName.TabIndex = 36;
            // 
            // dataGridViewListProposal
            // 
            this.dataGridViewListProposal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListProposal.Location = new System.Drawing.Point(23, 230);
            this.dataGridViewListProposal.Name = "dataGridViewListProposal";
            this.dataGridViewListProposal.RowTemplate.Height = 25;
            this.dataGridViewListProposal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListProposal.Size = new System.Drawing.Size(481, 289);
            this.dataGridViewListProposal.TabIndex = 52;
            this.dataGridViewListProposal.Visible = false;
            this.dataGridViewListProposal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListProposal_CellContentClick);
            // 
            // dataGridViewReceivedJobList
            // 
            this.dataGridViewReceivedJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceivedJobList.Location = new System.Drawing.Point(38, 230);
            this.dataGridViewReceivedJobList.Name = "dataGridViewReceivedJobList";
            this.dataGridViewReceivedJobList.RowTemplate.Height = 25;
            this.dataGridViewReceivedJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReceivedJobList.Size = new System.Drawing.Size(481, 289);
            this.dataGridViewReceivedJobList.TabIndex = 54;
            this.dataGridViewReceivedJobList.Visible = false;
            // 
            // btViewReceivedJob
            // 
            this.btViewReceivedJob.Location = new System.Drawing.Point(567, 357);
            this.btViewReceivedJob.Name = "btViewReceivedJob";
            this.btViewReceivedJob.Size = new System.Drawing.Size(180, 23);
            this.btViewReceivedJob.TabIndex = 53;
            this.btViewReceivedJob.Text = "View  received job";
            this.btViewReceivedJob.UseVisualStyleBackColor = true;
            this.btViewReceivedJob.Click += new System.EventHandler(this.btViewReceivedJob_Click);
            // 
            // btViewListJob
            // 
            this.btViewListJob.Location = new System.Drawing.Point(567, 230);
            this.btViewListJob.Name = "btViewListJob";
            this.btViewListJob.Size = new System.Drawing.Size(180, 23);
            this.btViewListJob.TabIndex = 2;
            this.btViewListJob.Text = "View List Job";
            this.btViewListJob.UseVisualStyleBackColor = true;
            this.btViewListJob.Click += new System.EventHandler(this.btViewListJob_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpExpedtedDay);
            this.groupBox1.Controls.Add(this.txtSkillNeed);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtHirerID);
            this.groupBox1.Controls.Add(this.txtProjectID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtProjectName);
            this.groupBox1.Controls.Add(this.txtComplexity);
            this.groupBox1.Controls.Add(this.txtMajor);
            this.groupBox1.Controls.Add(this.txtPaymentAmount);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.dtpCreateday);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 212);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job detail";
            // 
            // dtpExpedtedDay
            // 
            this.dtpExpedtedDay.Location = new System.Drawing.Point(444, 99);
            this.dtpExpedtedDay.Name = "dtpExpedtedDay";
            this.dtpExpedtedDay.Size = new System.Drawing.Size(100, 23);
            this.dtpExpedtedDay.TabIndex = 62;
            // 
            // txtSkillNeed
            // 
            this.txtSkillNeed.Location = new System.Drawing.Point(120, 175);
            this.txtSkillNeed.Name = "txtSkillNeed";
            this.txtSkillNeed.Size = new System.Drawing.Size(524, 23);
            this.txtSkillNeed.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 60;
            this.label11.Text = "Skill need";
            // 
            // txtHirerID
            // 
            this.txtHirerID.Location = new System.Drawing.Point(671, 54);
            this.txtHirerID.Name = "txtHirerID";
            this.txtHirerID.Size = new System.Drawing.Size(64, 23);
            this.txtHirerID.TabIndex = 59;
            this.txtHirerID.Visible = false;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(671, 21);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(64, 23);
            this.txtProjectID.TabIndex = 58;
            this.txtProjectID.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(612, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 57;
            this.label10.Text = "hirerid";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "projectid";
            this.label9.Visible = false;
            // 
            // btViewProfile
            // 
            this.btViewProfile.Location = new System.Drawing.Point(567, 421);
            this.btViewProfile.Name = "btViewProfile";
            this.btViewProfile.Size = new System.Drawing.Size(180, 23);
            this.btViewProfile.TabIndex = 57;
            this.btViewProfile.Text = "ViewProfile";
            this.btViewProfile.UseVisualStyleBackColor = true;
            this.btViewProfile.Click += new System.EventHandler(this.btViewProfile_Click);
            // 
            // FormSeekerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btViewProfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewReceivedJobList);
            this.Controls.Add(this.btViewReceivedJob);
            this.Controls.Add(this.dataGridViewListProposal);
            this.Controls.Add(this.btViewListJob);
            this.Controls.Add(this.btViewSubmitedProposal);
            this.Controls.Add(this.dataGridViewListJob);
            this.Name = "FormSeekerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeekerDashboard";
            this.Load += new System.EventHandler(this.FormSeekerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProposal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceivedJobList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListJob;
        private System.Windows.Forms.Button btViewSubmitedProposal;
        private System.Windows.Forms.DateTimePicker dtpCreateday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtComplexity;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.DataGridView dataGridViewListProposal;
        private System.Windows.Forms.DataGridView dataGridViewReceivedJobList;
        private System.Windows.Forms.Button btViewReceivedJob;
        private System.Windows.Forms.Button btViewListJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHirerID;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSkillNeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btViewProfile;
        private System.Windows.Forms.TextBox dtpExpedtedDay;
    }
}