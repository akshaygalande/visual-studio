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
    public partial class AddQuestion : Form
    {
        static int classid, subjectid, chapterid;
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            cmbClass = objfunc.LoadCombo(cmbClass, "select ClassName from Class_Mst");
            cmbQuetype = objfunc.LoadCombo(cmbQuetype, "select Qtype_Name from Qtype ");
        }


        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + cmbClass.Text + "'");

            subjectid = objfunc.GetId("select Subject_ID from Subject_MST where SubjectName='" + cmbSubject.Text + "'");

            cmbChapter = objfunc.LoadCombo(cmbChapter, "select ChapterName from Chapter where Class_ID=" + classid + " AND Subject_ID=" + subjectid + "");
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + cmbClass.Text + "'");

            cmbSubject = objfunc.LoadCombo(cmbSubject, "select SubjectName from Class_Subject_Mapping inner join Subject_MST on Class_Subject_Mapping.Subject_ID=Subject_MST.Subject_ID inner join Class_Mst on Class_Subject_Mapping.Class_ID=Class_MST.Class_ID where (Class_Subject_Mapping.Class_ID=" + classid + ")");
        }

        private void cmbQueType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmbQuetype.SelectedItem.ToString() == "Multiple Choice Question")
            {
                mcqgroup.Enabled = true;
            }
            else
            {
                mcqgroup.Enabled = false;
            }

        }



        private void cmbChapter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private bool validate()
        {
            bool valid = true;
            if (cmbClass.Text == "")
            {
                valid = false;
                cmbClass.BackColor = Color.Red;
            }
            else
            {
                cmbClass.BackColor = Color.White;
            }
            if (cmbSubject.Text == "")
            {

                valid = false;
                cmbSubject.BackColor = Color.Red;
            }
            else
            {
                cmbSubject.BackColor = Color.White;
            }

            if (cmbChapter.Text == "")
            {
                valid = false;
                cmbChapter.BackColor = Color.Red;
            }
            else
            {
                cmbChapter.BackColor = Color.White;
            }
            if (cmbQuetype.Text=="")
            {
                valid = false;
                cmbQuetype.BackColor = Color.Red;
            }
            else
            {
                cmbQuetype.BackColor = Color.White;
            }
            if (txtQuestion.Text=="")
            {
                valid = false;
                txtQuestion.BackColor = Color.Red;
            }
            else
            {
                txtQuestion.BackColor = Color.White;
            }
           // if (bool.Parse(cmbQuetype.SelectedText["Multiple choice question"].ToString()) == true)
            //if (bool.Parse(cmbQuetype.SelectedText = "Multiple choice question").ToString() == true)
            //if (Convert.ToBoolean(cmbQuetype.Text = "Multiple choice question")==true)
            switch (cmbQuetype.Text)
             {

                 case "Multiple Choice Question":
                                        if (optiona.Text == "")
                                        {
                                            valid = false;
                                            optiona.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            optiona.BackColor = Color.White;
                                        }
                                        if (optionb.Text == "")
                                        {
                                            valid = false;
                                            optionb.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            optionb.BackColor = Color.White;
                                        }
                                        if (optionc.Text == "")
                                        {
                                            valid = false;
                                            optionc.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            optionc.BackColor = Color.White;
                                        }
                                        if (optiond.Text == "")
                                        {
                                            valid = false;
                                            optiond.BackColor = Color.Red;
                                        }
                                        else
                                        {
                                            optiond.BackColor = Color.White;
                                        }
                                        break;
                    default: return valid;

            }
            return valid;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + cmbClass.Text + "'");
                subjectid = objfunc.GetId("select Subject_ID from Subject_MST where SubjectName='" + cmbSubject.Text + "'");
                chapterid = objfunc.GetId("select Chapter_ID from Chapter where ChapterName='" + cmbChapter.Text + "'");
                string query = "";
                switch (cmbQuetype.Text)
                {

                    case "Fill in the blanks":
                        if (objfunc.CheckDup("select Question_ID from mks1_FIB where Question='" + txtQuestion.Text + "'"))
                        {
                            MessageBox.Show("Question is already stored");
                            return;
                        }
                        else
                        {
                            query = "insert into mks1_FIB (Question,Chapter_ID,Subject_ID,Class_ID) values(@Question, @Chapter_ID, @Subject_ID, @Class_ID)";
                        }
                        break;


                    case "True or False": if (objfunc.CheckDup("select Question_ID from mks1_TRUEORFALSE where Question='" + txtQuestion.Text + "'"))
                        {
                            MessageBox.Show("Quetion is already stored");
                            return;
                        }
                        else
                        {
                            query = "insert into mks1_TRUEORFALSE (Question,Chapter_ID,Subject_ID,Class_ID) values(@Question, @Chapter_ID, @Subject_ID, @Class_ID)";
                        }
                        break;


                    case "Answer in one sentence": if (objfunc.CheckDup("select Question_ID from mks2_ONESENTENCE where Question='" + txtQuestion.Text + "'"))
                        {
                            MessageBox.Show("Quetion is already stored");
                            return;
                        }
                        else
                        {
                            query = "insert into mks2_ONESENTENCE (Question, Chapter_ID, Subject_ID, Class_ID) values(@Question, @Chapter_ID, @Subject_ID, @Class_ID)";
                        }
                        break;


                    case "Answer the following": if (objfunc.CheckDup("select Question_ID from mks3_ANSTHEFOLLOWING where Question='" + txtQuestion.Text + "'"))
                        {
                            MessageBox.Show("Quetion is already stored");
                            return;
                        }
                        else
                        {
                            query = "insert into mks3_ANSTHEFOLLOWING (Question,Chapter_ID,Subject_ID,Class_ID) values(@Question, @Chapter_ID, @Subject_ID, @Class_ID)";
                        }
                        break;


                    case "Give reasons": if (objfunc.CheckDup("select Question_ID from mks4_GIVEREASON where Question='" + txtQuestion.Text + "'"))
                        {
                            MessageBox.Show("Quetion is already stored");
                            return;
                        }
                        else
                        {
                            query = "insert into mks4_GIVEREASON(Question,Chapter_ID,Subject_ID,Class_ID) values(@Question, @Chapter_ID, @Subject_ID, @Class_ID)";
                        }
                        break;


                    case "Answer in brief": if (objfunc.CheckDup("select Question_ID from mks5_ANSINBRIEF where Question='" + txtQuestion.Text + "'"))
                        {
                            MessageBox.Show("Quetion is already stored");
                            return;
                        }
                        else
                        {
                            query = "insert into mks5_ANSINBRIEF(Question,Chapter_ID,Subject_ID,Class_ID) values(@Question, @Chapter_ID, @Subject_ID, @Class_ID)";
                        }
                        break;


                    case "Short Notes ": if (objfunc.CheckDup("select Question_ID from mks5_ANSINBRIEF where Question='" + txtQuestion.Text + "'"))
                        {
                            MessageBox.Show("Quetion is already stored");
                            return;
                        }
                        else
                        {
                            query = "insert into mks5_SHORTNOTES(Question,Chapter_ID,Subject_ID,Class_ID) values(@Question, @Chapter_ID, @Subject_ID, @Class_ID)";
                        }
                        break;

                    case "Multiple Choice Question":

                        if (objfunc.CheckDup("select Question_ID from mks1_MCQ where Question='" + txtQuestion.Text + "'"))
                        {

                            MessageBox.Show("Quetion is already stored");
                            return;
                        }
                        else
                        {
                            query = "insert into mks1_MCQ values(@Question, @Option_a, @Option_b, @Option_c, @Option_d,@Chapter_ID, @Subject_ID, @Class_ID)";
                            objcon.Open();
                            objcon.cmd.CommandText = query;
                            objcon.cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                            objcon.cmd.Parameters.AddWithValue("@Chapter_ID", chapterid);
                            objcon.cmd.Parameters.AddWithValue("@Subject_ID", subjectid);
                            objcon.cmd.Parameters.AddWithValue("@Class_ID", classid);
                            objcon.cmd.Parameters.AddWithValue("@Option_a", optiona.Text);
                            objcon.cmd.Parameters.AddWithValue("@Option_b", optionb.Text);
                            objcon.cmd.Parameters.AddWithValue("@Option_c", optionc.Text);
                            objcon.cmd.Parameters.AddWithValue("@Option_d", optiond.Text);
                            objcon.cmd.ExecuteNonQuery();
                            objcon.Close();
                            objfunc.CleanForm(this);
                            MessageBox.Show("Data Saved Sucessfully...");
                            
                        }
                        break;

                    //default: MessageBox.Show("Enter proper data");
                    //    break;
                }

                if (cmbQuetype.Text != "Multiple Choice Question")
                {

                    objcon.Open();
                    objcon.cmd.CommandText = query;
                    objcon.cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                    objcon.cmd.Parameters.AddWithValue("@Chapter_ID", chapterid);
                    objcon.cmd.Parameters.AddWithValue("@Subject_ID", subjectid);
                    objcon.cmd.Parameters.AddWithValue("@Class_ID", classid);
                    objcon.cmd.ExecuteNonQuery();
                    objcon.Close();
                    objfunc.CleanForm(this);
                    MessageBox.Show("Data Saved Sucessfully...");
                    
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Select and Enter values...");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

            AddQuestion obj = new AddQuestion();
            this.Hide();
            obj.Close();
        }

        private void cmbChapter_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        //AddQuestion obj = new AddQuestion();
        //private void btncancel_Click(object sender, EventArgs e)
        //{  
        //    obj.FormClosed += new FormClosedEventHandler(obj_Formclosed);
        //}
        //void obj_Formclosed(object sender, FormClosedEventArgs e)
        //{
        //    obj = null;
        //}
        
    }
}