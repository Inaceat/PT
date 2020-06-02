using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab4
{
    public partial class Task1Control : UserControl
    {
        public Task1Control()
        {
            InitializeComponent();

            
            functionChart.Series.Clear();
            

            _inputs.Add(xStartInput);
            _inputs.Add(xEndInput);
            _inputs.Add(xDeltaInput);
            _inputs.Add(bParamInput);
            _inputs.Add(cParamInput);

            xStartInput.TextChanged += ValidateForm;
            xEndInput.TextChanged += ValidateForm;
            xDeltaInput.TextChanged += ValidateForm;
            bParamInput.TextChanged += ValidateForm;
            cParamInput.TextChanged += ValidateForm;

            ValidateForm(null, null);
        }


        public event EventHandler PlotClick
        {
            add { plotButton.Click += value; }
            remove { plotButton.Click -= value; }
        }


        public double XStart => double.Parse(xStartInput.Text);
        public double XEnd => double.Parse(xEndInput.Text);
        public double XDelta => double.Parse(xDeltaInput.Text);

        public double BParam => double.Parse(bParamInput.Text);
        public double CParam => double.Parse(cParamInput.Text);


        public void SetPlotData(string name, Dictionary<double, double> data)
        {
            functionChart.Series.Clear();


            var series = new Series(name)
            {
                BorderWidth = 3,
                ChartType = SeriesChartType.Spline
            };
            
            series.Points.DataBindXY(data.Keys, data.Values);
           
            
            
            functionChart.Series.Add(series);
        }


        private readonly List<TextBox> _inputs = new List<TextBox>();

        //...
        private void ValidateForm(object sender, EventArgs e)
        {
            var xStartIsDouble = double.TryParse(xStartInput.Text, out var xStart);
            var xEndIsDouble = double.TryParse(xEndInput.Text, out var xEnd);


            if (xStartIsDouble && xEndIsDouble && xStart < xEnd)
            {
                MarkAsValid(xStartInput);
                MarkAsValid(xEndInput);
            }
            else
            {
                MarkAsInvalid(xStartInput);
                MarkAsInvalid(xEndInput);
            }
           

            var xDeltaIsDouble = double.TryParse(xDeltaInput.Text, out var xDelta);
            if (xDeltaIsDouble && xDelta > 0)
                MarkAsValid(xDeltaInput);
            else
                MarkAsInvalid(xDeltaInput);

            

            if (double.TryParse(bParamInput.Text, out _))
                MarkAsValid(bParamInput);
            else
                MarkAsInvalid(bParamInput);
            
            
            if (double.TryParse(cParamInput.Text, out _))
                MarkAsValid(cParamInput);
            else
                MarkAsInvalid(cParamInput);
            
            
            //Moar "..."
            plotButton.Enabled = _inputs.TrueForAll(box => box.BackColor.Equals(Color.White));
        }
        
        private void MarkAsValid(TextBox textBox)
        {
            textBox.BackColor = Color.White;
        }

        private void MarkAsInvalid(TextBox textBox)
        {
            textBox.BackColor = Color.FromArgb(255, 170, 170);
        }
    }
}
