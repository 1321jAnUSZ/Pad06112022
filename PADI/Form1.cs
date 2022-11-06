using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PADI
{
    public partial class Form1 : Form
    {
        static int rozmiar = 1;
        Random random = new Random();
        int[] t1 = new int[rozmiar];

        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < t1.Length; i++)
            {
                t1[i] = random.Next(0,2500);
            }
        }
        void Wypisz(Array array, RichTextBox RTB)
        {
            for(int i = 0; i < array.Length; i++)
            {
                RTB.AppendText(array.GetValue(i).ToString());
                RTB.Text += "\n";
            }
        }
        
        void zwiekszanieRozmaru(ref int[] t, int rozmiar)
        {
            int staryRozmiar = t.GetLength(0);
            Array.Resize(ref t, rozmiar);
            for(int i = staryRozmiar; i< rozmiar;i++)
            {
                t[i] = random.Next(0,2500);
            }
        }

        void Sort(ref int [] t,RichTextBox RTB)
        {
            Array.Sort(t);
            Wypisz(t, RTB);
        }
        void DeleteNum()
        {
            richTextBox1.Text = " ";
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            int rozmiar = Convert.ToInt32(textBox1.Text);
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            zwiekszanieRozmaru(ref t1, t1.Length + rozmiar);
            Wypisz(t1, richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sort(ref t1,richTextBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteNum();
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Lime)
            {
                panel1.BackColor = Color.DarkGray;
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                textBox1.BackColor = Color.Gray;
                richTextBox1.BackColor = Color.Gray;
            }
                else
            {
                panel1.BackColor = Color.LightBlue; 
                button1.BackColor = Color.Lime;
                button2.BackColor = Color.DarkOrange;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Yellow;
                textBox1.BackColor = Color.White;
                richTextBox1.BackColor = Color.White;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Wypisz(t1, richTextBox1);
        }
    }
}
