namespace RestApp
{
    partial class tablecookcs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restDataSet = new RestApp.restDataSet();
            this.restDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.master = new System.Windows.Forms.ComboBox();
            this.Line = new System.Windows.Forms.Button();
            this.idpos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(997, 557);
            this.dataGridView1.TabIndex = 0;
            // 
            // restDataSet
            // 
            this.restDataSet.DataSetName = "restDataSet";
            this.restDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restDataSetBindingSource
            // 
            this.restDataSetBindingSource.DataSource = this.restDataSet;
            this.restDataSetBindingSource.Position = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // master
            // 
            this.master.FormattingEnabled = true;
            this.master.Location = new System.Drawing.Point(1008, 47);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(228, 24);
            this.master.TabIndex = 1;
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(1008, 110);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(192, 52);
            this.Line.TabIndex = 2;
            this.Line.Text = "Отправить в очередь";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // idpos
            // 
            this.idpos.Location = new System.Drawing.Point(1008, 77);
            this.idpos.Name = "idpos";
            this.idpos.Size = new System.Drawing.Size(100, 22);
            this.idpos.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1008, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Новые заказы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1008, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Общий вид";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tablecookcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idpos);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.master);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tablecookcs";
            this.Text = "tablecookcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private restDataSet restDataSet;
        private System.Windows.Forms.BindingSource restDataSetBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox master;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.TextBox idpos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}