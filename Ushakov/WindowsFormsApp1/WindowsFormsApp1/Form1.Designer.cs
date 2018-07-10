namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Substract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Squaring = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(349, 52);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.ButtonClick);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(112, 26);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(156, 20);
            this.TextBox1.TabIndex = 1;
            // 
            // Substract
            // 
            this.Substract.Location = new System.Drawing.Point(251, 52);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(75, 23);
            this.Substract.TabIndex = 2;
            this.Substract.Text = "-";
            this.Substract.UseVisualStyleBackColor = true;
            this.Substract.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(349, 81);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 4;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(251, 80);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 5;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(304, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // Squaring
            // 
            this.Squaring.Location = new System.Drawing.Point(159, 51);
            this.Squaring.Name = "Squaring";
            this.Squaring.Size = new System.Drawing.Size(75, 23);
            this.Squaring.TabIndex = 8;
            this.Squaring.Text = "x^2";
            this.Squaring.UseVisualStyleBackColor = true;
            this.Squaring.Click += new System.EventHandler(this.Squaring_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(159, 80);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(75, 23);
            this.Sqrt.TabIndex = 9;
            this.Sqrt.Text = "sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Squaring_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 334);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Squaring);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Squaring;
        private System.Windows.Forms.Button Sqrt;
    }
}

