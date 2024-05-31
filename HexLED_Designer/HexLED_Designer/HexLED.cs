using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HexLED_Designer
{
    public enum LED_COLOR {BLACK, BLUE, GREEN, DARK_ORANGE, RED, WHITE_SMOKE, DIM_GRAY };
    public partial class HexLED : UserControl
    {
        private Color lightsOutColor = Color.Black;//消灯時の表示色
        public LED_COLOR PenColor = LED_COLOR.BLACK;
        public HexLED()
        {
            InitializeComponent();
            setColorToAllLEDs(LED_COLOR.BLACK);
        }
        public string getText()
        {
            string format =
            "    {0},{1},{2},{3},\n" +
            "   {4},{5},{6},{7},{8},\n" +
            " {9},{10},{11},{12},{13},{14},\n" +
            "{15},{16},{17},{18},{19},{20},{21},\n" +
            "  {22},{23},{24},{25},{26},{27},\n" +
            "   {28},{29},{30},{31},{32},\n" +
            "     {33},{34},{35},{36}";

            //string s = button1.Tag.ToString();

            //string text1 = String.Format("{0}", "A");
            //string text2 = String.Format(format, "A","B");
            //string text3 = String.Format(format, "A"+"B");


            string text = String.Format(format,
            "C" + button1.Tag.ToString(),
            "C" + button2.Tag.ToString(),
            "C" + button3.Tag.ToString(),
            "C" + button4.Tag.ToString(),
            "C" + button5.Tag.ToString(),
            "C" + button6.Tag.ToString(),
            "C" + button7.Tag.ToString(),
            "C" + button8.Tag.ToString(),
            "C" + button9.Tag.ToString(),
            "C" + button10.Tag.ToString(),
            "C" + button11.Tag.ToString(),
            "C" + button12.Tag.ToString(),
            "C" + button13.Tag.ToString(),
            "C" + button14.Tag.ToString(),
            "C" + button15.Tag.ToString(),
            "C" + button16.Tag.ToString(),
            "C" + button17.Tag.ToString(),
            "C" + button18.Tag.ToString(),
            "C" + button19.Tag.ToString(),
            "C" + button20.Tag.ToString(),
            "C" + button21.Tag.ToString(),
            "C" + button22.Tag.ToString(),
            "C" + button23.Tag.ToString(),
            "C" + button24.Tag.ToString(),
            "C" + button25.Tag.ToString(),
            "C" + button26.Tag.ToString(),
            "C" + button27.Tag.ToString(),
            "C" + button28.Tag.ToString(),
            "C" + button29.Tag.ToString(),
            "C" + button30.Tag.ToString(),
            "C" + button31.Tag.ToString(),
            "C" + button32.Tag.ToString(),
            "C" + button33.Tag.ToString(),
            "C" + button34.Tag.ToString(),
            "C" + button35.Tag.ToString(),
            "C" + button36.Tag.ToString(),
            "C" + button37.Tag.ToString()
            );
            return text;
        }

        public void setColorToAllLEDs(LED_COLOR color, bool forLightsOut = false)
        {
            setColor(button1, color, forLightsOut);
            setColor(button2, color, forLightsOut);
            setColor(button3, color, forLightsOut);
            setColor(button4, color, forLightsOut);
            setColor(button5, color, forLightsOut);
            setColor(button6, color, forLightsOut);
            setColor(button7, color, forLightsOut);
            setColor(button8, color, forLightsOut);
            setColor(button9, color, forLightsOut);
            setColor(button10, color, forLightsOut);
            setColor(button11, color, forLightsOut);
            setColor(button12, color, forLightsOut);
            setColor(button13, color, forLightsOut);
            setColor(button14, color, forLightsOut);
            setColor(button15, color, forLightsOut);
            setColor(button16, color, forLightsOut);
            setColor(button17, color, forLightsOut);
            setColor(button18, color, forLightsOut);
            setColor(button19, color, forLightsOut);
            setColor(button20, color, forLightsOut);
            setColor(button21, color, forLightsOut);
            setColor(button22, color, forLightsOut);
            setColor(button23, color, forLightsOut);
            setColor(button24, color, forLightsOut);
            setColor(button25, color, forLightsOut);
            setColor(button26, color, forLightsOut);
            setColor(button27, color, forLightsOut);
            setColor(button28, color, forLightsOut);
            setColor(button29, color, forLightsOut);
            setColor(button30, color, forLightsOut);
            setColor(button31, color, forLightsOut);
            setColor(button32, color, forLightsOut);
            setColor(button33, color, forLightsOut);
            setColor(button34, color, forLightsOut);
            setColor(button35, color, forLightsOut);
            setColor(button36, color, forLightsOut);
            setColor(button37, color, forLightsOut);
        }
        public void setColor(Button button, LED_COLOR color, bool forLightsOut = false)
        {
            if (forLightsOut && (int)button.Tag != (int)LED_COLOR.BLACK) return;
            button.Tag = (int)color;
            switch (color)
            {
                case LED_COLOR.BLACK:
                    button.BackColor = lightsOutColor;// Color.Black;
                    break;
                case LED_COLOR.BLUE:
                    button.BackColor = Color.Blue;
                    break;
                case LED_COLOR.GREEN:
                    button.BackColor = Color.Green;
                    break;
                case LED_COLOR.DARK_ORANGE:
                    button.BackColor = Color.DarkOrange;
                    break;
                case LED_COLOR.RED:
                    button.BackColor = Color.Red;
                    break;
                case LED_COLOR.WHITE_SMOKE:
                    button.BackColor = Color.White;//Color.WhiteSmoke;
                    break;
                case LED_COLOR.DIM_GRAY:
                    button.BackColor = Color.DimGray;
                    break;
            }
        }
        public void setColor(int LedNumber, LED_COLOR color)
        {
            switch (LedNumber)
            {
                case 1: setColor(button1, color); break;
                case 2: setColor(button2, color); break;
                case 3: setColor(button3, color); break;
                case 4: setColor(button4, color); break;
                case 5: setColor(button5, color); break;
                case 6: setColor(button6, color); break;
                case 7: setColor(button7, color); break;
                case 8: setColor(button8, color); break;
                case 9: setColor(button9, color); break;
                case 10: setColor(button10, color); break;
                case 11: setColor(button11, color); break;
                case 12: setColor(button12, color); break;
                case 13: setColor(button13, color); break;
                case 14: setColor(button14, color); break;
                case 15: setColor(button15, color); break;
                case 16: setColor(button16, color); break;
                case 17: setColor(button17, color); break;
                case 18: setColor(button18, color); break;
                case 19: setColor(button19, color); break;
                case 20: setColor(button20, color); break;
                case 21: setColor(button21, color); break;
                case 22: setColor(button22, color); break;
                case 23: setColor(button23, color); break;
                case 24: setColor(button24, color); break;
                case 25: setColor(button25, color); break;
                case 26: setColor(button26, color); break;
                case 27: setColor(button27, color); break;
                case 28: setColor(button28, color); break;
                case 29: setColor(button29, color); break;
                case 30: setColor(button30, color); break;
                case 31: setColor(button31, color); break;
                case 32: setColor(button32, color); break;
                case 33: setColor(button33, color); break;
                case 34: setColor(button34, color); break;
                case 35: setColor(button35, color); break;
                case 36: setColor(button36, color); break;
                case 37: setColor(button37, color); break;
            }
        }
        public void builtUnderWhiteShell(bool isBuiltUnder)
        {
            lightsOutColor = isBuiltUnder ? SystemColors.Control : Color.Black;
            BackColor = lightsOutColor;
        }

        private void HexLED_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            setColor(btn, PenColor);
        }

        private void HexLED_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void HexLED_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string text = e.Data.GetData(DataFormats.Text).ToString();
                string text_Cx = Regex.Replace(text, @"[^C0-9,]", "");
                string[] elements = text_Cx.Split(',');
                if (elements.Count() != 37) return;
                for (int i = 0; i < elements.Count(); i++)
                {
                    int n = int.Parse(elements[i].Replace("C", ""));
                    setColor(i+1, (LED_COLOR)Enum.ToObject(typeof(LED_COLOR),n));
                }
            }
        }
    }
}
