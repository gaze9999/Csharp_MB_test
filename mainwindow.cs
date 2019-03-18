using System;
using System.IO;
using System.Windows.Forms;

namespace test1
{
    public partial class Test : Form
    {

        public static string rtb = "";

        public Test()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog
            {
                Title = "Select file",
                InitialDirectory = ".\\",
                Filter = "json files (*.*)|*.json|Text files (*.*)|*.txt"
            };

            if (opf.ShowDialog() == DialogResult.OK)
            {
                string[] filelines = File.ReadAllLines(opf.FileName);
                richTextBox1.LoadFile(opf.FileName, RichTextBoxStreamType.PlainText); //show in text box
                rtb = richTextBox1.Text;
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            search f2 = new search();
            f2.ShowDialog(); // Shows Form2
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog
            {
                Title = "Select file",
                FilterIndex = 2,
                Filter = "json files (*.*)|*.json|Text files (*.*)|*.txt",
                RestoreDirectory = true
            };

            if (svf.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(svf.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
