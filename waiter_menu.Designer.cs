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
            this.waiter = new System.Windows.Forms.ComboBox();
            this.details = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.menuch = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.checkout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.TextBox();
            this.apply_edit = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.new_order = new System.Windows.Forms.Button();
            this.errase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.choise = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.put = new System.Windows.Forms.TextBox();
            this.sumforpay1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pay1 = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            // tabPage2
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "официант";
            // 
            // menuch
            // 
            this.menuch.FormattingEnabled = true;
            this.menuch.Location = new System.Drawing.Point(134, 171);
            this.menuch.Name = "menuch";
            this.menuch.Size = new System.Drawing.Size(272, 24);
            this.menuch.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Комментарий";
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
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(134, 523);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 22);
            this.edit.TabIndex = 11;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 348);
            this.dataGridView1.TabIndex = 0;
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
            // choise
            // 
            this.choise.Location = new System.Drawing.Point(20, 354);
            this.choise.Name = "choise";
            this.choise.Size = new System.Drawing.Size(126, 22);
            this.choise.TabIndex = 2;
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
            this.tabPage3.Controls.Add(this.pay1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBox3);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(666, 162);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Плата  картой";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // put
            // 
            this.put.Location = new System.Drawing.Point(145, 42);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(126, 22);
            this.put.TabIndex = 4;
            // 
            // sumforpay1
            // 
            this.sumforpay1.Location = new System.Drawing.Point(145, 70);
            this.sumforpay1.Name = "sumforpay1";
            this.sumforpay1.Size = new System.Drawing.Size(126, 22);
            this.sumforpay1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Внесено";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Итого";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сдача";
            // 
            // pay1
            // 
            this.pay1.Location = new System.Drawing.Point(427, 56);
            this.pay1.Name = "pay1";
            this.pay1.Size = new System.Drawing.Size(126, 51);
            this.pay1.TabIndex = 4;
            this.pay1.Text = "enter";
            this.pay1.UseVisualStyleBackColor = true;
            this.pay1.Click += new System.EventHandler(this.pay1_Click);
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(733, 1);
            this.order.Multiline = true;
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(462, 719);
            this.order.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "enter";
            this.button2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 22);
            this.textBox4.TabIndex = 11;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox3;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
    }
}