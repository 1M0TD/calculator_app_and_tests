namespace Calculator
{
    partial class Form1
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
            textbox_result = new TextBox();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_0 = new Button();
            btn_dot = new Button();
            btn_divide = new Button();
            btn_minus = new Button();
            btn_plus = new Button();
            btn_equal = new Button();
            btn_clearall = new Button();
            btn_clear = new Button();
            btn_multiply = new Button();
            btn_percent = new Button();
            SuspendLayout();
            // 
            // textbox_result
            // 
            textbox_result.Font = new Font("Comic Sans MS", 9F);
            textbox_result.ImeMode = ImeMode.Off;
            textbox_result.Location = new Point(12, 12);
            textbox_result.Name = "textbox_result";
            textbox_result.ReadOnly = true;
            textbox_result.Size = new Size(213, 24);
            textbox_result.TabIndex = 1;
            textbox_result.TabStop = false;
            textbox_result.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Comic Sans MS", 9F);
            btn_7.Location = new Point(12, 87);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(43, 29);
            btn_7.TabIndex = 8;
            btn_7.Tag = "7";
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += Digit_Choose_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Comic Sans MS", 9F);
            btn_8.Location = new Point(61, 87);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(43, 29);
            btn_8.TabIndex = 9;
            btn_8.Tag = "8";
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += Digit_Choose_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Comic Sans MS", 9F);
            btn_9.Location = new Point(110, 87);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(43, 29);
            btn_9.TabIndex = 10;
            btn_9.Tag = "9";
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += Digit_Choose_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Comic Sans MS", 9F);
            btn_4.Location = new Point(12, 118);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(43, 29);
            btn_4.TabIndex = 5;
            btn_4.Tag = "4";
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += Digit_Choose_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Comic Sans MS", 9F);
            btn_5.Location = new Point(61, 118);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(43, 29);
            btn_5.TabIndex = 6;
            btn_5.Tag = "5";
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += Digit_Choose_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Comic Sans MS", 9F);
            btn_6.Location = new Point(110, 118);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(43, 29);
            btn_6.TabIndex = 7;
            btn_6.Tag = "6";
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += Digit_Choose_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Comic Sans MS", 9F);
            btn_1.Location = new Point(12, 150);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(43, 29);
            btn_1.TabIndex = 2;
            btn_1.Tag = "1";
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += Digit_Choose_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Comic Sans MS", 9F);
            btn_2.Location = new Point(61, 149);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(43, 29);
            btn_2.TabIndex = 3;
            btn_2.Tag = "2";
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += Digit_Choose_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Comic Sans MS", 9F);
            btn_3.Location = new Point(110, 149);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(43, 29);
            btn_3.TabIndex = 4;
            btn_3.Tag = "3";
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += Digit_Choose_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Comic Sans MS", 9F);
            btn_0.Location = new Point(12, 181);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(92, 29);
            btn_0.TabIndex = 1;
            btn_0.Tag = "0";
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += Digit_Choose_Click;
            // 
            // btn_dot
            // 
            btn_dot.Font = new Font("Comic Sans MS", 9F);
            btn_dot.Location = new Point(110, 181);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(43, 29);
            btn_dot.TabIndex = 11;
            btn_dot.Tag = ",";
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = true;
            btn_dot.Click += Digit_Choose_Click;
            // 
            // btn_divide
            // 
            btn_divide.Font = new Font("Comic Sans MS", 9F);
            btn_divide.Location = new Point(195, 150);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(30, 58);
            btn_divide.TabIndex = 13;
            btn_divide.Tag = "/";
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += operation_Click;
            // 
            // btn_minus
            // 
            btn_minus.Font = new Font("Comic Sans MS", 9F);
            btn_minus.Location = new Point(159, 57);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(30, 28);
            btn_minus.TabIndex = 12;
            btn_minus.Tag = "-";
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += operation_Click;
            // 
            // btn_plus
            // 
            btn_plus.Font = new Font("Comic Sans MS", 9F);
            btn_plus.Location = new Point(159, 87);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(30, 60);
            btn_plus.TabIndex = 14;
            btn_plus.Tag = "+";
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += operation_Click;
            // 
            // btn_equal
            // 
            btn_equal.Font = new Font("Comic Sans MS", 9F);
            btn_equal.Location = new Point(159, 149);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(30, 59);
            btn_equal.TabIndex = 16;
            btn_equal.Tag = "=";
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_clearall
            // 
            btn_clearall.Font = new Font("Comic Sans MS", 9F);
            btn_clearall.Location = new Point(12, 56);
            btn_clearall.Name = "btn_clearall";
            btn_clearall.Size = new Size(92, 29);
            btn_clearall.TabIndex = 18;
            btn_clearall.Tag = "ce";
            btn_clearall.Text = "CE";
            btn_clearall.UseVisualStyleBackColor = true;
            btn_clearall.Click += btn_clearall_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Comic Sans MS", 9F);
            btn_clear.Location = new Point(110, 56);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(43, 29);
            btn_clear.TabIndex = 19;
            btn_clear.Tag = "c";
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.Font = new Font("Comic Sans MS", 9F);
            btn_multiply.Location = new Point(195, 87);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(30, 60);
            btn_multiply.TabIndex = 15;
            btn_multiply.Tag = "*";
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += operation_Click;
            // 
            // btn_percent
            // 
            btn_percent.Font = new Font("Comic Sans MS", 9F);
            btn_percent.Location = new Point(195, 57);
            btn_percent.Name = "btn_percent";
            btn_percent.Size = new Size(30, 28);
            btn_percent.TabIndex = 17;
            btn_percent.Tag = "%";
            btn_percent.Text = "%";
            btn_percent.UseVisualStyleBackColor = true;
            btn_percent.Click += operation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 221);
            Controls.Add(btn_dot);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_0);
            Controls.Add(btn_1);
            Controls.Add(btn_equal);
            Controls.Add(btn_plus);
            Controls.Add(btn_minus);
            Controls.Add(btn_divide);
            Controls.Add(btn_clear);
            Controls.Add(btn_clearall);
            Controls.Add(btn_percent);
            Controls.Add(btn_multiply);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(textbox_result);
            MaximizeBox = false;
            MaximumSize = new Size(250, 260);
            MinimumSize = new Size(250, 260);
            Name = "Form1";
            ShowIcon = false;
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_result;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_0;
        private Button btn_dot;
        private Button btn_divide;
        private Button btn_minus;
        private Button btn_plus;
        private Button btn_equal;
        private Button btn_clearall;
        private Button btn_clear;
        private Button btn_multiply;
        private Button btn_percent;
    }
}
