namespace Lab1WinForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.calculateFirstFooButton = new System.Windows.Forms.Button();
            this.xInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.aOutput = new System.Windows.Forms.TextBox();
            this.zInput = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clearFirstButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearSecondButton = new System.Windows.Forms.Button();
            this.calculateSecondFooButton = new System.Windows.Forms.Button();
            this.qInputTextBox = new System.Windows.Forms.TextBox();
            this.xInputTextBox = new System.Windows.Forms.TextBox();
            this.dOutputTextBox = new System.Windows.Forms.TextBox();
            this.functionsGroupBox = new System.Windows.Forms.GroupBox();
            this.powerRadioButton = new System.Windows.Forms.RadioButton();
            this.expRadioButton = new System.Windows.Forms.RadioButton();
            this.shinusRadioButton = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.functionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(108, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 17);
            label1.TabIndex = 0;
            label1.Text = "X =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(108, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 17);
            label2.TabIndex = 0;
            label2.Text = "Y =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(108, 215);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 17);
            label3.TabIndex = 0;
            label3.Text = "A =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(108, 79);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 17);
            label4.TabIndex = 0;
            label4.Text = "Z =";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(36, 64);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 17);
            label5.TabIndex = 6;
            label5.Text = "Q =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(36, 200);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(30, 17);
            label6.TabIndex = 4;
            label6.Text = "D =";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.Location = new System.Drawing.Point(36, 35);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(29, 17);
            label7.TabIndex = 8;
            label7.Text = "X =";
            // 
            // calculateFirstFooButton
            // 
            this.calculateFirstFooButton.Enabled = false;
            this.calculateFirstFooButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateFirstFooButton.Location = new System.Drawing.Point(143, 118);
            this.calculateFirstFooButton.Name = "calculateFirstFooButton";
            this.calculateFirstFooButton.Size = new System.Drawing.Size(152, 74);
            this.calculateFirstFooButton.TabIndex = 4;
            this.calculateFirstFooButton.Text = "Calculate";
            this.calculateFirstFooButton.UseVisualStyleBackColor = true;
            this.calculateFirstFooButton.Click += new System.EventHandler(this.calculateFirstFooButton_Click);
            // 
            // xInput
            // 
            this.xInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xInput.Location = new System.Drawing.Point(143, 19);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(152, 23);
            this.xInput.TabIndex = 1;
            this.xInput.TextChanged += new System.EventHandler(this.xInput_TextChanged);
            // 
            // yInput
            // 
            this.yInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yInput.Location = new System.Drawing.Point(143, 47);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(152, 23);
            this.yInput.TabIndex = 2;
            this.yInput.TextChanged += new System.EventHandler(this.yInput_TextChanged);
            // 
            // aOutput
            // 
            this.aOutput.BackColor = System.Drawing.SystemColors.Window;
            this.aOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aOutput.Location = new System.Drawing.Point(143, 212);
            this.aOutput.Name = "aOutput";
            this.aOutput.ReadOnly = true;
            this.aOutput.Size = new System.Drawing.Size(152, 23);
            this.aOutput.TabIndex = 5;
            // 
            // zInput
            // 
            this.zInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zInput.Location = new System.Drawing.Point(143, 76);
            this.zInput.Name = "zInput";
            this.zInput.Size = new System.Drawing.Size(152, 23);
            this.zInput.TabIndex = 3;
            this.zInput.TextChanged += new System.EventHandler(this.zInput_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(425, 279);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clearFirstButton);
            this.tabPage1.Controls.Add(this.calculateFirstFooButton);
            this.tabPage1.Controls.Add(label4);
            this.tabPage1.Controls.Add(this.xInput);
            this.tabPage1.Controls.Add(this.zInput);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(label3);
            this.tabPage1.Controls.Add(this.yInput);
            this.tabPage1.Controls.Add(this.aOutput);
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Foo One";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clearFirstButton
            // 
            this.clearFirstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearFirstButton.Location = new System.Drawing.Point(301, 212);
            this.clearFirstButton.Name = "clearFirstButton";
            this.clearFirstButton.Size = new System.Drawing.Size(75, 23);
            this.clearFirstButton.TabIndex = 6;
            this.clearFirstButton.Text = "Clear";
            this.clearFirstButton.UseVisualStyleBackColor = true;
            this.clearFirstButton.Click += new System.EventHandler(this.clearFirstButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearSecondButton);
            this.tabPage2.Controls.Add(this.calculateSecondFooButton);
            this.tabPage2.Controls.Add(label5);
            this.tabPage2.Controls.Add(this.qInputTextBox);
            this.tabPage2.Controls.Add(label6);
            this.tabPage2.Controls.Add(this.xInputTextBox);
            this.tabPage2.Controls.Add(this.dOutputTextBox);
            this.tabPage2.Controls.Add(label7);
            this.tabPage2.Controls.Add(this.functionsGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Foo Two";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearSecondButton
            // 
            this.clearSecondButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearSecondButton.Location = new System.Drawing.Point(229, 197);
            this.clearSecondButton.Name = "clearSecondButton";
            this.clearSecondButton.Size = new System.Drawing.Size(75, 23);
            this.clearSecondButton.TabIndex = 13;
            this.clearSecondButton.Text = "Clear";
            this.clearSecondButton.UseVisualStyleBackColor = true;
            this.clearSecondButton.Click += new System.EventHandler(this.clearSecondButton_Click);
            // 
            // calculateSecondFooButton
            // 
            this.calculateSecondFooButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateSecondFooButton.Location = new System.Drawing.Point(71, 103);
            this.calculateSecondFooButton.Name = "calculateSecondFooButton";
            this.calculateSecondFooButton.Size = new System.Drawing.Size(152, 74);
            this.calculateSecondFooButton.TabIndex = 11;
            this.calculateSecondFooButton.Text = "Calculate";
            this.calculateSecondFooButton.UseVisualStyleBackColor = true;
            this.calculateSecondFooButton.Click += new System.EventHandler(this.calculateSecondFooButton_Click);
            // 
            // qInputTextBox
            // 
            this.qInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qInputTextBox.Location = new System.Drawing.Point(71, 61);
            this.qInputTextBox.Name = "qInputTextBox";
            this.qInputTextBox.Size = new System.Drawing.Size(152, 23);
            this.qInputTextBox.TabIndex = 10;
            this.qInputTextBox.TextChanged += new System.EventHandler(this.qInputTextBox_TextChanged);
            // 
            // xInputTextBox
            // 
            this.xInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xInputTextBox.Location = new System.Drawing.Point(71, 32);
            this.xInputTextBox.Name = "xInputTextBox";
            this.xInputTextBox.Size = new System.Drawing.Size(152, 23);
            this.xInputTextBox.TabIndex = 9;
            this.xInputTextBox.TextChanged += new System.EventHandler(this.xInputTextBox_TextChanged);
            // 
            // dOutputTextBox
            // 
            this.dOutputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dOutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dOutputTextBox.Location = new System.Drawing.Point(71, 197);
            this.dOutputTextBox.Name = "dOutputTextBox";
            this.dOutputTextBox.ReadOnly = true;
            this.dOutputTextBox.Size = new System.Drawing.Size(152, 23);
            this.dOutputTextBox.TabIndex = 12;
            // 
            // functionsGroupBox
            // 
            this.functionsGroupBox.Controls.Add(this.powerRadioButton);
            this.functionsGroupBox.Controls.Add(this.expRadioButton);
            this.functionsGroupBox.Controls.Add(this.shinusRadioButton);
            this.functionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.functionsGroupBox.Location = new System.Drawing.Point(306, 6);
            this.functionsGroupBox.Name = "functionsGroupBox";
            this.functionsGroupBox.Size = new System.Drawing.Size(78, 104);
            this.functionsGroupBox.TabIndex = 3;
            this.functionsGroupBox.TabStop = false;
            this.functionsGroupBox.Text = "f(x)";
            // 
            // powerRadioButton
            // 
            this.powerRadioButton.AutoSize = true;
            this.powerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerRadioButton.Location = new System.Drawing.Point(11, 45);
            this.powerRadioButton.Name = "powerRadioButton";
            this.powerRadioButton.Size = new System.Drawing.Size(47, 21);
            this.powerRadioButton.TabIndex = 1;
            this.powerRadioButton.TabStop = true;
            this.powerRadioButton.Text = "x^2";
            this.powerRadioButton.UseVisualStyleBackColor = true;
            // 
            // expRadioButton
            // 
            this.expRadioButton.AutoSize = true;
            this.expRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expRadioButton.Location = new System.Drawing.Point(11, 68);
            this.expRadioButton.Name = "expRadioButton";
            this.expRadioButton.Size = new System.Drawing.Size(47, 21);
            this.expRadioButton.TabIndex = 2;
            this.expRadioButton.TabStop = true;
            this.expRadioButton.Text = "e^x";
            this.expRadioButton.UseVisualStyleBackColor = true;
            // 
            // shinusRadioButton
            // 
            this.shinusRadioButton.AutoSize = true;
            this.shinusRadioButton.Checked = true;
            this.shinusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shinusRadioButton.Location = new System.Drawing.Point(11, 22);
            this.shinusRadioButton.Name = "shinusRadioButton";
            this.shinusRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shinusRadioButton.Size = new System.Drawing.Size(57, 21);
            this.shinusRadioButton.TabIndex = 0;
            this.shinusRadioButton.TabStop = true;
            this.shinusRadioButton.Text = "sh(x)";
            this.shinusRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(450, 303);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foo calculator";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.functionsGroupBox.ResumeLayout(false);
            this.functionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateFirstFooButton;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.TextBox aOutput;
        private System.Windows.Forms.TextBox zInput;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton expRadioButton;
        private System.Windows.Forms.RadioButton powerRadioButton;
        private System.Windows.Forms.RadioButton shinusRadioButton;
        private System.Windows.Forms.GroupBox functionsGroupBox;
        private System.Windows.Forms.Button calculateSecondFooButton;
        private System.Windows.Forms.TextBox qInputTextBox;
        private System.Windows.Forms.TextBox xInputTextBox;
        private System.Windows.Forms.TextBox dOutputTextBox;
        private System.Windows.Forms.Button clearFirstButton;
        private System.Windows.Forms.Button clearSecondButton;
    }
}

