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

namespace Pr_9_zad_1_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "MyFile.txt";

            var WriterStream = new StreamWriter(path);
            
            int n = int.Parse(textBox1.Text);
            for (double i = 0; i <= n; i++)
            {
                WriterStream.WriteLine(1 / i);
            }
            WriterStream.Close();
            var rows = File.ReadAllLines(path);
            string str = "";
            for (int i = 3; i <= rows.Length; i += 3)
            {
                str += Convert.ToString(rows[i]);
                str += "\r\n";
            }
            textBox2.Text= Convert.ToString(str);
        }
    }
}
