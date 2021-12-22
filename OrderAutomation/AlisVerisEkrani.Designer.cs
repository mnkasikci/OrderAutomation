
namespace OrderAutomation
{
    partial class AlisVerisEkrani
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIsmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelkdvsiz = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelkdvli = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunID,
            this.urunIsmi,
            this.urunFiyat});
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(435, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // urunID
            // 
            this.urunID.HeaderText = "Column1";
            this.urunID.MinimumWidth = 6;
            this.urunID.Name = "urunID";
            this.urunID.Width = 125;
            // 
            // urunIsmi
            // 
            this.urunIsmi.HeaderText = "Column1";
            this.urunIsmi.MinimumWidth = 6;
            this.urunIsmi.Name = "urunIsmi";
            this.urunIsmi.Width = 125;
            // 
            // urunFiyat
            // 
            this.urunFiyat.HeaderText = "Column1";
            this.urunFiyat.MinimumWidth = 6;
            this.urunFiyat.Name = "urunFiyat";
            this.urunFiyat.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "urunler";
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
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(444, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "sepete ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(638, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 204);
            this.listBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "KDV\'li toplam fiyat:";
            // 
            // labelkdvsiz
            // 
            this.labelkdvsiz.AutoSize = true;
            this.labelkdvsiz.Location = new System.Drawing.Point(768, 267);
            this.labelkdvsiz.Name = "labelkdvsiz";
            this.labelkdvsiz.Size = new System.Drawing.Size(38, 20);
            this.labelkdvsiz.TabIndex = 8;
            this.labelkdvsiz.Text = "fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "urunler toplamı:";
            // 
            // labelkdvli
            // 
            this.labelkdvli.AutoSize = true;
            this.labelkdvli.Location = new System.Drawing.Point(781, 316);
            this.labelkdvli.Name = "labelkdvli";
            this.labelkdvli.Size = new System.Drawing.Size(71, 20);
            this.labelkdvli.TabIndex = 10;
            this.labelkdvli.Text = "fiyat+kdv";
            // 
            // AlisVerisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.labelkdvli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelkdvsiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AlisVerisEkrani";
            this.Text = "AlisVerisEkrani";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelkdvsiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIsmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelkdvli;
    }
}

