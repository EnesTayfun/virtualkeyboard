using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanalKlavye
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(tab.Checked)
            {
                SendKeys.Send("{TAB}");
            }
            tab.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if(capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("Q");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if(altgr.Checked)
            {
                SendKeys.Send("@");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("q");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("W");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("w");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("E");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("€");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("e");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("R");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("r");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("T");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("t");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("Y");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("y");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("U");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("u");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("I");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("ı");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("O");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("o");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("P");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("p");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("Ğ");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if(altgr.Checked)
            {
                SendKeys.Send("¨");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("ğ");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("Ü");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("~"); //tilda çıkmıyor alt satıra iniyor
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("ü");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send(";");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send(",");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("A");
                lshift.Checked = false;
                rshift.Checked = false;
            }

            else if (lctrl.Checked || rctrl.Checked)
            {
                SendKeys.Send("^{A}");
                lctrl.Checked = false;
                rctrl.Checked = false;
            }

            else
            {
                SendKeys.Send("a");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("S");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("s");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("D");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("F");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("f");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("G");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("g");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("h");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("h");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("J");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("j");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("K");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("k");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("L");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("l");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("Ş");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("ş");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("İ");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("i");
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("Z");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (lctrl.Checked || rctrl.Checked)
            {
                SendKeys.Send("^{Z}");
                lctrl.Checked = false;
                rctrl.Checked = false;
            }
            else
            {
                SendKeys.Send("z");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("X");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("x");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("C");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if(lctrl.Checked || rctrl.Checked)
            {
                SendKeys.Send("^{C}");
                lctrl.Checked = false;
                rctrl.Checked = false;
            }
            else
            {
                SendKeys.Send("c");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("V");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if(lctrl.Checked || rctrl.Checked)
            {
                SendKeys.Send("^{V}");
                lctrl.Checked = false;
                rctrl.Checked = false;
            }
            else
            {
                SendKeys.Send("v");
            }
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("B");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("b");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("N");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("n");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("M");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("m");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("Ö");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("ö");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (capslock.Checked || lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("Ç");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send("ç");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send(">");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("|");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("<");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send(":");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else
            {
                SendKeys.Send(".");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("é");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("<");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("{<}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("!");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send(">");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("1");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("'");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("£");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("{^}");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("#");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("{+}");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("$");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("4");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("{%}");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("{½}");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("5");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
                SendKeys.Send("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("/");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("{{}");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("7");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("{(}");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("[");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("8");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("{)}");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("]");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("9");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("=");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("{}}"); 
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("0");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("?");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                //SendKeys.Send("{}");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("*");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lshift.Checked || rshift.Checked)
            {
                SendKeys.Send("_");
                lshift.Checked = false;
                rshift.Checked = false;
            }
            else if (altgr.Checked)
            {
                SendKeys.Send("|");
                altgr.Checked = false;
            }
            else
            {
                SendKeys.Send("-");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (numlock.Checked)
            {
                SendKeys.Send("{DIVIDE}");
            }
            else
            {
                SendKeys.Send("{/}");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (numlock.Checked)
            {
                SendKeys.Send("{MULTIPLY}");
            }
            else
            {
                SendKeys.Send("{*}");
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (numlock.Checked)
            {
                SendKeys.Send("{SUBSTRACT}");
            }
            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (numlock.Checked)
            {
                SendKeys.Send("{ADD}");
            }
            else
            {
                SendKeys.Send("{+}");
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            {
                SendKeys.Send("7");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if(numlock.Checked)
            {
                SendKeys.Send("8");
            }
            else
            {
                SendKeys.Send("{PGUP}");
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            {
                SendKeys.Send("9");
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (numlock.Checked)
            {
                SendKeys.Send("4");
            }
            else
            {
                SendKeys.Send("{LEFT}");
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            {
                SendKeys.Send("5");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if(numlock.Checked)
            {
                SendKeys.Send("6");
            }
            else
            {
                SendKeys.Send("{RIGHT}");
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            {
                SendKeys.Send("1");
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (numlock.Checked)
            {
                SendKeys.Send("2");
            }
            else
            {
                SendKeys.Send("{PGDN}");
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            {
                SendKeys.Send("3");
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            {
                SendKeys.Send("0");
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            {
                SendKeys.Send(",");
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button85_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void button69_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void button76_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void button73_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void button75_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void button74_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void button77_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void button79_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void button78_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void button84_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (altgr.Checked)
            {
                SendKeys.Send("{BREAK}");
            }
            else
            {
                SendKeys.Send("{PAUSE}");
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (altgr.Checked)
            {
                SendKeys.Send("{END}");
            }
            else
            {
                SendKeys.Send("{HOME}");
            }
            
        }

        private void backspace_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
                SendKeys.Send("{ENTER}");
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void capslock_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
