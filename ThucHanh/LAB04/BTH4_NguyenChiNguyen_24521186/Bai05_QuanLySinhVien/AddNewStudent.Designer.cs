namespace Bai05_QuanLySinhVien
{
    partial class AddNewStudent
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
            this.lblMSSV = new System.Windows.Forms.Label();
            this.txbMSSV = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.txbAvg = new System.Windows.Forms.TextBox();
            this.lblAvg = new System.Windows.Forms.Label();
            this.cbbFaculty = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(163, 85);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(133, 20);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "Mã Số Sinh Viên";
            // 
            // txbMSSV
            // 
            this.txbMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMSSV.Location = new System.Drawing.Point(335, 82);
            this.txbMSSV.Name = "txbMSSV";
            this.txbMSSV.Size = new System.Drawing.Size(172, 27);
            this.txbMSSV.TabIndex = 1;
            // 
            // txbName
            // 
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(335, 134);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(303, 27);
            this.txbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(163, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên Sinh Viên";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaculty.Location = new System.Drawing.Point(163, 187);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(47, 20);
            this.lblFaculty.TabIndex = 4;
            this.lblFaculty.Text = "Khoa";
            // 
            // txbAvg
            // 
            this.txbAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAvg.Location = new System.Drawing.Point(335, 236);
            this.txbAvg.Name = "txbAvg";
            this.txbAvg.Size = new System.Drawing.Size(103, 27);
            this.txbAvg.TabIndex = 7;
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvg.Location = new System.Drawing.Point(163, 239);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(75, 20);
            this.lblAvg.TabIndex = 6;
            this.lblAvg.Text = "Điểm TB";
            // 
            // cbbFaculty
            // 
            this.cbbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFaculty.FormattingEnabled = true;
            this.cbbFaculty.Items.AddRange(new object[] {
            "Công nghệ Phần mềm",
            "Khoa học Máy tính",
            "Kỹ thuật Máy tính",
            "Khoa học & Kỹ thuật Thông tin",
            "Hệ thống Thông tin",
            "Mạng Máy tính & Truyền thông"});
            this.cbbFaculty.Location = new System.Drawing.Point(335, 187);
            this.cbbFaculty.Name = "cbbFaculty";
            this.cbbFaculty.Size = new System.Drawing.Size(303, 24);
            this.cbbFaculty.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(477, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(622, 336);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(104, 34);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbFaculty);
            this.Controls.Add(this.txbAvg);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbMSSV);
            this.Controls.Add(this.lblMSSV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "AddNewStudent";
            this.Text = "Thêm Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.TextBox txbMSSV;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.TextBox txbAvg;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.ComboBox cbbFaculty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuit;
    }
}