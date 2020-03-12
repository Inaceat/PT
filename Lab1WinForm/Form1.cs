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

            InputTextChanged(null, null);

        }

        private bool IsTextBoxInputValidDouble(TextBox inputTextBox)
        {
            return double.TryParse(inputTextBox.Text, NumberStyles.Float, RussianCulture, out _);
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

        
        private void InputTextChanged(object sender, EventArgs e)
        {
            var (valids, invalids, errors) = ValidateFirstFooInput(firstXInput, firstYInput, firstZInput);

            foreach (var textBox in valids)
                textBox.BackColor = Color.White;

            foreach (var textBox in invalids)
                textBox.BackColor = ErrorColor;

            if (invalids.Count == 0)
            {
                firstCalculateButton.Enabled = true;
                errorProvider.Clear(); 
            }
            else
            {
                firstCalculateButton.Enabled = false;

                var sb = new StringBuilder();

                foreach (var errorText in errors)
                    sb.AppendLine(errorText);

                errorProvider.SetError(firstCalculateButton, sb.ToString());
            }
        }

#endregion


#region SecondFoo

        private bool _isSecondXInputValid;
        private bool _isSecondQInputValid;

        private delegate double F(double x);

        private void calculateSecondFooButton_Click(object sender, EventArgs e)
        {
            var x = double.Parse(secondXInput.Text, RussianCulture);
            var q = double.Parse(secondQInput.Text, RussianCulture);

            F f;

            if (secondShinusRadio.Checked)
                f = Math.Sinh;
            else if (secondPowerRadio.Checked)
                f = arg => arg*arg;
            else //if (expRadioButton.Checked)
                f = Math.Exp;


            var result = CalculateFooTwo(x, q, f);

            if (double.IsNaN(result) || double.IsInfinity(result))
                secondDOutput.Text = "Invalid data";
            else
                secondDOutput.Text = result.ToString(RussianCulture);
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


        private void xInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _isSecondXInputValid = IsTextBoxInputValidDouble((TextBox) sender);

            secondCalculateButton.Enabled = _isSecondXInputValid && _isSecondQInputValid;
        }

        private void qInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _isSecondQInputValid = IsTextBoxInputValidDouble((TextBox)sender);

            secondCalculateButton.Enabled = _isSecondXInputValid && _isSecondQInputValid;
        }
#endregion
    }
}
