using System;
using System.Windows.Forms;

namespace test1
{
    public partial class search : Form
    {

        public static string kw = "";

        public search()
        {
            InitializeComponent();
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            /*
            char[] aw = kw.ToCharArray();
            string tbt = Test.rtb;
            int tblen = tbt.Length;
            int clen = 0;

            foreach (char ch in aw)
            {
                string tbtc = tbt.Trim(aw);
                Test.richTextBox1.AppendText(tbtc);
                clen += 1;
            }
            */
        }

        private void Cncbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
