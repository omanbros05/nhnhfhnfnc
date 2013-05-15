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
    public partial class QuestionsControl : UserControl
    {
        List<AutoCompleteEntry> Entries;

        public QuestionsControl()
        {
            InitializeComponent();
        }

        public QuestionsControl(List<AutoCompleteEntry> Entries)
            : this()
        {
            this.Entries = Entries;
        }

        public AskAndAnswer Question
        {
            get 
            {
                AskAndAnswer question = new AskAndAnswer();
                question.Question = autoCompleteTextBoxAsk.Text;
                question.Answer = richTextBoxAnswer.Text;

                return question;
            }

            set 
            {
                if (value != null)
                {
                    autoCompleteTextBoxAsk.Text = value.Question;
                    richTextBoxAnswer.Text = value.Answer;
                }
            }
        }

        public void InitTexts()
        {
            if (Entries != null)
            {
                autoCompleteTextBoxAsk.Items.Clear();
                foreach (AutoCompleteEntry entry in Entries)
                    this.autoCompleteTextBoxAsk.Items.Add(entry);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int currentIndex = Parent.Controls.GetChildIndex(this);
            for (int i = currentIndex + 1; i < Parent.Controls.Count; i++)
                Parent.Controls.SetChildIndex(Parent.Controls[i], i);

            QuestionsControl control = new QuestionsControl();
            control.InitTexts();
            control.Width = Parent.Width - 40;
            Parent.Controls.Add(control);
            Parent.Controls.SetChildIndex(control, currentIndex + 1);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }

    public class AskAndAnswer
    {
        private string question = string.Empty;
        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        private string answer = string.Empty;
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
    }
}
