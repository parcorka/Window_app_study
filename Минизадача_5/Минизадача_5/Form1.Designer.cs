namespace Минизадача_1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборФигурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.треуголькникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.выборЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборФигурыToolStripMenuItem,
            this.выборЦветаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборФигурыToolStripMenuItem
            // 
            this.выборФигурыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кругToolStripMenuItem,
            this.квадратToolStripMenuItem,
            this.треуголькникToolStripMenuItem});
            this.выборФигурыToolStripMenuItem.Name = "выборФигурыToolStripMenuItem";
            this.выборФигурыToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.выборФигурыToolStripMenuItem.Text = "выбор фигуры";
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Checked = true;
            this.кругToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кругToolStripMenuItem.Text = "круг";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.кругToolStripMenuItem_Click);
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.квадратToolStripMenuItem.Text = "квадрат";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.квадратToolStripMenuItem_Click);
            // 
            // треуголькникToolStripMenuItem
            // 
            this.треуголькникToolStripMenuItem.Name = "треуголькникToolStripMenuItem";
            this.треуголькникToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.треуголькникToolStripMenuItem.Text = "треуголькник";
            this.треуголькникToolStripMenuItem.Click += new System.EventHandler(this.треуголькникToolStripMenuItem_Click);
            // 
            // выборЦветаToolStripMenuItem
            // 
            this.выборЦветаToolStripMenuItem.Name = "выборЦветаToolStripMenuItem";
            this.выборЦветаToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.выборЦветаToolStripMenuItem.Text = "выбор цвета";
            this.выборЦветаToolStripMenuItem.Click += new System.EventHandler(this.выборЦветаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Задачка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборФигурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem треуголькникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЦветаToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

