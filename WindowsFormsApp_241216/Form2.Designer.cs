namespace WindowsFormsApp_241216
{
    partial class Form2
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
            this.button_rock = new System.Windows.Forms.Button();
            this.button_scissor = new System.Windows.Forms.Button();
            this.button_paper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_print
            // 
            this.textBox_print.Location = new System.Drawing.Point(95, 136);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.Size = new System.Drawing.Size(313, 185);
            this.textBox_print.TabIndex = 0;
            // 
            // button_rock
            // 
            this.button_rock.Location = new System.Drawing.Point(95, 98);
            this.button_rock.Name = "button_rock";
            this.button_rock.Size = new System.Drawing.Size(75, 23);
            this.button_rock.TabIndex = 1;
            this.button_rock.Text = "Rock";
            this.button_rock.UseVisualStyleBackColor = true;
            this.button_rock.Click += new System.EventHandler(this.button_rock_Click);
            // 
            // button_scissor
            // 
            this.button_scissor.Location = new System.Drawing.Point(176, 98);
            this.button_scissor.Name = "button_scissor";
            this.button_scissor.Size = new System.Drawing.Size(75, 23);
            this.button_scissor.TabIndex = 2;
            this.button_scissor.Text = "Scissor";
            this.button_scissor.UseVisualStyleBackColor = true;
            this.button_scissor.Click += new System.EventHandler(this.button_scissor_Click);
            // 
            // button_paper
            // 
            this.button_paper.Location = new System.Drawing.Point(257, 98);
            this.button_paper.Name = "button_paper";
            this.button_paper.Size = new System.Drawing.Size(75, 23);
            this.button_paper.TabIndex = 3;
            this.button_paper.Text = "Paper";
            this.button_paper.UseVisualStyleBackColor = true;
            this.button_paper.Click += new System.EventHandler(this.button_paper_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_paper);
            this.Controls.Add(this.button_scissor);
            this.Controls.Add(this.button_rock);
            this.Controls.Add(this.textBox_print);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_print;
        private System.Windows.Forms.Button button_rock;
        private System.Windows.Forms.Button button_scissor;
        private System.Windows.Forms.Button button_paper;
    }
}