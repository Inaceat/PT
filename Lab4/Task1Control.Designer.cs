namespace Lab4
{
    partial class Task1Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.functionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cParamInput = new System.Windows.Forms.TextBox();
            this.bParamInput = new System.Windows.Forms.TextBox();
            this.plotButton = new System.Windows.Forms.Button();
            this.xEndInput = new System.Windows.Forms.TextBox();
            this.xDeltaInput = new System.Windows.Forms.TextBox();
            this.xStartInput = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(76, 472);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(13, 13);
            label5.TabIndex = 22;
            label5.Text = "b";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(213, 472);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(13, 13);
            label4.TabIndex = 21;
            label4.Text = "c";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(286, 428);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 13);
            label3.TabIndex = 20;
            label3.Text = "delta";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(151, 428);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(20, 13);
            label2.TabIndex = 19;
            label2.Text = "Xn";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 428);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(20, 13);
            label1.TabIndex = 18;
            label1.Text = "Xo";
            // 
            // functionChart
            // 
            this.functionChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.functionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TextWrapThreshold = 30;
            this.functionChart.Legends.Add(legend1);
            this.functionChart.Location = new System.Drawing.Point(0, 0);
            this.functionChart.Name = "functionChart";
            this.functionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.functionChart.Series.Add(series1);
            this.functionChart.Size = new System.Drawing.Size(806, 406);
            this.functionChart.TabIndex = 0;
            this.functionChart.Text = "chart1";
            // 
            // cParamInput
            // 
            this.cParamInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cParamInput.Location = new System.Drawing.Point(239, 469);
            this.cParamInput.Name = "cParamInput";
            this.cParamInput.Size = new System.Drawing.Size(100, 20);
            this.cParamInput.TabIndex = 5;
            // 
            // bParamInput
            // 
            this.bParamInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bParamInput.Location = new System.Drawing.Point(102, 469);
            this.bParamInput.Name = "bParamInput";
            this.bParamInput.Size = new System.Drawing.Size(100, 20);
            this.bParamInput.TabIndex = 4;
            // 
            // plotButton
            // 
            this.plotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.plotButton.Location = new System.Drawing.Point(666, 425);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(118, 58);
            this.plotButton.TabIndex = 6;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            // 
            // xEndInput
            // 
            this.xEndInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xEndInput.Location = new System.Drawing.Point(177, 425);
            this.xEndInput.Name = "xEndInput";
            this.xEndInput.Size = new System.Drawing.Size(100, 20);
            this.xEndInput.TabIndex = 2;
            // 
            // xDeltaInput
            // 
            this.xDeltaInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xDeltaInput.Location = new System.Drawing.Point(322, 425);
            this.xDeltaInput.Name = "xDeltaInput";
            this.xDeltaInput.Size = new System.Drawing.Size(100, 20);
            this.xDeltaInput.TabIndex = 3;
            // 
            // xStartInput
            // 
            this.xStartInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xStartInput.Location = new System.Drawing.Point(44, 425);
            this.xStartInput.Name = "xStartInput";
            this.xStartInput.Size = new System.Drawing.Size(100, 20);
            this.xStartInput.TabIndex = 1;
            // 
            // Task1Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.cParamInput);
            this.Controls.Add(this.bParamInput);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.xEndInput);
            this.Controls.Add(this.xDeltaInput);
            this.Controls.Add(this.xStartInput);
            this.Controls.Add(this.functionChart);
            this.Name = "Task1Control";
            this.Size = new System.Drawing.Size(806, 502);
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart functionChart;
        private System.Windows.Forms.TextBox cParamInput;
        private System.Windows.Forms.TextBox bParamInput;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.TextBox xEndInput;
        private System.Windows.Forms.TextBox xDeltaInput;
        private System.Windows.Forms.TextBox xStartInput;
    }
}
