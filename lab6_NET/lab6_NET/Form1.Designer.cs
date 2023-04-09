namespace lab6_NET
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InfoAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTeachers = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoAbout,
            this.CloseAbout,
            this.Close,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InfoAbout
            // 
            this.InfoAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutTeachers,
            this.AboutStudents});
            this.InfoAbout.Name = "InfoAbout";
            this.InfoAbout.Size = new System.Drawing.Size(71, 20);
            this.InfoAbout.Text = "Сведения";
            // 
            // AboutTeachers
            // 
            this.AboutTeachers.Name = "AboutTeachers";
            this.AboutTeachers.Size = new System.Drawing.Size(174, 22);
            this.AboutTeachers.Text = "О преподавателях";
            this.AboutTeachers.Click += new System.EventHandler(this.AboutTeachers_Click);
            // 
            // AboutStudents
            // 
            this.AboutStudents.Name = "AboutStudents";
            this.AboutStudents.Size = new System.Drawing.Size(174, 22);
            this.AboutStudents.Text = "О студентах";
            this.AboutStudents.Click += new System.EventHandler(this.AboutStudents_Click);
            // 
            // CloseAbout
            // 
            this.CloseAbout.Name = "CloseAbout";
            this.CloseAbout.Size = new System.Drawing.Size(107, 20);
            this.CloseAbout.Text = "Свернуть в трей";
            this.CloseAbout.Click += new System.EventHandler(this.CloseAbout_Click);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(65, 20);
            this.Close.Text = "Закрыть";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(54, 20);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "lab6_NET";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InfoAbout;
        private System.Windows.Forms.ToolStripMenuItem AboutTeachers;
        private System.Windows.Forms.ToolStripMenuItem AboutStudents;
        private System.Windows.Forms.ToolStripMenuItem CloseAbout;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

