using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab5
{
    internal partial class MainForm : Form
    {
        private int? _gradeNumber;

        private void GetGradeNumberFilter()
        {
            if (int.TryParse(gradeNumberInput.Text, out int value))
                _gradeNumber = value;
            else
                _gradeNumber = null;
        }


        private string _gradeIndex = "";

        private void GetGradeIndexFilter()
        {
            _gradeIndex = gradeIndexInput.Text;
        }




        public MainForm()
        {
            InitializeComponent();


            _students = new BindingList<StudentInfo>();
            _students.ListChanged += (sender, args) => FillFormattedOutput();
            _students.ListChanged += CheckActionsEnabled;
            _students.ListChanged += SetStatusStrip;

            outputListBox.DataSource = _students;
            outputListBox.DisplayMember = "Name";
            outputListBox.SelectedIndexChanged += CheckActionsEnabled;
            outputListBox.SelectedIndexChanged += SetStatusStrip;
            

            gradeNumberInput.TextChanged += (sender, args) =>
            {
                GetGradeNumberFilter();
                FillFormattedOutput();
            };
            gradeIndexInput.TextChanged += (sender, args) =>
            {
                GetGradeIndexFilter();
                FillFormattedOutput();
            };
        }

        
        private void OnMainFormLoading(object sender, EventArgs e)
        {
            GetGradeNumberFilter();
            GetGradeIndexFilter();
            FillFormattedOutput();


            CheckActionsEnabled(sender, e);

            SetStatusStrip(sender, e);
        }
        



        private void FillFormattedOutput()
        {
            formattedOutputListBox.DataSource =
                _students
                    .Where(student => !_gradeNumber.HasValue || student.GradeNumber == _gradeNumber.Value)

                    .Where(student => string.IsNullOrEmpty(_gradeIndex) || student.GradeIndex == _gradeIndex)

                    .OrderBy(student => student.Name)

                    .Select(student => $"{student.Name}, {student.Perfomance}")

                    .ToList();
        }


        private void SetStatusStrip(object sender, EventArgs e)
        {
            if (-1 != outputListBox.SelectedIndex)
            {
                var item = outputListBox.SelectedItem as StudentInfo;

                nameStatusLabel.Text = item.Name;

                gradeStatusLabel.Text = $"{item.GradeNumber} \"{item.GradeIndex}\"";

                perfomanceStatusLabel.Text = item.Perfomance.ToString();
            }
            else
            {
                nameStatusLabel.Text = "";
                gradeStatusLabel.Text = "";
                perfomanceStatusLabel.Text = "";
            }
        }


        private void CheckActionsEnabled(object sender, EventArgs args)
        {
            updateButton.Enabled = updateMenuItem.Enabled = updateToolButton.Enabled = (-1 != outputListBox.SelectedIndex);


            deleteButton.Enabled = deleteMenuItem.Enabled = deleteToolButton.Enabled = (-1 != outputListBox.SelectedIndex);

            
            saveButton.Enabled = saveMenuItem.Enabled = saveToolButton.Enabled = (0 < _students.Count);
        }



        private readonly BindingList<StudentInfo> _students;


        private void LoadList(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Environment.CurrentDirectory;
                fileDialog.CheckFileExists = true;
                fileDialog.Filter = "Data (*.data)|*.data";

                DialogResult result = fileDialog.ShowDialog();

                if (DialogResult.OK == result)
                {
                    FileStream file = File.OpenRead(fileDialog.FileName);

                    var reader = new BinaryFormatter();

                    var readData = reader.Deserialize(file) as BindingList<StudentInfo>;

                    file.Close();

                    _students.Clear();
                    foreach (var data in readData)
                        _students.Add(data);
                }
            }
        }

        private void SaveList(object sender, EventArgs e)
        {
            using (var fileDialog = new SaveFileDialog())
            {
                fileDialog.InitialDirectory = Environment.CurrentDirectory;
                fileDialog.Filter = "Data (*.data)|*.data";
                
                DialogResult result = fileDialog.ShowDialog();
                
                if (DialogResult.OK == result)
                {
                    FileStream file = File.Create(fileDialog.FileName);
                    
                    var writer = new BinaryFormatter();

                    writer.Serialize(file, _students);

                    file.Close();
                }
            }
        }


        private void AddItem(object sender, EventArgs e)
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

        private void UpdateItem(object sender, EventArgs e)
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

        private void DeleteItem(object sender, EventArgs e)
        {
            foreach (int index in outputListBox.SelectedIndices.Cast<int>().Reverse())
                _students.RemoveAt(index);

            SetStatusStrip(sender, e);
        }
    }
}
