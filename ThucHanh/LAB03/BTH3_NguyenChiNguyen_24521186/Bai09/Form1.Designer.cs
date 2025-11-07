namespace Bai09
{
    partial class frmStudentInfo
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
            this.grbInputGroupBox = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lsbSelectedSubject = new System.Windows.Forms.ListBox();
            this.lsbSubject = new System.Windows.Forms.ListBox();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.rabFemale = new System.Windows.Forms.RadioButton();
            this.rabMale = new System.Windows.Forms.RadioButton();
            this.cbbMajor = new System.Windows.Forms.ComboBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSsn = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSsn = new System.Windows.Forms.Label();
            this.dgvSudentInfo = new System.Windows.Forms.DataGridView();
            this.Mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfSubjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbInputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInputGroupBox
            // 
            this.grbInputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbInputGroupBox.Controls.Add(this.btnRemove);
            this.grbInputGroupBox.Controls.Add(this.btnSave);
            this.grbInputGroupBox.Controls.Add(this.lsbSelectedSubject);
            this.grbInputGroupBox.Controls.Add(this.lsbSubject);
            this.grbInputGroupBox.Controls.Add(this.btnUnselect);
            this.grbInputGroupBox.Controls.Add(this.btnSelect);
            this.grbInputGroupBox.Controls.Add(this.lblSelectSubject);
            this.grbInputGroupBox.Controls.Add(this.rabFemale);
            this.grbInputGroupBox.Controls.Add(this.rabMale);
            this.grbInputGroupBox.Controls.Add(this.cbbMajor);
            this.grbInputGroupBox.Controls.Add(this.txbName);
            this.grbInputGroupBox.Controls.Add(this.txbSsn);
            this.grbInputGroupBox.Controls.Add(this.lblGender);
            this.grbInputGroupBox.Controls.Add(this.lblMajor);
            this.grbInputGroupBox.Controls.Add(this.lblName);
            this.grbInputGroupBox.Controls.Add(this.lblSsn);
            this.grbInputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputGroupBox.Location = new System.Drawing.Point(28, 24);
            this.grbInputGroupBox.Name = "grbInputGroupBox";
            this.grbInputGroupBox.Size = new System.Drawing.Size(947, 415);
            this.grbInputGroupBox.TabIndex = 0;
            this.grbInputGroupBox.TabStop = false;
            this.grbInputGroupBox.Text = "Thông Tin Sinh Viên";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(484, 374);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(145, 31);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Xóa Chọn";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(312, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 31);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu Thông Tin";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lsbSelectedSubject
            // 
            this.lsbSelectedSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbSelectedSubject.FormattingEnabled = true;
            this.lsbSelectedSubject.ItemHeight = 18;
            this.lsbSelectedSubject.Location = new System.Drawing.Point(503, 198);
            this.lsbSelectedSubject.Name = "lsbSelectedSubject";
            this.lsbSelectedSubject.Size = new System.Drawing.Size(291, 166);
            this.lsbSelectedSubject.TabIndex = 16;
            // 
            // lsbSubject
            // 
            this.lsbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbSubject.FormattingEnabled = true;
            this.lsbSubject.ItemHeight = 18;
            this.lsbSubject.Items.AddRange(new object[] {
            "Cơ Sở Dữ Liệu",
            "Lập Trình Hướng Đối Tượng",
            "Cấu Trúc Dữ Liệu & Giải Thuật",
            "Nhập Môn Lập Trình",
            "Hệ Điều Hành",
            "Nhập Môn Công Nghệ Phần Mềm"});
            this.lsbSubject.Location = new System.Drawing.Point(147, 198);
            this.lsbSubject.Name = "lsbSubject";
            this.lsbSubject.Size = new System.Drawing.Size(291, 166);
            this.lsbSubject.TabIndex = 15;
            // 
            // btnUnselect
            // 
            this.btnUnselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUnselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnselect.Location = new System.Drawing.Point(444, 275);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(53, 38);
            this.btnUnselect.TabIndex = 14;
            this.btnUnselect.Text = "<";
            this.btnUnselect.UseVisualStyleBackColor = false;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(444, 229);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(53, 40);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubject.Location = new System.Drawing.Point(143, 169);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(239, 23);
            this.lblSelectSubject.TabIndex = 10;
            this.lblSelectSubject.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // rabFemale
            // 
            this.rabFemale.AutoSize = true;
            this.rabFemale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabFemale.Location = new System.Drawing.Point(391, 130);
            this.rabFemale.Name = "rabFemale";
            this.rabFemale.Size = new System.Drawing.Size(54, 27);
            this.rabFemale.TabIndex = 9;
            this.rabFemale.TabStop = true;
            this.rabFemale.Text = "Nữ";
            this.rabFemale.UseVisualStyleBackColor = true;
            // 
            // rabMale
            // 
            this.rabMale.AutoSize = true;
            this.rabMale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabMale.Location = new System.Drawing.Point(298, 130);
            this.rabMale.Name = "rabMale";
            this.rabMale.Size = new System.Drawing.Size(68, 27);
            this.rabMale.TabIndex = 8;
            this.rabMale.TabStop = true;
            this.rabMale.Text = "Nam";
            this.rabMale.UseVisualStyleBackColor = true;
            // 
            // cbbMajor
            // 
            this.cbbMajor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbMajor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajor.FormattingEnabled = true;
            this.cbbMajor.Items.AddRange(new object[] {
            "Kỹ Thuật Phần Mềm",
            "Truyền Thông Đa Phương Tiện",
            "Hệ Thống Thông Tin",
            "Thương Mai Điện Tử",
            "Khoa Học Dữ Liệu",
            "Khoa Học Máy Tính",
            "Mạng Máy Tính và Truyền Thông Dữ Liệu",
            "Kỹ Thuật Máy Tính",
            "Trí Tuệ Nhân Tạo",
            "Công Nghệ Thông Tin",
            "An Toàn Thông Tin",
            "Thiết Kế Vi Mạch"});
            this.cbbMajor.Location = new System.Drawing.Point(298, 95);
            this.cbbMajor.Name = "cbbMajor";
            this.cbbMajor.Size = new System.Drawing.Size(388, 28);
            this.cbbMajor.TabIndex = 7;
            // 
            // txbName
            // 
            this.txbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(298, 63);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(388, 27);
            this.txbName.TabIndex = 5;
            // 
            // txbSsn
            // 
            this.txbSsn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSsn.Location = new System.Drawing.Point(298, 31);
            this.txbSsn.Name = "txbSsn";
            this.txbSsn.Size = new System.Drawing.Size(259, 27);
            this.txbSsn.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(144, 130);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(78, 23);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Giới Tính";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.Location = new System.Drawing.Point(144, 98);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(125, 23);
            this.lblMajor.TabIndex = 2;
            this.lblMajor.Text = "Chuyên Ngành";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(144, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ Tên";
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSsn.Location = new System.Drawing.Point(144, 33);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(111, 23);
            this.lblSsn.TabIndex = 0;
            this.lblSsn.Text = "Mã Sinh Viên";
            // 
            // dgvSudentInfo
            // 
            this.dgvSudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSudentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mssv,
            this.StudentName,
            this.Major,
            this.Gender,
            this.NumberOfSubjects});
            this.dgvSudentInfo.Location = new System.Drawing.Point(25, 456);
            this.dgvSudentInfo.Name = "dgvSudentInfo";
            this.dgvSudentInfo.RowHeadersWidth = 51;
            this.dgvSudentInfo.RowTemplate.Height = 24;
            this.dgvSudentInfo.Size = new System.Drawing.Size(949, 315);
            this.dgvSudentInfo.TabIndex = 1;
            // 
            // Mssv
            // 
            this.Mssv.HeaderText = "MSSV";
            this.Mssv.MinimumWidth = 6;
            this.Mssv.Name = "Mssv";
            // 
            // StudentName
            // 
            this.StudentName.FillWeight = 150F;
            this.StudentName.HeaderText = "Họ Tên";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            // 
            // Major
            // 
            this.Major.FillWeight = 150F;
            this.Major.HeaderText = "Chuyên Ngành";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // NumberOfSubjects
            // 
            this.NumberOfSubjects.FillWeight = 50F;
            this.NumberOfSubjects.HeaderText = "Số Môn";
            this.NumberOfSubjects.MinimumWidth = 6;
            this.NumberOfSubjects.Name = "NumberOfSubjects";
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.dgvSudentInfo);
            this.Controls.Add(this.grbInputGroupBox);
            this.Name = "frmStudentInfo";
            this.Text = "Nhập Liệu Sinh Viên";
            this.grbInputGroupBox.ResumeLayout(false);
            this.grbInputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudentInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputGroupBox;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSsn;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSsn;
        private System.Windows.Forms.ComboBox cbbMajor;
        private System.Windows.Forms.RadioButton rabFemale;
        private System.Windows.Forms.RadioButton rabMale;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lsbSelectedSubject;
        private System.Windows.Forms.ListBox lsbSubject;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvSudentInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfSubjects;
    }
}

