namespace RestApp
{
    partial class Cooking
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
            this.applyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cookBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewCook = new System.Windows.Forms.DataGridView();
            this.idOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.readyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.orderInfoBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewInfoPurchase = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibleCooker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCook)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.applyButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.orderBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cookBox);
            this.tabPage1.Controls.Add(this.dataGridViewCook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обработка заказа";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(659, 94);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(108, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Взять заказ";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выбор заказа";
            // 
            // orderBox
            // 
            this.orderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Location = new System.Drawing.Point(725, 38);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(142, 21);
            this.orderBox.TabIndex = 3;
            this.orderBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор повара";
            // 
            // cookBox
            // 
            this.cookBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cookBox.FormattingEnabled = true;
            this.cookBox.Location = new System.Drawing.Point(560, 38);
            this.cookBox.Name = "cookBox";
            this.cookBox.Size = new System.Drawing.Size(142, 21);
            this.cookBox.TabIndex = 1;
            this.cookBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cookBox_MouseClick);
            // 
            // dataGridViewCook
            // 
            this.dataGridViewCook.AllowUserToAddRows = false;
            this.dataGridViewCook.AllowUserToDeleteRows = false;
            this.dataGridViewCook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrder,
            this.quantity,
            this.totalPrice,
            this.nameMeal,
            this.timeOrder});
            this.dataGridViewCook.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCook.Name = "dataGridViewCook";
            this.dataGridViewCook.ReadOnly = true;
            this.dataGridViewCook.Size = new System.Drawing.Size(544, 390);
            this.dataGridViewCook.TabIndex = 0;
            // 
            // idOrder
            // 
            this.idOrder.HeaderText = "Номер заказа";
            this.idOrder.Name = "idOrder";
            this.idOrder.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Кол-во";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Стоимость";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // nameMeal
            // 
            this.nameMeal.HeaderText = "Название блюда";
            this.nameMeal.Name = "nameMeal";
            this.nameMeal.ReadOnly = true;
            // 
            // timeOrder
            // 
            this.timeOrder.HeaderText = "Начало заказа";
            this.timeOrder.Name = "timeOrder";
            this.timeOrder.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.readyButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.orderInfoBox);
            this.tabPage2.Controls.Add(this.dataGridViewInfoPurchase);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Информация о принятых заказах";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(725, 95);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(96, 23);
            this.readyButton.TabIndex = 7;
            this.readyButton.Text = "Заказ готов";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Заказ";
            // 
            // orderInfoBox
            // 
            this.orderInfoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderInfoBox.FormattingEnabled = true;
            this.orderInfoBox.Location = new System.Drawing.Point(701, 36);
            this.orderInfoBox.Name = "orderInfoBox";
            this.orderInfoBox.Size = new System.Drawing.Size(142, 21);
            this.orderInfoBox.TabIndex = 5;
            this.orderInfoBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderInfoBox_MouseClick);
            // 
            // dataGridViewInfoPurchase
            // 
            this.dataGridViewInfoPurchase.AllowUserToAddRows = false;
            this.dataGridViewInfoPurchase.AllowUserToDeleteRows = false;
            this.dataGridViewInfoPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.responsibleCooker});
            this.dataGridViewInfoPurchase.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInfoPurchase.Name = "dataGridViewInfoPurchase";
            this.dataGridViewInfoPurchase.ReadOnly = true;
            this.dataGridViewInfoPurchase.Size = new System.Drawing.Size(644, 390);
            this.dataGridViewInfoPurchase.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Название блюда";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Начало заказа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // responsibleCooker
            // 
            this.responsibleCooker.HeaderText = "Ответственный повар";
            this.responsibleCooker.Name = "responsibleCooker";
            this.responsibleCooker.ReadOnly = true;
            // 
            // Cooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Cooking";
            this.Text = "Cooking";
            this.Load += new System.EventHandler(this.Cooking_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCook)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cookBox;
        private System.Windows.Forms.DataGridView dataGridViewCook;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.DataGridView dataGridViewInfoPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleCooker;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orderInfoBox;
    }
}