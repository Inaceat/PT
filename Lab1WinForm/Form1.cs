using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1WinForm
{
    public partial class MainForm : Form
    {
        private static readonly IFormatProvider RussianCulture = new CultureInfo("ru-RU");
        private static readonly Color ErrorColor = Color.FromArgb(255, 170, 170);

        public MainForm()
        {
            InitializeComponent();

            _selectedFoo = Math.Sinh;

            FirstInputTextChanged(null, null);
            SecondInputTextChanged(null, null);
        }

#region First Foo

        private void calculateFirstFooButton_Click(object sender, EventArgs e)
        {
            var x = double.Parse(firstXInput.Text, RussianCulture);
            var y = double.Parse(firstYInput.Text, RussianCulture);
            var z = double.Parse(firstZInput.Text, RussianCulture);
        
            var result = CalculateFooOne(x, y, z);

            firstAOutput.Text = result.ToString(RussianCulture);
        }

        private static double CalculateFooOne(double x, double y, double z)
        {
            return Math.Pow(2, -x) *
                   Math.Sqrt(x + Math.Pow(Math.Abs(y), 1.0 / 4)) *
                   Math.Pow(Math.Exp((x - 1) / Math.Sin(z)), 1.0 / 3);
        }
        

        private void clearFirstButton_Click(object sender, EventArgs e)
        {
            firstXInput.Clear();
            firstYInput.Clear();
            firstZInput.Clear();

            firstAOutput.Clear();
        }


        private (List<TextBox> validInputs, List<TextBox> invalidInputs, List<string> errors) 
            ValidateFirstFooInput(TextBox xInput, TextBox yInput, TextBox zInput)
        {
            var validInputs = new List<TextBox>();
            var invalidInputs = new List<TextBox>();
            var errors = new List<string>();

            //X & Y
            double x;
            double y;

            var isXValidDouble = double.TryParse(xInput.Text, NumberStyles.Float, RussianCulture, out x);
            var isYValidDouble = double.TryParse(yInput.Text, NumberStyles.Float, RussianCulture, out y);

            //If valid numbers
            if (isXValidDouble && isYValidDouble)
            {
                //And not in function definition interval
                if (x + Math.Pow(Math.Abs(y), 1.0 / 4) < 0)
                {
                    invalidInputs.Add(xInput);
                    invalidInputs.Add(yInput);

                    errors.Add("X+abs(Y)^4 should be >= 0");
                }
                else//numbers from D(f)
                {
                    validInputs.Add(xInput);
                    validInputs.Add(yInput);
                }
                
            }
            else//if at least one is invalid
            {
                if (isXValidDouble)
                    validInputs.Add(xInput);
                else
                {
                    invalidInputs.Add(xInput);
                    errors.Add("X is not a number");
                }

                if (isYValidDouble)
                    validInputs.Add(yInput);
                else
                {
                    invalidInputs.Add(yInput);
                    errors.Add("Y is not a number");
                }
            }

            //Z
            if (double.TryParse(zInput.Text, NumberStyles.Float, RussianCulture, out _))
                validInputs.Add(zInput);
            else
            {
                invalidInputs.Add(zInput);
                errors.Add("Z is not a number");
            }

            return (validInputs, invalidInputs, errors);
        }

        
        private void FirstInputTextChanged(object sender, EventArgs e)
        {
            var (valids, invalids, errors) = ValidateFirstFooInput(firstXInput, firstYInput, firstZInput);

            foreach (var textBox in valids)
                textBox.BackColor = Color.White;

            foreach (var textBox in invalids)
                textBox.BackColor = ErrorColor;

            if (invalids.Count == 0)
            {
                firstCalculateButton.Enabled = true;
                firstErrorProvider.Clear(); 
            }
            else
            {
                firstCalculateButton.Enabled = false;

                var sb = new StringBuilder();

                foreach (var errorText in errors)
                    sb.AppendLine(errorText);

                firstErrorProvider.SetError(firstCalculateButton, sb.ToString());
            }
        }

#endregion


#region SecondFoo
        
        private delegate double F(double x);
        private F _selectedFoo;

        private void calculateSecondFooButton_Click(object sender, EventArgs e)
        {
            var x = double.Parse(secondXInput.Text, RussianCulture);
            var q = double.Parse(secondQInput.Text, RussianCulture);
        
            secondDOutput.Text = CalculateFooTwo(x, q, _selectedFoo).ToString(RussianCulture);
        }

        private double CalculateFooTwo(double x, double q, F f)
        {
            var abs = Math.Abs(x * q);

            if (Math.Abs(10 - abs) < double.Epsilon)
                return f(x) + q;

            if (abs > 10)
                return Math.Log(Math.Abs(f(x)) + Math.Abs(q));

            return Math.Exp(f(x) + q);
        }


        private void clearSecondButton_Click(object sender, EventArgs e)
        {
            secondXInput.Clear();
            secondQInput.Clear();

            secondDOutput.Clear();
        }


        private (List<Control> validInputs, List<Control> invalidInputs, List<string> errors)
            ValidateSecondFooInput(TextBox xInput, TextBox qInput)
        {
            var validInputs = new List<Control>();
            var invalidInputs = new List<Control>();
            var errors = new List<string>();

            var isXValid = double.TryParse(xInput.Text, NumberStyles.Float, RussianCulture, out var x);
            var isQValid = double.TryParse(qInput.Text, NumberStyles.Float, RussianCulture, out var q);

            if (isXValid && isQValid)
            {
                var result = CalculateFooTwo(x, q, _selectedFoo);

                if (double.IsNaN(result) || double.IsInfinity(result))
                {
                    invalidInputs.Add(xInput);
                    invalidInputs.Add(qInput);
                    errors.Add("Cannot calculate function with current arguments");
                }
                else
                {
                    validInputs.Add(xInput);
                    validInputs.Add(qInput);
                }
            }
            else
            {
                //X
                if (isXValid)
                    validInputs.Add(xInput);
                else
                {
                    invalidInputs.Add(xInput);
                    errors.Add("X is not a number");
                }

                //Q
                if (isQValid)
                    validInputs.Add(qInput);
                else
                {
                    invalidInputs.Add(qInput);
                    errors.Add("Q is not a number");
                }
            }

            return (validInputs, invalidInputs, errors);
        }


        private void SecondInputTextChanged(object sender, EventArgs e)
        {
            var (valids, invalids, errors) = ValidateSecondFooInput(secondXInput, secondQInput);

            foreach (var textBox in valids)
                textBox.BackColor = Color.White;

            foreach (var textBox in invalids)
                textBox.BackColor = ErrorColor;

            if (invalids.Count == 0)
            {
                secondCalculateButton.Enabled = true;
                secondErrorProvider.Clear();
            }
            else
            {
                secondCalculateButton.Enabled = false;

                var sb = new StringBuilder();

                foreach (var errorText in errors)
                    sb.AppendLine(errorText);

                secondErrorProvider.SetError(secondCalculateButton, sb.ToString());
            }
        }

        private void RadioCheckedChanged(object sender, EventArgs e)
        {
            if (secondShinusRadio.Checked)
                _selectedFoo = Math.Sinh;
            else if (secondPowerRadio.Checked)
                _selectedFoo = d => d * d;
            else //if (expRadioButton.Checked)
                _selectedFoo = Math.Exp;

            SecondInputTextChanged(null, null);
        }

#endregion
    }
}
