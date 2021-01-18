namespace Project_TPP_ver_2
{
    partial class Polygons
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polygons));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.типыВершинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квдратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.треугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типАлгоритмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОпределениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.джарвисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыВершинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.палитраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.радиусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыВершинToolStripMenuItem,
            this.типАлгоритмаToolStripMenuItem,
            this.параметрыВершинToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // типыВершинToolStripMenuItem
            // 
            this.типыВершинToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кругToolStripMenuItem,
            this.квдратToolStripMenuItem,
            this.треугольникToolStripMenuItem});
            this.типыВершинToolStripMenuItem.Name = "типыВершинToolStripMenuItem";
            this.типыВершинToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.типыВершинToolStripMenuItem.Text = "Тип вершины";
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.кругToolStripMenuItem.Text = "Круг";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.КругToolStripMenuItem_Click);
            // 
            // квдратToolStripMenuItem
            // 
            this.квдратToolStripMenuItem.Name = "квдратToolStripMenuItem";
            this.квдратToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.квдратToolStripMenuItem.Text = "Квдрат";
            this.квдратToolStripMenuItem.Click += new System.EventHandler(this.КвдратToolStripMenuItem_Click);
            // 
            // треугольникToolStripMenuItem
            // 
            this.треугольникToolStripMenuItem.Name = "треугольникToolStripMenuItem";
            this.треугольникToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.треугольникToolStripMenuItem.Text = "Треугольник";
            this.треугольникToolStripMenuItem.Click += new System.EventHandler(this.ТреугольникToolStripMenuItem_Click);
            // 
            // типАлгоритмаToolStripMenuItem
            // 
            this.типАлгоритмаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поОпределениюToolStripMenuItem,
            this.джарвисToolStripMenuItem});
            this.типАлгоритмаToolStripMenuItem.Name = "типАлгоритмаToolStripMenuItem";
            this.типАлгоритмаToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.типАлгоритмаToolStripMenuItem.Text = "Тип алгоритма";
            // 
            // поОпределениюToolStripMenuItem
            // 
            this.поОпределениюToolStripMenuItem.Name = "поОпределениюToolStripMenuItem";
            this.поОпределениюToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.поОпределениюToolStripMenuItem.Text = "По определению";
            this.поОпределениюToolStripMenuItem.Click += new System.EventHandler(this.ПоОпределениюToolStripMenuItem_Click);
            // 
            // джарвисToolStripMenuItem
            // 
            this.джарвисToolStripMenuItem.Name = "джарвисToolStripMenuItem";
            this.джарвисToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.джарвисToolStripMenuItem.Text = "Джарвис";
            this.джарвисToolStripMenuItem.Click += new System.EventHandler(this.ДжарвисToolStripMenuItem_Click);
            // 
            // параметрыВершинToolStripMenuItem
            // 
            this.параметрыВершинToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.палитраToolStripMenuItem,
            this.радиусToolStripMenuItem});
            this.параметрыВершинToolStripMenuItem.Name = "параметрыВершинToolStripMenuItem";
            this.параметрыВершинToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.параметрыВершинToolStripMenuItem.Text = "Параметры вершин";
            // 
            // палитраToolStripMenuItem
            // 
            this.палитраToolStripMenuItem.Name = "палитраToolStripMenuItem";
            this.палитраToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.палитраToolStripMenuItem.Text = "Палитра";
            this.палитраToolStripMenuItem.Click += new System.EventHandler(this.ПалитраToolStripMenuItem_Click);
            // 
            // радиусToolStripMenuItem
            // 
            this.радиусToolStripMenuItem.Name = "радиусToolStripMenuItem";
            this.радиусToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.радиусToolStripMenuItem.Text = "Радиус";
            this.радиусToolStripMenuItem.Click += new System.EventHandler(this.РадиусToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Play";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Stop";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // Polygons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Polygons";
            this.Text = "Polygons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem типыВершинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квдратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem треугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типАлгоритмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОпределениюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem джарвисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыВершинToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem палитраToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem радиусToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

