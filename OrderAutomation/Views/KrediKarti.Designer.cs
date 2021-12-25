
namespace OrderAutomation.Views
{
    partial class KrediKarti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KrediKarti));
            this.kartNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.HataIkon = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.formataUygunDegilText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kartNoTextBox
            // 
            this.kartNoTextBox.Location = new System.Drawing.Point(150, 61);
            this.kartNoTextBox.Name = "kartNoTextBox";
            this.kartNoTextBox.Size = new System.Drawing.Size(330, 23);
            this.kartNoTextBox.TabIndex = 0;
            this.kartNoTextBox.TextChanged += new System.EventHandler(this.kartNoTextBox_TextChanged);
            this.kartNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kartNoTextBox_KeyPress);
            this.kartNoTextBox.Leave += new System.EventHandler(this.kartNoTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kart Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // adSoyad
            // 
            this.adSoyad.Location = new System.Drawing.Point(150, 25);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(330, 23);
            this.adSoyad.TabIndex = 0;
            this.adSoyad.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 23);
            this.textBox3.TabIndex = 0;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "CVC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(264, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "SKT";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(313, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            ""});
            this.comboBox2.Location = new System.Drawing.Point(400, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 23);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.DropDownClosed += new System.EventHandler(this.comboBox2_DropDownClosed);
            // 
            // HataIkon
            // 
            this.HataIkon.AutoSize = true;
            this.HataIkon.ImageKey = "sign-error-icon.png";
            this.HataIkon.ImageList = this.ımageList1;
            this.HataIkon.Location = new System.Drawing.Point(659, 64);
            this.HataIkon.Name = "HataIkon";
            this.HataIkon.Size = new System.Drawing.Size(25, 21);
            this.HataIkon.TabIndex = 3;
            this.HataIkon.Text = "      ";
            this.HataIkon.UseCompatibleTextRendering = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "sign-error-icon.png");
            // 
            // formataUygunDegilText
            // 
            this.formataUygunDegilText.AutoSize = true;
            this.formataUygunDegilText.ImageKey = "sign-error-icon.png";
            this.formataUygunDegilText.Location = new System.Drawing.Point(486, 64);
            this.formataUygunDegilText.Name = "formataUygunDegilText";
            this.formataUygunDegilText.Size = new System.Drawing.Size(180, 21);
            this.formataUygunDegilText.TabIndex = 3;
            this.formataUygunDegilText.Text = "Kredi Kartı Formata Uygun Değil";
            this.formataUygunDegilText.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "ÖDEME TAMAMLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KrediKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formataUygunDegilText);
            this.Controls.Add(this.HataIkon);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.kartNoTextBox);
            this.Name = "KrediKarti";
            this.Text = "KrediKarti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kartNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label HataIkon;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label formataUygunDegilText;
        private System.Windows.Forms.Button button1;
    }
}