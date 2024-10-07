namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.comboBoxShapes = new System.Windows.Forms.ComboBox();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxShapes
            // 
            this.comboBoxShapes.FormattingEnabled = true;
            this.comboBoxShapes.Location = new System.Drawing.Point(22, 12);
            this.comboBoxShapes.Name = "comboBoxShapes";
            this.comboBoxShapes.Size = new System.Drawing.Size(88, 21);
            this.comboBoxShapes.TabIndex = 0;
            this.comboBoxShapes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxShapes_SelectedIndexChanged);
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Location = new System.Drawing.Point(22, 39);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.Size = new System.Drawing.Size(88, 21);
            this.comboBoxColors.TabIndex = 1;
            this.comboBoxColors.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColors_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 309);
            this.Controls.Add(this.comboBoxColors);
            this.Controls.Add(this.comboBoxShapes);
            this.MaximumSize = new System.Drawing.Size(352, 348);
            this.MinimumSize = new System.Drawing.Size(352, 348);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxShapes;
        private System.Windows.Forms.ComboBox comboBoxColors;
    }
}

