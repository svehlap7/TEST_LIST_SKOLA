using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIST_TEST2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> list = new List<int>();

        private void Vypis(List<int> list, ListBox l)
        {
            l.Items.Clear();

            foreach (char y in list)
            {
                l.Items.Add(y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int cisla = 0;
            int n = Convert.ToInt32(textBox1.Text);
            Random random1 = new Random();
            int cislaa;

            for (int i = 0; i < n; i++)
            {
                int znak = random1.Next(32, 127);
                if (znak != 32)
                {
                    textBox2.AppendText(((char)znak).ToString());
                }
                list.Add((char)znak);

                if (znak >= 48 && znak <= 57)
                {
                    list.Add(znak);
                }

            }
          
           Vypis(list, listBox1);

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("test moc nepovedl se");
        }
    }
}
