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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.firstCalculateButton = new System.Windows.Forms.Button();
            this.firstXInput = new System.Windows.Forms.TextBox();
            this.firstYInput = new System.Windows.Forms.TextBox();
            this.firstAOutput = new System.Windows.Forms.TextBox();
            this.firstZInput = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.firstClearButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.secondClearButton = new System.Windows.Forms.Button();
            this.secondCalculateButton = new System.Windows.Forms.Button();
            this.secondQInput = new System.Windows.Forms.TextBox();
            this.secondXInput = new System.Windows.Forms.TextBox();
            this.secondDOutput = new System.Windows.Forms.TextBox();
            this.secondFunctionsGroup = new System.Windows.Forms.GroupBox();
            this.secondPowerRadio = new System.Windows.Forms.RadioButton();
            this.secondExpRadio = new System.Windows.Forms.RadioButton();
            this.secondShinusRadio = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.secondFunctionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            // firstCalculateButton
            // 
            this.firstCalculateButton.Enabled = false;
            this.firstCalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstCalculateButton.Location = new System.Drawing.Point(143, 118);
            this.firstCalculateButton.Name = "firstCalculateButton";
            this.firstCalculateButton.Size = new System.Drawing.Size(152, 74);
            this.firstCalculateButton.TabIndex = 4;
            this.firstCalculateButton.Text = "Calculate";
            this.firstCalculateButton.UseVisualStyleBackColor = true;
            this.firstCalculateButton.Click += new System.EventHandler(this.calculateFirstFooButton_Click);
            // 
            // firstXInput
            // 
            this.firstXInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstXInput.Location = new System.Drawing.Point(143, 19);
            this.firstXInput.Name = "firstXInput";
            this.firstXInput.Size = new System.Drawing.Size(152, 23);
            this.firstXInput.TabIndex = 1;
            this.firstXInput.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // firstYInput
            // 
            this.firstYInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstYInput.Location = new System.Drawing.Point(143, 47);
            this.firstYInput.Name = "firstYInput";
            this.firstYInput.Size = new System.Drawing.Size(152, 23);
            this.firstYInput.TabIndex = 2;
            this.firstYInput.TextChanged += new System.EventHandler(this.InputTextChanged);
            // 
            // firstAOutput
            // 
            this.firstAOutput.BackColor = System.Drawing.SystemColors.Window;
            this.firstAOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstAOutput.Location = new System.Drawing.Point(143, 212);
            this.firstAOutput.Name = "firstAOutput";
            this.firstAOutput.ReadOnly = true;
            this.firstAOutput.Size = new System.Drawing.Size(152, 23);
            this.firstAOutput.TabIndex = 5;
            // 
            // firstZInput
            // 
            this.firstZInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstZInput.Location = new System.Drawing.Point(143, 76);
            this.firstZInput.Name = "firstZInput";
            this.firstZInput.Size = new System.Drawing.Size(152, 23);
            this.firstZInput.TabIndex = 3;
            this.firstZInput.TextChanged += new System.EventHandler(this.InputTextChanged);
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
            this.tabPage1.Controls.Add(this.firstClearButton);
            this.tabPage1.Controls.Add(this.firstCalculateButton);
            this.tabPage1.Controls.Add(label4);
            this.tabPage1.Controls.Add(this.firstXInput);
            this.tabPage1.Controls.Add(this.firstZInput);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(label3);
            this.tabPage1.Controls.Add(this.firstYInput);
            this.tabPage1.Controls.Add(this.firstAOutput);
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Foo One";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // firstClearButton
            // 
            this.firstClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstClearButton.Location = new System.Drawing.Point(301, 212);
            this.firstClearButton.Name = "firstClearButton";
            this.firstClearButton.Size = new System.Drawing.Size(75, 23);
            this.firstClearButton.TabIndex = 6;
            this.firstClearButton.Text = "Clear";
            this.firstClearButton.UseVisualStyleBackColor = true;
            this.firstClearButton.Click += new System.EventHandler(this.clearFirstButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.secondClearButton);
            this.tabPage2.Controls.Add(this.secondCalculateButton);
            this.tabPage2.Controls.Add(label5);
            this.tabPage2.Controls.Add(this.secondQInput);
            this.tabPage2.Controls.Add(label6);
            this.tabPage2.Controls.Add(this.secondXInput);
            this.tabPage2.Controls.Add(this.secondDOutput);
            this.tabPage2.Controls.Add(label7);
            this.tabPage2.Controls.Add(this.secondFunctionsGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Foo Two";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // secondClearButton
            // 
            this.secondClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.secondClearButton.Location = new System.Drawing.Point(229, 197);
            this.secondClearButton.Name = "secondClearButton";
            this.secondClearButton.Size = new System.Drawing.Size(75, 23);
            this.secondClearButton.TabIndex = 13;
            this.secondClearButton.Text = "Clear";
            this.secondClearButton.UseVisualStyleBackColor = true;
            this.secondClearButton.Click += new System.EventHandler(this.clearSecondButton_Click);
            // 
            // secondCalculateButton
            // 
            this.secondCalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondCalculateButton.Location = new System.Drawing.Point(71, 103);
            this.secondCalculateButton.Name = "secondCalculateButton";
            this.secondCalculateButton.Size = new System.Drawing.Size(152, 74);
            this.secondCalculateButton.TabIndex = 11;
            this.secondCalculateButton.Text = "Calculate";
            this.secondCalculateButton.UseVisualStyleBackColor = true;
            this.secondCalculateButton.Click += new System.EventHandler(this.calculateSecondFooButton_Click);
            // 
            // secondQInput
            // 
            this.secondQInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondQInput.Location = new System.Drawing.Point(71, 61);
            this.secondQInput.Name = "secondQInput";
            this.secondQInput.Size = new System.Drawing.Size(152, 23);
            this.secondQInput.TabIndex = 10;
            this.secondQInput.TextChanged += new System.EventHandler(this.qInputTextBox_TextChanged);
            // 
            // secondXInput
            // 
            this.secondXInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondXInput.Location = new System.Drawing.Point(71, 32);
            this.secondXInput.Name = "secondXInput";
            this.secondXInput.Size = new System.Drawing.Size(152, 23);
            this.secondXInput.TabIndex = 9;
            this.secondXInput.TextChanged += new System.EventHandler(this.xInputTextBox_TextChanged);
            // 
            // secondDOutput
            // 
            this.secondDOutput.BackColor = System.Drawing.SystemColors.Window;
            this.secondDOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondDOutput.Location = new System.Drawing.Point(71, 197);
            this.secondDOutput.Name = "secondDOutput";
            this.secondDOutput.ReadOnly = true;
            this.secondDOutput.Size = new System.Drawing.Size(152, 23);
            this.secondDOutput.TabIndex = 12;
            // 
            // secondFunctionsGroup
            // 
            this.secondFunctionsGroup.Controls.Add(this.secondPowerRadio);
            this.secondFunctionsGroup.Controls.Add(this.secondExpRadio);
            this.secondFunctionsGroup.Controls.Add(this.secondShinusRadio);
            this.secondFunctionsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.secondFunctionsGroup.Location = new System.Drawing.Point(306, 6);
            this.secondFunctionsGroup.Name = "secondFunctionsGroup";
            this.secondFunctionsGroup.Size = new System.Drawing.Size(78, 104);
            this.secondFunctionsGroup.TabIndex = 3;
            this.secondFunctionsGroup.TabStop = false;
            this.secondFunctionsGroup.Text = "f(x)";
            // 
            // secondPowerRadio
            // 
            this.secondPowerRadio.AutoSize = true;
            this.secondPowerRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondPowerRadio.Location = new System.Drawing.Point(11, 45);
            this.secondPowerRadio.Name = "secondPowerRadio";
            this.secondPowerRadio.Size = new System.Drawing.Size(47, 21);
            this.secondPowerRadio.TabIndex = 1;
            this.secondPowerRadio.TabStop = true;
            this.secondPowerRadio.Text = "x^2";
            this.secondPowerRadio.UseVisualStyleBackColor = true;
            // 
            // secondExpRadio
            // 
            this.secondExpRadio.AutoSize = true;
            this.secondExpRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondExpRadio.Location = new System.Drawing.Point(11, 68);
            this.secondExpRadio.Name = "secondExpRadio";
            this.secondExpRadio.Size = new System.Drawing.Size(47, 21);
            this.secondExpRadio.TabIndex = 2;
            this.secondExpRadio.TabStop = true;
            this.secondExpRadio.Text = "e^x";
            this.secondExpRadio.UseVisualStyleBackColor = true;
            // 
            // secondShinusRadio
            // 
            this.secondShinusRadio.AutoSize = true;
            this.secondShinusRadio.Checked = true;
            this.secondShinusRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondShinusRadio.Location = new System.Drawing.Point(11, 22);
            this.secondShinusRadio.Name = "secondShinusRadio";
            this.secondShinusRadio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secondShinusRadio.Size = new System.Drawing.Size(57, 21);
            this.secondShinusRadio.TabIndex = 0;
            this.secondShinusRadio.TabStop = true;
            this.secondShinusRadio.Text = "sh(x)";
            this.secondShinusRadio.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
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
            this.secondFunctionsGroup.ResumeLayout(false);
            this.secondFunctionsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstCalculateButton;
        private System.Windows.Forms.TextBox firstXInput;
        private System.Windows.Forms.TextBox firstYInput;
        private System.Windows.Forms.TextBox firstAOutput;
        private System.Windows.Forms.TextBox firstZInput;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton secondExpRadio;
        private System.Windows.Forms.RadioButton secondPowerRadio;
        private System.Windows.Forms.RadioButton secondShinusRadio;
        private System.Windows.Forms.GroupBox secondFunctionsGroup;
        private System.Windows.Forms.Button secondCalculateButton;
        private System.Windows.Forms.TextBox secondQInput;
        private System.Windows.Forms.TextBox secondXInput;
        private System.Windows.Forms.TextBox secondDOutput;
        private System.Windows.Forms.Button firstClearButton;
        private System.Windows.Forms.Button secondClearButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

