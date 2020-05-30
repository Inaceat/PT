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

                _outTextBox.Text = "";

                foreach (var argAndValuePair in value)
                    _outTextBox.Text += $"{argAndValuePair.Key}\t{argAndValuePair.Value}\r\n";
            }
        }


        private void ValidateForm(object sender, EventArgs e)
        {
            var xDeltaIsDouble = double.TryParse(_xDeltaInput.Text, out var xDelta);
            if (xDeltaIsDouble && xDelta > 0)
            {
                MarkAsValid(_xDeltaInput);
            }
            else
            {
                MarkAsInvalid(_xDeltaInput);
            }


            var xStartIsDouble = double.TryParse(_xStartInput.Text, out var xStart);
            var xEndIsDouble = double.TryParse(_xEndInput.Text, out var xEnd);
            if (xStartIsDouble && xEndIsDouble && xStart < xEnd)
            {
                MarkAsValid(_xStartInput);
                MarkAsValid(_xEndInput);
            }
            else
            {
                MarkAsInvalid(_xStartInput);
                MarkAsInvalid(_xEndInput);
            }

            
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
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            Label label5;

            _xEndInput = new TextBox();
            _xDeltaInput = new TextBox();
            _xStartInput = new TextBox();
            _outTextBox = new TextBox();
            _doTaskButton = new Button();
            _cParamInput = new TextBox();
            _bParamInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            
            // 
            // xEndInput
            // 
            _xEndInput.Location = new Point(56, 140);
            _xEndInput.Name = "_xEndInput";
            _xEndInput.Size = new Size(100, 20);
            _xEndInput.TabIndex = 3;
            // 
            // xDeltaInput
            // 
            _xDeltaInput.Location = new Point(56, 166);
            _xDeltaInput.Name = "_xDeltaInput";
            _xDeltaInput.Size = new Size(100, 20);
            _xDeltaInput.TabIndex = 2;
            // 
            // xStartInput
            // 
            _xStartInput.Location = new Point(56, 114);
            _xStartInput.Name = "_xStartInput";
            _xStartInput.Size = new Size(100, 20);
            _xStartInput.TabIndex = 1;
            // 
            // outTextBox
            // 
            _outTextBox.BackColor = SystemColors.Window;
            _outTextBox.Dock = DockStyle.Right;
            _outTextBox.Location = new Point(394, 3);
            _outTextBox.Multiline = true;
            _outTextBox.Name = "_outTextBox";
            _outTextBox.ReadOnly = true;
            _outTextBox.ScrollBars = ScrollBars.Vertical;
            _outTextBox.Size = new Size(302, 374);
            _outTextBox.TabIndex = 0;
            // 
            // doTaskButton
            // 
            _doTaskButton.Location = new Point(148, 262);
            _doTaskButton.Name = "_doTaskButton";
            _doTaskButton.Size = new Size(75, 23);
            _doTaskButton.TabIndex = 4;
            _doTaskButton.Text = "Calculate";
            _doTaskButton.UseVisualStyleBackColor = true;
            // 
            // cParamInput
            // 
            _cParamInput.Location = new Point(240, 155);
            _cParamInput.Name = "_cParamInput";
            _cParamInput.Size = new Size(100, 20);
            _cParamInput.TabIndex = 6;
            // 
            // bParamInput
            // 
            _bParamInput.Location = new Point(240, 129);
            _bParamInput.Name = "bParamInput";
            _bParamInput.Size = new Size(100, 20);
            _bParamInput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 117);
            label1.Name = "label1";
            label1.Size = new Size(20, 13);
            label1.TabIndex = 7;
            label1.Text = "Xo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 143);
            label2.Name = "label2";
            label2.Size = new Size(20, 13);
            label2.TabIndex = 8;
            label2.Text = "Xn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 169);
            label3.Name = "label3";
            label3.Size = new Size(30, 13);
            label3.TabIndex = 9;
            label3.Text = "delta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 158);
            label4.Name = "label4";
            label4.Size = new Size(13, 13);
            label4.TabIndex = 10;
            label4.Text = "c";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 132);
            label5.Name = "label5";
            label5.Size = new Size(13, 13);
            label5.TabIndex = 11;
            label5.Text = "b";

            SuspendLayout();
            
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_cParamInput);
            Controls.Add(_bParamInput);
            Controls.Add(_doTaskButton);
            Controls.Add(_xEndInput);
            Controls.Add(_xDeltaInput);
            Controls.Add(_xStartInput);
            Controls.Add(_outTextBox);

            ResumeLayout(false);
        }


        private TextBox _xStartInput;
        private TextBox _xEndInput;
        private TextBox _xDeltaInput;

        private TextBox _bParamInput;
        private TextBox _cParamInput;
        
        private Button _doTaskButton;
        
        private TextBox _outTextBox;
    }
}
