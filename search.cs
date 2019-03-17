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

        private void okbtn_Click(object sender, EventArgs e)
        {
            string tbt = Test.rtb;
        }

        private void cncbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
