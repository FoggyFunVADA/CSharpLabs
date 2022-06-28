namespace ObjectsView
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TraineeMechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExperiencedMechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessionalMechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.DemonstrationOfWorkLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 109);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(258, 549);
            this.textBox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOperatorToolStripMenuItem,
            this.AddMechanicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddOperatorToolStripMenuItem
            // 
            this.AddOperatorToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOperatorToolStripMenuItem.Name = "AddOperatorToolStripMenuItem";
            this.AddOperatorToolStripMenuItem.Size = new System.Drawing.Size(392, 20);
            this.AddOperatorToolStripMenuItem.Text = "Добавить на форму оператора с квадрокоптером";
            this.AddOperatorToolStripMenuItem.Click += new System.EventHandler(this.AddOperatorToolStripMenuItem_Click);
            // 
            // AddMechanicToolStripMenuItem
            // 
            this.AddMechanicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TraineeMechanicToolStripMenuItem,
            this.ExperiencedMechanicToolStripMenuItem,
            this.ProfessionalMechanicToolStripMenuItem});
            this.AddMechanicToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMechanicToolStripMenuItem.Name = "AddMechanicToolStripMenuItem";
            this.AddMechanicToolStripMenuItem.Size = new System.Drawing.Size(242, 20);
            this.AddMechanicToolStripMenuItem.Text = "Добавить на форму механика";
            // 
            // TraineeMechanicToolStripMenuItem
            // 
            this.TraineeMechanicToolStripMenuItem.Name = "TraineeMechanicToolStripMenuItem";
            this.TraineeMechanicToolStripMenuItem.Size = new System.Drawing.Size(472, 22);
            this.TraineeMechanicToolStripMenuItem.Text = "Механик-стажёр (медленный ремонт)";
            this.TraineeMechanicToolStripMenuItem.Click += new System.EventHandler(this.TraineeMechanicToolStripMenuItem_Click);
            // 
            // ExperiencedMechanicToolStripMenuItem
            // 
            this.ExperiencedMechanicToolStripMenuItem.Name = "ExperiencedMechanicToolStripMenuItem";
            this.ExperiencedMechanicToolStripMenuItem.Size = new System.Drawing.Size(472, 22);
            this.ExperiencedMechanicToolStripMenuItem.Text = "Опытный механик (быстрый ремонт)";
            this.ExperiencedMechanicToolStripMenuItem.Click += new System.EventHandler(this.ExperiencedMechanicToolStripMenuItem_Click);
            // 
            // ProfessionalMechanicToolStripMenuItem
            // 
            this.ProfessionalMechanicToolStripMenuItem.Name = "ProfessionalMechanicToolStripMenuItem";
            this.ProfessionalMechanicToolStripMenuItem.Size = new System.Drawing.Size(472, 22);
            this.ProfessionalMechanicToolStripMenuItem.Text = "Механик профессионал (наиболее быстрый ремонт)";
            this.ProfessionalMechanicToolStripMenuItem.Click += new System.EventHandler(this.ProfessionalMechanicToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Отчёт";
            // 
            // DemonstrationOfWorkLabel
            // 
            this.DemonstrationOfWorkLabel.AutoSize = true;
            this.DemonstrationOfWorkLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DemonstrationOfWorkLabel.Location = new System.Drawing.Point(660, 83);
            this.DemonstrationOfWorkLabel.Name = "DemonstrationOfWorkLabel";
            this.DemonstrationOfWorkLabel.Size = new System.Drawing.Size(257, 23);
            this.DemonstrationOfWorkLabel.TabIndex = 7;
            this.DemonstrationOfWorkLabel.Text = "Демонстрация работы";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(469, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(353, 32);
            this.Title.TabIndex = 8;
            this.Title.Text = "Полёт квадрокоптера";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(276, 109);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1005, 549);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 662);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DemonstrationOfWorkLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Квадрокоптер";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddOperatorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DemonstrationOfWorkLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ToolStripMenuItem AddMechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TraineeMechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExperiencedMechanicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfessionalMechanicToolStripMenuItem;
    }
}

