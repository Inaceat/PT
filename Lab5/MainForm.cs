using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Lab5
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _students = new BindingList<StudentInfo>();


            _students.Add(new StudentInfo("Уася", 2, "Б", StudentInfo.StudentPerfomance.Good));
            _students.Add(new StudentInfo("Петюа", 5, "А", StudentInfo.StudentPerfomance.Excellent));
            _students.Add(new StudentInfo("ВАЛЕРА", 11, "А", StudentInfo.StudentPerfomance.Good));
            _students.Add(new StudentInfo("Игорь", 2, "В", StudentInfo.StudentPerfomance.Passable));
            _students.Add(new StudentInfo("Евлампий", 7, "Г", StudentInfo.StudentPerfomance.Good));
 

            outputListBox.DataSource = _students;
            outputListBox.DisplayMember = "Name";
            outputListBox.SelectedIndexChanged += CheckButtonsEnabled;
        }
        

        private void CheckButtonsEnabled(object sender, EventArgs args)
        {
            updateButton.Enabled = (1 == outputListBox.SelectedIndices.Count);

            deleteButton.Enabled = (1 <= outputListBox.SelectedIndices.Count);
        }


        private readonly BindingList<StudentInfo> _students;


        private void OnAddClick(object sender, EventArgs e)
        {
            using (var inputDialog = new StudentInputDialogForm())
            {
                DialogResult result = inputDialog.ShowDialog();
                
                if (DialogResult.OK == result)
                {
                    _students.Add(inputDialog.StudentInput);
                }
            }
        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            if(1 != outputListBox.SelectedIndices.Count)
                return;

            using (var inputDialog = new StudentInputDialogForm(_students[outputListBox.SelectedIndex]))
            {
                DialogResult result = inputDialog.ShowDialog();
                
                if (DialogResult.OK == result)
                {
                    _students[outputListBox.SelectedIndex] = inputDialog.StudentInput;
                }
            }
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            foreach (int index in outputListBox.SelectedIndices.Cast<int>().Reverse())
                _students.RemoveAt(index);
        }
    }
}
