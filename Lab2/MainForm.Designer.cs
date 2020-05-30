namespace Lab2
{
    partial class MainForm
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
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabTask1 = new System.Windows.Forms.TabPage();
            this.task1Control = new Lab2.Task1Control();
            this.tabTask2 = new System.Windows.Forms.TabPage();
            this.tabTask3 = new System.Windows.Forms.TabPage();
            this.tabsControl.SuspendLayout();
            this.tabTask1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabTask1);
            this.tabsControl.Controls.Add(this.tabTask2);
            this.tabsControl.Controls.Add(this.tabTask3);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.Location = new System.Drawing.Point(0, 0);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(694, 483);
            this.tabsControl.TabIndex = 0;
            // 
            // tabTask1
            // 
            this.tabTask1.Controls.Add(this.task1Control);
            this.tabTask1.Location = new System.Drawing.Point(4, 22);
            this.tabTask1.Name = "tabTask1";
            this.tabTask1.Padding = new System.Windows.Forms.Padding(3);
            this.tabTask1.Size = new System.Drawing.Size(686, 457);
            this.tabTask1.TabIndex = 0;
            this.tabTask1.Text = "Task 1";
            this.tabTask1.UseVisualStyleBackColor = true;
            // 
            // task1Control
            // 
            this.task1Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task1Control.Location = new System.Drawing.Point(3, 3);
            this.task1Control.Name = "task1Control";
            this.task1Control.Size = new System.Drawing.Size(680, 451);
            this.task1Control.TabIndex = 0;
            // 
            // tabTask2
            // 
            this.tabTask2.Location = new System.Drawing.Point(4, 22);
            this.tabTask2.Name = "tabTask2";
            this.tabTask2.Padding = new System.Windows.Forms.Padding(3);
            this.tabTask2.Size = new System.Drawing.Size(686, 457);
            this.tabTask2.TabIndex = 1;
            this.tabTask2.Text = "Task 2";
            this.tabTask2.UseVisualStyleBackColor = true;
            // 
            // tabTask3
            // 
            this.tabTask3.Location = new System.Drawing.Point(4, 22);
            this.tabTask3.Name = "tabTask3";
            this.tabTask3.Size = new System.Drawing.Size(686, 457);
            this.tabTask3.TabIndex = 2;
            this.tabTask3.Text = "Task 3";
            this.tabTask3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 483);
            this.Controls.Add(this.tabsControl);
            this.Name = "MainForm";
            this.Text = "Lab 2";
            this.tabsControl.ResumeLayout(false);
            this.tabTask1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabTask1;
        private System.Windows.Forms.TabPage tabTask2;
        private System.Windows.Forms.TabPage tabTask3;
        private Task1Control task1Control;
    }
}

