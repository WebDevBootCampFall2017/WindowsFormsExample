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

namespace ReadFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        /*This is the callback for the open_file
         * 
         * */
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //This is called when the file is okay
            string filename = ((OpenFileDialog)sender).FileName;

            textBox1.Text = File.ReadAllText(filename);
        }
    }
}
