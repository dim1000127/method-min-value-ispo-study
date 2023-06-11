namespace MethodMinValue
{
    partial class Form1
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownCol = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.Calculate = new System.Windows.Forms.Button();
            this.listBoxSteps = new System.Windows.Forms.ListBox();
            this.ClearTableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.Size = new System.Drawing.Size(465, 321);
            this.dataGridView2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Потребности(bj)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Запасы(ai)";
            // 
            // numericUpDownCol
            // 
            this.numericUpDownCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCol.Location = new System.Drawing.Point(171, 77);
            this.numericUpDownCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCol.Name = "numericUpDownCol";
            this.numericUpDownCol.Size = new System.Drawing.Size(51, 26);
            this.numericUpDownCol.TabIndex = 29;
            this.numericUpDownCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCol.ValueChanged += new System.EventHandler(this.numericUpDownCol_ValueChanged);
            // 
            // numericUpDownRow
            // 
            this.numericUpDownRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRow.Location = new System.Drawing.Point(171, 32);
            this.numericUpDownRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRow.Name = "numericUpDownRow";
            this.numericUpDownRow.Size = new System.Drawing.Size(51, 26);
            this.numericUpDownRow.TabIndex = 28;
            this.numericUpDownRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRow.ValueChanged += new System.EventHandler(this.numericUpDownRow_ValueChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(263, 47);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(95, 50);
            this.Calculate.TabIndex = 32;
            this.Calculate.Text = "Рассчитать опорный план";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // listBoxSteps
            // 
            this.listBoxSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSteps.FormattingEnabled = true;
            this.listBoxSteps.ItemHeight = 16;
            this.listBoxSteps.Location = new System.Drawing.Point(525, 117);
            this.listBoxSteps.Name = "listBoxSteps";
            this.listBoxSteps.Size = new System.Drawing.Size(320, 308);
            this.listBoxSteps.TabIndex = 33;
            // 
            // ClearTableButton
            // 
            this.ClearTableButton.Location = new System.Drawing.Point(405, 47);
            this.ClearTableButton.Name = "ClearTableButton";
            this.ClearTableButton.Size = new System.Drawing.Size(95, 50);
            this.ClearTableButton.TabIndex = 34;
            this.ClearTableButton.Text = "Очистить таблицу и список";
            this.ClearTableButton.UseVisualStyleBackColor = true;
            this.ClearTableButton.Click += new System.EventHandler(this.ClearTableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.ClearTableButton);
            this.Controls.Add(this.listBoxSteps);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownCol);
            this.Controls.Add(this.numericUpDownRow);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownCol;
        private System.Windows.Forms.NumericUpDown numericUpDownRow;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ListBox listBoxSteps;
        private System.Windows.Forms.Button ClearTableButton;
    }
}

