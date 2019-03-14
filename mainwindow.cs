using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Windows.Forms;

namespace test1
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Select file";
            opf.InitialDirectory = ".\\";
            opf.Filter = "json files (*.*)|*.json";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                String[] filelines = File.ReadAllLines(opf.FileName);
                try
                    {
                        richTextBox1.LoadFile(opf.FileName, RichTextBoxStreamType.PlainText);
                    }
                catch (SecurityException ex)
                    {
                        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
                    }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search f2 = new search();
            f2.ShowDialog(); // Shows Form2
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
