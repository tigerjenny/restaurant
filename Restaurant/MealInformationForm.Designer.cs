namespace Restaurant
{
    partial class MealInformationForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.cboBox_Kind = new System.Windows.Forms.ComboBox();
            this.cboBox_MealName = new System.Windows.Forms.ComboBox();
            this.tb_sale = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "種類";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(149, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(282, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "售價";
            // 
            // cboBox_Kind
            // 
            this.cboBox_Kind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBox_Kind.FormattingEnabled = true;
            this.cboBox_Kind.Location = new System.Drawing.Point(12, 52);
            this.cboBox_Kind.Name = "cboBox_Kind";
            this.cboBox_Kind.Size = new System.Drawing.Size(121, 20);
            this.cboBox_Kind.TabIndex = 4;
            this.cboBox_Kind.SelectedIndexChanged += new System.EventHandler(this.cboBox_Kind_SelectedIndexChanged);
            // 
            // cboBox_MealName
            // 
            this.cboBox_MealName.FormattingEnabled = true;
            this.cboBox_MealName.Location = new System.Drawing.Point(152, 52);
            this.cboBox_MealName.Name = "cboBox_MealName";
            this.cboBox_MealName.Size = new System.Drawing.Size(121, 20);
            this.cboBox_MealName.TabIndex = 5;
            this.cboBox_MealName.SelectedIndexChanged += new System.EventHandler(this.cboBox_MealName_SelectedIndexChanged);
            // 
            // tb_sale
            // 
            this.tb_sale.Location = new System.Drawing.Point(285, 52);
            this.tb_sale.Name = "tb_sale";
            this.tb_sale.Size = new System.Drawing.Size(100, 22);
            this.tb_sale.TabIndex = 7;
            this.tb_sale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_Keypress);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Insert.Location = new System.Drawing.Point(407, 45);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "新增";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Update.Location = new System.Drawing.Point(407, 74);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(363, 178);
            this.dataGridView1.TabIndex = 10;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(407, 103);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // MealInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.tb_sale);
            this.Controls.Add(this.cboBox_MealName);
            this.Controls.Add(this.cboBox_Kind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MealInformationForm";
            this.Text = "MealInformationForm";
            this.Load += new System.EventHandler(this.MealInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBox_Kind;
        private System.Windows.Forms.ComboBox cboBox_MealName;
        private System.Windows.Forms.TextBox tb_sale;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Delete;
    }
}