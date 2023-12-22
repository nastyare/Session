namespace Session
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
            this.halfButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.intergalsButton = new System.Windows.Forms.Button();
            this.slauButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // halfButton
            // 
            this.halfButton.Location = new System.Drawing.Point(140, 52);
            this.halfButton.Name = "halfButton";
            this.halfButton.Size = new System.Drawing.Size(121, 55);
            this.halfButton.TabIndex = 0;
            this.halfButton.Text = " Дихотомия";
            this.halfButton.UseVisualStyleBackColor = true;
            this.halfButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(140, 128);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(122, 44);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "Ньютон";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(306, 267);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(121, 43);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Сортировки";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // decButton
            // 
            this.decButton.Location = new System.Drawing.Point(141, 199);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(121, 46);
            this.decButton.TabIndex = 3;
            this.decButton.Text = "Спуск";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // intergalsButton
            // 
            this.intergalsButton.Location = new System.Drawing.Point(462, 52);
            this.intergalsButton.Name = "intergalsButton";
            this.intergalsButton.Size = new System.Drawing.Size(116, 55);
            this.intergalsButton.TabIndex = 4;
            this.intergalsButton.Text = "Интегралы";
            this.intergalsButton.UseVisualStyleBackColor = true;
            this.intergalsButton.Click += new System.EventHandler(this.intergalsButton_Click);
            // 
            // slauButton
            // 
            this.slauButton.Location = new System.Drawing.Point(462, 128);
            this.slauButton.Name = "slauButton";
            this.slauButton.Size = new System.Drawing.Size(116, 44);
            this.slauButton.TabIndex = 5;
            this.slauButton.Text = "СЛАУ";
            this.slauButton.UseVisualStyleBackColor = true;
            this.slauButton.Click += new System.EventHandler(this.slauButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(462, 199);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(116, 43);
            this.squareButton.TabIndex = 6;
            this.squareButton.Text = "Квадраты";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.slauButton);
            this.Controls.Add(this.intergalsButton);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.halfButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button halfButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Button intergalsButton;
        private System.Windows.Forms.Button slauButton;
        private System.Windows.Forms.Button squareButton;
    }
}

