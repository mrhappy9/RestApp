namespace RestApp
{
    partial class WareHouse
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonForecast = new System.Windows.Forms.Button();
            this.allProductsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonForecast);
            this.tabPage1.Controls.Add(this.allProductsButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonForecast
            // 
            this.buttonForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForecast.Location = new System.Drawing.Point(118, 325);
            this.buttonForecast.Name = "buttonForecast";
            this.buttonForecast.Size = new System.Drawing.Size(108, 31);
            this.buttonForecast.TabIndex = 2;
            this.buttonForecast.Text = "Прогноз";
            this.buttonForecast.UseVisualStyleBackColor = true;
            // 
            // allProductsButton
            // 
            this.allProductsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allProductsButton.Location = new System.Drawing.Point(6, 325);
            this.allProductsButton.Name = "allProductsButton";
            this.allProductsButton.Size = new System.Drawing.Size(82, 31);
            this.allProductsButton.TabIndex = 1;
            this.allProductsButton.Tag = "Warehouse";
            this.allProductsButton.Text = "Все товары";
            this.allProductsButton.UseVisualStyleBackColor = true;
            this.allProductsButton.Click += new System.EventHandler(this.allProductsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.idProduct,
            this.quantityProduct,
            this.priceProduct,
            this.infoProduct});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(520, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // productName
            // 
            this.productName.Frozen = true;
            this.productName.HeaderText = "Название товара";
            this.productName.MaxInputLength = 50;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // idProduct
            // 
            this.idProduct.Frozen = true;
            this.idProduct.HeaderText = "Артикул";
            this.idProduct.MaxInputLength = 50;
            this.idProduct.Name = "idProduct";
            this.idProduct.ReadOnly = true;
            // 
            // quantityProduct
            // 
            this.quantityProduct.Frozen = true;
            this.quantityProduct.HeaderText = "Количество(кг)";
            this.quantityProduct.MaxInputLength = 50;
            this.quantityProduct.Name = "quantityProduct";
            this.quantityProduct.ReadOnly = true;
            // 
            // priceProduct
            // 
            this.priceProduct.Frozen = true;
            this.priceProduct.HeaderText = "Цена";
            this.priceProduct.MaxInputLength = 50;
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.ReadOnly = true;
            // 
            // infoProduct
            // 
            this.infoProduct.Frozen = true;
            this.infoProduct.HeaderText = "Доп. информация";
            this.infoProduct.MaxInputLength = 100;
            this.infoProduct.Name = "infoProduct";
            this.infoProduct.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "WareHouse";
            this.Text = "WareHouse";
            this.Load += new System.EventHandler(this.WareHouse_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonForecast;
        private System.Windows.Forms.Button allProductsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoProduct;
    }
}