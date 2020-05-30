using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    internal class Task1Control : UserControl
    {
        public Task1Control()
        {
            InitializeComponent();

            _xStartInput.TextChanged += ValidateForm;
            _xEndInput.TextChanged += ValidateForm;
            _xDeltaInput.TextChanged += ValidateForm;

            _bParamInput.TextChanged += ValidateForm;
            _cParamInput.TextChanged += ValidateForm;


            MarkAsInvalid(_xStartInput);
            MarkAsInvalid(_xEndInput);
            MarkAsInvalid(_xDeltaInput);
            
            MarkAsInvalid(_bParamInput);
            MarkAsInvalid(_cParamInput);
        }


        public event EventHandler CalculateClick
        {
            add { _doTaskButton.Click += value; }
            remove { _doTaskButton.Click -= value; }
        }


        public double XStart => double.Parse(_xStartInput.Text);
        public double XEnd => double.Parse(_xEndInput.Text);
        public double XDelta => double.Parse(_xDeltaInput.Text);

        public double BParam => double.Parse(_bParamInput.Text);
        public double CParam => double.Parse(_cParamInput.Text);


        public Dictionary<double, double> FunctionTabValues
        {
            set
            {
                if (value == null) 
                    return;

                _outTextBox.ResetText();

                foreach (var argAndValuePair in value)
                    _outTextBox.Text += $"{argAndValuePair.Key}\t{argAndValuePair.Value}\r\n";
            }
        }

        //...
        private void ValidateForm(object sender, EventArgs e)
        {
            
            var xStartIsDouble = double.TryParse(_xStartInput.Text, out var xStart);
            var xEndIsDouble = double.TryParse(_xEndInput.Text, out var xEnd);
            

            if (xStartIsDouble)
                MarkAsValid(_xStartInput);
            else
                MarkAsInvalid(_xStartInput);


            if (xEndIsDouble)
                MarkAsValid(_xEndInput);
            else
                MarkAsInvalid(_xEndInput);



            var xDeltaIsDouble = double.TryParse(_xDeltaInput.Text, out var xDelta);
            if (xDeltaIsDouble && Math.Abs(xDelta) > double.Epsilon)
            {
                if (xStartIsDouble && xEndIsDouble && Math.Sign(xDelta) == Math.Sign(xEnd - xStart)
                    || !xStartIsDouble
                    || !xEndIsDouble
                )
                    MarkAsValid(_xDeltaInput);
                else
                    MarkAsInvalid(_xDeltaInput);
            }
            else
                MarkAsInvalid(_xDeltaInput);

            

            if (double.TryParse(_bParamInput.Text, out _))
                MarkAsValid(_bParamInput);
            else
                MarkAsInvalid(_bParamInput);
            
            
            if (double.TryParse(_cParamInput.Text, out _))
                MarkAsValid(_cParamInput);
            else
                MarkAsInvalid(_cParamInput);
        }


        
        private void MarkAsValid(TextBox textBox)
        {
            textBox.BackColor = Color.White;
        }

        private void MarkAsInvalid(TextBox textBox)
        {
            textBox.BackColor = Color.FromArgb(255, 170, 170);
        }



        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._xEndInput = new System.Windows.Forms.TextBox();
            this._xDeltaInput = new System.Windows.Forms.TextBox();
            this._xStartInput = new System.Windows.Forms.TextBox();
            this._outTextBox = new System.Windows.Forms.TextBox();
            this._doTaskButton = new System.Windows.Forms.Button();
            this._cParamInput = new System.Windows.Forms.TextBox();
            this._bParamInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Xo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Xn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "delta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "b";
            // 
            // _xEndInput
            // 
            this._xEndInput.Location = new System.Drawing.Point(56, 140);
            this._xEndInput.Name = "_xEndInput";
            this._xEndInput.Size = new System.Drawing.Size(100, 20);
            this._xEndInput.TabIndex = 3;
            // 
            // _xDeltaInput
            // 
            this._xDeltaInput.Location = new System.Drawing.Point(56, 166);
            this._xDeltaInput.Name = "_xDeltaInput";
            this._xDeltaInput.Size = new System.Drawing.Size(100, 20);
            this._xDeltaInput.TabIndex = 2;
            // 
            // _xStartInput
            // 
            this._xStartInput.Location = new System.Drawing.Point(56, 114);
            this._xStartInput.Name = "_xStartInput";
            this._xStartInput.Size = new System.Drawing.Size(100, 20);
            this._xStartInput.TabIndex = 1;
            // 
            // _outTextBox
            // 
            this._outTextBox.BackColor = System.Drawing.SystemColors.Window;
            this._outTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this._outTextBox.Location = new System.Drawing.Point(365, 0);
            this._outTextBox.Multiline = true;
            this._outTextBox.Name = "_outTextBox";
            this._outTextBox.ReadOnly = true;
            this._outTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._outTextBox.Size = new System.Drawing.Size(302, 436);
            this._outTextBox.TabIndex = 0;
            // 
            // _doTaskButton
            // 
            this._doTaskButton.Location = new System.Drawing.Point(148, 262);
            this._doTaskButton.Name = "_doTaskButton";
            this._doTaskButton.Size = new System.Drawing.Size(75, 23);
            this._doTaskButton.TabIndex = 4;
            this._doTaskButton.Text = "Calculate";
            this._doTaskButton.UseVisualStyleBackColor = true;
            // 
            // _cParamInput
            // 
            this._cParamInput.Location = new System.Drawing.Point(240, 155);
            this._cParamInput.Name = "_cParamInput";
            this._cParamInput.Size = new System.Drawing.Size(100, 20);
            this._cParamInput.TabIndex = 6;
            // 
            // _bParamInput
            // 
            this._bParamInput.Location = new System.Drawing.Point(240, 129);
            this._bParamInput.Name = "_bParamInput";
            this._bParamInput.Size = new System.Drawing.Size(100, 20);
            this._bParamInput.TabIndex = 5;
            // 
            // Task1Control
            // 
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cParamInput);
            this.Controls.Add(this._bParamInput);
            this.Controls.Add(this._doTaskButton);
            this.Controls.Add(this._xEndInput);
            this.Controls.Add(this._xDeltaInput);
            this.Controls.Add(this._xStartInput);
            this.Controls.Add(this._outTextBox);
            this.Name = "Task1Control";
            this.Size = new System.Drawing.Size(667, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private TextBox _xStartInput;
        private TextBox _xEndInput;
        private TextBox _xDeltaInput;

        private TextBox _bParamInput;
        private TextBox _cParamInput;
        
        private Button _doTaskButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox _outTextBox;
    }
}
