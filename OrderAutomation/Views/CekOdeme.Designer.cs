
namespace OrderAutomation.Views
{
    partial class CekOdeme
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
            this.button1 = new System.Windows.Forms.Button();
            this.isimLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.bankIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(279, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ödeme Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isimLabel
            // 
            this.isimLabel.AutoSize = true;
            this.isimLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isimLabel.Location = new System.Drawing.Point(261, 86);
            this.isimLabel.Name = "isimLabel";
            this.isimLabel.Size = new System.Drawing.Size(119, 25);
            this.isimLabel.TabIndex = 1;
            this.isimLabel.Text = "İsim Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(418, 88);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(182, 23);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // bankIdTextBox
            // 
            this.bankIdTextBox.Location = new System.Drawing.Point(418, 128);
            this.bankIdTextBox.Name = "bankIdTextBox";
            this.bankIdTextBox.Size = new System.Drawing.Size(182, 23);
            this.bankIdTextBox.TabIndex = 2;
            this.bankIdTextBox.TextChanged += new System.EventHandler(this.bankIdTextBox_TextChanged);
            // 
            // CekOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bankIdTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isimLabel);
            this.Controls.Add(this.button1);
            this.Name = "CekOdeme";
            this.Text = "CekOdeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label isimLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox bankIdTextBox;
    }
}