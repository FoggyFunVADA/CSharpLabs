namespace ProductInWarehouseView
{
    partial class OutputProducts
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
            this.ProductFirstLvl = new System.Windows.Forms.Label();
            this.ProductSecondLvl = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.Quality1 = new System.Windows.Forms.Label();
            this.Quality2 = new System.Windows.Forms.Label();
            this.FirstQuality = new System.Windows.Forms.TextBox();
            this.SecondQuality = new System.Windows.Forms.TextBox();
            this.Info1 = new System.Windows.Forms.Label();
            this.Info2 = new System.Windows.Forms.Label();
            this.FirstInfo = new System.Windows.Forms.TextBox();
            this.SecondInfo = new System.Windows.Forms.TextBox();
            this.GetQuality = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductFirstLvl
            // 
            this.ProductFirstLvl.AutoSize = true;
            this.ProductFirstLvl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductFirstLvl.Location = new System.Drawing.Point(26, 74);
            this.ProductFirstLvl.Name = "ProductFirstLvl";
            this.ProductFirstLvl.Size = new System.Drawing.Size(213, 18);
            this.ProductFirstLvl.TabIndex = 2;
            this.ProductFirstLvl.Text = "Товар первого уровня";
            // 
            // ProductSecondLvl
            // 
            this.ProductSecondLvl.AutoSize = true;
            this.ProductSecondLvl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductSecondLvl.Location = new System.Drawing.Point(282, 74);
            this.ProductSecondLvl.Name = "ProductSecondLvl";
            this.ProductSecondLvl.Size = new System.Drawing.Size(213, 18);
            this.ProductSecondLvl.TabIndex = 3;
            this.ProductSecondLvl.Text = "Товар первого уровня";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(155, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(253, 25);
            this.title.TabIndex = 4;
            this.title.Text = "Вывод информации";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Quality1
            // 
            this.Quality1.AutoSize = true;
            this.Quality1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quality1.Location = new System.Drawing.Point(26, 117);
            this.Quality1.Name = "Quality1";
            this.Quality1.Size = new System.Drawing.Size(92, 18);
            this.Quality1.TabIndex = 5;
            this.Quality1.Text = "Качество:";
            // 
            // Quality2
            // 
            this.Quality2.AutoSize = true;
            this.Quality2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quality2.Location = new System.Drawing.Point(287, 117);
            this.Quality2.Name = "Quality2";
            this.Quality2.Size = new System.Drawing.Size(92, 18);
            this.Quality2.TabIndex = 6;
            this.Quality2.Text = "Качество:";
            // 
            // FirstQuality
            // 
            this.FirstQuality.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstQuality.Location = new System.Drawing.Point(29, 138);
            this.FirstQuality.Multiline = true;
            this.FirstQuality.Name = "FirstQuality";
            this.FirstQuality.ReadOnly = true;
            this.FirstQuality.Size = new System.Drawing.Size(235, 28);
            this.FirstQuality.TabIndex = 8;
            // 
            // SecondQuality
            // 
            this.SecondQuality.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondQuality.Location = new System.Drawing.Point(290, 138);
            this.SecondQuality.Multiline = true;
            this.SecondQuality.Name = "SecondQuality";
            this.SecondQuality.ReadOnly = true;
            this.SecondQuality.Size = new System.Drawing.Size(240, 28);
            this.SecondQuality.TabIndex = 9;
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info1.Location = new System.Drawing.Point(26, 184);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(121, 18);
            this.Info1.TabIndex = 10;
            this.Info1.Text = "Информация:";
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info2.Location = new System.Drawing.Point(287, 184);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(121, 18);
            this.Info2.TabIndex = 11;
            this.Info2.Text = "Информация:";
            // 
            // FirstInfo
            // 
            this.FirstInfo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstInfo.Location = new System.Drawing.Point(29, 205);
            this.FirstInfo.Multiline = true;
            this.FirstInfo.Name = "FirstInfo";
            this.FirstInfo.ReadOnly = true;
            this.FirstInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FirstInfo.Size = new System.Drawing.Size(235, 129);
            this.FirstInfo.TabIndex = 12;
            // 
            // SecondInfo
            // 
            this.SecondInfo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondInfo.Location = new System.Drawing.Point(290, 205);
            this.SecondInfo.Multiline = true;
            this.SecondInfo.Name = "SecondInfo";
            this.SecondInfo.ReadOnly = true;
            this.SecondInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SecondInfo.Size = new System.Drawing.Size(240, 129);
            this.SecondInfo.TabIndex = 13;
            // 
            // GetQuality
            // 
            this.GetQuality.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetQuality.Location = new System.Drawing.Point(90, 357);
            this.GetQuality.Name = "GetQuality";
            this.GetQuality.Size = new System.Drawing.Size(174, 84);
            this.GetQuality.TabIndex = 14;
            this.GetQuality.Text = "Получить качество товаров";
            this.GetQuality.UseVisualStyleBackColor = true;
            this.GetQuality.Click += new System.EventHandler(this.GetQuality_Click);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(270, 357);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(182, 84);
            this.Output.TabIndex = 15;
            this.Output.Text = "Вывести информацию о товарах\r\n";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // OutputProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 442);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.GetQuality);
            this.Controls.Add(this.SecondInfo);
            this.Controls.Add(this.FirstInfo);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.SecondQuality);
            this.Controls.Add(this.FirstQuality);
            this.Controls.Add(this.Quality2);
            this.Controls.Add(this.Quality1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.ProductSecondLvl);
            this.Controls.Add(this.ProductFirstLvl);
            this.Name = "OutputProducts";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductFirstLvl;
        private System.Windows.Forms.Label ProductSecondLvl;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Quality1;
        private System.Windows.Forms.Label Quality2;
        private System.Windows.Forms.TextBox FirstQuality;
        private System.Windows.Forms.TextBox SecondQuality;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.Label Info2;
        private System.Windows.Forms.TextBox FirstInfo;
        private System.Windows.Forms.TextBox SecondInfo;
        private System.Windows.Forms.Button GetQuality;
        private System.Windows.Forms.Button Output;
    }
}