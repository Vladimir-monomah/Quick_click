namespace FasrClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_counter = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_counter
            // 
            this.label_counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_counter.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_counter.Location = new System.Drawing.Point(45, 69);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(188, 124);
            this.label_counter.TabIndex = 0;
            this.label_counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_counter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_counter_MouseDown);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(44, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(188, 54);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Начать игру";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_result
            // 
            this.label_result.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.Location = new System.Drawing.Point(42, 193);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(191, 59);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "---";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_counter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Быстрощёлк";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_result;
    }
}

