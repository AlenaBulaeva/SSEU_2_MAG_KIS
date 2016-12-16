namespace Sotrudnik
{
    partial class FormSotrudnik
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelDR = new System.Windows.Forms.Label();
            this.labelDolgn = new System.Windows.Forms.Label();
            this.labelOklad = new System.Windows.Forms.Label();
            this.radioButtonSovm = new System.Windows.Forms.RadioButton();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxDR = new System.Windows.Forms.TextBox();
            this.textBoxDolgn = new System.Windows.Forms.TextBox();
            this.textBoxOklad = new System.Windows.Forms.TextBox();
            this.radioButtonNeSovm = new System.Windows.Forms.RadioButton();
            this.textBoxSotrudnikInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(12, 17);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // labelDR
            // 
            this.labelDR.AutoSize = true;
            this.labelDR.Location = new System.Drawing.Point(12, 41);
            this.labelDR.Name = "labelDR";
            this.labelDR.Size = new System.Drawing.Size(87, 13);
            this.labelDR.TabIndex = 1;
            this.labelDR.Text = "День рождения";
            // 
            // labelDolgn
            // 
            this.labelDolgn.AutoSize = true;
            this.labelDolgn.Location = new System.Drawing.Point(12, 67);
            this.labelDolgn.Name = "labelDolgn";
            this.labelDolgn.Size = new System.Drawing.Size(65, 13);
            this.labelDolgn.TabIndex = 2;
            this.labelDolgn.Text = "Должность";
            // 
            // labelOklad
            // 
            this.labelOklad.AutoSize = true;
            this.labelOklad.Location = new System.Drawing.Point(12, 94);
            this.labelOklad.Name = "labelOklad";
            this.labelOklad.Size = new System.Drawing.Size(39, 13);
            this.labelOklad.TabIndex = 3;
            this.labelOklad.Text = "Оклад";
            // 
            // radioButtonSovm
            // 
            this.radioButtonSovm.AutoSize = true;
            this.radioButtonSovm.Checked = true;
            this.radioButtonSovm.Location = new System.Drawing.Point(15, 117);
            this.radioButtonSovm.Name = "radioButtonSovm";
            this.radioButtonSovm.Size = new System.Drawing.Size(136, 17);
            this.radioButtonSovm.TabIndex = 4;
            this.radioButtonSovm.TabStop = true;
            this.radioButtonSovm.Text = "По совместительству";
            this.radioButtonSovm.UseVisualStyleBackColor = true;
            this.radioButtonSovm.CheckedChanged += new System.EventHandler(this.radioButtonSovm_CheckedChanged);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(52, 12);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(220, 20);
            this.textBoxFIO.TabIndex = 5;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // textBoxDR
            // 
            this.textBoxDR.Location = new System.Drawing.Point(105, 38);
            this.textBoxDR.Name = "textBoxDR";
            this.textBoxDR.Size = new System.Drawing.Size(100, 20);
            this.textBoxDR.TabIndex = 6;
            this.textBoxDR.TextChanged += new System.EventHandler(this.textBoxDR_TextChanged);
            // 
            // textBoxDolgn
            // 
            this.textBoxDolgn.Location = new System.Drawing.Point(83, 64);
            this.textBoxDolgn.Name = "textBoxDolgn";
            this.textBoxDolgn.Size = new System.Drawing.Size(100, 20);
            this.textBoxDolgn.TabIndex = 7;
            this.textBoxDolgn.TextChanged += new System.EventHandler(this.textBoxDolgn_TextChanged);
            // 
            // textBoxOklad
            // 
            this.textBoxOklad.Location = new System.Drawing.Point(57, 91);
            this.textBoxOklad.Name = "textBoxOklad";
            this.textBoxOklad.Size = new System.Drawing.Size(100, 20);
            this.textBoxOklad.TabIndex = 8;
            this.textBoxOklad.TextChanged += new System.EventHandler(this.textBoxOklad_TextChanged);
            // 
            // radioButtonNeSovm
            // 
            this.radioButtonNeSovm.AutoSize = true;
            this.radioButtonNeSovm.Location = new System.Drawing.Point(15, 140);
            this.radioButtonNeSovm.Name = "radioButtonNeSovm";
            this.radioButtonNeSovm.Size = new System.Drawing.Size(151, 17);
            this.radioButtonNeSovm.TabIndex = 9;
            this.radioButtonNeSovm.Text = "Не по совместительству";
            this.radioButtonNeSovm.UseVisualStyleBackColor = true;
            // 
            // textBoxSotrudnikInfo
            // 
            this.textBoxSotrudnikInfo.Location = new System.Drawing.Point(12, 163);
            this.textBoxSotrudnikInfo.Multiline = true;
            this.textBoxSotrudnikInfo.Name = "textBoxSotrudnikInfo";
            this.textBoxSotrudnikInfo.ReadOnly = true;
            this.textBoxSotrudnikInfo.Size = new System.Drawing.Size(260, 157);
            this.textBoxSotrudnikInfo.TabIndex = 10;
            // 
            // FormSotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 404);
            this.Controls.Add(this.textBoxSotrudnikInfo);
            this.Controls.Add(this.radioButtonNeSovm);
            this.Controls.Add(this.textBoxOklad);
            this.Controls.Add(this.textBoxDolgn);
            this.Controls.Add(this.textBoxDR);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.radioButtonSovm);
            this.Controls.Add(this.labelOklad);
            this.Controls.Add(this.labelDolgn);
            this.Controls.Add(this.labelDR);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormSotrudnik";
            this.Text = "Сотрудник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelDR;
        private System.Windows.Forms.Label labelDolgn;
        private System.Windows.Forms.Label labelOklad;
        private System.Windows.Forms.RadioButton radioButtonSovm;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxDR;
        private System.Windows.Forms.TextBox textBoxDolgn;
        private System.Windows.Forms.TextBox textBoxOklad;
        private System.Windows.Forms.RadioButton radioButtonNeSovm;
        private System.Windows.Forms.TextBox textBoxSotrudnikInfo;
    }
}

