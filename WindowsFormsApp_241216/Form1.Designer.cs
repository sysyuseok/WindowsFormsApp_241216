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
            this.radioButton_english = new System.Windows.Forms.RadioButton();
            this.radioButton_math = new System.Windows.Forms.RadioButton();
            this.Student_num = new System.Windows.Forms.Button();
            this.radioButton_korean = new System.Windows.Forms.RadioButton();
            this.checkBox_english = new System.Windows.Forms.CheckBox();
            this.checkBox_math = new System.Windows.Forms.CheckBox();
            this.checkBox_korean = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.textBox_print.Size = new System.Drawing.Size(334, 288);
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
            // radioButton_english
            // 
            this.radioButton_english.AutoSize = true;
            this.radioButton_english.Location = new System.Drawing.Point(48, 66);
            this.radioButton_english.Name = "radioButton_english";
            this.radioButton_english.Size = new System.Drawing.Size(75, 19);
            this.radioButton_english.TabIndex = 3;
            this.radioButton_english.TabStop = true;
            this.radioButton_english.Text = "English";
            this.radioButton_english.UseVisualStyleBackColor = true;
            // 
            // radioButton_math
            // 
            this.radioButton_math.AutoSize = true;
            this.radioButton_math.Location = new System.Drawing.Point(188, 65);
            this.radioButton_math.Name = "radioButton_math";
            this.radioButton_math.Size = new System.Drawing.Size(60, 19);
            this.radioButton_math.TabIndex = 6;
            this.radioButton_math.TabStop = true;
            this.radioButton_math.Text = "Math";
            // 
            // Student_num
            // 
            this.Student_num.Location = new System.Drawing.Point(413, 62);
            this.Student_num.Name = "Student_num";
            this.Student_num.Size = new System.Drawing.Size(134, 23);
            this.Student_num.TabIndex = 7;
            this.Student_num.Text = "student num\r\n";
            this.Student_num.UseVisualStyleBackColor = true;
            this.Student_num.Click += new System.EventHandler(this.Student_num_Click);
            // 
            // radioButton_korean
            // 
            this.radioButton_korean.AutoSize = true;
            this.radioButton_korean.Location = new System.Drawing.Point(296, 65);
            this.radioButton_korean.Name = "radioButton_korean";
            this.radioButton_korean.Size = new System.Drawing.Size(73, 19);
            this.radioButton_korean.TabIndex = 8;
            this.radioButton_korean.TabStop = true;
            this.radioButton_korean.Text = "Korean";
            this.radioButton_korean.UseVisualStyleBackColor = true;
            // 
            // checkBox_english
            // 
            this.checkBox_english.AutoSize = true;
            this.checkBox_english.Location = new System.Drawing.Point(48, 65);
            this.checkBox_english.Name = "checkBox_english";
            this.checkBox_english.Size = new System.Drawing.Size(76, 19);
            this.checkBox_english.TabIndex = 9;
            this.checkBox_english.Text = "English";
            this.checkBox_english.UseVisualStyleBackColor = true;
            this.checkBox_english.CheckedChanged += new System.EventHandler(this.checkBox_english_CheckedChanged);
            // 
            // checkBox_math
            // 
            this.checkBox_math.AutoSize = true;
            this.checkBox_math.Location = new System.Drawing.Point(186, 66);
            this.checkBox_math.Name = "checkBox_math";
            this.checkBox_math.Size = new System.Drawing.Size(61, 19);
            this.checkBox_math.TabIndex = 10;
            this.checkBox_math.Text = "Math";
            this.checkBox_math.UseVisualStyleBackColor = true;
            this.checkBox_math.CheckedChanged += new System.EventHandler(this.checkBox_math_CheckedChanged);
            // 
            // checkBox_korean
            // 
            this.checkBox_korean.AutoSize = true;
            this.checkBox_korean.Location = new System.Drawing.Point(296, 66);
            this.checkBox_korean.Name = "checkBox_korean";
            this.checkBox_korean.Size = new System.Drawing.Size(74, 19);
            this.checkBox_korean.TabIndex = 11;
            this.checkBox_korean.Text = "Korean";
            this.checkBox_korean.UseVisualStyleBackColor = true;
            this.checkBox_korean.CheckedChanged += new System.EventHandler(this.checkBox_korean_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(539, 253);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox_korean);
            this.Controls.Add(this.checkBox_math);
            this.Controls.Add(this.checkBox_english);
            this.Controls.Add(this.radioButton_korean);
            this.Controls.Add(this.Student_num);
            this.Controls.Add(this.radioButton_math);
            this.Controls.Add(this.radioButton_english);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_print);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_print;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.RadioButton radioButton_english;
        private System.Windows.Forms.RadioButton radioButton_math;
        private System.Windows.Forms.Button Student_num;
        private System.Windows.Forms.RadioButton radioButton_korean;
        private System.Windows.Forms.CheckBox checkBox_english;
        private System.Windows.Forms.CheckBox checkBox_math;
        private System.Windows.Forms.CheckBox checkBox_korean;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

