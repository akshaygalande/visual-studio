using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QPGS
{
    public partial class PrincipleMainForm : Form
    {
        public PrincipleMainForm()
        {
            InitializeComponent();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccount obj = new CreateAccount();
            obj.Show();
            this.Hide();
        }

        

        private void PrincipleMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAccount obj = new ManageAccount();
            obj.MdiParent = this;
            obj.Show();
        }

        private void PrincipleMainForm_Load(object sender, EventArgs e)
        {

        }

        private void classMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Masterd obj = new Class_Masterd();
            obj.MdiParent = this;
            obj.Show();
        }

        private void subjectMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subject_Master obj = new Subject_Master();
            obj.MdiParent = this;
            obj.Show();
        }

        private void examMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam_Master obj = new Exam_Master();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestion obj = new AddQuestion();
            obj.MdiParent = this;
            obj.Show();
        }

        private void classSubjectMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAccount obj = new ManageAccount();
            obj.MdiParent = this;
            obj.Show();

        }

        private void classSubjectMappingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Class_Subject_Mapping obj = new Class_Subject_Mapping();
            obj.MdiParent = this;
            obj.Show();
        }

        private void classExamMAppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Exam_Mapping obj = new Class_Exam_Mapping();
            obj.MdiParent = this;
            obj.Show();
        }

        private void questionTypeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void paperMastersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateQuestionPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generate_Question_Paper obj = new Generate_Question_Paper();
            obj.MdiParent = this;
            obj.Show();
        }

        private void chapterMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chapter_Master obj = new Chapter_Master();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
