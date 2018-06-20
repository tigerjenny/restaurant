namespace Restaurant
{
    partial class EmployeeInformationForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBox_Work = new System.Windows.Forms.ComboBox();
            this.cboBox_Name = new System.Windows.Forms.ComboBox();
            this.cboBox_Location = new System.Windows.Forms.ComboBox();
            this.tb_Account = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "職稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(184, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(184, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "密碼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(184, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "薪水";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(13, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "分店";
            // 
            // cboBox_Work
            // 
            this.cboBox_Work.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBox_Work.FormattingEnabled = true;
            this.cboBox_Work.Location = new System.Drawing.Point(16, 32);
            this.cboBox_Work.Name = "cboBox_Work";
            this.cboBox_Work.Size = new System.Drawing.Size(121, 20);
            this.cboBox_Work.TabIndex = 7;
            this.cboBox_Work.SelectedIndexChanged += new System.EventHandler(this.cboBox_Work_SelectedIndexChanged);
            // 
            // cboBox_Name
            // 
            this.cboBox_Name.FormattingEnabled = true;
            this.cboBox_Name.Location = new System.Drawing.Point(16, 83);
            this.cboBox_Name.Name = "cboBox_Name";
            this.cboBox_Name.Size = new System.Drawing.Size(121, 20);
            this.cboBox_Name.TabIndex = 8;
            this.cboBox_Name.SelectedIndexChanged += new System.EventHandler(this.cboBox_Name_SelectedIndexChanged);
            // 
            // cboBox_Location
            // 
            this.cboBox_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBox_Location.FormattingEnabled = true;
            this.cboBox_Location.Location = new System.Drawing.Point(16, 140);
            this.cboBox_Location.Name = "cboBox_Location";
            this.cboBox_Location.Size = new System.Drawing.Size(121, 20);
            this.cboBox_Location.TabIndex = 9;
            // 
            // tb_Account
            // 
            this.tb_Account.Location = new System.Drawing.Point(187, 33);
            this.tb_Account.Name = "tb_Account";
            this.tb_Account.Size = new System.Drawing.Size(150, 22);
            this.tb_Account.TabIndex = 11;
            this.tb_Account.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_Keypress);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(187, 84);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(150, 22);
            this.tb_Password.TabIndex = 12;
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_Keypress);
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(187, 138);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(150, 22);
            this.tb_salary.TabIndex = 13;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Insert.Location = new System.Drawing.Point(417, 33);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 14;
            this.btn_Insert.Text = "新增";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Update.Location = new System.Drawing.Point(417, 80);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 22);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Delete.Location = new System.Drawing.Point(417, 135);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 22);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 179);
            this.dataGridView1.TabIndex = 17;
            // 
            // EmployeeInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Account);
            this.Controls.Add(this.cboBox_Location);
            this.Controls.Add(this.cboBox_Name);
            this.Controls.Add(this.cboBox_Work);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeInformationForm";
            this.Text = "EmployeeInformationForm";
            this.Load += new System.EventHandler(this.EmployeeInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboBox_Work;
        private System.Windows.Forms.ComboBox cboBox_Name;
        private System.Windows.Forms.ComboBox cboBox_Location;
        private System.Windows.Forms.TextBox tb_Account;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}