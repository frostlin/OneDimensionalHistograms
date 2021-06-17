namespace Histogramms
{
    partial class Rand
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea2";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1367, 843);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // buttonPlot
            // 
            this.buttonPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlot.Location = new System.Drawing.Point(761, 871);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(130, 36);
            this.buttonPlot.TabIndex = 1;
            this.buttonPlot.Text = "Сгенерировать";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click_1);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownCount.Location = new System.Drawing.Point(335, 881);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(118, 20);
            this.numericUpDownCount.TabIndex = 2;
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownLeft.Location = new System.Drawing.Point(599, 881);
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownLeft.TabIndex = 3;
            // 
            // numericUpDownRight
            // 
            this.numericUpDownRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownRight.Location = new System.Drawing.Point(690, 881);
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownRight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 882);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сгенерировать";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 881);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "элементов от";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 881);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "до";
            // 
            // numericUpDownIterations
            // 
            this.numericUpDownIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownIterations.Location = new System.Drawing.Point(161, 882);
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownIterations.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 881);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "выборок, по";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(1187, 872);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(93, 36);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Очистить гистограмму";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.Location = new System.Drawing.Point(1286, 872);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 36);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Закрыть";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click_1);
            // 
            // Rand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 919);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownIterations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownRight);
            this.Controls.Add(this.numericUpDownLeft);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.buttonPlot);
            this.Controls.Add(this.chart);
            this.Name = "Rand";
            this.Text = "Rand";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBack;
    }
}