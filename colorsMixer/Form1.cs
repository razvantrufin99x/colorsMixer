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
        public string hexR="0";
        public string hexG="0";
        public string hexB="0";
        public int ihexR=0;
        public int ihexG=0;
        public int ihexB=0;

        public int ihexA=255;
        public string hexA="FF";

        public void setcolor()
        {
            Color c = Color.FromArgb(ihexA, ihexR, ihexG, ihexB);

            panel1.BackColor = c;
                
        }
        public void updateDecaOfColor()
        {
            string s = textBox5.Text;
            Color color = Color.FromArgb(ihexA,ihexR, ihexG, ihexB);
            this.textBox4.Text = color.ToString();

        }
        public void updatevalshexa()
        {
            string shexR;
            if (ihexR < 10) { shexR = "0" + hexR.ToString(); }
            else {  shexR = hexR.ToString(); }
            string shexG;
            if (ihexG < 10) { shexG = "0" + hexG.ToString(); }
            else { shexG = hexG.ToString(); }
            string shexB;
            if (ihexB < 10) { shexB = "0" + hexB.ToString(); }
            else { shexB = hexB.ToString(); }


            textBox5.Text = "#"+shexR+shexG+shexB;
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

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
           label9.Text = trackBar4.Value.ToString();
            hexA = toHexa(trackBar4.Value);
            ihexA = trackBar4.Value;
            label10.Text = hexA;
            label11.Text = ihexA.ToString();
            updatevalshexa();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateDecaOfColor();
            updatevalshexa();
            label10.Text = hexA;
            label11.Text = ihexA.ToString();
        }
    }
}
