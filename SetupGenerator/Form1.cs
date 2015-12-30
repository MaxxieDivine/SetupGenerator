using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SetupGenerator
{
    public partial class Form1 : Form
    {
        List<Card> list = new List<Card>();

        List<Card> supply = new List<Card>();

        public Form1()
        {
            InitializeComponent();

            

            //var delimiters = new char[] { '\t' } - \t is a tab character
            //use the tab delimited file then split on \t
            //each value of the card will be on its own line...keep track with counter
            //
            foreach (string line in File.ReadAllLines("cardTest.txt"))
            {
                string [] file = line.Split('\t');
                Card card = new Card();
                card.cardName = file[0];
                card.cardSet  = file[1];
                card.cardType = file[2];
                card.cardCost = file[3];
                card.cardText = file[4];
                list.Add(card);
            }
            card1.Text = list[0].cardName;
            card2.Text = list[1].cardName;
            card3.Text = list[2].cardName;

        }

        private void select1_Click(object sender, EventArgs e)
        {
            listBox_Supply.Items.Add(list[0].cardName);
            pictureBox1.Visible = true;
        }

        private void select2_Click(object sender, EventArgs e)
        {
            listBox_Supply.Items.Add(list[1].cardName);
        }

        private void select3_Click(object sender, EventArgs e)
        {
            listBox_Supply.Items.Add(list[2].cardName);
        }
    }
}
