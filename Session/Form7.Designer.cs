namespace Session
{
    partial class Form7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.расчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.function = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(12, 215);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(741, 302);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            title3.Name = "Title1";
            this.chart1.Titles.Add(title3);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчитатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 29);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // расчитатьToolStripMenuItem
            // 
            this.расчитатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem1});
            this.расчитатьToolStripMenuItem.Name = "расчитатьToolStripMenuItem";
            this.расчитатьToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.расчитатьToolStripMenuItem.Text = "Меню";
            this.расчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.рассчитатьToolStripMenuItem.Text = "Рассчитать";
            this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem1
            // 
            this.очиститьToolStripMenuItem1.Name = "очиститьToolStripMenuItem1";
            this.очиститьToolStripMenuItem1.Size = new System.Drawing.Size(176, 30);
            this.очиститьToolStripMenuItem1.Text = "Очистить";
            this.очиститьToolStripMenuItem1.Click += new System.EventHandler(this.очиститьToolStripMenuItem1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(187, 164);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(535, 166);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 22;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(70, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Минимум:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(379, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Максимум:";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(194, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(350, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "e =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "a =";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(599, 54);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(140, 22);
            this.textBox7.TabIndex = 16;
            // 
            // function
            // 
            this.function.AutoSize = true;
            this.function.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.792F, System.Drawing.FontStyle.Bold);
            this.function.Location = new System.Drawing.Point(503, 54);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(66, 20);
            this.function.TabIndex = 17;
            this.function.Text = "F(x) = ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.function);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox7);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form7";
            this.Text = "Методы";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem расчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label function;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
