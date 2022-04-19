using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Quote_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] stringArray = {
                "Навали погромче",
                "Ты дурака за меня не держи",
                "Нихуя себе струя",
                "Это вам не шахматы, здесь думать надо",
                "Время срать, а мы не ели",
                "На пук пукичах",
                "хлюп хлюп пук хрюк",
                "Жопа рабочая",
                "Ультрамегасуперпуперхарооош",
                "Я щас нахуй пройду в ноги и отлижу пизду",
                "Ебланоид",
                "Постоянный тильт",
                "Ты ебач",
                "Земля говном",
            };
            Random r = new Random();
            int n = r.Next(stringArray.Count());
            textBox1.Text = (stringArray[n]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
