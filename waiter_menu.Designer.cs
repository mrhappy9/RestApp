namespace RestApp
{
    partial class waiter_menu
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
            this.waiter = new System.Windows.Forms.ComboBox();
            this.details = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.new_order = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.errase = new System.Windows.Forms.Button();
            this.apply_edit = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.TextBox();
            this.edit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.menuch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.discount1 = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.TextBox();
            this.pay1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.final1 = new System.Windows.Forms.TextBox();
            this.sumforpay1 = new System.Windows.Forms.TextBox();
            this.put = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sumforpay2 = new System.Windows.Forms.TextBox();
            this.cardnumber = new System.Windows.Forms.TextBox();
            this.cardholder = new System.Windows.Forms.TextBox();
            this.choise = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.TextBox();
            this.new_pay = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Waiter_code = new System.Windows.Forms.TextBox();
            this.restDataSet = new RestApp.restDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new RestApp.restDataSetTableAdapters.orderTableAdapter();
            this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wayofpaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timecontrolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // waiter
            // 
            this.waiter.FormattingEnabled = true;
            this.waiter.Location = new System.Drawing.Point(134, 56);
            this.waiter.Name = "waiter";
            this.waiter.Size = new System.Drawing.Size(351, 24);
            this.waiter.TabIndex = 1;
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(134, 214);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(351, 246);
            this.details.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 708);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.new_order);
            this.tabPage1.Controls.Add(this.amount);
            this.tabPage1.Controls.Add(this.errase);
            this.tabPage1.Controls.Add(this.apply_edit);
            this.tabPage1.Controls.Add(this.edit);
            this.tabPage1.Controls.Add(this.edit_button);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.checkout);
            this.tabPage1.Controls.Add(this.add);
            this.tabPage1.Controls.Add(this.menuch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.waiter);
            this.tabPage1.Controls.Add(this.details);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить заказ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // new_order
            // 
            this.new_order.Location = new System.Drawing.Point(502, 523);
            this.new_order.Name = "new_order";
            this.new_order.Size = new System.Drawing.Size(183, 70);
            this.new_order.TabIndex = 14;
            this.new_order.Text = "Новый чек";
            this.new_order.UseVisualStyleBackColor = true;
            this.new_order.Click += new System.EventHandler(this.new_order_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(412, 174);
            this.amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(73, 22);
            this.amount.TabIndex = 13;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errase
            // 
            this.errase.Location = new System.Drawing.Point(502, 318);
            this.errase.Name = "errase";
            this.errase.Size = new System.Drawing.Size(183, 70);
            this.errase.TabIndex = 12;
            this.errase.Text = "Аннулировать чек";
            this.errase.UseVisualStyleBackColor = true;
            this.errase.Click += new System.EventHandler(this.errase_Click);
            // 
            // apply_edit
            // 
            this.apply_edit.Location = new System.Drawing.Point(502, 242);
            this.apply_edit.Name = "apply_edit";
            this.apply_edit.Size = new System.Drawing.Size(183, 70);
            this.apply_edit.TabIndex = 12;
            this.apply_edit.Text = "Применить измененя ";
            this.apply_edit.UseVisualStyleBackColor = true;
            this.apply_edit.Click += new System.EventHandler(this.apply_edit_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(134, 523);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 22);
            this.edit.TabIndex = 11;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(240, 520);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(245, 29);
            this.edit_button.TabIndex = 10;
            this.edit_button.Text = "Номер позиции для изменения ";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Меню";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Комментарий";
            // 
            // checkout
            // 
            this.checkout.Location = new System.Drawing.Point(134, 603);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(551, 70);
            this.checkout.TabIndex = 7;
            this.checkout.Text = "Чек-релиз";
            this.checkout.UseVisualStyleBackColor = true;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(502, 166);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(183, 70);
            this.add.TabIndex = 6;
            this.add.Text = "Добавить позицию";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // menuch
            // 
            this.menuch.FormattingEnabled = true;
            this.menuch.Location = new System.Drawing.Point(134, 171);
            this.menuch.Name = "menuch";
            this.menuch.Size = new System.Drawing.Size(272, 24);
            this.menuch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "официант";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.Waiter_code);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tip);
            this.tabPage2.Controls.Add(this.new_pay);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.discount1);
            this.tabPage2.Controls.Add(this.discount);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.choise);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оплата ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Скидка";
            // 
            // discount1
            // 
            this.discount1.Location = new System.Drawing.Point(245, 354);
            this.discount1.Name = "discount1";
            this.discount1.Size = new System.Drawing.Size(126, 22);
            this.discount1.TabIndex = 5;
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(393, 359);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(126, 51);
            this.discount.TabIndex = 4;
            this.discount.Text = "Перерасчет";
            this.discount.UseVisualStyleBackColor = true;
            this.discount.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(20, 470);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(674, 191);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.back);
            this.tabPage3.Controls.Add(this.pay1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.final1);
            this.tabPage3.Controls.Add(this.sumforpay1);
            this.tabPage3.Controls.Add(this.put);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(666, 162);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Наличные";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "С учетом скидки ";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(53, 109);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 22);
            this.back.TabIndex = 10;
            // 
            // pay1
            // 
            this.pay1.Location = new System.Drawing.Point(365, 55);
            this.pay1.Name = "pay1";
            this.pay1.Size = new System.Drawing.Size(126, 51);
            this.pay1.TabIndex = 4;
            this.pay1.Text = "enter";
            this.pay1.UseVisualStyleBackColor = true;
            this.pay1.Click += new System.EventHandler(this.pay1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сдача";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Итого";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Внесено";
            // 
            // final1
            // 
            this.final1.Location = new System.Drawing.Point(53, 81);
            this.final1.Name = "final1";
            this.final1.Size = new System.Drawing.Size(126, 22);
            this.final1.TabIndex = 6;
            // 
            // sumforpay1
            // 
            this.sumforpay1.Location = new System.Drawing.Point(53, 56);
            this.sumforpay1.Name = "sumforpay1";
            this.sumforpay1.Size = new System.Drawing.Size(126, 22);
            this.sumforpay1.TabIndex = 5;
            // 
            // put
            // 
            this.put.Location = new System.Drawing.Point(53, 28);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(126, 22);
            this.put.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.final);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.sumforpay2);
            this.tabPage4.Controls.Add(this.cardnumber);
            this.tabPage4.Controls.Add(this.cardholder);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(666, 162);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Плата  картой";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(261, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Со скидкой";
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(129, 126);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(126, 22);
            this.final.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Итого";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Номер карты";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Владелец";
            // 
            // sumforpay2
            // 
            this.sumforpay2.Location = new System.Drawing.Point(129, 98);
            this.sumforpay2.Name = "sumforpay2";
            this.sumforpay2.Size = new System.Drawing.Size(126, 22);
            this.sumforpay2.TabIndex = 13;
            // 
            // cardnumber
            // 
            this.cardnumber.Location = new System.Drawing.Point(129, 70);
            this.cardnumber.Name = "cardnumber";
            this.cardnumber.Size = new System.Drawing.Size(126, 22);
            this.cardnumber.TabIndex = 12;
            // 
            // cardholder
            // 
            this.cardholder.Location = new System.Drawing.Point(129, 42);
            this.cardholder.Name = "cardholder";
            this.cardholder.Size = new System.Drawing.Size(126, 22);
            this.cardholder.TabIndex = 11;
            // 
            // choise
            // 
            this.choise.Location = new System.Drawing.Point(20, 354);
            this.choise.Name = "choise";
            this.choise.Size = new System.Drawing.Size(126, 22);
            this.choise.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeorderDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.wayofpaymentDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.timecontrolDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(733, 1);
            this.order.Multiline = true;
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(462, 719);
            this.order.TabIndex = 4;
            // 
            // new_pay
            // 
            this.new_pay.Location = new System.Drawing.Point(525, 359);
            this.new_pay.Name = "new_pay";
            this.new_pay.Size = new System.Drawing.Size(126, 51);
            this.new_pay.TabIndex = 11;
            this.new_pay.Text = "Новый платеж";
            this.new_pay.UseVisualStyleBackColor = true;
            this.new_pay.Click += new System.EventHandler(this.new_pay_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Чаевые";
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(245, 390);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(126, 22);
            this.tip.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(152, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Waiter_code";
            // 
            // Waiter_code
            // 
            this.Waiter_code.Location = new System.Drawing.Point(245, 418);
            this.Waiter_code.Name = "Waiter_code";
            this.Waiter_code.Size = new System.Drawing.Size(126, 22);
            this.Waiter_code.TabIndex = 14;
            // 
            // restDataSet
            // 
            this.restDataSet.DataSetName = "restDataSet";
            this.restDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.restDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // idOrderDataGridViewTextBoxColumn
            // 
            this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "idOrder";
            this.idOrderDataGridViewTextBoxColumn.HeaderText = "idOrder";
            this.idOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
            this.idOrderDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeorderDataGridViewTextBoxColumn
            // 
            this.timeorderDataGridViewTextBoxColumn.DataPropertyName = "time_order";
            this.timeorderDataGridViewTextBoxColumn.HeaderText = "time_order";
            this.timeorderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeorderDataGridViewTextBoxColumn.Name = "timeorderDataGridViewTextBoxColumn";
            this.timeorderDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "payment";
            this.paymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.Width = 125;
            // 
            // wayofpaymentDataGridViewTextBoxColumn
            // 
            this.wayofpaymentDataGridViewTextBoxColumn.DataPropertyName = "wayofpayment";
            this.wayofpaymentDataGridViewTextBoxColumn.HeaderText = "wayofpayment";
            this.wayofpaymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wayofpaymentDataGridViewTextBoxColumn.Name = "wayofpaymentDataGridViewTextBoxColumn";
            this.wayofpaymentDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timecontrolDataGridViewTextBoxColumn
            // 
            this.timecontrolDataGridViewTextBoxColumn.DataPropertyName = "time_control";
            this.timecontrolDataGridViewTextBoxColumn.HeaderText = "time_control";
            this.timecontrolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timecontrolDataGridViewTextBoxColumn.Name = "timecontrolDataGridViewTextBoxColumn";
            this.timecontrolDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // waiter_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 762);
            this.Controls.Add(this.order);
            this.Controls.Add(this.tabControl1);
            this.Name = "waiter_menu";
            this.Text = "waiter_menu";
            this.Load += new System.EventHandler(this.waiter_menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox waiter;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox menuch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button apply_edit;
        private System.Windows.Forms.TextBox edit;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Button new_order;
        private System.Windows.Forms.Button errase;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox final1;
        private System.Windows.Forms.TextBox sumforpay1;
        private System.Windows.Forms.TextBox put;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox choise;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pay1;
        private System.Windows.Forms.TextBox order;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sumforpay2;
        private System.Windows.Forms.TextBox cardnumber;
        private System.Windows.Forms.TextBox cardholder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox discount1;
        private System.Windows.Forms.Button discount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox back;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox final;
        private System.Windows.Forms.Button new_pay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Waiter_code;
        private restDataSet restDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private restDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wayofpaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timecontrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}