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

namespace Pr_9_zad_2_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string String_3(string fileName)
        {
            string String_1;
            string buf = "";
            StreamReader reader = new StreamReader(fileName);
            while (!reader.EndOfStream)
            {
                String_1 = reader.ReadLine();
                if (String_1.Length > buf.Length)
                    buf = String_1;
            }
            return buf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Str = String_3("zadanie_2.txt");
           textBox2.Text=Convert.ToString (Str);
           textBox1.Text = Convert.ToString( Str.Length);
        }
    }
}
