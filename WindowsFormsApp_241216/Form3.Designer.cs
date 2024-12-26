namespace WindowsFormsApp_241216
{
    partial class Form3
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
            this.textBox_print = new System.Windows.Forms.TextBox();
            this.radioButton_plus = new System.Windows.Forms.RadioButton();
            this.radioButton_minus = new System.Windows.Forms.RadioButton();
            this.radioButton_multiply = new System.Windows.Forms.RadioButton();
            this.radioButton_division = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_print
            // 
            this.textBox_print.Location = new System.Drawing.Point(247, 113);
            this.textBox_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.Size = new System.Drawing.Size(132, 23);
            this.textBox_print.TabIndex = 0;
            this.textBox_print.Text = "output";
            // 
            // radioButton_plus
            // 
            this.radioButton_plus.AutoSize = true;
            this.radioButton_plus.Location = new System.Drawing.Point(55, 84);
            this.radioButton_plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_plus.Name = "radioButton_plus";
            this.radioButton_plus.Size = new System.Drawing.Size(29, 16);
            this.radioButton_plus.TabIndex = 1;
            this.radioButton_plus.TabStop = true;
            this.radioButton_plus.Text = "+";
            this.radioButton_plus.UseVisualStyleBackColor = true;
            // 
            // radioButton_minus
            // 
            this.radioButton_minus.AutoSize = true;
            this.radioButton_minus.Location = new System.Drawing.Point(101, 84);
            this.radioButton_minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_minus.Name = "radioButton_minus";
            this.radioButton_minus.Size = new System.Drawing.Size(29, 16);
            this.radioButton_minus.TabIndex = 2;
            this.radioButton_minus.TabStop = true;
            this.radioButton_minus.Text = "-";
            this.radioButton_minus.UseVisualStyleBackColor = true;
            // 
            // radioButton_multiply
            // 
            this.radioButton_multiply.AutoSize = true;
            this.radioButton_multiply.Location = new System.Drawing.Point(143, 84);
            this.radioButton_multiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_multiply.Name = "radioButton_multiply";
            this.radioButton_multiply.Size = new System.Drawing.Size(29, 16);
            this.radioButton_multiply.TabIndex = 3;
            this.radioButton_multiply.TabStop = true;
            this.radioButton_multiply.Text = "*";
            this.radioButton_multiply.UseVisualStyleBackColor = true;
            // 
            // radioButton_division
            // 
            this.radioButton_division.AutoSize = true;
            this.radioButton_division.Location = new System.Drawing.Point(182, 84);
            this.radioButton_division.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_division.Name = "radioButton_division";
            this.radioButton_division.Size = new System.Drawing.Size(29, 16);
            this.radioButton_division.TabIndex = 4;
            this.radioButton_division.TabStop = true;
            this.radioButton_division.Text = "/";
            this.radioButton_division.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 18);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(55, 113);
            this.textBox_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(88, 21);
            this.textBox_input.TabIndex = 6;
            this.textBox_input.Text = "input";
            //this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_division);
            this.Controls.Add(this.radioButton_multiply);
            this.Controls.Add(this.radioButton_minus);
            this.Controls.Add(this.radioButton_plus);
            this.Controls.Add(this.textBox_print);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
            #endregion

        private System.Windows.Forms.TextBox textBox_print;
        private System.Windows.Forms.RadioButton radioButton_plus;
        private System.Windows.Forms.RadioButton radioButton_minus;
        private System.Windows.Forms.RadioButton radioButton_multiply;
        private System.Windows.Forms.RadioButton radioButton_division;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_input;
    }
}