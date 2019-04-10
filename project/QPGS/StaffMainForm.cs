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
    public partial class StaffMainForm : Form
    {
        public StaffMainForm()
        {
            InitializeComponent();
        }

        private void addQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestion obj = new AddQuestion();
            obj.MdiParent = this;
            obj.Show();
        }

        private void generateQuestionPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generate_Question_Paper obj = new Generate_Question_Paper();
            obj.MdiParent = this;
            obj.Show();
        }

        private void checkQuestionPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CheckQuestionPaper obj = new CheckQuestionPaper();
            //obj.MdiParent = this;
            //obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
