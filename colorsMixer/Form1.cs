using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorsMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string hexR;
        public string hexG;
        public string hexB;
        public int ihexR;
        public int ihexG;
        public int ihexB;

        public void setcolor()
        {
            Color c = Color.FromArgb(120, ihexR, ihexG, ihexB);

            panel1.BackColor = c;
                
        }
        public void updateDecaOfColor()
        {
            string s = textBox5.Text;
            Color color = Color.FromArgb(ihexR, ihexG, ihexB);
            this.textBox4.Text = color.ToString();

        }
        public void updatevalshexa()
        {
            textBox5.Text = "#"+hexR+hexG+hexB;
            setcolor();
            updateDecaOfColor();
        }
        public void setHextoTextBox(ref TextBox t, string x)
        {
            t.Text = x;    
        }

        // Convert integer 182 as a hex in a string variable
        public string toHexa(int x)
        {
            return  x.ToString("X");

        }
        // Convert the hex string back to the number
        public int toInt(string hex)
        {
            return  int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            hexR = toHexa(trackBar1.Value);
            ihexR = trackBar1.Value;
            setHextoTextBox(ref this.textBox6,hexR);
            updatevalshexa();
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
            hexG = toHexa(trackBar2.Value);
            ihexG = trackBar2.Value;
            setHextoTextBox(ref this.textBox7, hexG);
            updatevalshexa();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
            hexB = toHexa(trackBar3.Value);
            ihexB = trackBar3.Value;
            setHextoTextBox(ref this.textBox8, hexB);
            updatevalshexa();
        }
    }
}
