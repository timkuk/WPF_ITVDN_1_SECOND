
namespace Lesson33HomeWork33_Task1
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
            this.ReflectionText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OPEN_Button = new System.Windows.Forms.Button();
            this.SAVE_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReflectionText
            // 
            this.ReflectionText.Location = new System.Drawing.Point(130, 57);
            this.ReflectionText.Multiline = true;
            this.ReflectionText.Name = "ReflectionText";
            this.ReflectionText.Size = new System.Drawing.Size(537, 238);
            this.ReflectionText.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OPEN_Button
            // 
            this.OPEN_Button.Location = new System.Drawing.Point(220, 302);
            this.OPEN_Button.Name = "OPEN_Button";
            this.OPEN_Button.Size = new System.Drawing.Size(94, 29);
            this.OPEN_Button.TabIndex = 2;
            this.OPEN_Button.Text = "OPEN";
            this.OPEN_Button.UseVisualStyleBackColor = true;
            this.OPEN_Button.Click += new System.EventHandler(this.OPEN_Button_Click);
            // 
            // SAVE_Button
            // 
            this.SAVE_Button.Location = new System.Drawing.Point(338, 302);
            this.SAVE_Button.Name = "SAVE_Button";
            this.SAVE_Button.Size = new System.Drawing.Size(94, 29);
            this.SAVE_Button.TabIndex = 3;
            this.SAVE_Button.Text = "SAVE";
            this.SAVE_Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SAVE_Button);
            this.Controls.Add(this.OPEN_Button);
            this.Controls.Add(this.ReflectionText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ReflectionText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OPEN_Button;
        private System.Windows.Forms.Button SAVE_Button;
    }
}

