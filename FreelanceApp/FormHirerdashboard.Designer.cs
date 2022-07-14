namespace FreelanceApp
{
    partial class FormHirerdashboard
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
            this.dataGridViewListPostedJob = new System.Windows.Forms.DataGridView();
            this.buttonPostAJob = new System.Windows.Forms.Button();
            this.dataGridViewAcceptedJob = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonViewPostedJob = new System.Windows.Forms.Button();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.textBoxProjectId = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxPaymentAmount = new System.Windows.Forms.TextBox();
            this.textBoxMajor = new System.Windows.Forms.TextBox();
            this.textBoxComplexity = new System.Windows.Forms.TextBox();
            this.textBoxExpectedDuration = new System.Windows.Forms.TextBox();
            this.dateTimePickerCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPostedJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcceptedJob)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListPostedJob
            // 
            this.dataGridViewListPostedJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPostedJob.Location = new System.Drawing.Point(22, 143);
            this.dataGridViewListPostedJob.Name = "dataGridViewListPostedJob";
            this.dataGridViewListPostedJob.ReadOnly = true;
            this.dataGridViewListPostedJob.RowTemplate.Height = 25;
            this.dataGridViewListPostedJob.Size = new System.Drawing.Size(575, 368);
            this.dataGridViewListPostedJob.TabIndex = 1;
            this.dataGridViewListPostedJob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListPostedJob_CellContentClick);
            this.dataGridViewListPostedJob.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListPostedJob_CellDoubleClick);
            // 
            // buttonPostAJob
            // 
            this.buttonPostAJob.Location = new System.Drawing.Point(967, 30);
            this.buttonPostAJob.Name = "buttonPostAJob";
            this.buttonPostAJob.Size = new System.Drawing.Size(75, 23);
            this.buttonPostAJob.TabIndex = 2;
            this.buttonPostAJob.Text = "Post A Job";
            this.buttonPostAJob.UseVisualStyleBackColor = true;
            this.buttonPostAJob.Click += new System.EventHandler(this.buttonPostAJob_Click);
            // 
            // dataGridViewAcceptedJob
            // 
            this.dataGridViewAcceptedJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcceptedJob.Location = new System.Drawing.Point(58, 168);
            this.dataGridViewAcceptedJob.Name = "dataGridViewAcceptedJob";
            this.dataGridViewAcceptedJob.ReadOnly = true;
            this.dataGridViewAcceptedJob.RowTemplate.Height = 25;
            this.dataGridViewAcceptedJob.Size = new System.Drawing.Size(575, 368);
            this.dataGridViewAcceptedJob.TabIndex = 1;
            this.dataGridViewAcceptedJob.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAcceptedJob_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(883, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Accepted Job";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonViewPostedJob
            // 
            this.buttonViewPostedJob.Location = new System.Drawing.Point(883, 113);
            this.buttonViewPostedJob.Name = "buttonViewPostedJob";
            this.buttonViewPostedJob.Size = new System.Drawing.Size(159, 23);
            this.buttonViewPostedJob.TabIndex = 2;
            this.buttonViewPostedJob.Text = "View Posted Job";
            this.buttonViewPostedJob.UseVisualStyleBackColor = true;
            this.buttonViewPostedJob.Click += new System.EventHandler(this.buttonViewPostedJob_Click);
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(187, 26);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.ReadOnly = true;
            this.textBoxProjectName.Size = new System.Drawing.Size(100, 23);
            this.textBoxProjectName.TabIndex = 3;
            // 
            // textBoxProjectId
            // 
            this.textBoxProjectId.Location = new System.Drawing.Point(44, 27);
            this.textBoxProjectId.Name = "textBoxProjectId";
            this.textBoxProjectId.ReadOnly = true;
            this.textBoxProjectId.Size = new System.Drawing.Size(100, 23);
            this.textBoxProjectId.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(337, 27);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(100, 23);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(477, 28);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(100, 23);
            this.textBoxLocation.TabIndex = 6;
            // 
            // textBoxPaymentAmount
            // 
            this.textBoxPaymentAmount.Location = new System.Drawing.Point(44, 72);
            this.textBoxPaymentAmount.Name = "textBoxPaymentAmount";
            this.textBoxPaymentAmount.ReadOnly = true;
            this.textBoxPaymentAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxPaymentAmount.TabIndex = 7;
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.Location = new System.Drawing.Point(187, 72);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.ReadOnly = true;
            this.textBoxMajor.Size = new System.Drawing.Size(100, 23);
            this.textBoxMajor.TabIndex = 8;
            // 
            // textBoxComplexity
            // 
            this.textBoxComplexity.Location = new System.Drawing.Point(337, 72);
            this.textBoxComplexity.Name = "textBoxComplexity";
            this.textBoxComplexity.ReadOnly = true;
            this.textBoxComplexity.Size = new System.Drawing.Size(100, 23);
            this.textBoxComplexity.TabIndex = 9;
            // 
            // textBoxExpectedDuration
            // 
            this.textBoxExpectedDuration.Location = new System.Drawing.Point(477, 72);
            this.textBoxExpectedDuration.Name = "textBoxExpectedDuration";
            this.textBoxExpectedDuration.ReadOnly = true;
            this.textBoxExpectedDuration.Size = new System.Drawing.Size(100, 23);
            this.textBoxExpectedDuration.TabIndex = 10;
            // 
            // dateTimePickerCreatedDate
            // 
            this.dateTimePickerCreatedDate.Location = new System.Drawing.Point(619, 28);
            this.dateTimePickerCreatedDate.Name = "dateTimePickerCreatedDate";
            this.dateTimePickerCreatedDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerCreatedDate.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "ProjectId";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "ProjectName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "created date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "expected duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "complexity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "major";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "PaymentAmount";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(924, 354);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormHirerdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 620);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerCreatedDate);
            this.Controls.Add(this.textBoxExpectedDuration);
            this.Controls.Add(this.textBoxComplexity);
            this.Controls.Add(this.textBoxMajor);
            this.Controls.Add(this.textBoxPaymentAmount);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxProjectId);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.buttonViewPostedJob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPostAJob);
            this.Controls.Add(this.dataGridViewAcceptedJob);
            this.Controls.Add(this.dataGridViewListPostedJob);
            this.Name = "FormHirerdashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHirerdashboard";
            this.Load += new System.EventHandler(this.FormHirerdashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPostedJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcceptedJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewListPostedJob;
        private System.Windows.Forms.Button buttonPostAJob;
        private System.Windows.Forms.DataGridView dataGridViewAcceptedJob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonViewPostedJob;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.TextBox textBoxProjectId;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxPaymentAmount;
        private System.Windows.Forms.TextBox textBoxMajor;
        private System.Windows.Forms.TextBox textBoxComplexity;
        private System.Windows.Forms.TextBox textBoxExpectedDuration;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreatedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDelete;
    }
}