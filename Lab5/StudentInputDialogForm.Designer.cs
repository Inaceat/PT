namespace Lab5
{
    internal partial class StudentInputDialogForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.nameInput = new System.Windows.Forms.TextBox();
            this.perfomanceComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.gradeIndexInput = new System.Windows.Forms.TextBox();
            this.gradeNumberInput = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 17);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(24, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 17);
            label2.TabIndex = 3;
            label2.Text = "Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(24, 95);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 17);
            label3.TabIndex = 4;
            label3.Text = "Perfomance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(328, 65);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 17);
            label4.TabIndex = 12;
            label4.Text = "Index";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(160, 65);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 17);
            label5.TabIndex = 13;
            label5.Text = "Number";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(163, 32);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(303, 23);
            this.nameInput.TabIndex = 0;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // perfomanceComboBox
            // 
            this.perfomanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perfomanceComboBox.FormattingEnabled = true;
            this.perfomanceComboBox.Location = new System.Drawing.Point(163, 92);
            this.perfomanceComboBox.Name = "perfomanceComboBox";
            this.perfomanceComboBox.Size = new System.Drawing.Size(303, 24);
            this.perfomanceComboBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(111, 146);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(87, 39);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OnOK);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(317, 146);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 39);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.OnCancel);
            // 
            // gradeIndexInput
            // 
            this.gradeIndexInput.Location = new System.Drawing.Point(375, 62);
            this.gradeIndexInput.Name = "gradeIndexInput";
            this.gradeIndexInput.Size = new System.Drawing.Size(91, 23);
            this.gradeIndexInput.TabIndex = 2;
            // 
            // gradeNumberInput
            // 
            this.gradeNumberInput.Location = new System.Drawing.Point(224, 63);
            this.gradeNumberInput.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.gradeNumberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gradeNumberInput.Name = "gradeNumberInput";
            this.gradeNumberInput.ReadOnly = true;
            this.gradeNumberInput.Size = new System.Drawing.Size(92, 23);
            this.gradeNumberInput.TabIndex = 1;
            this.gradeNumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gradeNumberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StudentInputDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 213);
            this.Controls.Add(this.gradeNumberInput);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.gradeIndexInput);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.perfomanceComboBox);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.nameInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentInputDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Input";
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ComboBox perfomanceComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox gradeIndexInput;
        private System.Windows.Forms.NumericUpDown gradeNumberInput;
    }
}