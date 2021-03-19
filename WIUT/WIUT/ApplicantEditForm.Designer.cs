namespace WIUT
{
    partial class ApplicantEditForm
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
            this.components = new System.ComponentModel.Container();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.dtmDoB = new System.Windows.Forms.DateTimePicker();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPassport = new System.Windows.Forms.TextBox();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxMaritalStatus = new System.Windows.Forms.TextBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(126, 42);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(185, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(126, 68);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(185, 20);
            this.tbxSurname.TabIndex = 1;
            // 
            // dtmDoB
            // 
            this.dtmDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDoB.Location = new System.Drawing.Point(126, 120);
            this.dtmDoB.Name = "dtmDoB";
            this.dtmDoB.Size = new System.Drawing.Size(185, 20);
            this.dtmDoB.TabIndex = 3;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(126, 94);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(185, 20);
            this.tbxAddress.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marital Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Passport №";
            // 
            // tbxPassport
            // 
            this.tbxPassport.Location = new System.Drawing.Point(126, 179);
            this.tbxPassport.Name = "tbxPassport";
            this.tbxPassport.Size = new System.Drawing.Size(185, 20);
            this.tbxPassport.TabIndex = 5;
            // 
            // cbxCourse
            // 
            this.cbxCourse.DataSource = this.courseBindingSource1;
            this.cbxCourse.DisplayMember = "Name";
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(126, 206);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(185, 21);
            this.cbxCourse.TabIndex = 6;
            this.cbxCourse.ValueMember = "Id";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(WIUT.DAL.Course);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(44, 206);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "Course";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxMaritalStatus
            // 
            this.tbxMaritalStatus.Location = new System.Drawing.Point(126, 151);
            this.tbxMaritalStatus.Name = "tbxMaritalStatus";
            this.tbxMaritalStatus.Size = new System.Drawing.Size(185, 20);
            this.tbxMaritalStatus.TabIndex = 4;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataSource = typeof(WIUT.DAL.Course);
            // 
            // ApplicantEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(342, 334);
            this.Controls.Add(this.tbxMaritalStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.cbxCourse);
            this.Controls.Add(this.tbxPassport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.dtmDoB);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxName);
            this.Name = "ApplicantEditForm";
            this.Text = "Applicant";
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.DateTimePicker dtmDoB;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPassport;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.TextBox tbxMaritalStatus;
        private System.Windows.Forms.BindingSource courseBindingSource1;
    }
}