
namespace OrderAutomation.Views
{
    partial class OdemeEkrani
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
            this.toplamBedelEtiketi = new System.Windows.Forms.Label();
            this.toplamBedel = new System.Windows.Forms.Label();
            this.VergisizToplamBedelEtiketi = new System.Windows.Forms.Label();
            this.VergisizToplamBedel = new System.Windows.Forms.Label();
            this.nakitButton = new System.Windows.Forms.Button();
            this.creditCardButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toplamBedelEtiketi
            // 
            this.toplamBedelEtiketi.AutoSize = true;
            this.toplamBedelEtiketi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toplamBedelEtiketi.Location = new System.Drawing.Point(413, 241);
            this.toplamBedelEtiketi.Name = "toplamBedelEtiketi";
            this.toplamBedelEtiketi.Size = new System.Drawing.Size(159, 32);
            this.toplamBedelEtiketi.TabIndex = 0;
            this.toplamBedelEtiketi.Text = "Toplam Bedel";
            // 
            // toplamBedel
            // 
            this.toplamBedel.AutoSize = true;
            this.toplamBedel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toplamBedel.Location = new System.Drawing.Point(599, 241);
            this.toplamBedel.Name = "toplamBedel";
            this.toplamBedel.Size = new System.Drawing.Size(27, 32);
            this.toplamBedel.TabIndex = 0;
            this.toplamBedel.Text = "0";
            // 
            // VergisizToplamBedelEtiketi
            // 
            this.VergisizToplamBedelEtiketi.AutoSize = true;
            this.VergisizToplamBedelEtiketi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VergisizToplamBedelEtiketi.Location = new System.Drawing.Point(325, 192);
            this.VergisizToplamBedelEtiketi.Name = "VergisizToplamBedelEtiketi";
            this.VergisizToplamBedelEtiketi.Size = new System.Drawing.Size(247, 32);
            this.VergisizToplamBedelEtiketi.TabIndex = 1;
            this.VergisizToplamBedelEtiketi.Text = "Vergisiz Toplam Bedel";
            this.VergisizToplamBedelEtiketi.Click += new System.EventHandler(this.VergisizToplamBedelEtiketi_Click);
            // 
            // VergisizToplamBedel
            // 
            this.VergisizToplamBedel.AutoSize = true;
            this.VergisizToplamBedel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VergisizToplamBedel.Location = new System.Drawing.Point(599, 192);
            this.VergisizToplamBedel.Name = "VergisizToplamBedel";
            this.VergisizToplamBedel.Size = new System.Drawing.Size(27, 32);
            this.VergisizToplamBedel.TabIndex = 2;
            this.VergisizToplamBedel.Text = "0";
            // 
            // nakitButton
            // 
            this.nakitButton.Location = new System.Drawing.Point(133, 303);
            this.nakitButton.Name = "nakitButton";
            this.nakitButton.Size = new System.Drawing.Size(161, 39);
            this.nakitButton.TabIndex = 3;
            this.nakitButton.Text = "Nakit";
            this.nakitButton.UseVisualStyleBackColor = true;
            this.nakitButton.Click += new System.EventHandler(this.nakitButton_Click);
            // 
            // creditCardButton
            // 
            this.creditCardButton.Location = new System.Drawing.Point(325, 303);
            this.creditCardButton.Name = "creditCardButton";
            this.creditCardButton.Size = new System.Drawing.Size(161, 39);
            this.creditCardButton.TabIndex = 3;
            this.creditCardButton.Text = "Kredi Kartı";
            this.creditCardButton.UseVisualStyleBackColor = true;
            this.creditCardButton.Click += new System.EventHandler(this.creditCardButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(510, 303);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(161, 39);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Çek";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // OdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.creditCardButton);
            this.Controls.Add(this.nakitButton);
            this.Controls.Add(this.VergisizToplamBedel);
            this.Controls.Add(this.VergisizToplamBedelEtiketi);
            this.Controls.Add(this.toplamBedel);
            this.Controls.Add(this.toplamBedelEtiketi);
            this.Name = "OdemeEkrani";
            this.Text = "OdemeEkrani";
            this.Load += new System.EventHandler(this.OdemeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toplamBedelEtiketi;
        private System.Windows.Forms.Label toplamBedel;
        private System.Windows.Forms.Label VergisizToplamBedelEtiketi;
        private System.Windows.Forms.Label VergisizToplamBedel;
        private System.Windows.Forms.Button nakitButton;
        private System.Windows.Forms.Button creditCardButton;
        private System.Windows.Forms.Button checkButton;
    }
}