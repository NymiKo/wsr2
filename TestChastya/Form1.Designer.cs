namespace TestChastya
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
            this.labelTestChastya = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelStart = new System.Windows.Forms.Panel();
            this.panelVopros = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.radioBtnVariant4 = new System.Windows.Forms.RadioButton();
            this.radioBtnVariant3 = new System.Windows.Forms.RadioButton();
            this.radioBtnVariant2 = new System.Windows.Forms.RadioButton();
            this.radioBtnVariant1 = new System.Windows.Forms.RadioButton();
            this.labelVariant = new System.Windows.Forms.Label();
            this.panelEnd = new System.Windows.Forms.Panel();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.btnReturnStart = new System.Windows.Forms.Button();
            this.panelStart.SuspendLayout();
            this.panelVopros.SuspendLayout();
            this.panelEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTestChastya
            // 
            this.labelTestChastya.AutoSize = true;
            this.labelTestChastya.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestChastya.Location = new System.Drawing.Point(31, 29);
            this.labelTestChastya.Name = "labelTestChastya";
            this.labelTestChastya.Size = new System.Drawing.Size(246, 39);
            this.labelTestChastya.TabIndex = 0;
            this.labelTestChastya.Text = "Тест Счастья";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(71, 104);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(162, 50);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Начать тест";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.labelTestChastya);
            this.panelStart.Controls.Add(this.buttonStart);
            this.panelStart.Location = new System.Drawing.Point(12, 12);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(299, 191);
            this.panelStart.TabIndex = 2;
            // 
            // panelVopros
            // 
            this.panelVopros.Controls.Add(this.btnNext);
            this.panelVopros.Controls.Add(this.radioBtnVariant4);
            this.panelVopros.Controls.Add(this.radioBtnVariant3);
            this.panelVopros.Controls.Add(this.radioBtnVariant2);
            this.panelVopros.Controls.Add(this.radioBtnVariant1);
            this.panelVopros.Controls.Add(this.labelVariant);
            this.panelVopros.Location = new System.Drawing.Point(12, 12);
            this.panelVopros.Name = "panelVopros";
            this.panelVopros.Size = new System.Drawing.Size(803, 262);
            this.panelVopros.TabIndex = 3;
            this.panelVopros.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(656, 211);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 38);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // radioBtnVariant4
            // 
            this.radioBtnVariant4.AutoSize = true;
            this.radioBtnVariant4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnVariant4.Location = new System.Drawing.Point(31, 149);
            this.radioBtnVariant4.Name = "radioBtnVariant4";
            this.radioBtnVariant4.Size = new System.Drawing.Size(113, 28);
            this.radioBtnVariant4.TabIndex = 4;
            this.radioBtnVariant4.TabStop = true;
            this.radioBtnVariant4.Text = "Вариант1";
            this.radioBtnVariant4.UseVisualStyleBackColor = true;
            // 
            // radioBtnVariant3
            // 
            this.radioBtnVariant3.AutoSize = true;
            this.radioBtnVariant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnVariant3.Location = new System.Drawing.Point(31, 113);
            this.radioBtnVariant3.Name = "radioBtnVariant3";
            this.radioBtnVariant3.Size = new System.Drawing.Size(113, 28);
            this.radioBtnVariant3.TabIndex = 3;
            this.radioBtnVariant3.TabStop = true;
            this.radioBtnVariant3.Text = "Вариант1";
            this.radioBtnVariant3.UseVisualStyleBackColor = true;
            // 
            // radioBtnVariant2
            // 
            this.radioBtnVariant2.AutoSize = true;
            this.radioBtnVariant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnVariant2.Location = new System.Drawing.Point(31, 76);
            this.radioBtnVariant2.Name = "radioBtnVariant2";
            this.radioBtnVariant2.Size = new System.Drawing.Size(113, 28);
            this.radioBtnVariant2.TabIndex = 2;
            this.radioBtnVariant2.TabStop = true;
            this.radioBtnVariant2.Text = "Вариант1";
            this.radioBtnVariant2.UseVisualStyleBackColor = true;
            // 
            // radioBtnVariant1
            // 
            this.radioBtnVariant1.AutoSize = true;
            this.radioBtnVariant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnVariant1.Location = new System.Drawing.Point(31, 40);
            this.radioBtnVariant1.Name = "radioBtnVariant1";
            this.radioBtnVariant1.Size = new System.Drawing.Size(113, 28);
            this.radioBtnVariant1.TabIndex = 1;
            this.radioBtnVariant1.Text = "Вариант1";
            this.radioBtnVariant1.UseVisualStyleBackColor = true;
            // 
            // labelVariant
            // 
            this.labelVariant.AutoSize = true;
            this.labelVariant.Location = new System.Drawing.Point(93, 31);
            this.labelVariant.Name = "labelVariant";
            this.labelVariant.Size = new System.Drawing.Size(0, 13);
            this.labelVariant.TabIndex = 0;
            // 
            // panelEnd
            // 
            this.panelEnd.Controls.Add(this.btnReturnStart);
            this.panelEnd.Controls.Add(this.labelScore);
            this.panelEnd.Controls.Add(this.labelEnd);
            this.panelEnd.Location = new System.Drawing.Point(12, 12);
            this.panelEnd.Name = "panelEnd";
            this.panelEnd.Size = new System.Drawing.Size(381, 236);
            this.panelEnd.TabIndex = 4;
            this.panelEnd.Visible = false;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnd.Location = new System.Drawing.Point(140, 31);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(98, 31);
            this.labelEnd.TabIndex = 0;
            this.labelEnd.Text = "Конец";
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(14, 81);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(350, 50);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "label1";
            // 
            // btnReturnStart
            // 
            this.btnReturnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnStart.Location = new System.Drawing.Point(124, 149);
            this.btnReturnStart.Name = "btnReturnStart";
            this.btnReturnStart.Size = new System.Drawing.Size(133, 49);
            this.btnReturnStart.TabIndex = 2;
            this.btnReturnStart.Text = "К началу";
            this.btnReturnStart.UseVisualStyleBackColor = true;
            this.btnReturnStart.Click += new System.EventHandler(this.btnReturnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 214);
            this.Controls.Add(this.panelEnd);
            this.Controls.Add(this.panelVopros);
            this.Controls.Add(this.panelStart);
            this.Name = "Form1";
            this.Text = "Тест счастья";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelVopros.ResumeLayout(false);
            this.panelVopros.PerformLayout();
            this.panelEnd.ResumeLayout(false);
            this.panelEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTestChastya;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Panel panelVopros;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton radioBtnVariant4;
        private System.Windows.Forms.RadioButton radioBtnVariant3;
        private System.Windows.Forms.RadioButton radioBtnVariant2;
        private System.Windows.Forms.RadioButton radioBtnVariant1;
        private System.Windows.Forms.Label labelVariant;
        private System.Windows.Forms.Panel panelEnd;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Button btnReturnStart;
    }
}

