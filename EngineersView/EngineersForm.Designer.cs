namespace EngineersView
{
    partial class EngineersForm
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
            this.ClassLabel = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.PropertiesListBox = new System.Windows.Forms.ListBox();
            this.ParametersListBox = new System.Windows.Forms.ListBox();
            this.Create = new System.Windows.Forms.Button();
            this.FillParameters = new System.Windows.Forms.Button();
            this.Perform = new System.Windows.Forms.Button();
            this.PropertiesLabel = new System.Windows.Forms.Label();
            this.ParametersLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassLabel.Location = new System.Drawing.Point(29, 74);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(68, 18);
            this.ClassLabel.TabIndex = 1;
            this.ClassLabel.Text = "Класс:";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(115, 74);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(287, 26);
            this.ClassComboBox.TabIndex = 5;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodLabel.Location = new System.Drawing.Point(29, 126);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(70, 18);
            this.MethodLabel.TabIndex = 6;
            this.MethodLabel.Text = "Метод:";
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.Enabled = false;
            this.MethodComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Location = new System.Drawing.Point(115, 126);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(287, 26);
            this.MethodComboBox.TabIndex = 7;
            this.MethodComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodComboBox_SelectedIndexChanged);
            // 
            // PropertiesListBox
            // 
            this.PropertiesListBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropertiesListBox.FormattingEnabled = true;
            this.PropertiesListBox.ItemHeight = 18;
            this.PropertiesListBox.Location = new System.Drawing.Point(32, 189);
            this.PropertiesListBox.Name = "PropertiesListBox";
            this.PropertiesListBox.Size = new System.Drawing.Size(370, 256);
            this.PropertiesListBox.TabIndex = 10;
            // 
            // ParametersListBox
            // 
            this.ParametersListBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParametersListBox.FormattingEnabled = true;
            this.ParametersListBox.ItemHeight = 18;
            this.ParametersListBox.Location = new System.Drawing.Point(418, 189);
            this.ParametersListBox.Name = "ParametersListBox";
            this.ParametersListBox.Size = new System.Drawing.Size(370, 256);
            this.ParametersListBox.TabIndex = 11;
            // 
            // Create
            // 
            this.Create.Enabled = false;
            this.Create.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(419, 74);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(112, 58);
            this.Create.TabIndex = 12;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // FillParameters
            // 
            this.FillParameters.Enabled = false;
            this.FillParameters.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillParameters.Location = new System.Drawing.Point(536, 74);
            this.FillParameters.Name = "FillParameters";
            this.FillParameters.Size = new System.Drawing.Size(121, 58);
            this.FillParameters.TabIndex = 13;
            this.FillParameters.Text = "Ввести параметры";
            this.FillParameters.UseVisualStyleBackColor = true;
            this.FillParameters.Click += new System.EventHandler(this.FillParameters_Click);
            // 
            // Perform
            // 
            this.Perform.Enabled = false;
            this.Perform.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Perform.Location = new System.Drawing.Point(663, 74);
            this.Perform.Name = "Perform";
            this.Perform.Size = new System.Drawing.Size(125, 58);
            this.Perform.TabIndex = 14;
            this.Perform.Text = "Выполнить";
            this.Perform.UseVisualStyleBackColor = true;
            this.Perform.Click += new System.EventHandler(this.Perform_Click);
            // 
            // PropertiesLabel
            // 
            this.PropertiesLabel.AutoSize = true;
            this.PropertiesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropertiesLabel.Location = new System.Drawing.Point(29, 168);
            this.PropertiesLabel.Name = "PropertiesLabel";
            this.PropertiesLabel.Size = new System.Drawing.Size(98, 18);
            this.PropertiesLabel.TabIndex = 15;
            this.PropertiesLabel.Text = "Свойства:";
            // 
            // ParametersLabel
            // 
            this.ParametersLabel.AutoSize = true;
            this.ParametersLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametersLabel.Location = new System.Drawing.Point(415, 168);
            this.ParametersLabel.Name = "ParametersLabel";
            this.ParametersLabel.Size = new System.Drawing.Size(116, 18);
            this.ParametersLabel.TabIndex = 16;
            this.ParametersLabel.Text = "Параметры:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(259, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(282, 25);
            this.Title.TabIndex = 17;
            this.Title.Text = "Задача на рефлексию";
            // 
            // EngineersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ParametersLabel);
            this.Controls.Add(this.PropertiesLabel);
            this.Controls.Add(this.Perform);
            this.Controls.Add(this.FillParameters);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.ParametersListBox);
            this.Controls.Add(this.PropertiesListBox);
            this.Controls.Add(this.MethodComboBox);
            this.Controls.Add(this.MethodLabel);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.ClassLabel);
            this.Name = "EngineersForm";
            this.Text = "Рефлексия";
            this.Load += new System.EventHandler(this.EngineersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.Label MethodLabel;
        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.ListBox PropertiesListBox;
        private System.Windows.Forms.ListBox ParametersListBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button FillParameters;
        private System.Windows.Forms.Button Perform;
        private System.Windows.Forms.Label PropertiesLabel;
        private System.Windows.Forms.Label ParametersLabel;
        private System.Windows.Forms.Label Title;
    }
}

