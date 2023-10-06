using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            richTextBox1.SelectionColor = Color.DeepSkyBlue;
        }

        private void pastebtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void redobtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        
    }
}
