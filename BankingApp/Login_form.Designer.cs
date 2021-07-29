
namespace BankingApp
{
    partial class Login_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logButton = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.MaskedTextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Login";
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(210, 276);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 47);
            this.logButton.TabIndex = 3;
            this.logButton.Text = "Login";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(243, 171);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 22);
            this.userText.TabIndex = 4;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(243, 209);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(100, 22);
            this.passText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.MaskedTextBox userText;
        private System.Windows.Forms.TextBox passText;
    }
}

