using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Task2Control : UserControl
    {
        public Task2Control()
        {
            InitializeComponent();
        }

        


        public event EventHandler RandomizeClick
        {
            add { randomizeButton.Click += value; }
            remove { randomizeButton.Click -= value; }
        }

        public event EventHandler FillResultButtonClick
        {
            add { fillResultButton.Click += value; }
            remove { fillResultButton.Click -= value; }
        }

        public event EventHandler ChangeSignClick
        {
            add { changeSignButton.Click += value; }
            remove { changeSignButton.Click -= value; }
        }

        public event EventHandler FilterClick
        {
            add { filterButton.Click += value; }
            remove { filterButton.Click -= value; }
        }

        public event EventHandler SortClick
        {
            add { sortButton.Click += value; }
            remove { sortButton.Click -= value; }
        }


        public void ChangeResultOrderView(bool isAsc)
        {
            sortButton.Text = isAsc ? @"Sort: \/" : @"Sort: /\";
        }


        public void SetInitialData(List<int> newData)
        {
            initialArray.DataSource = newData.Select((item, index) =>$"X[{index}] = {item}").ToList();
        }

        public void SetResultData(List<int> newData)
        {
            resultArray.DataSource = newData.Select((item, index) =>$"Y[{index}] = {item}").ToList();
        }
    }
}
