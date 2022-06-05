namespace EmployeesView
{
    partial class FillDirector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.FullNameLable = new System.Windows.Forms.Label();
            this.SalaryLable = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.PercentagePremiumLabel = new System.Windows.Forms.Label();
            this.PercentagePremium = new System.Windows.Forms.TextBox();
            this.WorkExperienceLabel = new System.Windows.Forms.Label();
            this.WorkExperience = new System.Windows.Forms.TextBox();
            this.DepartmentNameLabel = new System.Windows.Forms.Label();
            this.DepartmentName = new System.Windows.Forms.TextBox();
            this.NumberOfSubordinateLabel = new System.Windows.Forms.Label();
            this.NumberOfSubordinate = new System.Windows.Forms.TextBox();
            this.AddOrChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(135, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(179, 25);
            this.Title.TabIndex = 15;
            this.Title.Text = "Ввод данных:";
            // 
            // FullName
            // 
            this.FullName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullName.Location = new System.Drawing.Point(184, 75);
            this.FullName.Multiline = true;
            this.FullName.Name = "FullName";
            this.FullName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FullName.Size = new System.Drawing.Size(268, 37);
            this.FullName.TabIndex = 26;
            this.FullName.Text = "Пупкин Василий Сергеевич";
            // 
            // FullNameLable
            // 
            this.FullNameLable.AutoSize = true;
            this.FullNameLable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLable.Location = new System.Drawing.Point(14, 78);
            this.FullNameLable.Name = "FullNameLable";
            this.FullNameLable.Size = new System.Drawing.Size(120, 18);
            this.FullNameLable.TabIndex = 27;
            this.FullNameLable.Text = "Полное имя:";
            // 
            // SalaryLable
            // 
            this.SalaryLable.AutoSize = true;
            this.SalaryLable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryLable.Location = new System.Drawing.Point(14, 121);
            this.SalaryLable.Name = "SalaryLable";
            this.SalaryLable.Size = new System.Drawing.Size(71, 18);
            this.SalaryLable.TabIndex = 28;
            this.SalaryLable.Text = "Оклад:";
            // 
            // Salary
            // 
            this.Salary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salary.Location = new System.Drawing.Point(184, 121);
            this.Salary.Multiline = true;
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(268, 31);
            this.Salary.TabIndex = 29;
            this.Salary.Text = "15350";
            // 
            // PercentagePremiumLabel
            // 
            this.PercentagePremiumLabel.AutoSize = true;
            this.PercentagePremiumLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentagePremiumLabel.Location = new System.Drawing.Point(14, 164);
            this.PercentagePremiumLabel.Name = "PercentagePremiumLabel";
            this.PercentagePremiumLabel.Size = new System.Drawing.Size(97, 36);
            this.PercentagePremiumLabel.TabIndex = 30;
            this.PercentagePremiumLabel.Text = "Бонусный\r\nпроцент:";
            // 
            // PercentagePremium
            // 
            this.PercentagePremium.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentagePremium.Location = new System.Drawing.Point(184, 164);
            this.PercentagePremium.Multiline = true;
            this.PercentagePremium.Name = "PercentagePremium";
            this.PercentagePremium.Size = new System.Drawing.Size(268, 36);
            this.PercentagePremium.TabIndex = 31;
            this.PercentagePremium.Text = "12";
            // 
            // WorkExperienceLabel
            // 
            this.WorkExperienceLabel.AutoSize = true;
            this.WorkExperienceLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkExperienceLabel.Location = new System.Drawing.Point(14, 217);
            this.WorkExperienceLabel.Name = "WorkExperienceLabel";
            this.WorkExperienceLabel.Size = new System.Drawing.Size(80, 36);
            this.WorkExperienceLabel.TabIndex = 32;
            this.WorkExperienceLabel.Text = "Опыт\r\nработы:";
            // 
            // WorkExperience
            // 
            this.WorkExperience.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkExperience.Location = new System.Drawing.Point(184, 217);
            this.WorkExperience.Multiline = true;
            this.WorkExperience.Name = "WorkExperience";
            this.WorkExperience.Size = new System.Drawing.Size(268, 36);
            this.WorkExperience.TabIndex = 33;
            this.WorkExperience.Text = "3";
            // 
            // DepartmentNameLabel
            // 
            this.DepartmentNameLabel.AutoSize = true;
            this.DepartmentNameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentNameLabel.Location = new System.Drawing.Point(14, 266);
            this.DepartmentNameLabel.Name = "DepartmentNameLabel";
            this.DepartmentNameLabel.Size = new System.Drawing.Size(164, 36);
            this.DepartmentNameLabel.TabIndex = 34;
            this.DepartmentNameLabel.Text = "Название отдела\r\nуправления:";
            // 
            // DepartmentName
            // 
            this.DepartmentName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentName.Location = new System.Drawing.Point(184, 266);
            this.DepartmentName.Multiline = true;
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DepartmentName.Size = new System.Drawing.Size(268, 36);
            this.DepartmentName.TabIndex = 35;
            this.DepartmentName.Text = "Отдел безопасности";
            // 
            // NumberOfSubordinateLabel
            // 
            this.NumberOfSubordinateLabel.AutoSize = true;
            this.NumberOfSubordinateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfSubordinateLabel.Location = new System.Drawing.Point(14, 319);
            this.NumberOfSubordinateLabel.Name = "NumberOfSubordinateLabel";
            this.NumberOfSubordinateLabel.Size = new System.Drawing.Size(137, 36);
            this.NumberOfSubordinateLabel.TabIndex = 36;
            this.NumberOfSubordinateLabel.Text = "Количество\r\nподчинённых:";
            // 
            // NumberOfSubordinate
            // 
            this.NumberOfSubordinate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfSubordinate.Location = new System.Drawing.Point(184, 319);
            this.NumberOfSubordinate.Multiline = true;
            this.NumberOfSubordinate.Name = "NumberOfSubordinate";
            this.NumberOfSubordinate.Size = new System.Drawing.Size(268, 36);
            this.NumberOfSubordinate.TabIndex = 37;
            this.NumberOfSubordinate.Text = "3";
            // 
            // AddOrChange
            // 
            this.AddOrChange.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrChange.Location = new System.Drawing.Point(93, 378);
            this.AddOrChange.Name = "AddOrChange";
            this.AddOrChange.Size = new System.Drawing.Size(262, 67);
            this.AddOrChange.TabIndex = 38;
            this.AddOrChange.Text = "Добавить/Изменить";
            this.AddOrChange.UseVisualStyleBackColor = true;
            this.AddOrChange.Click += new System.EventHandler(this.AddOrChange_Click);
            // 
            // FillDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 457);
            this.Controls.Add(this.AddOrChange);
            this.Controls.Add(this.NumberOfSubordinate);
            this.Controls.Add(this.NumberOfSubordinateLabel);
            this.Controls.Add(this.DepartmentName);
            this.Controls.Add(this.DepartmentNameLabel);
            this.Controls.Add(this.WorkExperience);
            this.Controls.Add(this.WorkExperienceLabel);
            this.Controls.Add(this.PercentagePremium);
            this.Controls.Add(this.PercentagePremiumLabel);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.SalaryLable);
            this.Controls.Add(this.FullNameLable);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.Title);
            this.Name = "FillDirector";
            this.Text = "Создание руководителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label FullNameLable;
        private System.Windows.Forms.Label SalaryLable;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label PercentagePremiumLabel;
        private System.Windows.Forms.TextBox PercentagePremium;
        private System.Windows.Forms.Label WorkExperienceLabel;
        private System.Windows.Forms.TextBox WorkExperience;
        private System.Windows.Forms.Label DepartmentNameLabel;
        private System.Windows.Forms.TextBox DepartmentName;
        private System.Windows.Forms.Label NumberOfSubordinateLabel;
        private System.Windows.Forms.TextBox NumberOfSubordinate;
        private System.Windows.Forms.Button AddOrChange;
    }
}