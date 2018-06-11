namespace Restaurant
{
    partial class ChooseForm
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
            this.btn_meal = new System.Windows.Forms.Button();
            this.btn_Item = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btn_Vip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_meal
            // 
            this.btn_meal.Image = global::Restaurant.Properties.Resources.圖片_1;
            this.btn_meal.Location = new System.Drawing.Point(1, 3);
            this.btn_meal.Name = "btn_meal";
            this.btn_meal.Size = new System.Drawing.Size(188, 214);
            this.btn_meal.TabIndex = 0;
            this.btn_meal.UseVisualStyleBackColor = true;
            this.btn_meal.Click += new System.EventHandler(this.btn_meal_Click);
            // 
            // btn_Item
            // 
            this.btn_Item.Image = global::Restaurant.Properties.Resources.圖片_3;
            this.btn_Item.Location = new System.Drawing.Point(195, 3);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(177, 214);
            this.btn_Item.TabIndex = 1;
            this.btn_Item.UseVisualStyleBackColor = true;
            this.btn_Item.Click += new System.EventHandler(this.btn_Item_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.Image = global::Restaurant.Properties.Resources.Unknown;
            this.btn_Employee.Location = new System.Drawing.Point(1, 248);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(188, 214);
            this.btn_Employee.TabIndex = 2;
            this.btn_Employee.UseVisualStyleBackColor = true;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Vip
            // 
            this.btn_Vip.Image = global::Restaurant.Properties.Resources.圖片_2;
            this.btn_Vip.Location = new System.Drawing.Point(195, 248);
            this.btn_Vip.Name = "btn_Vip";
            this.btn_Vip.Size = new System.Drawing.Size(177, 214);
            this.btn_Vip.TabIndex = 3;
            this.btn_Vip.UseVisualStyleBackColor = true;
            this.btn_Vip.Click += new System.EventHandler(this.btn_Vip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(60, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "員工資料";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(251, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "VIP資料";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(60, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "餐點資料";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(251, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "庫存管理";
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Vip);
            this.Controls.Add(this.btn_Employee);
            this.Controls.Add(this.btn_Item);
            this.Controls.Add(this.btn_meal);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "ChooseForm";
            this.Text = "ChooseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_meal;
        private System.Windows.Forms.Button btn_Item;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Button btn_Vip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}