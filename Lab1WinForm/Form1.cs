using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lab1WinForm
{
    public partial class MainForm : Form
    {
        private static readonly IFormatProvider AmericanCulture = new CultureInfo("en-US");
        private static readonly Color ErrorColor = Color.FromArgb(255, 170, 170);

        public MainForm()
        {
            InitializeComponent();

            xInput.BackColor = ErrorColor;
            yInput.BackColor = ErrorColor;
            zInput.BackColor = ErrorColor;

            _isFirstXInputValid = false;
            _isFirstYInputValid = false;
            _isFirstZInputValid = false;

            calculateFirstFooButton.Enabled = false;


            xInputTextBox.BackColor = ErrorColor;
            qInputTextBox.BackColor = ErrorColor;

            _isSecondXInputValid = false;
            _isSecondQInputValid = false;

            calculateSecondFooButton.Enabled = false;
        }

        private bool IsTextBoxInputValidDouble(TextBox inputTextBox)
        {
            var isInputValid = double.TryParse(inputTextBox.Text, NumberStyles.Float, AmericanCulture, out _);

            if (isInputValid)
                inputTextBox.BackColor = Color.White;
            else
                inputTextBox.BackColor = ErrorColor;

            return isInputValid;
        }


#region First Foo

        private bool _isFirstXInputValid;
        private bool _isFirstYInputValid;
        private bool _isFirstZInputValid;


        private void calculateFirstFooButton_Click(object sender, EventArgs e)
        {
            var x = double.Parse(xInput.Text, AmericanCulture);
            var y = double.Parse(yInput.Text, AmericanCulture);
            var z = double.Parse(zInput.Text, AmericanCulture);

            aOutput.Text = CalculateFooOne(x, y, z).ToString(AmericanCulture);
        }

        private static double CalculateFooOne(double x, double y, double z)
        {
            return Math.Pow(2, -x) *
                   Math.Sqrt(x + Math.Pow(Math.Abs(y), 1.0 / 4)) *
                   Math.Pow(Math.Exp((x - 1) / Math.Sin(z)), 1.0 / 3);
        }


        private void clearFirstButton_Click(object sender, EventArgs e)
        {
            xInput.Clear();
            yInput.Clear();
            zInput.Clear();

            aOutput.Clear();
        }


        
        private void xInput_TextChanged(object sender, EventArgs e)
        {
            _isFirstXInputValid = IsTextBoxInputValidDouble((TextBox)sender);

            calculateFirstFooButton.Enabled = _isFirstXInputValid && _isFirstYInputValid && _isFirstZInputValid;
        }

        private void yInput_TextChanged(object sender, EventArgs e)
        {
            _isFirstYInputValid = IsTextBoxInputValidDouble((TextBox)sender);

            calculateFirstFooButton.Enabled = _isFirstXInputValid && _isFirstYInputValid && _isFirstZInputValid;
        }

        private void zInput_TextChanged(object sender, EventArgs e)
        {
            _isFirstZInputValid = IsTextBoxInputValidDouble((TextBox)sender);

            calculateFirstFooButton.Enabled = _isFirstXInputValid && _isFirstYInputValid && _isFirstZInputValid;
        }

#endregion


#region SecondFoo

        private bool _isSecondXInputValid;
        private bool _isSecondQInputValid;

        private delegate double F(double x);

        private void calculateSecondFooButton_Click(object sender, EventArgs e)
        {
            var x = double.Parse(xInputTextBox.Text, AmericanCulture);
            var q = double.Parse(qInputTextBox.Text, AmericanCulture);

            F f;

            if (shinusRadioButton.Checked)
                f = Math.Sinh;
            else if (powerRadioButton.Checked)
                f = arg => arg*arg;
            else //if (expRadioButton.Checked)
                f = Math.Exp;


            dOutputTextBox.Text = CalculateFooTwo(x, q, f).ToString(AmericanCulture);
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
            xInputTextBox.Clear();
            qInputTextBox.Clear();

            dOutputTextBox.Clear();
        }


        private void xInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _isSecondXInputValid = IsTextBoxInputValidDouble((TextBox) sender);

            calculateSecondFooButton.Enabled = _isSecondXInputValid && _isSecondQInputValid;
        }

        private void qInputTextBox_TextChanged(object sender, EventArgs e)
        {
            _isSecondQInputValid = IsTextBoxInputValidDouble((TextBox)sender);

            calculateSecondFooButton.Enabled = _isSecondXInputValid && _isSecondQInputValid;
        }
#endregion
    }
}
