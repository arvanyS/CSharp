using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hexadecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool swap = false;
        bool swap2=false;
        public string[] DecToHex(int dec, string[] array )
        {
            int i = 0;
            while (dec >= 16)
            {
                array[i] = (dec % 16).ToString();
                dec = dec / 16;
                i++;

            }
            array[i] = dec.ToString();
            return array;
        }
        public string[] DecToBin(int dec, string[] array)
        {
            int i = 0;
            
            while (dec >= 2)
            {
                 array[i] = (dec % 2).ToString();
                 dec = dec / 2;
                 i++;

            }
            array[i] = dec.ToString();
                
            
            return array;
        }
        public int BinArraySize(int dec)
        {
            
            int size = 0;
            if (dec == 0)
            {
                return size+1;
            }
            while (dec >= 1)
            {

                dec = dec / 2;
                size++;
            }
            
            return size;

        }

        public string[] NumToLettter(string[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == "10") { array[i] = "A";} 
                if (array[i] == "11") { array[i] = "B"; }
                if (array[i] == "12") { array[i] = "C"; }
                if (array[i] == "13") { array[i] = "D"; }
                if (array[i] == "14") { array[i] = "E"; }
                if (array[i] == "15") { array[i] = "F"; }
            }

            return array;
        }
        public string[] LetterToNum(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "A") { array[i] = "10"; }
                if (array[i] == "B") { array[i] = "11"; }
                if (array[i] == "C") { array[i] = "12"; }
                if (array[i] == "D") { array[i] = "13"; }
                if (array[i] == "E") { array[i] = "14"; }
                if (array[i] == "F") { array[i] = "15"; }
            }

            return array;
        }
        public string[] ConvertToArray(string hex)
        {
            string[] array= new string[hex.Length];
            for (int j = 0; j < hex.Length; j++)
            {
                array[j] = hex[j].ToString();
            }
            return array;
        }

        public string PrintArrayReversed(string[] array)
        {
            string hex="";
            for(int i=array.Length-1; i>=0; i--)
            {
                hex+= array[i];
            }
            return hex;
        }

        public int HexToDec (string[] array)
        {
            int dec = 0;
            for(int i = 0; i < array.Length; i++)
            {
                dec += Convert.ToInt32(array[array.Length - 1 - i]) * (int)Math.Pow(16, i) ;
            }
            return dec;
        }
        public int BinToDec(string[] array)
        {
            int dec = 0;
            for (int i = 0; i < array.Length; i++)
            {
                dec += Convert.ToInt32(array[array.Length - 1 - i]) * (int)Math.Pow(2, i);
            }
            return dec;
        }
        public bool IsBinary(string dec)
        {
            int nonBinaryDigit = 0;
            for(int i=0; i < dec.Length; i++)
            {
                if ((dec[i] != '0') && (dec[i] != '1'))
                {
                    nonBinaryDigit++;
                }
            }
            return nonBinaryDigit == 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (!swap)
                {
                    string[] array = new string[textBox1.Text.Length];
                    int dec = Convert.ToInt32(textBox1.Text);

                    string hex = PrintArrayReversed(NumToLettter(DecToHex(dec, array)));
                    textBox2.Text = hex;

                }
                else
                {
                    string[] array = new string[textBox1.Text.Length];
                    string hex = textBox1.Text;

                    textBox2.Text = HexToDec(LetterToNum(ConvertToArray(hex))).ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter an integer");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            swap = !swap;
            
            (label1.Text) = swap ? "Hexadecimal" : "Decimal";
            (label2.Text) = swap ? "Decimal" : "Hexadecimal";
            textBox2.Clear();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                if (!swap2)
                {
                    
                    int dec = Convert.ToInt32(textBox3.Text);
                    string[] array = new string[BinArraySize(dec)];

                    string bin = PrintArrayReversed(DecToBin(dec,array));
                    textBox4.Text = bin;
                }
                else
                {
                    string[] array = new string[textBox3.Text.Length];
                    string bin = textBox3.Text;
                    if (!IsBinary(bin))
                    {
                        MessageBox.Show("Please enter a binary number");
                    }
                    else
                    {
                        textBox4.Text = BinToDec(ConvertToArray(bin)).ToString();
                    }

                   
                }
            }
            else
            {
                MessageBox.Show("Please enter an integer");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            swap2 = !swap2;

            (label3.Text) = swap2 ? "Binary" : "Decimal";
            (label4.Text) = swap2 ? "Decimal" : "Binary";
            textBox4.Clear();
        }
    }
}
