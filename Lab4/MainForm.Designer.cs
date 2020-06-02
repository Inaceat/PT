namespace Lab4
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.task1Control = new Lab4.Task1Control();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.task2Control = new Lab4.Task2Control();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1084, 632);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.task1Control);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // task1Control
            // 
            this.task1Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task1Control.Location = new System.Drawing.Point(3, 3);
            this.task1Control.Name = "task1Control";
            this.task1Control.Size = new System.Drawing.Size(810, 540);
            this.task1Control.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.task2Control);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // task2Control
            // 
            this.task2Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.task2Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task2Control.Location = new System.Drawing.Point(3, 3);
            this.task2Control.Name = "task2Control";
            this.task2Control.Size = new System.Drawing.Size(1070, 600);
            this.task2Control.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 632);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Lab 4";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Task1Control task1Control;
        private Task2Control task2Control;
    }
}

