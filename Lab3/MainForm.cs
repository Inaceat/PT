using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _errorList = new List<string>();

            _validationChecks = new Dictionary<Func<string, bool>, string>
            {
                {NotEmpty, "Empty input"},
                {LessThan200Symbols, "Input exceeds 200 symbols"},
                {NoNewLines, "New lines in input"},
                {FirstSymbolIsCapitalLetter, "First symbol is not capital letter"},
                {PunctuationImmediatelyAfterWord, "Punctuation mark is not after word"},
                {NoAdjacentSpaces, "Two spaces in a row"}
            };




            ValidateInputText();
        }



        private void TransformButton_Click(object sender, System.EventArgs e)
        {
            TransformInput();
        }

        private void TextInput_TextChanged(object sender, System.EventArgs e)
        {
            ValidateInputText();
        }



        private readonly List<string> _errorList;
        private readonly Dictionary<Func<string, bool>, string> _validationChecks;

        private void ValidateInputText()
        {
            GetInputErrors();


            if (0 == _errorList.Count)
            {
                errorProvider.Clear();
                transformButton.Enabled = true;
            }
            else
            {
                var errors = new StringBuilder();


                foreach (var errorText in _errorList) 
                    errors.AppendLine(errorText);


                errorProvider.SetError(transformButton, errors.ToString());
                transformButton.Enabled = false;
            }
        }

        private void GetInputErrors()
        {
            _errorList.Clear();

            foreach (var check in _validationChecks)
            {
                if (!check.Key(textInput.Text))
                    _errorList.Add(check.Value);
            }
        }



        private bool NotEmpty(string text)
        {
            return 0 != text.Length;
        }

        private bool LessThan200Symbols(string text)
        {
            return 200 >= text.Length;
        }
        
        private bool NoNewLines(string text)
        {
            return !text.Contains(Environment.NewLine);
        }
        
        private bool FirstSymbolIsCapitalLetter(string text)
        {
            return text.Length == 0 || char.IsUpper(text[0]);
        }

        private bool PunctuationImmediatelyAfterWord(string text)
        {
            if (0 == text.Length)
                return true;
            
    
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsPunctuation(text[i]) && !char.IsLetterOrDigit(text[i - 1]))
                    return false;
            }
        
            return true;
        }

        private bool NoAdjacentSpaces(string text)
        {
            return !text.Contains("  ");
        }


        private void TransformInput()
        {
            var result = textInput.Text;

            //If length is odd number, reomve substring starting with 2nd space
            if (0 != textInput.Text.Length % 2)
            {
                int firstSpaceIndex = textInput.Text.IndexOf(" ", StringComparison.Ordinal);

                if (firstSpaceIndex < textInput.Text.Length)
                {
                    int secondSpaceIndex = textInput.Text.IndexOf(" ", firstSpaceIndex + 1, StringComparison.Ordinal);

                    if (-1 != secondSpaceIndex)
                    {
                        result = textInput.Text.Substring(0, secondSpaceIndex);
                    }
                }
            }

            //Each word on new line
            textOutput.Text = Regex.Replace(result, @"( )(\w)", "$1" + Environment.NewLine + "$2");;
        }
    }
}
