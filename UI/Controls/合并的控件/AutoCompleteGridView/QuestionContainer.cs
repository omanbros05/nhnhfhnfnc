using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnforceUI.Input;

namespace EnforceUI
{
    public partial class QuestionContainer : UserControl
    {
        List<AutoCompleteEntry> entries;

        public QuestionContainer()
        {
            InitializeComponent();
        }

        public List<AutoCompleteEntry> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        public void Clear()
        {
            flowLayoutPanel.Controls.Clear();
        }

        public void Init()
        {
            Clear();
            Add(new AskAndAnswer());
        }

        public void Add(AskAndAnswer question)
        {
            QuestionsControl control = new QuestionsControl(Entries);
            control.InitTexts();
            control.Width = flowLayoutPanel.Width - 40;
            control.Question = question;
            flowLayoutPanel.Controls.Add(control);
        }

        public List<AskAndAnswer> GetItems()
        {
            List<AskAndAnswer> Questions = new List<AskAndAnswer>();
            foreach (Control control in flowLayoutPanel.Controls)
            {
                QuestionsControl question = control as QuestionsControl;
                Questions.Add(question.Question);
            }

            return Questions;
        }
    }
}
