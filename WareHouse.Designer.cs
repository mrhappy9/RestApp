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
            this.costProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonClearGoods = new System.Windows.Forms.Button();
            this.buttonAddGoods = new System.Windows.Forms.Button();
            this.dataGridAcceptanceGoods = new System.Windows.Forms.DataGridView();
            this.nameAccepProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityAccepProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costAccepProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoAccepProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.removeItem = new System.Windows.Forms.Button();
            this.itemsBox = new System.Windows.Forms.ComboBox();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.infoForecast = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcceptanceGoods)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 418);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonForecast);
            this.tabPage1.Controls.Add(this.allProductsButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Склад товаров";
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
            this.buttonForecast.Click += new System.EventHandler(this.buttonForecast_Click);
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
            this.costProduct,
            this.infoProduct});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 300);
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
            // costProduct
            // 
            this.costProduct.Frozen = true;
            this.costProduct.HeaderText = "Стоимость";
            this.costProduct.MaxInputLength = 50;
            this.costProduct.Name = "costProduct";
            this.costProduct.ReadOnly = true;
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
            this.tabPage2.Controls.Add(this.buttonClearGoods);
            this.tabPage2.Controls.Add(this.buttonAddGoods);
            this.tabPage2.Controls.Add(this.dataGridAcceptanceGoods);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Приемка товара";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonClearGoods
            // 
            this.buttonClearGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearGoods.Location = new System.Drawing.Point(149, 318);
            this.buttonClearGoods.Name = "buttonClearGoods";
            this.buttonClearGoods.Size = new System.Drawing.Size(107, 29);
            this.buttonClearGoods.TabIndex = 2;
            this.buttonClearGoods.Text = "Очистить таблицу";
            this.buttonClearGoods.UseVisualStyleBackColor = true;
            this.buttonClearGoods.Click += new System.EventHandler(this.buttonClearGoods_Click);
            // 
            // buttonAddGoods
            // 
            this.buttonAddGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGoods.Location = new System.Drawing.Point(6, 318);
            this.buttonAddGoods.Name = "buttonAddGoods";
            this.buttonAddGoods.Size = new System.Drawing.Size(98, 29);
            this.buttonAddGoods.TabIndex = 1;
            this.buttonAddGoods.Text = "Принять товар";
            this.buttonAddGoods.UseVisualStyleBackColor = true;
            this.buttonAddGoods.Click += new System.EventHandler(this.buttonAddGoods_Click);
            // 
            // dataGridAcceptanceGoods
            // 
            this.dataGridAcceptanceGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAcceptanceGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameAccepProduct,
            this.quantityAccepProduct,
            this.costAccepProduct,
            this.infoAccepProduct});
            this.dataGridAcceptanceGoods.Location = new System.Drawing.Point(4, 3);
            this.dataGridAcceptanceGoods.Name = "dataGridAcceptanceGoods";
            this.dataGridAcceptanceGoods.Size = new System.Drawing.Size(444, 281);
            this.dataGridAcceptanceGoods.TabIndex = 0;
            // 
            // nameAccepProduct
            // 
            this.nameAccepProduct.HeaderText = "Наименование товара";
            this.nameAccepProduct.MaxInputLength = 50;
            this.nameAccepProduct.Name = "nameAccepProduct";
            // 
            // quantityAccepProduct
            // 
            this.quantityAccepProduct.HeaderText = "Количество(кг)";
            this.quantityAccepProduct.MaxInputLength = 50;
            this.quantityAccepProduct.Name = "quantityAccepProduct";
            // 
            // costAccepProduct
            // 
            this.costAccepProduct.HeaderText = "Стоимость";
            this.costAccepProduct.MaxInputLength = 50;
            this.costAccepProduct.Name = "costAccepProduct";
            // 
            // infoAccepProduct
            // 
            this.infoAccepProduct.HeaderText = "Доп.информация";
            this.infoAccepProduct.MaxInputLength = 100;
            this.infoAccepProduct.Name = "infoAccepProduct";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.removeItem);
            this.tabPage3.Controls.Add(this.itemsBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(549, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Списание товара";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // removeItem
            // 
            this.removeItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeItem.Location = new System.Drawing.Point(230, 35);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(123, 31);
            this.removeItem.TabIndex = 2;
            this.removeItem.Text = "Списать товар";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // itemsBox
            // 
            this.itemsBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemsBox.FormattingEnabled = true;
            this.itemsBox.Location = new System.Drawing.Point(15, 41);
            this.itemsBox.Name = "itemsBox";
            this.itemsBox.Size = new System.Drawing.Size(172, 21);
            this.itemsBox.TabIndex = 0;
            this.itemsBox.SelectedIndexChanged += new System.EventHandler(this.itemsBox_SelectedIndexChanged);
            this.itemsBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.itemsBox_MouseClick);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(593, 125);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(202, 87);
            this.infoBox.TabIndex = 1;
            // 
            // infoForecast
            // 
            this.infoForecast.AutoSize = true;
            this.infoForecast.Location = new System.Drawing.Point(649, 109);
            this.infoForecast.Name = "infoForecast";
            this.infoForecast.Size = new System.Drawing.Size(85, 13);
            this.infoForecast.TabIndex = 2;
            this.infoForecast.Text = "Инфо прогноза";
            // 
            // WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 458);
            this.Controls.Add(this.infoForecast);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "WareHouse";
            this.Text = "WareHouse";
            this.Load += new System.EventHandler(this.WareHouse_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcceptanceGoods)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonForecast;
        private System.Windows.Forms.Button allProductsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridAcceptanceGoods;
        private System.Windows.Forms.Button buttonAddGoods;
        private System.Windows.Forms.Button buttonClearGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn costProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoProduct;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAccepProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityAccepProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn costAccepProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoAccepProduct;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox itemsBox;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Label infoForecast;
    }
}