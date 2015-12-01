using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoeAppForms2
{
    public partial class Form1 : Form
    {
        KoBNamnRetur _myKoBNamnRetur = new KoBNamnRetur();
        string path = @"C:\Users\Kalle\Desktop\Kul\TestFilter.filter";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(textBox1.Lines);
        }


        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
            textBox3.Text = listBox1.SelectedItem.ToString();
        }

        
        public struct KoBNamnRetur
        {
            public string klassNamn;
            public string basTyp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            _myKoBNamnRetur.klassNamn = textBox2.Text;
        }

        
        private void btn2_Click(object sender, EventArgs e)
        {
            string rKNamn = textBox2.Text;
            if (rKNamn.Contains("Handed"))
            {
                rKNamn = rKNamn.Replace("Handed", "Hand");
            }
            _myKoBNamnRetur.basTyp = rKNamn;
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            string show = "Show";
            string klass = "Class ";
            string baseType = "BaseType ";
            string fontSize = "SetFontSize ";
            int font = 28;
            string borderColor = "SetBorderColor ";
            int color = 255;
            string rarity = "Rarity ";
            string normal = "Normal ";
            string magic = "Magic ";
            string rare = "Rare";
            string itemLevel = "ItemLevel ";
            int level = 1;
            string klassNamn = _myKoBNamnRetur.klassNamn;
            string basTyp = _myKoBNamnRetur.basTyp;

            StreamWriter sw = new StreamWriter(path, true); //Skapar streamwriter till pathen som angivits ovan, true gör att den inte skriver över annan data
            sw.WriteLine("\r\n" + show + "\r\n" + klass + klassNamn + "\r\n" + baseType + '"' + basTyp + '"' + "\r\n" + fontSize + font + "\r\n" + borderColor + color + "\r\n" +
                rarity + @">= " + normal + magic + rare + "\r\n" + itemLevel + @">= " + level);
            sw.Close();
            MessageBox.Show("Sparat!");

        }
    }
}
