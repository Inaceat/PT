using System;
using System.Windows.Forms;

namespace Lab5
{
    internal partial class StudentInputDialogForm : Form
    {
        public StudentInputDialogForm()
        {
            InitializeComponent();

            _studentInput = null;

            perfomanceComboBox.DataSource = Enum.GetValues(typeof(StudentInfo.StudentPerfomance));
        }

        public StudentInputDialogForm(StudentInfo studentInfo) : this()
        {
            nameInput.Text = studentInfo.Name;

            gradeNumberInput.Value = studentInfo.GradeNumber;

            gradeIndexInput.Text = studentInfo.GradeIndex;

            perfomanceComboBox.SelectedItem = studentInfo.Perfomance;
        }


        private StudentInfo _studentInput;

        public StudentInfo StudentInput => _studentInput ?? throw new InvalidOperationException("Cannot get user input before asking him!");


        private void OnOK(object sender, System.EventArgs e)
        {
            try
            {
                _studentInput = new StudentInfo(nameInput.Text,
                                                (int) gradeNumberInput.Value,
                                                gradeIndexInput.Text,
                                                (StudentInfo.StudentPerfomance) perfomanceComboBox.SelectedValue);

                DialogResult = DialogResult.OK;

            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnCancel(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
