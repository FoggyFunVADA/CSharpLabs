namespace PlaneView
{
    partial class OutputPlane
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
            this.RouteLabel = new System.Windows.Forms.Label();
            this.SetRoute = new System.Windows.Forms.Button();
            this.GetRoute = new System.Windows.Forms.Button();
            this.Fly = new System.Windows.Forms.Button();
            this.Route = new System.Windows.Forms.TextBox();
            this.FlightReportLabel = new System.Windows.Forms.Label();
            this.FlightReport = new System.Windows.Forms.TextBox();
            this.GetСharacteristic = new System.Windows.Forms.Button();
            this.Сharacteristic = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.ReplacingСharacteristicsLabel = new System.Windows.Forms.Label();
            this.Landing = new System.Windows.Forms.Button();
            this.Brand = new System.Windows.Forms.TextBox();
            this.LengthOfWing = new System.Windows.Forms.TextBox();
            this.WheelDiameter = new System.Windows.Forms.TextBox();
            this.PowerOfEngine = new System.Windows.Forms.TextBox();
            this.ReplaceBrand = new System.Windows.Forms.Button();
            this.ReplaceLength = new System.Windows.Forms.Button();
            this.ReplaceDiameter = new System.Windows.Forms.Button();
            this.ReplacePower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RouteLabel
            // 
            this.RouteLabel.AutoSize = true;
            this.RouteLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RouteLabel.Location = new System.Drawing.Point(12, 134);
            this.RouteLabel.Name = "RouteLabel";
            this.RouteLabel.Size = new System.Drawing.Size(96, 18);
            this.RouteLabel.TabIndex = 0;
            this.RouteLabel.Text = "Маршрут:";
            // 
            // SetRoute
            // 
            this.SetRoute.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetRoute.Location = new System.Drawing.Point(12, 61);
            this.SetRoute.Name = "SetRoute";
            this.SetRoute.Size = new System.Drawing.Size(145, 56);
            this.SetRoute.TabIndex = 1;
            this.SetRoute.Text = "Задать маршрут";
            this.SetRoute.UseVisualStyleBackColor = true;
            this.SetRoute.Click += new System.EventHandler(this.SetRoute_Click);
            // 
            // GetRoute
            // 
            this.GetRoute.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetRoute.Location = new System.Drawing.Point(176, 61);
            this.GetRoute.Name = "GetRoute";
            this.GetRoute.Size = new System.Drawing.Size(159, 56);
            this.GetRoute.TabIndex = 2;
            this.GetRoute.Text = "Вывести маршрут";
            this.GetRoute.UseVisualStyleBackColor = true;
            this.GetRoute.Click += new System.EventHandler(this.GetRoute_Click);
            // 
            // Fly
            // 
            this.Fly.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fly.Location = new System.Drawing.Point(360, 61);
            this.Fly.Name = "Fly";
            this.Fly.Size = new System.Drawing.Size(152, 56);
            this.Fly.TabIndex = 3;
            this.Fly.Text = "Лететь по маршруту";
            this.Fly.UseVisualStyleBackColor = true;
            this.Fly.Click += new System.EventHandler(this.Fly_Click);
            // 
            // Route
            // 
            this.Route.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Route.Location = new System.Drawing.Point(116, 136);
            this.Route.Multiline = true;
            this.Route.Name = "Route";
            this.Route.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Route.Size = new System.Drawing.Size(208, 92);
            this.Route.TabIndex = 4;
            this.Route.Text = "Воронеж --> Торонто --> Суздаль";
            // 
            // FlightReportLabel
            // 
            this.FlightReportLabel.AutoSize = true;
            this.FlightReportLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlightReportLabel.Location = new System.Drawing.Point(342, 137);
            this.FlightReportLabel.Name = "FlightReportLabel";
            this.FlightReportLabel.Size = new System.Drawing.Size(93, 36);
            this.FlightReportLabel.TabIndex = 5;
            this.FlightReportLabel.Text = "Отчёт\r\nо полёте:";
            // 
            // FlightReport
            // 
            this.FlightReport.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlightReport.Location = new System.Drawing.Point(441, 135);
            this.FlightReport.Multiline = true;
            this.FlightReport.Name = "FlightReport";
            this.FlightReport.ReadOnly = true;
            this.FlightReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FlightReport.Size = new System.Drawing.Size(235, 92);
            this.FlightReport.TabIndex = 6;
            // 
            // GetСharacteristic
            // 
            this.GetСharacteristic.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetСharacteristic.Location = new System.Drawing.Point(441, 238);
            this.GetСharacteristic.Name = "GetСharacteristic";
            this.GetСharacteristic.Size = new System.Drawing.Size(235, 81);
            this.GetСharacteristic.TabIndex = 7;
            this.GetСharacteristic.Text = "Получить технические характеристики";
            this.GetСharacteristic.UseVisualStyleBackColor = true;
            this.GetСharacteristic.Click += new System.EventHandler(this.GetСharacteristic_Click);
            // 
            // Сharacteristic
            // 
            this.Сharacteristic.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сharacteristic.Location = new System.Drawing.Point(441, 334);
            this.Сharacteristic.Multiline = true;
            this.Сharacteristic.Name = "Сharacteristic";
            this.Сharacteristic.ReadOnly = true;
            this.Сharacteristic.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Сharacteristic.Size = new System.Drawing.Size(235, 172);
            this.Сharacteristic.TabIndex = 8;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(212, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(282, 25);
            this.Title.TabIndex = 9;
            this.Title.Text = "Действия с самолётом";
            // 
            // ReplacingСharacteristicsLabel
            // 
            this.ReplacingСharacteristicsLabel.AutoSize = true;
            this.ReplacingСharacteristicsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplacingСharacteristicsLabel.Location = new System.Drawing.Point(102, 238);
            this.ReplacingСharacteristicsLabel.Name = "ReplacingСharacteristicsLabel";
            this.ReplacingСharacteristicsLabel.Size = new System.Drawing.Size(218, 18);
            this.ReplacingСharacteristicsLabel.TabIndex = 14;
            this.ReplacingСharacteristicsLabel.Text = "Замена характеристик:";
            // 
            // Landing
            // 
            this.Landing.Enabled = false;
            this.Landing.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Landing.Location = new System.Drawing.Point(528, 61);
            this.Landing.Name = "Landing";
            this.Landing.Size = new System.Drawing.Size(148, 56);
            this.Landing.TabIndex = 19;
            this.Landing.Text = "Закончить полёт";
            this.Landing.UseVisualStyleBackColor = true;
            this.Landing.Click += new System.EventHandler(this.Landing_Click);
            // 
            // Brand
            // 
            this.Brand.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brand.Location = new System.Drawing.Point(263, 268);
            this.Brand.Multiline = true;
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(160, 36);
            this.Brand.TabIndex = 20;
            this.Brand.Text = "Boeing";
            // 
            // LengthOfWing
            // 
            this.LengthOfWing.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthOfWing.Location = new System.Drawing.Point(263, 310);
            this.LengthOfWing.Multiline = true;
            this.LengthOfWing.Name = "LengthOfWing";
            this.LengthOfWing.Size = new System.Drawing.Size(160, 33);
            this.LengthOfWing.TabIndex = 21;
            this.LengthOfWing.Text = "6,1";
            // 
            // WheelDiameter
            // 
            this.WheelDiameter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WheelDiameter.Location = new System.Drawing.Point(263, 352);
            this.WheelDiameter.Multiline = true;
            this.WheelDiameter.Name = "WheelDiameter";
            this.WheelDiameter.Size = new System.Drawing.Size(160, 41);
            this.WheelDiameter.TabIndex = 22;
            this.WheelDiameter.Text = "29,4";
            // 
            // PowerOfEngine
            // 
            this.PowerOfEngine.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerOfEngine.Location = new System.Drawing.Point(263, 399);
            this.PowerOfEngine.Multiline = true;
            this.PowerOfEngine.Name = "PowerOfEngine";
            this.PowerOfEngine.Size = new System.Drawing.Size(160, 44);
            this.PowerOfEngine.TabIndex = 23;
            this.PowerOfEngine.Text = "190";
            // 
            // ReplaceBrand
            // 
            this.ReplaceBrand.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceBrand.Location = new System.Drawing.Point(27, 268);
            this.ReplaceBrand.Name = "ReplaceBrand";
            this.ReplaceBrand.Size = new System.Drawing.Size(223, 36);
            this.ReplaceBrand.TabIndex = 24;
            this.ReplaceBrand.Text = "Заменить бренд";
            this.ReplaceBrand.UseVisualStyleBackColor = true;
            this.ReplaceBrand.Click += new System.EventHandler(this.ReplaceBrand_Click);
            // 
            // ReplaceLength
            // 
            this.ReplaceLength.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceLength.Location = new System.Drawing.Point(27, 310);
            this.ReplaceLength.Name = "ReplaceLength";
            this.ReplaceLength.Size = new System.Drawing.Size(223, 33);
            this.ReplaceLength.TabIndex = 25;
            this.ReplaceLength.Text = "Заменить длину крыла";
            this.ReplaceLength.UseVisualStyleBackColor = true;
            this.ReplaceLength.Click += new System.EventHandler(this.ReplaceLength_Click);
            // 
            // ReplaceDiameter
            // 
            this.ReplaceDiameter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplaceDiameter.Location = new System.Drawing.Point(27, 349);
            this.ReplaceDiameter.Name = "ReplaceDiameter";
            this.ReplaceDiameter.Size = new System.Drawing.Size(223, 44);
            this.ReplaceDiameter.TabIndex = 26;
            this.ReplaceDiameter.Text = "Заменить диаметр колёс шасси";
            this.ReplaceDiameter.UseVisualStyleBackColor = true;
            this.ReplaceDiameter.Click += new System.EventHandler(this.ReplaceDiameter_Click);
            // 
            // ReplacePower
            // 
            this.ReplacePower.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReplacePower.Location = new System.Drawing.Point(27, 399);
            this.ReplacePower.Name = "ReplacePower";
            this.ReplacePower.Size = new System.Drawing.Size(223, 44);
            this.ReplacePower.TabIndex = 27;
            this.ReplacePower.Text = "Заменить мощность двигателя";
            this.ReplacePower.UseVisualStyleBackColor = true;
            this.ReplacePower.Click += new System.EventHandler(this.ReplacePower_Click);
            // 
            // OutputPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 506);
            this.Controls.Add(this.ReplacePower);
            this.Controls.Add(this.ReplaceDiameter);
            this.Controls.Add(this.ReplaceLength);
            this.Controls.Add(this.ReplaceBrand);
            this.Controls.Add(this.PowerOfEngine);
            this.Controls.Add(this.WheelDiameter);
            this.Controls.Add(this.LengthOfWing);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.Landing);
            this.Controls.Add(this.ReplacingСharacteristicsLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Сharacteristic);
            this.Controls.Add(this.GetСharacteristic);
            this.Controls.Add(this.FlightReport);
            this.Controls.Add(this.FlightReportLabel);
            this.Controls.Add(this.Route);
            this.Controls.Add(this.Fly);
            this.Controls.Add(this.GetRoute);
            this.Controls.Add(this.SetRoute);
            this.Controls.Add(this.RouteLabel);
            this.Name = "OutputPlane";
            this.Text = "OutputPlane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RouteLabel;
        private System.Windows.Forms.Button SetRoute;
        private System.Windows.Forms.Button GetRoute;
        private System.Windows.Forms.Button Fly;
        private System.Windows.Forms.TextBox Route;
        private System.Windows.Forms.Label FlightReportLabel;
        private System.Windows.Forms.TextBox FlightReport;
        private System.Windows.Forms.Button GetСharacteristic;
        private System.Windows.Forms.TextBox Сharacteristic;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ReplacingСharacteristicsLabel;
        private System.Windows.Forms.Button Landing;
        private System.Windows.Forms.TextBox Brand;
        private System.Windows.Forms.TextBox LengthOfWing;
        private System.Windows.Forms.TextBox WheelDiameter;
        private System.Windows.Forms.TextBox PowerOfEngine;
        private System.Windows.Forms.Button ReplaceBrand;
        private System.Windows.Forms.Button ReplaceLength;
        private System.Windows.Forms.Button ReplaceDiameter;
        private System.Windows.Forms.Button ReplacePower;
    }
}