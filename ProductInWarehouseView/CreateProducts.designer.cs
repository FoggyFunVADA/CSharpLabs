namespace ProductInWarehouseView
{
    partial class CreateProducts
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
            this.title = new System.Windows.Forms.Label();
            this.ProductFirstLvl = new System.Windows.Forms.Label();
            this.ProductSecondLvl = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.Price1 = new System.Windows.Forms.Label();
            this.Price2 = new System.Windows.Forms.Label();
            this.FirstPrice = new System.Windows.Forms.TextBox();
            this.SecondPrice = new System.Windows.Forms.TextBox();
            this.Quantity1 = new System.Windows.Forms.Label();
            this.Quantity2 = new System.Windows.Forms.Label();
            this.FirstQuantity = new System.Windows.Forms.TextBox();
            this.SecondQuantity = new System.Windows.Forms.TextBox();
            this.YearOfRelease = new System.Windows.Forms.Label();
            this.SecondYearOfRelease = new System.Windows.Forms.TextBox();
            this.CreateProductsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(76, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(432, 46);
            this.title.TabIndex = 0;
            this.title.Text = "Демонстрация работы полиморфизма\r\nТовары на складе";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProductFirstLvl
            // 
            this.ProductFirstLvl.AutoSize = true;
            this.ProductFirstLvl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductFirstLvl.Location = new System.Drawing.Point(39, 96);
            this.ProductFirstLvl.Name = "ProductFirstLvl";
            this.ProductFirstLvl.Size = new System.Drawing.Size(213, 18);
            this.ProductFirstLvl.TabIndex = 1;
            this.ProductFirstLvl.Text = "Товар первого уровня";
            // 
            // ProductSecondLvl
            // 
            this.ProductSecondLvl.AutoSize = true;
            this.ProductSecondLvl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductSecondLvl.Location = new System.Drawing.Point(306, 96);
            this.ProductSecondLvl.Name = "ProductSecondLvl";
            this.ProductSecondLvl.Size = new System.Drawing.Size(210, 18);
            this.ProductSecondLvl.TabIndex = 2;
            this.ProductSecondLvl.Text = "Товар второго уровня";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1.Location = new System.Drawing.Point(39, 123);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(135, 18);
            this.Name1.TabIndex = 4;
            this.Name1.Text = "Наименование:";
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name2.Location = new System.Drawing.Point(306, 123);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(135, 18);
            this.Name2.TabIndex = 5;
            this.Name2.Text = "Наименование:";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(42, 144);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(224, 28);
            this.FirstName.TabIndex = 7;
            this.FirstName.Text = "Картофель";
            // 
            // SecondName
            // 
            this.SecondName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondName.Location = new System.Drawing.Point(309, 144);
            this.SecondName.Multiline = true;
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(224, 28);
            this.SecondName.TabIndex = 8;
            this.SecondName.Text = "Огурец";
            // 
            // Price1
            // 
            this.Price1.AutoSize = true;
            this.Price1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price1.Location = new System.Drawing.Point(39, 185);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(57, 18);
            this.Price1.TabIndex = 9;
            this.Price1.Text = "Цена:";
            // 
            // Price2
            // 
            this.Price2.AutoSize = true;
            this.Price2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price2.Location = new System.Drawing.Point(306, 185);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(57, 18);
            this.Price2.TabIndex = 10;
            this.Price2.Text = "Цена:";
            // 
            // FirstPrice
            // 
            this.FirstPrice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPrice.Location = new System.Drawing.Point(42, 206);
            this.FirstPrice.Multiline = true;
            this.FirstPrice.Name = "FirstPrice";
            this.FirstPrice.Size = new System.Drawing.Size(224, 29);
            this.FirstPrice.TabIndex = 11;
            this.FirstPrice.Text = "66,9";
            // 
            // SecondPrice
            // 
            this.SecondPrice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondPrice.Location = new System.Drawing.Point(309, 206);
            this.SecondPrice.Multiline = true;
            this.SecondPrice.Name = "SecondPrice";
            this.SecondPrice.Size = new System.Drawing.Size(224, 28);
            this.SecondPrice.TabIndex = 12;
            this.SecondPrice.Text = "66,9";
            // 
            // Quantity1
            // 
            this.Quantity1.AutoSize = true;
            this.Quantity1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quantity1.Location = new System.Drawing.Point(39, 249);
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.Size = new System.Drawing.Size(112, 18);
            this.Quantity1.TabIndex = 13;
            this.Quantity1.Text = "Количество:";
            // 
            // Quantity2
            // 
            this.Quantity2.AutoSize = true;
            this.Quantity2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quantity2.Location = new System.Drawing.Point(306, 249);
            this.Quantity2.Name = "Quantity2";
            this.Quantity2.Size = new System.Drawing.Size(112, 18);
            this.Quantity2.TabIndex = 14;
            this.Quantity2.Text = "Количество:";
            // 
            // FirstQuantity
            // 
            this.FirstQuantity.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstQuantity.Location = new System.Drawing.Point(42, 270);
            this.FirstQuantity.Multiline = true;
            this.FirstQuantity.Name = "FirstQuantity";
            this.FirstQuantity.Size = new System.Drawing.Size(224, 29);
            this.FirstQuantity.TabIndex = 15;
            this.FirstQuantity.Text = "13";
            // 
            // SecondQuantity
            // 
            this.SecondQuantity.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondQuantity.Location = new System.Drawing.Point(309, 270);
            this.SecondQuantity.Multiline = true;
            this.SecondQuantity.Name = "SecondQuantity";
            this.SecondQuantity.Size = new System.Drawing.Size(224, 29);
            this.SecondQuantity.TabIndex = 16;
            this.SecondQuantity.Text = "13";
            // 
            // YearOfRelease
            // 
            this.YearOfRelease.AutoSize = true;
            this.YearOfRelease.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearOfRelease.Location = new System.Drawing.Point(306, 311);
            this.YearOfRelease.Name = "YearOfRelease";
            this.YearOfRelease.Size = new System.Drawing.Size(122, 18);
            this.YearOfRelease.TabIndex = 17;
            this.YearOfRelease.Text = "Год выпуска:";
            // 
            // SecondYearOfRelease
            // 
            this.SecondYearOfRelease.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondYearOfRelease.Location = new System.Drawing.Point(309, 332);
            this.SecondYearOfRelease.Multiline = true;
            this.SecondYearOfRelease.Name = "SecondYearOfRelease";
            this.SecondYearOfRelease.Size = new System.Drawing.Size(224, 29);
            this.SecondYearOfRelease.TabIndex = 18;
            this.SecondYearOfRelease.Text = "1914";
            // 
            // CreateProductsButton
            // 
            this.CreateProductsButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateProductsButton.Location = new System.Drawing.Point(147, 379);
            this.CreateProductsButton.Name = "CreateProductsButton";
            this.CreateProductsButton.Size = new System.Drawing.Size(243, 57);
            this.CreateProductsButton.TabIndex = 19;
            this.CreateProductsButton.Text = "Создать объекты";
            this.CreateProductsButton.UseVisualStyleBackColor = true;
            this.CreateProductsButton.Click += new System.EventHandler(this.CreateProductsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Введите данные";
            // 
            // CreateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateProductsButton);
            this.Controls.Add(this.SecondYearOfRelease);
            this.Controls.Add(this.YearOfRelease);
            this.Controls.Add(this.SecondQuantity);
            this.Controls.Add(this.FirstQuantity);
            this.Controls.Add(this.Quantity2);
            this.Controls.Add(this.Quantity1);
            this.Controls.Add(this.SecondPrice);
            this.Controls.Add(this.FirstPrice);
            this.Controls.Add(this.Price2);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.ProductSecondLvl);
            this.Controls.Add(this.ProductFirstLvl);
            this.Controls.Add(this.title);
            this.Name = "CreateProducts";
            this.Text = "Товары на складе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label ProductFirstLvl;
        private System.Windows.Forms.Label ProductSecondLvl;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.Label Price1;
        private System.Windows.Forms.Label Price2;
        private System.Windows.Forms.TextBox FirstPrice;
        private System.Windows.Forms.TextBox SecondPrice;
        private System.Windows.Forms.Label Quantity1;
        private System.Windows.Forms.Label Quantity2;
        private System.Windows.Forms.TextBox FirstQuantity;
        private System.Windows.Forms.TextBox SecondQuantity;
        private System.Windows.Forms.Label YearOfRelease;
        private System.Windows.Forms.TextBox SecondYearOfRelease;
        private System.Windows.Forms.Button CreateProductsButton;
        private System.Windows.Forms.Label label1;
    }
}

