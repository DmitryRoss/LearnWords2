using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeranWords
{
    public partial class LearnWords : Form
    {
        internal static string selectedDict;
        internal enum Direction { RussPol, PolRuss };
        internal static Direction selectedDirection;
        internal static TextBox TextBoxForWordToBeTranslated;
        internal static TextBox TextBoxForTypedWord;
        internal static TextBox TextBoxLogWithResults;
        internal static GroupBox GroupBoxForDirection;
        internal static Button ButtonCheckTranslation;
        internal static string translation;
        private static Runner runner;

        public LearnWords()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            textBoxLogWithResults.Clear();
            groupBoxForDirection.Enabled = false;
            selectedDict = comboBoxSelectListWithWords.Text;
            selectedDirection = radioButtonPolishRussian.Checked ? Direction.PolRuss : Direction.RussPol;

            backgroundWorkerMain = new BackgroundWorker();
            backgroundWorkerMain.DoWork += Run;
            backgroundWorkerMain.RunWorkerAsync();
            buttonCheckTranslation.Enabled = true;
        }

        private static void Run(object sender, EventArgs e)
        {           
            runner = new Runner(selectedDict, selectedDirection);
            runner.Run();            
        }

        private void LearnWords_Load(object sender, EventArgs e)
        {
            buttonCheckTranslation.Enabled = false;
            ButtonCheckTranslation = buttonCheckTranslation;
            TextBoxForWordToBeTranslated = textBoxForWordToBeTranslated;
            TextBoxForTypedWord = textBoxForTypedTranslation;
            TextBoxLogWithResults = textBoxLogWithResults;
            GroupBoxForDirection = groupBoxForDirection;


            LoadDictionaries();
        }
        internal static void Finish()
        {
            MessageBox.Show("Well Done - you made it!!!\nPick new list and start again.");
            ButtonCheckTranslation.Enabled = false;
            GroupBoxForDirection.Enabled = true;
        }

        private void LoadDictionaries()
        {
            Dictionary<string, int> dictionaries = DictionaryLoader.GetDictionaries();
            foreach (KeyValuePair<string, int> pair in dictionaries)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = pair.Key;
                item.Value = pair.Value;

                comboBoxSelectListWithWords.Items.Add(item);
            }
            try
            {
                comboBoxSelectListWithWords.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("There is no dictionaries in specified folder!!!");
            }
        }

        private void buttonCheckTranslation_Click(object sender, EventArgs e)
        {
            translation = textBoxForTypedTranslation.Text;
            CheckTranslation();
        }

        private static void CheckTranslation(object sender, EventArgs e)
        {
            runner.CheckTranslation(translation);
        }
        private void CheckTranslation()
        {
            runner.CheckTranslation(translation);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxForTypedTranslation.Focused)
                {
                    buttonCheckTranslation.PerformClick();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            GroupBoxForDirection.Enabled = true;
            buttonCheckTranslation.Enabled = false;
            textBoxForTypedTranslation.Clear();
            textBoxForTypedTranslation.Enabled = false;
            textBoxForWordToBeTranslated.Clear();
        }
    }
}
