using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QPGS
{
    public partial class Operator_main_form : Form
    {
        public Operator_main_form()
        {
            InitializeComponent();
        }

        private void addQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestion obj = new AddQuestion();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
