namespace Lab2
{
    partial class Task2Control
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
            this.initialArray = new System.Windows.Forms.ListBox();
            this.resultArray = new System.Windows.Forms.ListBox();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.changeSignButton = new System.Windows.Forms.Button();
            this.fillResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialArray
            // 
            this.initialArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.initialArray.FormattingEnabled = true;
            this.initialArray.Location = new System.Drawing.Point(10, 10);
            this.initialArray.Margin = new System.Windows.Forms.Padding(10);
            this.initialArray.Name = "initialArray";
            this.initialArray.Size = new System.Drawing.Size(179, 485);
            this.initialArray.TabIndex = 0;
            // 
            // resultArray
            // 
            this.resultArray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultArray.FormattingEnabled = true;
            this.resultArray.Location = new System.Drawing.Point(391, 10);
            this.resultArray.Margin = new System.Windows.Forms.Padding(10);
            this.resultArray.Name = "resultArray";
            this.resultArray.Size = new System.Drawing.Size(180, 446);
            this.resultArray.TabIndex = 1;
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(202, 10);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(104, 23);
            this.randomizeButton.TabIndex = 2;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.Location = new System.Drawing.Point(456, 469);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 39);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort: \\/";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterButton.Location = new System.Drawing.Point(274, 185);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(104, 23);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // changeSignButton
            // 
            this.changeSignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeSignButton.Location = new System.Drawing.Point(274, 133);
            this.changeSignButton.Name = "changeSignButton";
            this.changeSignButton.Size = new System.Drawing.Size(104, 23);
            this.changeSignButton.TabIndex = 5;
            this.changeSignButton.Text = "Change Sign";
            this.changeSignButton.UseVisualStyleBackColor = true;
            // 
            // fillResultButton
            // 
            this.fillResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillResultButton.Location = new System.Drawing.Point(303, 84);
            this.fillResultButton.Name = "fillResultButton";
            this.fillResultButton.Size = new System.Drawing.Size(75, 23);
            this.fillResultButton.TabIndex = 6;
            this.fillResultButton.Text = "Fill";
            this.fillResultButton.UseVisualStyleBackColor = true;
            // 
            // Task2Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillResultButton);
            this.Controls.Add(this.changeSignButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.resultArray);
            this.Controls.Add(this.initialArray);
            this.Name = "Task2Control";
            this.Size = new System.Drawing.Size(581, 518);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox initialArray;
        private System.Windows.Forms.ListBox resultArray;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button changeSignButton;
        private System.Windows.Forms.Button fillResultButton;
    }
}
