namespace EmployeesView
{
    partial class DirectorsForm
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
            this.AddDirector = new System.Windows.Forms.Button();
            this.DeleteDirector = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.СhangeDepartment = new System.Windows.Forms.Button();
            this.GetFinalSalary = new System.Windows.Forms.Button();
            this.EvaluateWorkExperience = new System.Windows.Forms.Button();
            this.TryGetBonus = new System.Windows.Forms.Button();
            this.GetInfo = new System.Windows.Forms.Button();
            this.ListOfDirectors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddDirector
            // 
            this.AddDirector.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDirector.Location = new System.Drawing.Point(12, 76);
            this.AddDirector.Name = "AddDirector";
            this.AddDirector.Size = new System.Drawing.Size(165, 68);
            this.AddDirector.TabIndex = 1;
            this.AddDirector.Text = "Добавить руководителя";
            this.AddDirector.UseVisualStyleBackColor = true;
            this.AddDirector.Click += new System.EventHandler(this.AddDirector_Click);
            // 
            // DeleteDirector
            // 
            this.DeleteDirector.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDirector.Location = new System.Drawing.Point(183, 76);
            this.DeleteDirector.Name = "DeleteDirector";
            this.DeleteDirector.Size = new System.Drawing.Size(158, 68);
            this.DeleteDirector.TabIndex = 2;
            this.DeleteDirector.Text = "Удалить руководителя";
            this.DeleteDirector.UseVisualStyleBackColor = true;
            this.DeleteDirector.Click += new System.EventHandler(this.DeleteDirector_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(332, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(535, 25);
            this.Title.TabIndex = 3;
            this.Title.Text = "Задача на интерфейс и абстрактный класс";
            // 
            // СhangeDepartment
            // 
            this.СhangeDepartment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.СhangeDepartment.Location = new System.Drawing.Point(347, 76);
            this.СhangeDepartment.Name = "СhangeDepartment";
            this.СhangeDepartment.Size = new System.Drawing.Size(156, 68);
            this.СhangeDepartment.TabIndex = 4;
            this.СhangeDepartment.Text = "Изменить отдел руководителя";
            this.СhangeDepartment.UseVisualStyleBackColor = true;
            this.СhangeDepartment.Click += new System.EventHandler(this.СhangeDepartment_Click);
            // 
            // GetFinalSalary
            // 
            this.GetFinalSalary.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetFinalSalary.Location = new System.Drawing.Point(509, 76);
            this.GetFinalSalary.Name = "GetFinalSalary";
            this.GetFinalSalary.Size = new System.Drawing.Size(158, 68);
            this.GetFinalSalary.TabIndex = 5;
            this.GetFinalSalary.Text = "Получить итоговую зарплату";
            this.GetFinalSalary.UseVisualStyleBackColor = true;
            this.GetFinalSalary.Click += new System.EventHandler(this.GetFinalSalary_Click);
            // 
            // EvaluateWorkExperience
            // 
            this.EvaluateWorkExperience.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EvaluateWorkExperience.Location = new System.Drawing.Point(673, 76);
            this.EvaluateWorkExperience.Name = "EvaluateWorkExperience";
            this.EvaluateWorkExperience.Size = new System.Drawing.Size(172, 68);
            this.EvaluateWorkExperience.TabIndex = 6;
            this.EvaluateWorkExperience.Text = "Оценить опыт работы";
            this.EvaluateWorkExperience.UseVisualStyleBackColor = true;
            this.EvaluateWorkExperience.Click += new System.EventHandler(this.EvaluateWorkExperience_Click);
            // 
            // TryGetBonus
            // 
            this.TryGetBonus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TryGetBonus.Location = new System.Drawing.Point(851, 76);
            this.TryGetBonus.Name = "TryGetBonus";
            this.TryGetBonus.Size = new System.Drawing.Size(187, 68);
            this.TryGetBonus.TabIndex = 7;
            this.TryGetBonus.Text = "Попробовать получить бонус за число сотрудников";
            this.TryGetBonus.UseVisualStyleBackColor = true;
            this.TryGetBonus.Click += new System.EventHandler(this.TryGetBonus_Click);
            // 
            // GetInfo
            // 
            this.GetInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetInfo.Location = new System.Drawing.Point(1044, 76);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(196, 68);
            this.GetInfo.TabIndex = 8;
            this.GetInfo.Text = "Получить информацию о руководителе";
            this.GetInfo.UseVisualStyleBackColor = true;
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // ListOfDirectors
            // 
            this.ListOfDirectors.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfDirectors.FormattingEnabled = true;
            this.ListOfDirectors.HorizontalScrollbar = true;
            this.ListOfDirectors.ItemHeight = 16;
            this.ListOfDirectors.Location = new System.Drawing.Point(12, 171);
            this.ListOfDirectors.Name = "ListOfDirectors";
            this.ListOfDirectors.ScrollAlwaysVisible = true;
            this.ListOfDirectors.Size = new System.Drawing.Size(1228, 228);
            this.ListOfDirectors.TabIndex = 9;
            this.ListOfDirectors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListOfDirectors_MouseDoubleClick);
            // 
            // DirectorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 411);
            this.Controls.Add(this.ListOfDirectors);
            this.Controls.Add(this.GetInfo);
            this.Controls.Add(this.TryGetBonus);
            this.Controls.Add(this.EvaluateWorkExperience);
            this.Controls.Add(this.GetFinalSalary);
            this.Controls.Add(this.СhangeDepartment);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DeleteDirector);
            this.Controls.Add(this.AddDirector);
            this.Name = "DirectorsForm";
            this.Text = "Руководители";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddDirector;
        private System.Windows.Forms.Button DeleteDirector;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button СhangeDepartment;
        private System.Windows.Forms.Button GetFinalSalary;
        private System.Windows.Forms.Button EvaluateWorkExperience;
        private System.Windows.Forms.Button TryGetBonus;
        private System.Windows.Forms.Button GetInfo;
        private System.Windows.Forms.ListBox ListOfDirectors;
    }
}

