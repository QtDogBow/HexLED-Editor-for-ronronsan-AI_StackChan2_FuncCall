using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexLED_Designer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hexLED1.builtUnderWhiteShell(checkBox1.Checked);
            hexLED1.setColorToAllLEDs(LED_COLOR.BLACK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = hexLED1.getText();
            Clipboard.SetText(hexLED1.getText());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hexLED1.PenColor = LED_COLOR.BLACK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hexLED1.PenColor = LED_COLOR.BLUE;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hexLED1.PenColor = LED_COLOR.GREEN;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hexLED1.PenColor = LED_COLOR.DARK_ORANGE;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hexLED1.PenColor = LED_COLOR.RED;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hexLED1.PenColor = LED_COLOR.WHITE_SMOKE;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hexLED1.PenColor = LED_COLOR.DIM_GRAY;
        }

        private void hexLED1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hexLED1.setColorToAllLEDs(LED_COLOR.BLACK);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hexLED1.builtUnderWhiteShell(checkBox1.Checked);
            hexLED1.setColorToAllLEDs(LED_COLOR.BLACK,true);

        }
    }
}
