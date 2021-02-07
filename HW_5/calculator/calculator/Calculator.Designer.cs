
namespace calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_result = new System.Windows.Forms.TextBox();
            this.lab_operation = new System.Windows.Forms.Label();
            this.btn_number0 = new System.Windows.Forms.Button();
            this.btn_number1 = new System.Windows.Forms.Button();
            this.btn_number2 = new System.Windows.Forms.Button();
            this.btn_number3 = new System.Windows.Forms.Button();
            this.btn_number4 = new System.Windows.Forms.Button();
            this.btn_number5 = new System.Windows.Forms.Button();
            this.btn_number6 = new System.Windows.Forms.Button();
            this.btn_number7 = new System.Windows.Forms.Button();
            this.btn_number8 = new System.Windows.Forms.Button();
            this.btn_number9 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_difference = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_result
            // 
            this.tb_result.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_result.Location = new System.Drawing.Point(12, 12);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.Size = new System.Drawing.Size(227, 33);
            this.tb_result.TabIndex = 0;
            // 
            // lab_operation
            // 
            this.lab_operation.AutoSize = true;
            this.lab_operation.Location = new System.Drawing.Point(-219, -66);
            this.lab_operation.Name = "lab_operation";
            this.lab_operation.Size = new System.Drawing.Size(0, 15);
            this.lab_operation.TabIndex = 1;
            this.lab_operation.Visible = false;
            this.lab_operation.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_number0
            // 
            this.btn_number0.Location = new System.Drawing.Point(13, 213);
            this.btn_number0.Name = "btn_number0";
            this.btn_number0.Size = new System.Drawing.Size(52, 32);
            this.btn_number0.TabIndex = 2;
            this.btn_number0.Text = "0";
            this.btn_number0.UseVisualStyleBackColor = true;
            this.btn_number0.Click += new System.EventHandler(this.btn_number0_Click);
            // 
            // btn_number1
            // 
            this.btn_number1.Location = new System.Drawing.Point(12, 175);
            this.btn_number1.Name = "btn_number1";
            this.btn_number1.Size = new System.Drawing.Size(53, 32);
            this.btn_number1.TabIndex = 3;
            this.btn_number1.Text = "1";
            this.btn_number1.UseVisualStyleBackColor = true;
            this.btn_number1.Click += new System.EventHandler(this.btn_number1_Click);
            // 
            // btn_number2
            // 
            this.btn_number2.Location = new System.Drawing.Point(71, 175);
            this.btn_number2.Name = "btn_number2";
            this.btn_number2.Size = new System.Drawing.Size(52, 32);
            this.btn_number2.TabIndex = 4;
            this.btn_number2.Text = "2";
            this.btn_number2.UseVisualStyleBackColor = true;
            this.btn_number2.Click += new System.EventHandler(this.btn_number2_Click);
            // 
            // btn_number3
            // 
            this.btn_number3.Location = new System.Drawing.Point(129, 175);
            this.btn_number3.Name = "btn_number3";
            this.btn_number3.Size = new System.Drawing.Size(52, 32);
            this.btn_number3.TabIndex = 5;
            this.btn_number3.Text = "3";
            this.btn_number3.UseVisualStyleBackColor = true;
            this.btn_number3.Click += new System.EventHandler(this.btn_number3_Click);
            // 
            // btn_number4
            // 
            this.btn_number4.Location = new System.Drawing.Point(12, 137);
            this.btn_number4.Name = "btn_number4";
            this.btn_number4.Size = new System.Drawing.Size(53, 32);
            this.btn_number4.TabIndex = 6;
            this.btn_number4.Text = "4";
            this.btn_number4.UseVisualStyleBackColor = true;
            this.btn_number4.Click += new System.EventHandler(this.btn_number4_Click);
            // 
            // btn_number5
            // 
            this.btn_number5.Location = new System.Drawing.Point(71, 137);
            this.btn_number5.Name = "btn_number5";
            this.btn_number5.Size = new System.Drawing.Size(52, 32);
            this.btn_number5.TabIndex = 7;
            this.btn_number5.Text = "5";
            this.btn_number5.UseVisualStyleBackColor = true;
            this.btn_number5.Click += new System.EventHandler(this.btn_number5_Click);
            // 
            // btn_number6
            // 
            this.btn_number6.Location = new System.Drawing.Point(129, 137);
            this.btn_number6.Name = "btn_number6";
            this.btn_number6.Size = new System.Drawing.Size(52, 32);
            this.btn_number6.TabIndex = 8;
            this.btn_number6.Text = "6";
            this.btn_number6.UseVisualStyleBackColor = true;
            this.btn_number6.Click += new System.EventHandler(this.btn_number6_Click);
            // 
            // btn_number7
            // 
            this.btn_number7.Location = new System.Drawing.Point(12, 99);
            this.btn_number7.Name = "btn_number7";
            this.btn_number7.Size = new System.Drawing.Size(53, 32);
            this.btn_number7.TabIndex = 9;
            this.btn_number7.Text = "7";
            this.btn_number7.UseVisualStyleBackColor = true;
            this.btn_number7.Click += new System.EventHandler(this.btn_number7_Click);
            // 
            // btn_number8
            // 
            this.btn_number8.Location = new System.Drawing.Point(71, 99);
            this.btn_number8.Name = "btn_number8";
            this.btn_number8.Size = new System.Drawing.Size(52, 32);
            this.btn_number8.TabIndex = 10;
            this.btn_number8.Text = "8";
            this.btn_number8.UseVisualStyleBackColor = true;
            this.btn_number8.Click += new System.EventHandler(this.btn_number8_Click);
            // 
            // btn_number9
            // 
            this.btn_number9.Location = new System.Drawing.Point(129, 99);
            this.btn_number9.Name = "btn_number9";
            this.btn_number9.Size = new System.Drawing.Size(52, 32);
            this.btn_number9.TabIndex = 11;
            this.btn_number9.Text = "9";
            this.btn_number9.UseVisualStyleBackColor = true;
            this.btn_number9.Click += new System.EventHandler(this.btn_number9_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Location = new System.Drawing.Point(71, 213);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(52, 32);
            this.btn_dot.TabIndex = 12;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(129, 213);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(110, 32);
            this.btn_result.TabIndex = 13;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click_1);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(187, 175);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(52, 32);
            this.btn_divide.TabIndex = 14;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(187, 137);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(52, 32);
            this.btn_multiply.TabIndex = 15;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_difference
            // 
            this.btn_difference.Location = new System.Drawing.Point(187, 99);
            this.btn_difference.Name = "btn_difference";
            this.btn_difference.Size = new System.Drawing.Size(52, 32);
            this.btn_difference.TabIndex = 16;
            this.btn_difference.Text = "-";
            this.btn_difference.UseVisualStyleBackColor = true;
            this.btn_difference.Click += new System.EventHandler(this.btn_difference_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(187, 61);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(52, 32);
            this.btn_sum.TabIndex = 17;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(129, 61);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(52, 32);
            this.btn_minus.TabIndex = 18;
            this.btn_minus.Text = "+/-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_erase
            // 
            this.btn_erase.Location = new System.Drawing.Point(71, 61);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(52, 32);
            this.btn_erase.TabIndex = 19;
            this.btn_erase.Text = "<--";
            this.btn_erase.UseVisualStyleBackColor = true;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 61);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(53, 32);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(251, 261);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_difference);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_number9);
            this.Controls.Add(this.btn_number8);
            this.Controls.Add(this.btn_number7);
            this.Controls.Add(this.btn_number6);
            this.Controls.Add(this.btn_number5);
            this.Controls.Add(this.btn_number4);
            this.Controls.Add(this.btn_number3);
            this.Controls.Add(this.btn_number2);
            this.Controls.Add(this.btn_number1);
            this.Controls.Add(this.btn_number0);
            this.Controls.Add(this.lab_operation);
            this.Controls.Add(this.tb_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label lab_operation;
        private System.Windows.Forms.Button btn_number0;
        private System.Windows.Forms.Button btn_number1;
        private System.Windows.Forms.Button btn_number2;
        private System.Windows.Forms.Button btn_number3;
        private System.Windows.Forms.Button btn_number4;
        private System.Windows.Forms.Button btn_number5;
        private System.Windows.Forms.Button btn_number6;
        private System.Windows.Forms.Button btn_number7;
        private System.Windows.Forms.Button btn_number8;
        private System.Windows.Forms.Button btn_number9;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_difference;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_erase;
        private System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.Button btn_result;
    }
}

