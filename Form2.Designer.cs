namespace Library
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издательстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employee_fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_passport_series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_passport_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_passport_where = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_passport_when = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1249, 30);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.издательстваToolStripMenuItem,
            this.toolStripSeparator1,
            this.сотрудникиToolStripMenuItem,
            this.должностиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // издательстваToolStripMenuItem
            // 
            this.издательстваToolStripMenuItem.Name = "издательстваToolStripMenuItem";
            this.издательстваToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.издательстваToolStripMenuItem.Text = "Сотрудники";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.сотрудникиToolStripMenuItem.Text = "Издательства";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1082, 303);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 35);
            this.button5.TabIndex = 26;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1082, 204);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 35);
            this.button4.TabIndex = 25;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1082, 161);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 35);
            this.button3.TabIndex = 24;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 27);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Справочник Сотрудники";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee_fio,
            this.employee_post,
            this.employee_passport_series,
            this.employee_passport_number,
            this.employee_passport_where,
            this.employee_passport_when});
            this.dataGridView1.Location = new System.Drawing.Point(65, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 361);
            this.dataGridView1.TabIndex = 19;
            // 
            // employee_fio
            // 
            this.employee_fio.HeaderText = "ФИО";
            this.employee_fio.MinimumWidth = 6;
            this.employee_fio.Name = "employee_fio";
            this.employee_fio.ReadOnly = true;
            this.employee_fio.Width = 200;
            // 
            // employee_post
            // 
            this.employee_post.HeaderText = "Должность";
            this.employee_post.MinimumWidth = 6;
            this.employee_post.Name = "employee_post";
            this.employee_post.ReadOnly = true;
            this.employee_post.Width = 150;
            // 
            // employee_passport_series
            // 
            this.employee_passport_series.HeaderText = "Серия паспорта";
            this.employee_passport_series.MinimumWidth = 6;
            this.employee_passport_series.Name = "employee_passport_series";
            this.employee_passport_series.ReadOnly = true;
            this.employee_passport_series.Width = 80;
            // 
            // employee_passport_number
            // 
            this.employee_passport_number.HeaderText = "Номер паспорта";
            this.employee_passport_number.MinimumWidth = 6;
            this.employee_passport_number.Name = "employee_passport_number";
            this.employee_passport_number.ReadOnly = true;
            this.employee_passport_number.Width = 125;
            // 
            // employee_passport_where
            // 
            this.employee_passport_where.HeaderText = "Кем выдан паспорт";
            this.employee_passport_where.MinimumWidth = 6;
            this.employee_passport_where.Name = "employee_passport_where";
            this.employee_passport_where.ReadOnly = true;
            this.employee_passport_where.Width = 200;
            // 
            // employee_passport_when
            // 
            this.employee_passport_when.HeaderText = "Когда выдан паспорт";
            this.employee_passport_when.MinimumWidth = 6;
            this.employee_passport_when.Name = "employee_passport_when";
            this.employee_passport_when.ReadOnly = true;
            this.employee_passport_when.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 601);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem издательстваToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem должностиToolStripMenuItem;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn employee_fio;
        private DataGridViewTextBoxColumn employee_post;
        private DataGridViewTextBoxColumn employee_passport_series;
        private DataGridViewTextBoxColumn employee_passport_number;
        private DataGridViewTextBoxColumn employee_passport_where;
        private DataGridViewTextBoxColumn employee_passport_when;
    }
}