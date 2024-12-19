namespace WindowsFormsApp_241216
{
    partial class Form1
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
            this.textBox_print = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.radioButton_true = new System.Windows.Forms.RadioButton();
            this.radioButton_false = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result : ";
            // 
            // textBox_print
            // 
            this.textBox_print.Location = new System.Drawing.Point(35, 126);
            this.textBox_print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.ReadOnly = true;
            this.textBox_print.Size = new System.Drawing.Size(490, 288);
            this.textBox_print.TabIndex = 2;
            this.textBox_print.UseWaitCursor = true;
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(35, 92);
            this.textBox_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(397, 25);
            this.textBox_input.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(440, 92);
            this.Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(86, 29);
            this.Button.TabIndex = 1;
            this.Button.Text = "INPUT";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // radioButton_true
            // 
            this.radioButton_true.AutoSize = true;
            this.radioButton_true.Location = new System.Drawing.Point(48, 66);
            this.radioButton_true.Name = "radioButton_true";
            this.radioButton_true.Size = new System.Drawing.Size(65, 19);
            this.radioButton_true.TabIndex = 3;
            this.radioButton_true.TabStop = true;
            this.radioButton_true.Text = "TRUE";
            this.radioButton_true.UseVisualStyleBackColor = true;
            this.radioButton_true.CheckedChanged += new System.EventHandler(this.radioButton_true_CheckedChanged);
            // 
            // radioButton_false
            // 
            this.radioButton_false.AutoSize = true;
            this.radioButton_false.Location = new System.Drawing.Point(188, 65);
            this.radioButton_false.Name = "radioButton_false";
            this.radioButton_false.Size = new System.Drawing.Size(72, 19);
            this.radioButton_false.TabIndex = 6;
            this.radioButton_false.TabStop = true;
            this.radioButton_false.Text = "FALSE";
            this.radioButton_false.UseVisualStyleBackColor = true;
            this.radioButton_false.CheckedChanged += new System.EventHandler(this.radioButton_false_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.radioButton_false);
            this.Controls.Add(this.radioButton_true);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_print);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_print;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.RadioButton radioButton_true;
        private System.Windows.Forms.RadioButton radioButton_false;
    }
}

