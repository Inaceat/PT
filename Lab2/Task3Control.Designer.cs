namespace Lab2
{
    partial class Task3Control
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
            this.matrixView = new System.Windows.Forms.DataGridView();
            this.calculateButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.mainDiagSumOutput = new System.Windows.Forms.TextBox();
            this.fillButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixView
            // 
            this.matrixView.AllowUserToAddRows = false;
            this.matrixView.AllowUserToDeleteRows = false;
            this.matrixView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrixView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrixView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixView.ColumnHeadersVisible = false;
            this.matrixView.Location = new System.Drawing.Point(3, 3);
            this.matrixView.Name = "matrixView";
            this.matrixView.ReadOnly = true;
            this.matrixView.RowHeadersVisible = false;
            this.matrixView.Size = new System.Drawing.Size(546, 398);
            this.matrixView.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculateButton.Location = new System.Drawing.Point(99, 408);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.Location = new System.Drawing.Point(453, 407);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // mainDiagSumOutput
            // 
            this.mainDiagSumOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mainDiagSumOutput.Location = new System.Drawing.Point(180, 410);
            this.mainDiagSumOutput.Name = "mainDiagSumOutput";
            this.mainDiagSumOutput.Size = new System.Drawing.Size(147, 20);
            this.mainDiagSumOutput.TabIndex = 3;
            // 
            // fillButton
            // 
            this.fillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fillButton.Location = new System.Drawing.Point(18, 407);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 4;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            // 
            // Task3Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.mainDiagSumOutput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.matrixView);
            this.Name = "Task3Control";
            this.Size = new System.Drawing.Size(552, 455);
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrixView;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox mainDiagSumOutput;
        private System.Windows.Forms.Button fillButton;
    }
}
