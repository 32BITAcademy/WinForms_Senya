namespace WinForms_Senya
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddNewGood = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GoodName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Present = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNewGood
            // 
            this.buttonAddNewGood.Location = new System.Drawing.Point(281, 430);
            this.buttonAddNewGood.Name = "buttonAddNewGood";
            this.buttonAddNewGood.Size = new System.Drawing.Size(267, 40);
            this.buttonAddNewGood.TabIndex = 1;
            this.buttonAddNewGood.Text = "Добавить новый товар";
            this.buttonAddNewGood.UseVisualStyleBackColor = true;
            this.buttonAddNewGood.Click += new System.EventHandler(this.buttonAddNewGood_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodName1,
            this.Present});
            this.dataGridView1.Location = new System.Drawing.Point(93, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(648, 388);
            this.dataGridView1.TabIndex = 2;
            // 
            // GoodName1
            // 
            this.GoodName1.HeaderText = "Название";
            this.GoodName1.Name = "GoodName1";
            this.GoodName1.ReadOnly = true;
            this.GoodName1.Width = 500;
            // 
            // Present
            // 
            this.Present.HeaderText = "В наличии";
            this.Present.Name = "Present";
            this.Present.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddNewGood);
            this.Name = "FormMain";
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodName;
        private System.Windows.Forms.Button buttonAddNewGood;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodName1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Present;
    }
}

