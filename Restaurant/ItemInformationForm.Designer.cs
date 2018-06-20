namespace Restaurant
{
    partial class ItemInformationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBox_Items = new System.Windows.Forms.ComboBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.tb_used = new System.Windows.Forms.TextBox();
            this.btn_Sure = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "品項";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "庫存數";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(166, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "今日用量";
            // 
            // cboBox_Items
            // 
            this.cboBox_Items.FormattingEnabled = true;
            this.cboBox_Items.Location = new System.Drawing.Point(16, 44);
            this.cboBox_Items.Name = "cboBox_Items";
            this.cboBox_Items.Size = new System.Drawing.Size(121, 20);
            this.cboBox_Items.TabIndex = 5;
            this.cboBox_Items.SelectedIndexChanged += new System.EventHandler(this.cboBox_Items_SelectedIndexChanged);
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(16, 117);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(100, 22);
            this.tb_stock.TabIndex = 6;
            this.tb_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_Keypress);
            // 
            // tb_used
            // 
            this.tb_used.Location = new System.Drawing.Point(169, 44);
            this.tb_used.Name = "tb_used";
            this.tb_used.Size = new System.Drawing.Size(100, 22);
            this.tb_used.TabIndex = 7;
            this.tb_used.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_Keypress);
            // 
            // btn_Sure
            // 
            this.btn_Sure.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Sure.Location = new System.Drawing.Point(254, 117);
            this.btn_Sure.Name = "btn_Sure";
            this.btn_Sure.Size = new System.Drawing.Size(75, 23);
            this.btn_Sure.TabIndex = 8;
            this.btn_Sure.Text = "確認";
            this.btn_Sure.UseVisualStyleBackColor = true;
            this.btn_Sure.Click += new System.EventHandler(this.btn_Sure_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(331, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // ItemInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sure);
            this.Controls.Add(this.tb_used);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.cboBox_Items);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ItemInformationForm";
            this.Text = "ItemInformationForm";
            this.Load += new System.EventHandler(this.ItemInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBox_Items;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_used;
        private System.Windows.Forms.Button btn_Sure;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}