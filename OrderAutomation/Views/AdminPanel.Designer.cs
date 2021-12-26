
namespace OrderAutomation.Views
{
    partial class AdminPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.paymentsTab = new System.Windows.Forms.TabPage();
            this.paymentsGrid = new System.Windows.Forms.DataGridView();
            this.itemsTab = new System.Windows.Forms.TabPage();
            this.deleteItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.itemsGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.paymentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).BeginInit();
            this.itemsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ordersTab);
            this.tabControl1.Controls.Add(this.paymentsTab);
            this.tabControl1.Controls.Add(this.itemsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1116, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.ordersGrid);
            this.ordersTab.Location = new System.Drawing.Point(4, 24);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTab.Size = new System.Drawing.Size(1108, 422);
            this.ordersTab.TabIndex = 0;
            this.ordersTab.Text = "Orders";
            this.ordersTab.UseVisualStyleBackColor = true;
            // 
            // ordersGrid
            // 
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersGrid.Location = new System.Drawing.Point(3, 3);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.RowTemplate.Height = 25;
            this.ordersGrid.Size = new System.Drawing.Size(1102, 416);
            this.ordersGrid.TabIndex = 0;
            // 
            // paymentsTab
            // 
            this.paymentsTab.Controls.Add(this.paymentsGrid);
            this.paymentsTab.Location = new System.Drawing.Point(4, 24);
            this.paymentsTab.Name = "paymentsTab";
            this.paymentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.paymentsTab.Size = new System.Drawing.Size(1108, 422);
            this.paymentsTab.TabIndex = 1;
            this.paymentsTab.Text = "Payments";
            this.paymentsTab.UseVisualStyleBackColor = true;
            // 
            // paymentsGrid
            // 
            this.paymentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsGrid.Location = new System.Drawing.Point(3, 3);
            this.paymentsGrid.Name = "paymentsGrid";
            this.paymentsGrid.ReadOnly = true;
            this.paymentsGrid.RowTemplate.Height = 25;
            this.paymentsGrid.Size = new System.Drawing.Size(1102, 416);
            this.paymentsGrid.TabIndex = 0;
            // 
            // itemsTab
            // 
            this.itemsTab.Controls.Add(this.deleteItem);
            this.itemsTab.Controls.Add(this.addItem);
            this.itemsTab.Controls.Add(this.itemsGrid);
            this.itemsTab.Location = new System.Drawing.Point(4, 24);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTab.Size = new System.Drawing.Size(1108, 422);
            this.itemsTab.TabIndex = 2;
            this.itemsTab.Text = "Items";
            this.itemsTab.UseVisualStyleBackColor = true;
            // 
            // deleteItem
            // 
            this.deleteItem.Location = new System.Drawing.Point(865, 167);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(168, 55);
            this.deleteItem.TabIndex = 1;
            this.deleteItem.Text = "Delete Item";
            this.deleteItem.UseVisualStyleBackColor = true;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(865, 76);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(168, 55);
            this.addItem.TabIndex = 1;
            this.addItem.Text = "Add Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // itemsGrid
            // 
            this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemsGrid.Location = new System.Drawing.Point(3, 3);
            this.itemsGrid.Name = "itemsGrid";
            this.itemsGrid.RowTemplate.Height = 25;
            this.itemsGrid.Size = new System.Drawing.Size(780, 416);
            this.itemsGrid.TabIndex = 0;
            this.itemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.tabControl1.ResumeLayout(false);
            this.ordersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.paymentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).EndInit();
            this.itemsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ordersTab;
        private System.Windows.Forms.TabPage paymentsTab;
        private System.Windows.Forms.TabPage itemsTab;
        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.DataGridView paymentsGrid;
        private System.Windows.Forms.DataGridView itemsGrid;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.Button addItem;
    }
}