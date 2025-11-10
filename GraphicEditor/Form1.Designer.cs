namespace GraphicEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rectangle_btn = new System.Windows.Forms.Button();
            this.Circle_btn = new System.Windows.Forms.Button();
            this.Move_btn = new System.Windows.Forms.Button();
            this.Thick_btn = new System.Windows.Forms.Button();
            this.Shadow_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(136, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 416);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Rectangle_btn
            // 
            this.Rectangle_btn.Location = new System.Drawing.Point(8, 22);
            this.Rectangle_btn.Name = "Rectangle_btn";
            this.Rectangle_btn.Size = new System.Drawing.Size(122, 23);
            this.Rectangle_btn.TabIndex = 1;
            this.Rectangle_btn.Text = "Квадрат";
            this.Rectangle_btn.UseVisualStyleBackColor = true;
            this.Rectangle_btn.Click += new System.EventHandler(this.Rectangle_btn_Click);
            // 
            // Circle_btn
            // 
            this.Circle_btn.Location = new System.Drawing.Point(8, 51);
            this.Circle_btn.Name = "Circle_btn";
            this.Circle_btn.Size = new System.Drawing.Size(122, 23);
            this.Circle_btn.TabIndex = 2;
            this.Circle_btn.Text = "Круг";
            this.Circle_btn.UseVisualStyleBackColor = true;
            this.Circle_btn.Click += new System.EventHandler(this.Circle_btn_Click);
            // 
            // Move_btn
            // 
            this.Move_btn.Location = new System.Drawing.Point(8, 80);
            this.Move_btn.Name = "Move_btn";
            this.Move_btn.Size = new System.Drawing.Size(122, 23);
            this.Move_btn.TabIndex = 3;
            this.Move_btn.Text = "Двигать";
            this.Move_btn.UseVisualStyleBackColor = true;
            this.Move_btn.Click += new System.EventHandler(this.Move_btn_Click);
            // 
            // Thick_btn
            // 
            this.Thick_btn.Location = new System.Drawing.Point(136, 473);
            this.Thick_btn.Name = "Thick_btn";
            this.Thick_btn.Size = new System.Drawing.Size(122, 23);
            this.Thick_btn.TabIndex = 5;
            this.Thick_btn.Text = "Толщина";
            this.Thick_btn.UseVisualStyleBackColor = true;
            this.Thick_btn.Click += new System.EventHandler(this.Thick_btn_Click);
            // 
            // Shadow_btn
            // 
            this.Shadow_btn.Location = new System.Drawing.Point(136, 444);
            this.Shadow_btn.Name = "Shadow_btn";
            this.Shadow_btn.Size = new System.Drawing.Size(122, 23);
            this.Shadow_btn.TabIndex = 4;
            this.Shadow_btn.Text = "Тень";
            this.Shadow_btn.UseVisualStyleBackColor = true;
            this.Shadow_btn.Click += new System.EventHandler(this.Shadow_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.Thick_btn);
            this.Controls.Add(this.Shadow_btn);
            this.Controls.Add(this.Move_btn);
            this.Controls.Add(this.Circle_btn);
            this.Controls.Add(this.Rectangle_btn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Rectangle_btn;
        private System.Windows.Forms.Button Circle_btn;
        private System.Windows.Forms.Button Move_btn;
        private System.Windows.Forms.Button Thick_btn;
        private System.Windows.Forms.Button Shadow_btn;
    }
}

