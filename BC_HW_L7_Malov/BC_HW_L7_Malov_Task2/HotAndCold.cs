using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_HW_L7_Malov_Task2
{
    public partial class HotAndCold : Form
    {
        Random rnd = new Random();
        int rightnumber;
        int answer;
        string tempanswer;
        int count = 0;
        public HotAndCold()
        {
            rightnumber = rnd.Next(1, 100);            
            InitializeComponent();
            TitleLabel.Text = "Доброго времени суторк, пользователь. Давай сыграем в игру?\nЯ загадал число от 1 до 100, и твоя задача отгадать его за минимальное количество попыток.\nЯ даже буду немного подсказывать тебе.Удачи!=)";
            TitleBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Title2.gif");
            ColdPicBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Cold.gif");
            HotPixBox.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Hot.gif");
            WinnerPicBox.Image= Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Winner1.gif");
            CountLabel.Text = $"Your try=> {count}";
            ColdPicBox.Visible=false;            
            HotPixBox.Visible = false;
            WinnerPicBox.Visible = false;
            HotLabel.Visible = false;
            ColdLabel.Visible = false;
            mistakeLabel.Visible = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetMyAnswer(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TitleBox.Visible = false;
                TitleLabel.Visible = false;
                if (int.TryParse(textBox1.Text, out answer))
                {
                    if (answer != rightnumber && (answer >= rightnumber - 12 && answer <= rightnumber + 12))
                    {
                        ColdPicBox.Visible = false;
                        HotPixBox.Visible = true;
                        HotLabel.Visible = true;
                        ColdLabel.Visible = false;
                        mistakeLabel.Visible = true;
                        mistakeLabel.Text = $"MISTAKE!\n{answer}\nIs not my number!";
                    }
                    else
                    if (answer <= rightnumber - 12 || answer >= rightnumber + 12)
                    {
                        ColdPicBox.Visible = true;
                        HotPixBox.Visible = false;
                        HotLabel.Visible = false;
                        ColdLabel.Visible = true;
                        mistakeLabel.Visible = true;
                        mistakeLabel.Text = $"MISTAKE!\n{answer}\nIs not my number!";
                    }
                    else
                    if (answer == rightnumber)
                    {
                        HotLabel.Visible = false;
                        ColdLabel.Visible = false;
                        HotPixBox.Visible = false;
                        ColdPicBox.Visible = false;
                        WinnerPicBox.Visible = true;
                        mistakeLabel.Visible = false;
                        MessageBox.Show($"Поздравляю! Я и вправду загадал число {rightnumber} \nИ тебе на это понадобилось всего лишь {count} попыток! ", "YOU ARE THE CHAMPION!");
                        textBox1.Visible=false;
                    }
                }
                else
                    MessageBox.Show("будь добр, вводи только числа!", "error!");
                count++;
                CountLabel.Text = $"Your try=> {count}";
                textBox1.Text = "";
            }
        }

        private void showRightAnswerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Слабак! Так и быть, скажу. Я загадал число {rightnumber}", "LOOSER!");
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты готов?Сейчас начнётся новая игра!","START NEW GAME");
            rightnumber = rnd.Next(1, 100);
            count = 0;
            answer = 0;
            textBox1.Visible=true;
            textBox1.Text = "";
            CountLabel.Text = $"Your try=> {count}";
            WinnerPicBox.Visible = false;
            ColdPicBox.Visible = false;
            HotPixBox.Visible = false;
            HotLabel.Visible = false;
            ColdLabel.Visible = false;
            mistakeLabel.Visible = false;
            TitleBox.Visible = true;
            TitleLabel.Visible = true;
        }
    }
}
