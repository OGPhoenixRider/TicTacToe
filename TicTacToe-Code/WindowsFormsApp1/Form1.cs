using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool XTurn;
        int turnCnt = 1;
        string XTurnStr = "Current turn: Player 1 (X)";
        public void buttSlct(Button card)
        {
            card.Text = XTurn ? "X" : "O";
            XTurn = !(XTurn);
            if (XTurn)
                textBox1.Text = XTurnStr;
            else
                textBox1.Text = "Current turn: Player 2 (O)";
            textBox2.Text = "Turn Count: " + Convert.ToString(++turnCnt);
        }
        public void checkWin()
        {

        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttSlct(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttSlct(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttSlct(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttSlct(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttSlct(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttSlct(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttSlct(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttSlct(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttSlct(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttSlct(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttSlct(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttSlct(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttSlct(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttSlct(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttSlct(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttSlct(button16);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XTurn = true;
            card card1 = new card(4, 1, button1);
            card card2 = new card(4, 2, button2);
            card card3 = new card(4, 3, button3);
            card card4 = new card(4, 4, button4);
            card card5 = new card(3, 1, button5);
            card card6 = new card(3, 2, button6);
            card card7 = new card(3, 3, button7);
            card card8 = new card(3, 4, button8);
            card card9 = new card(2, 1, button9);
            card card10 = new card(2, 2, button10);
            card card11 = new card(2, 3, button11);
            card card12 = new card(2, 4, button12);
            card card13 = new card(1, 1, button13);
            card card14 = new card(1, 2, button14);
            card card15 = new card(1, 3, button15);
            card card16 = new card(1, 4, button16);
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = button10.Text = button11.Text = button12.Text = button13.Text = button14.Text = button15.Text = button16.Text = "";

        }
    }
}
