namespace Lab6cSharp
{
    partial class Applications
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstAnimals = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnAscending = new System.Windows.Forms.RadioButton();
            this.rbtnDescending = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "CreateWolf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Clone";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // lstAnimals
            // 
            this.lstAnimals.FormattingEnabled = true;
            this.lstAnimals.Location = new System.Drawing.Point(12, 12);
            this.lstAnimals.Name = "lstAnimals";
            this.lstAnimals.Size = new System.Drawing.Size(309, 303);
            this.lstAnimals.TabIndex = 13;
            this.lstAnimals.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstAnimals_Format);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(340, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "CreateLion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(340, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 34);
            this.button5.TabIndex = 15;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnDescending);
            this.panel2.Controls.Add(this.rbtnAscending);
            this.panel2.Location = new System.Drawing.Point(327, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 46);
            this.panel2.TabIndex = 19;
            // 
            // rbtnAscending
            // 
            this.rbtnAscending.AutoSize = true;
            this.rbtnAscending.Checked = true;
            this.rbtnAscending.Location = new System.Drawing.Point(4, 4);
            this.rbtnAscending.Name = "rbtnAscending";
            this.rbtnAscending.Size = new System.Drawing.Size(96, 17);
            this.rbtnAscending.TabIndex = 0;
            this.rbtnAscending.TabStop = true;
            this.rbtnAscending.Text = "Сорт по зрост";
            this.rbtnAscending.UseVisualStyleBackColor = true;
            this.rbtnAscending.CheckedChanged += new System.EventHandler(this.rbtnAscending_CheckedChanged);
            // 
            // rbtnDescending
            // 
            this.rbtnDescending.AutoSize = true;
            this.rbtnDescending.Location = new System.Drawing.Point(4, 26);
            this.rbtnDescending.Name = "rbtnDescending";
            this.rbtnDescending.Size = new System.Drawing.Size(91, 17);
            this.rbtnDescending.TabIndex = 1;
            this.rbtnDescending.TabStop = true;
            this.rbtnDescending.Text = "Сорт по спад";
            this.rbtnDescending.UseVisualStyleBackColor = true;
            this.rbtnDescending.CheckedChanged += new System.EventHandler(this.rbtnDescending_CheckedChanged);
            // 
            // Applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 333);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lstAnimals);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Applications";
            this.Text = "Application";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstAnimals;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnDescending;
        private System.Windows.Forms.RadioButton rbtnAscending;
    }
}

