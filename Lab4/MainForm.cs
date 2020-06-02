using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            task1Control.PlotClick += Task1Plot;
        }


        //Task 1
        private void Task1Plot(object sender, EventArgs e)
        {
            string name = $"x * sin[ √ (x + {task1Control.BParam} + {task1Control.CParam}) ]";

            task1Control.SetPlotData(name,
                                     GetFunctionTabValues(task1Control.XStart, task1Control.XEnd, task1Control.XDelta,
                                                          x => x * Math.Sin(Math.Sqrt(x + task1Control.BParam +
                                                                                      task1Control.CParam))));
        }

        private Dictionary<double, double> GetFunctionTabValues(double xStart, double xEnd, double xDelta, Func<double, double> foo)
        {
            var values = new Dictionary<double, double>();

            var xCurrent = xStart;

            do
            {
                values.Add(xCurrent, foo(xCurrent));

                xCurrent += xDelta;

            } while (xCurrent < xEnd);

            values.Add(xEnd, foo(xEnd));

            return values;
        }
    }
}
