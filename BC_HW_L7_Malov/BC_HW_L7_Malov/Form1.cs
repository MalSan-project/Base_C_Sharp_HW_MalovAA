using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_HW_L7_Malov
{
    public partial class Doubler : Form
    {
        public event EventHandler UpdateTextNumber;
        List<int> number=new List<int>();
        int activenumber = 1;
        int finalnumber;
        int index = 0;
        int count = 0;
        Random rnd = new Random();
        public Doubler()
        {            
            InitializeComponent();
            finalnumber = rnd.Next(1, (int.MaxValue / 2) - 1);
            CountLabel.Text = count.ToString();
            ResultLabel.Text = activenumber.ToString();
            MessageBox.Show($"Бобро пожаловать. \nТебе нужнo за короткое время с помощью +1 и *2 \nдостичь числa=> {finalnumber}\nУдачи!", "New Game!");
            UpdateTextNumber += Doubler_UpdateTextNumber;
        }

        private void Doubler_UpdateTextNumber(object sender, EventArgs e)
        {
            ResultLabel.Text = activenumber.ToString();
            CountLabel.Text = count.ToString();
            if (activenumber >= finalnumber)
                MessageBox.Show($"Перебор, товарищь. Тебе нужно было получить число=> {finalnumber}","Looser");
            if (activenumber == finalnumber)
                MessageBox.Show($"Ура! Ты смог получить число=> {finalnumber}\nИ потребовалось тебе всего-то {count} попыток!))))","WINNER");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number.Add(activenumber);
            if (number.Last() < finalnumber)
            {                
                activenumber+=1;
                count++;
                if (UpdateTextNumber != null)
                    UpdateTextNumber.Invoke(sender, e);
            }
            else
                if (number.Last() > finalnumber)
                MessageBox.Show("Перебор, товарищ!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number.Add(activenumber);
            if (number.Last() < finalnumber)
            {                
                activenumber = activenumber * 2;                
                count++;
                if (UpdateTextNumber != null)
                    UpdateTextNumber.Invoke(sender, e);
            }
            else
                if (number.Last() > finalnumber)
                MessageBox.Show("Перебор, товарищ!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                number.Clear();
                number.Add(1);
                activenumber = 1;
                count++;
            if (UpdateTextNumber != null)
                UpdateTextNumber.Invoke(sender, e);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (number.Count() > 0)
            {
                activenumber = number.Last();
                number.Remove(number.Last());                
                count++;
                if (UpdateTextNumber != null)
                    UpdateTextNumber.Invoke(sender, e);
            }
            else
            {                
                MessageBox.Show("Хватит откатываться!Дальше уже некуда!)", "there is nothing to cancel");
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count = 0;
            number.Clear();
            number.Add(1);
            activenumber = 1;
            finalnumber = rnd.Next(0, (int.MaxValue / 2)-1);
            MessageBox.Show($"Бобро пожаловать. \nТебе нужнo за короткое время с помощью +1 и *2 \nдостичь числa=> {finalnumber}\nУдачи!","New Game!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Благодарю за игру!)", "Адьёс амигос!");
            Close();
        }
    }
}
