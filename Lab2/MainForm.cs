using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            task1Control.CalculateClick += DoTask1;
        }


        private void DoTask1(object sender, EventArgs e)
        {
            task1Control.FunctionTabValues =
                GetFunctionTabValues(task1Control.XStart, task1Control.XEnd, task1Control.XDelta, 
                                     x => x * Math.Sin(Math.Sqrt(x + task1Control.BParam + task1Control.CParam)));
        }

        private Dictionary<double, double> GetFunctionTabValues(double xStart, double xEnd, double xDelta, Func<double, double> foo)
        {
            var values = new Dictionary<double, double>();

            var xCurrent = xStart;

            do
            {
                values.Add(xCurrent, foo(xCurrent));

                xCurrent += xDelta;

            } while (
                (xDelta > 0 && xCurrent < xEnd)
                ||(xDelta < 0 && xCurrent > xEnd));

            values.Add(xEnd, foo(xEnd));

            return values;
        }




    }
}
