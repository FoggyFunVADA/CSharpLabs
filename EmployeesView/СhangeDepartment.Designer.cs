namespace EmployeesView
{
    partial class СhangeDepartment
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
            this.NewDepartmentLabel = new System.Windows.Forms.Label();
            this.NewNumberOfSubordinateLabel = new System.Windows.Forms.Label();
            this.DepartmentNew = new System.Windows.Forms.TextBox();
            this.NumberOfSubordinateNew = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(131, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(177, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Смена отдела";
            // 
            // NewDepartmentLabel
            // 
            this.NewDepartmentLabel.AutoSize = true;
            this.NewDepartmentLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewDepartmentLabel.Location = new System.Drawing.Point(37, 55);
            this.NewDepartmentLabel.Name = "NewDepartmentLabel";
            this.NewDepartmentLabel.Size = new System.Drawing.Size(130, 18);
            this.NewDepartmentLabel.TabIndex = 1;
            this.NewDepartmentLabel.Text = "Новый отдел:";
            // 
            // NewNumberOfSubordinateLabel
            // 
            this.NewNumberOfSubordinateLabel.AutoSize = true;
            this.NewNumberOfSubordinateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewNumberOfSubordinateLabel.Location = new System.Drawing.Point(37, 101);
            this.NewNumberOfSubordinateLabel.Name = "NewNumberOfSubordinateLabel";
            this.NewNumberOfSubordinateLabel.Size = new System.Drawing.Size(174, 36);
            this.NewNumberOfSubordinateLabel.TabIndex = 2;
            this.NewNumberOfSubordinateLabel.Text = "Новое количество\r\nподчинённых:";
            // 
            // DepartmentNew
            // 
            this.DepartmentNew.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentNew.Location = new System.Drawing.Point(235, 55);
            this.DepartmentNew.Multiline = true;
            this.DepartmentNew.Name = "DepartmentNew";
            this.DepartmentNew.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DepartmentNew.Size = new System.Drawing.Size(198, 36);
            this.DepartmentNew.TabIndex = 3;
            // 
            // NumberOfSubordinateNew
            // 
            this.NumberOfSubordinateNew.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfSubordinateNew.Location = new System.Drawing.Point(235, 101);
            this.NumberOfSubordinateNew.Multiline = true;
            this.NumberOfSubordinateNew.Name = "NumberOfSubordinateNew";
            this.NumberOfSubordinateNew.Size = new System.Drawing.Size(198, 36);
            this.NumberOfSubordinateNew.TabIndex = 4;
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(156, 154);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(120, 49);
            this.Change.TabIndex = 5;
            this.Change.Text = "Замена";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // СhangeDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 215);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.NumberOfSubordinateNew);
            this.Controls.Add(this.DepartmentNew);
            this.Controls.Add(this.NewNumberOfSubordinateLabel);
            this.Controls.Add(this.NewDepartmentLabel);
            this.Controls.Add(this.Title);
            this.Name = "СhangeDepartment";
            this.Text = "Смена отдела";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label NewDepartmentLabel;
        private System.Windows.Forms.Label NewNumberOfSubordinateLabel;
        private System.Windows.Forms.TextBox DepartmentNew;
        private System.Windows.Forms.TextBox NumberOfSubordinateNew;
        private System.Windows.Forms.Button Change;
    }
}