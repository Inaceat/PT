using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


            task1Control.CalculateClick += DoTask1;


            _initialAray = new List<int>();
            _resultAray = new List<int>();
            _randomProvider = new Random(42);

            task2Control.RandomizeClick += Task2FillInitialArray;
            task2Control.FillResultButtonClick += Task2FillResultArray;
            task2Control.ChangeSignClick += Task2ShuffleResultSigns;
            task2Control.FilterClick += Task2FilterResultArray;
            task2Control.SortClick += Task2SortResultArray;
        }


        //Task 1
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


        //Task 2
        private readonly List<int> _initialAray;
        private List<int> _resultAray;
        private bool _isAscending = true;
        private readonly Random _randomProvider;


        //Randoms from D[f(x)]
        private void Task2FillInitialArray(object sender, EventArgs eventArgs)
        {
            _initialAray.Clear();
            _resultAray.Clear();

            for (int i = 0; i < 15; ++i)
                _initialAray.Add(_randomProvider.Next(-3, 100));


            task2Control.SetInitialData(_initialAray);
            task2Control.SetResultData(_resultAray);
        }

        //y = f(x)
        private void Task2FillResultArray(object sender, EventArgs eventArgs)
        {
            _resultAray.Clear();


            foreach (var item in _initialAray)
                _resultAray.Add((int)Math.Floor(Math.Sin(Math.Sqrt(3.4084 + item)) * item));

            task2Control.SetResultData(_resultAray);
        }
        
        //y = |y| * (-1)^(50% 0, 50% 1)
        private void Task2ShuffleResultSigns(object sender, EventArgs eventArgs)
        {
            for (var i = 0; i < _resultAray.Count; i++)
            {
                _resultAray[i] = Math.Abs(_resultAray[i]);

                if (0 == _randomProvider.Next(2))
                    _resultAray[i] *= -1;
            }

            task2Control.SetResultData(_resultAray);
        }
        
        //A bit of WAT here, so selecting y where y^2 + 3y - 5 > 0
        private void Task2FilterResultArray(object sender, EventArgs eventArgs)
        {
            _resultAray = _resultAray.Where(y => y * y + 3 * y - 5 > 0).ToList();

            task2Control.SetResultData(_resultAray);
        }

        //Sorting result, switching asc & desc
        private void Task2SortResultArray(object sender, EventArgs eventArgs)
        {
            if (_isAscending)
                _resultAray = _resultAray.OrderByDescending(y => y).ToList();
            else
                _resultAray = _resultAray.OrderBy(y => y).ToList();

            _isAscending = !_isAscending;

            task2Control.SetResultData(_resultAray);
            task2Control.ChangeResultOrderView(_isAscending);
        }
    }
}
