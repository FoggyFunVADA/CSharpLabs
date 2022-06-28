namespace ObjectsView
{
    partial class InputForm
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
            this.InputInfo = new System.Windows.Forms.TextBox();
            this.InputInfoButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputInfo
            // 
            this.InputInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputInfo.Location = new System.Drawing.Point(12, 45);
            this.InputInfo.Multiline = true;
            this.InputInfo.Name = "InputInfo";
            this.InputInfo.Size = new System.Drawing.Size(405, 42);
            this.InputInfo.TabIndex = 8;
            this.InputInfo.Text = "---";
            // 
            // InputInfoButton
            // 
            this.InputInfoButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputInfoButton.Location = new System.Drawing.Point(131, 93);
            this.InputInfoButton.Name = "InputInfoButton";
            this.InputInfoButton.Size = new System.Drawing.Size(181, 46);
            this.InputInfoButton.TabIndex = 9;
            this.InputInfoButton.Text = "Ввод данных";
            this.InputInfoButton.UseVisualStyleBackColor = true;
            this.InputInfoButton.Click += new System.EventHandler(this.InputInfoButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(12, 22);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(33, 20);
            this.InfoLabel.TabIndex = 10;
            this.InfoLabel.Text = "---";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 143);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.InputInfoButton);
            this.Controls.Add(this.InputInfo);
            this.Name = "InputForm";
            this.Text = "Ввод данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputInfo;
        private System.Windows.Forms.Button InputInfoButton;
        private System.Windows.Forms.Label InfoLabel;
    }
}