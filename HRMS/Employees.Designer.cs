
namespace HRMS
{
    partial class Employees
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.joinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.DOBdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbQualification = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EmployeeDVG = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.btnImgUploader = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.hRMSDataSet = new HRMS.HRMSDataSet();
            this.loginfrmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginfrmTableAdapter = new HRMS.HRMSDataSetTableAdapters.loginfrmTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picEmp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginfrmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(256, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEES INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "GENDER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "DOB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(9, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "PHONE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(9, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "ADDRESS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(9, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "POSITION:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(8, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "JOIN DATE:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(162, 184);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(197, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(162, 266);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(197, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // joinDateTimePicker
            // 
            this.joinDateTimePicker.Location = new System.Drawing.Point(162, 349);
            this.joinDateTimePicker.Name = "joinDateTimePicker";
            this.joinDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.joinDateTimePicker.TabIndex = 4;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Director",
            "CEO",
            "Senior Manager",
            "Maneger",
            "Deputy Manager",
            "Assistant Manager",
            "Senior Executive",
            "Executive Officer",
            "Officer",
            "Delivary Man",
            "Office Peon",
            "Messenger"});
            this.cmbPosition.Location = new System.Drawing.Point(162, 307);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(197, 21);
            this.cmbPosition.TabIndex = 5;
            // 
            // DOBdateTimePicker
            // 
            this.DOBdateTimePicker.Location = new System.Drawing.Point(162, 140);
            this.DOBdateTimePicker.Name = "DOBdateTimePicker";
            this.DOBdateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.DOBdateTimePicker.TabIndex = 4;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(162, 95);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(197, 21);
            this.cmbGender.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(9, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "QUALIFICATION:";
            // 
            // cmbQualification
            // 
            this.cmbQualification.FormattingEnabled = true;
            this.cmbQualification.Items.AddRange(new object[] {
            "BSC",
            "MBA",
            "HONOURS(BA)",
            "PASS COURSE",
            "BBA",
            "MASTERS",
            "HSC",
            "SSC"});
            this.cmbQualification.Location = new System.Drawing.Point(162, 392);
            this.cmbQualification.Name = "cmbQualification";
            this.cmbQualification.Size = new System.Drawing.Size(197, 21);
            this.cmbQualification.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(9, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "IMAGE PATH:";
            // 
            // EmployeeDVG
            // 
            this.EmployeeDVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDVG.Location = new System.Drawing.Point(379, 54);
            this.EmployeeDVG.Name = "EmployeeDVG";
            this.EmployeeDVG.Size = new System.Drawing.Size(868, 418);
            this.EmployeeDVG.TabIndex = 7;
            
            this.EmployeeDVG.SelectionChanged += new System.EventHandler(this.EmployeeDVG_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSave.Location = new System.Drawing.Point(394, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEdit.Location = new System.Drawing.Point(529, 498);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 33);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(663, 498);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBack.Location = new System.Drawing.Point(787, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(7, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "BASIC SALARY:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(162, 227);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(197, 20);
            this.txtSalary.TabIndex = 3;
            // 
            // txtImgPath
            // 
            this.txtImgPath.Location = new System.Drawing.Point(13, 495);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.Size = new System.Drawing.Size(197, 20);
            this.txtImgPath.TabIndex = 3;
            // 
            // btnImgUploader
            // 
            this.btnImgUploader.BackColor = System.Drawing.Color.SpringGreen;
            this.btnImgUploader.Location = new System.Drawing.Point(162, 449);
            this.btnImgUploader.Name = "btnImgUploader";
            this.btnImgUploader.Size = new System.Drawing.Size(75, 23);
            this.btnImgUploader.TabIndex = 11;
            this.btnImgUploader.Text = "...";
            this.btnImgUploader.UseVisualStyleBackColor = false;
            this.btnImgUploader.Click += new System.EventHandler(this.btnImgUploader_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // hRMSDataSet
            // 
            this.hRMSDataSet.DataSetName = "HRMSDataSet";
            this.hRMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginfrmBindingSource
            // 
            this.loginfrmBindingSource.DataMember = "loginfrm";
            this.loginfrmBindingSource.DataSource = this.hRMSDataSet;
            // 
            // loginfrmTableAdapter
            // 
            this.loginfrmTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRMS.Properties.Resources.download2;
            this.pictureBox1.Location = new System.Drawing.Point(1211, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // picEmp
            // 
            this.picEmp.BackColor = System.Drawing.Color.Honeydew;
            this.picEmp.Location = new System.Drawing.Point(249, 422);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(100, 98);
            this.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmp.TabIndex = 6;
            this.picEmp.TabStop = false;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1259, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnImgUploader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.EmployeeDVG);
            this.Controls.Add(this.picEmp);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbQualification);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.DOBdateTimePicker);
            this.Controls.Add(this.joinDateTimePicker);
            this.Controls.Add(this.txtImgPath);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginfrmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker joinDateTimePicker;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.DateTimePicker DOBdateTimePicker;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbQualification;
        private System.Windows.Forms.PictureBox picEmp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView EmployeeDVG;
        private HRMSDataSet hRMSDataSet;
        private System.Windows.Forms.BindingSource loginfrmBindingSource;
        private HRMSDataSetTableAdapters.loginfrmTableAdapter loginfrmTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.Button btnImgUploader;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}