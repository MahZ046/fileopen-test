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


namespace openfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select file";
            openFileDialog1.FileName = "select";
            openFileDialog1.InitialDirectory = @"C:\users";
            openFileDialog1.Filter = "txt files(.txt)|*.txt|tüm dosyalar(*)|*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FileInfo file = new FileInfo(textBox1.Text);
            StreamReader text = file.OpenText();
            textBox2.Text = text.ReadToEnd();
        }
    }
}
