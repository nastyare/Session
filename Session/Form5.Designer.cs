namespace Session
{
    partial class Form5
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
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowHeadersWidth = 51;
            this.dataGridViewA.RowTemplate.Height = 24;
            this.dataGridViewA.Size = new System.Drawing.Size(369, 283);
            this.dataGridViewA.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(859, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Excel 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(772, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Excel 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(403, 390);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Метод Крамера";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(403, 470);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(119, 20);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Метод Гаусса";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(403, 549);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(184, 20);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Метод Жордана-Гаусса";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // menuStrip3
            // 
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1012, 29);
            this.menuStrip3.TabIndex = 7;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.calculateToolStripMenuItem.Text = "Рассчитать";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.deleteToolStripMenuItem.Text = "Очистить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 360);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 254);
            this.textBox2.TabIndex = 13;
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Location = new System.Drawing.Point(403, 60);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersWidth = 51;
            this.dataGridViewB.RowTemplate.Height = 24;
            this.dataGridViewB.Size = new System.Drawing.Size(176, 283);
            this.dataGridViewB.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Размер матрицы для генерации:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 646);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.dataGridViewA);
            this.Name = "Form5";
            this.Text = "СЛАУ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridViewB;
        private System.Windows.Forms.Label label1;
    }
}