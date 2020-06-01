using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Task3Control : UserControl
    {
        public Task3Control()
        {
            InitializeComponent();
        }


        public event EventHandler FillClick
        {
            add => fillButton.Click += value;
            remove => fillButton.Click -= value;
        }
        
        public event EventHandler CalculateClick
        {
            add => calculateButton.Click += value;
            remove => calculateButton.Click -= value;
        }

        public event EventHandler ChangeClick
        {
            add => changeButton.Click += value;
            remove => changeButton.Click -= value;
        }


        public void SetMatrix(int[,] matrix)
        {
            matrixView.ColumnCount = matrix.GetLength(1);

            matrixView.Rows.Clear();
            matrixView.Rows.Add(matrix.GetLength(0));

            for (int i = 0; i < matrixView.RowCount; i++)
                for (int j = 0; j < matrixView.ColumnCount; j++)
                    matrixView.Rows[i].Cells[j].Value = matrix[i, j];
        }

        public void SetMainDiagSum(int sum)
        {
            mainDiagSumOutput.Text = sum.ToString();
        }
        public void ClearMainDiagSum()
        {
            mainDiagSumOutput.Clear();
        }
    }
}
