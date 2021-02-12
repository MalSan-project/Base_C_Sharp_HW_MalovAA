using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BC_HW_L8_Malov
{
    public partial class RiddlerGetBaseForm : Form
    {
        List<Riddler> riddlers = new List<Riddler>();
        public RiddlerGetBaseForm()
        {            
            InitializeComponent();
            NumberOfRiddle.Maximum = riddlers.Count();
            NumberOfRiddle.Minimum = 0;
            
        }

        private void strToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static bool CheckReddleUser(Riddler tempriddle,List<Riddler> riddles)
        {
            foreach (Riddler rid in riddles)
                if (tempriddle.question == rid.question)
                {
                    MessageBox.Show("Такой вопрос у нас уже имеется!", "ITS NO GOOD");
                    return false;
                }
            return true;
        }

        private void AddRiddleBut_Click(object sender, EventArgs e)
        {
            Riddler tempriddle = new Riddler();
            tempriddle.question = TextBoxQuestion.Text;
            tempriddle.answer = TextBoxAnswer.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            tempriddle.comment = CommentBox.Text;
            if (CheckReddleUser(tempriddle, riddlers))
            {
                riddlers.Add(tempriddle);
                MessageBox.Show("Поздравляю, вы успешно добавили загадку!", "NEW RIDDLE");
            }
        }

        private void NumberOfRiddle_ValueChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(NumberOfRiddle.Value);
            if (index < riddlers.Count)
            {
                TextBoxQuestion.Text = riddlers[index].question;
                TextBoxAnswer.Text = riddlers[index].ToStringAnswer();
                CommentBox.Text = riddlers[index].comment;
            }
            else
                MessageBox.Show("Загадка с данным номером отсутствует!", "ERROR!");
        }

        private void EditRiddleBut_Click(object sender, EventArgs e)
        {
            Riddler tempriddle = new Riddler();
            tempriddle.question = TextBoxQuestion.Text;
            tempriddle.answer = TextBoxAnswer.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            tempriddle.comment = CommentBox.Text;            
            int index = Convert.ToInt32(NumberOfRiddle.Value);
            riddlers[index]=tempriddle;
            MessageBox.Show("Поздравляю, вы успешно изменили загадку!", "EDIT RIDDLE");
            }

        private void DeleteRiddle_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(NumberOfRiddle.Value);
            if (index < riddlers.Count())
                riddlers.Remove(riddlers[index]);
            else
                MessageBox.Show("Загадка с данным номером отсутствует!", "ERROR!");
        }

        private void openRiddlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;

                if (database.Count != 0)
                {
                    tbQuestion.Text = database[0].Text;
                    cbTrue.Checked = database[0].TrueFalse;
                }
            }
        }
    }
    }
}
