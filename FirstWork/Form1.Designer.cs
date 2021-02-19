
namespace FirstWork
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Faculty = new System.Windows.Forms.TextBox();
            this.Dean = new System.Windows.Forms.TextBox();
            this.Abbreviation = new System.Windows.Forms.TextBox();
            this.File = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deansNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abbreviationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dean\'s Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Abbreviation:";
            // 
            // Faculty
            // 
            this.Faculty.Enabled = false;
            this.Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Faculty.Location = new System.Drawing.Point(179, 50);
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            this.Faculty.Size = new System.Drawing.Size(184, 26);
            this.Faculty.TabIndex = 3;
            // 
            // Dean
            // 
            this.Dean.Enabled = false;
            this.Dean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dean.Location = new System.Drawing.Point(179, 93);
            this.Dean.Name = "Dean";
            this.Dean.ReadOnly = true;
            this.Dean.Size = new System.Drawing.Size(184, 26);
            this.Dean.TabIndex = 4;
            // 
            // Abbreviation
            // 
            this.Abbreviation.Enabled = false;
            this.Abbreviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Abbreviation.Location = new System.Drawing.Point(179, 136);
            this.Abbreviation.Name = "Abbreviation";
            this.Abbreviation.ReadOnly = true;
            this.Abbreviation.Size = new System.Drawing.Size(184, 26);
            this.Abbreviation.TabIndex = 5;
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(41, 199);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(164, 26);
            this.File.TabIndex = 6;
            this.File.Text = "Append to File";
            this.File.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(233, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Output file name:";
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName.Location = new System.Drawing.Point(226, 199);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(137, 26);
            this.FileName.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editWindowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editWindowsToolStripMenuItem
            // 
            this.editWindowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facultyToolStripMenuItem,
            this.deansNameToolStripMenuItem,
            this.abbreviationToolStripMenuItem});
            this.editWindowsToolStripMenuItem.Name = "editWindowsToolStripMenuItem";
            this.editWindowsToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.editWindowsToolStripMenuItem.Text = "Edit Windows";
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.facultyToolStripMenuItem.Text = "Faculty";
            this.facultyToolStripMenuItem.Click += new System.EventHandler(this.facultyToolStripMenuItem_Click);
            // 
            // deansNameToolStripMenuItem
            // 
            this.deansNameToolStripMenuItem.Name = "deansNameToolStripMenuItem";
            this.deansNameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deansNameToolStripMenuItem.Text = "Dean\'s Name";
            // 
            // abbreviationToolStripMenuItem
            // 
            this.abbreviationToolStripMenuItem.Name = "abbreviationToolStripMenuItem";
            this.abbreviationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abbreviationToolStripMenuItem.Text = "Abbreviation";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 242);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.File);
            this.Controls.Add(this.Abbreviation);
            this.Controls.Add(this.Dean);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Faculty;
        private System.Windows.Forms.TextBox Dean;
        private System.Windows.Forms.TextBox Abbreviation;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deansNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abbreviationToolStripMenuItem;
    }
}

