
namespace OrderAutomation.Views
{
    partial class NakitOdeme
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.odenenBedelLabel = new System.Windows.Forms.Label();
            this.paraUstuLabel = new System.Windows.Forms.Label();
            this.paraUstu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // odenenBedelLabel
            // 
            this.odenenBedelLabel.AutoSize = true;
            this.odenenBedelLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.odenenBedelLabel.Location = new System.Drawing.Point(327, 113);
            this.odenenBedelLabel.Name = "odenenBedelLabel";
            this.odenenBedelLabel.Size = new System.Drawing.Size(150, 30);
            this.odenenBedelLabel.TabIndex = 1;
            this.odenenBedelLabel.Text = "Ödenen Bedel";
            // 
            // paraUstuLabel
            // 
            this.paraUstuLabel.AutoSize = true;
            this.paraUstuLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paraUstuLabel.Location = new System.Drawing.Point(254, 225);
            this.paraUstuLabel.Name = "paraUstuLabel";
            this.paraUstuLabel.Size = new System.Drawing.Size(106, 30);
            this.paraUstuLabel.TabIndex = 1;
            this.paraUstuLabel.Text = "Para Üstü";
            // 
            // paraUstu
            // 
            this.paraUstu.AutoSize = true;
            this.paraUstu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paraUstu.Location = new System.Drawing.Point(443, 225);
            this.paraUstu.Name = "paraUstu";
            this.paraUstu.Size = new System.Drawing.Size(0, 30);
            this.paraUstu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(327, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ödeme Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NakitOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paraUstu);
            this.Controls.Add(this.paraUstuLabel);
            this.Controls.Add(this.odenenBedelLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "NakitOdeme";
            this.Text = "NakitOdeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label odenenBedelLabel;
        private System.Windows.Forms.Label paraUstuLabel;
        private System.Windows.Forms.Label paraUstu;
        private System.Windows.Forms.Button button1;
    }
}