using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace QPGS
{
    public partial class Generate_Question_Paper : Form
    {

        static int classid,subjectid,chapterid;
        DataTable dt = new DataTable();
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        DataTable dtQ = new DataTable();
        string strQP = "";
        static string strExamName = "", strSubject = "",strClass="";
        ArrayList QType = new ArrayList();
        ArrayList QNo = new ArrayList();
        int TotalMarks = 0, lblmarksnumber=0;
        //int QNo = 1;
        public Generate_Question_Paper()
        {
            InitializeComponent();
            //txtQNo.Text = QNo.ToString();
            strQP += "<html>";
            strQP += "<body>";
            //strQP += "<center><h1>Exam:" + strExamName + "</center></h1>";
            //strQP += "<center><h2>Class:" + strClass + "</center></h2>";
            //strQP += "<center><h2>Subject:" + strSubject + "</center></h2>";
            strQP += "<table width='100%' cellpadding='1' cellspacing='2'>";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Generate_Question_Paper_Load(object sender, EventArgs e)
        {
            
        
            //try
            //{

            //    string strcmd = "SELECT Class_ID, ClassName " +
            //                    " FROM            Class_Mst " +
            //                    " ORDER BY ClassName";
            //    objcon.cmd.CommandText = strcmd;
            //    objcon.adapter.SelectCommand = objcon.cmd;
            //    DataTable dt = new DataTable();
            //    objcon.adapter.Fill(dt);
            //    cmbclass.DataSource = dt;
            //    cmbclass.DisplayMember = "ClassName";
            //    cmbclass.ValueMember = "Class_ID";
            //}
            //catch (Exception ex) { throw ex; }
       
            cmbclass = objfunc.LoadCombo(cmbclass, "select ClassName from Class_Mst");
          
          cmbqtype = objfunc.LoadCombo(cmbqtype, "select Qtype_Name from Qtype ");

          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                strClass = cmbclass.Text;
            }
            catch (Exception) { }
           classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + cmbclass.Text + "'");

           cmbexam = objfunc.LoadCombo(cmbexam, "select Exam_Type from Class_Exam_Mapping inner join Class_Mst on Class_Mst.Class_ID = Class_Exam_Mapping.Class_ID inner join Exam_Mst on   Class_Exam_Mapping.Exam_ID= Exam_Mst.Exam_ID where (Class_Exam_Mapping.Class_ID="+classid+")");
           cmbSubject = objfunc.LoadCombo(cmbSubject, "select SubjectName from Class_Subject_Mapping inner join Subject_MST on Class_Subject_Mapping.Subject_ID=Subject_MST.Subject_ID inner join Class_Mst on Class_Subject_Mapping.Class_ID=Class_MST.Class_ID where (Class_Subject_Mapping.Class_ID="+classid+")");
        }

        private void cmbchapter_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                strSubject = cmbSubject.Text;
            }
            catch (Exception) { }

            strQP += "<center><h1>Exam:" + strExamName + "</center></h1>";
            strQP += "<center><h2>Class:" + strClass + "</center></h2>";
            strQP += "<center><h2>Subject:" + strSubject + "</center></h2>";

            subjectid = objfunc.GetId("select Subject_ID from Subject_MST where (SubjectName='" + cmbSubject.Text + "')");
            string query = "select ChapterName from Chapter where Subject_ID=" + subjectid + " ";

            DataTable dt = new DataTable();
            dt = SQLHelper.GetData(query);

            checkedListBox1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(dt.Rows[i]["ChapterName"].ToString());

            }  
            

            //checkedListBox1.Items.Add();
            //cmbchapter = objfunc.LoadCombo(cmbchapter, "select ChapterName from Chapter where Subject_ID=" + subjectid + " and Class_ID=" + classid + "");
        }

        private void cmbqtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbexam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                strExamName = cmbexam.Text;
            }
            catch (Exception) { }
        }


        private bool validate()
        {
            bool valid = true;
            if (cmbclass.Text == "")
            {
                valid = false;
                cmbclass.BackColor = Color.Red;
            }
            else
            {
                cmbclass.BackColor = Color.White;
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

           
            if (cmbqtype.Text == "")
            {
                valid = false;
                cmbqtype.BackColor = Color.Red;
            }
            else
            {
                cmbqtype.BackColor = Color.White;
            }
            if (cmbexam.Text == "")
            {
                valid = false;
                cmbexam.BackColor = Color.Red;
            }
            else
            {
                cmbexam.BackColor = Color.White;
            }
            if (txtQNo.Text == "")
            {
                valid = false;
                txtQNo.BackColor = Color.Red;
            }
            else
            {
                txtQNo.BackColor = Color.White;
            }
           
            if (txtMarks.Text == "")
            {
                valid = false;
                txtMarks.BackColor = Color.Red;
            }
            else
            {
                txtMarks.BackColor = Color.White;
            }
            //if (txttitle.Text == "")
            //{
            //    valid = false;
            //    txttitle.BackColor = Color.Red;
            //}
            //else
            //{
            //    txttitle.BackColor = Color.White;
            //}

            if (txtTotalMarks.Text == "")
            {
                valid = false;
                txtTotalMarks.BackColor = Color.Red;
            }
            else
            {
                txtTotalMarks.BackColor = Color.White;
            }
            if (cmbmarks.Text == "")
            {
                valid = false;
                txtTotalMarks.BackColor = Color.Red;            
            }
            else
            {
                txtTotalMarks.BackColor = Color.White;
            }
            if (checkedListBox1.Text == "")
            {
                valid = false;
                checkedListBox1.BackColor = Color.Red;
            }
            else
            {
                checkedListBox1.BackColor = Color.White;
            }

            return valid;
        }
        private void AddQuestion(int i, int count)
        {
            while (i < count)
            {
                int gridcount = dataGridView1.SelectedRows.Count;
                for (int j = 0; j < gridcount; i++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[j].Cells[2].Value) == true)
                    {
                        strQP += "<tr>";
                        strQP += "<td>";
                        strQP += i.ToString();
                        //i++;
                        strQP += "</td>";
                        strQP += "<td>";
                        strQP += dataGridView1.Rows[i].Cells[1].Value.ToString();
                        strQP += "</td>";
                        strQP += "<td>";
                        strQP += "&nbsp;";
                        strQP += "</td>";
                        strQP += "</tr>";
                    }
                }
            }
            strQP += "<tr>";
            strQP += "<td>";
            strQP += "&nbsp;";
            strQP += "</td>";
            strQP += "<td>";
            strQP += "&nbsp;";
            strQP += "</td>";
            strQP += "<td>";
            strQP += "&nbsp;";
            strQP += "</td>";
            strQP += "</tr>";
            MessageBox.Show("Question(s) added successfully");

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (validate())
            {

                int Totalqt = 0,  cmbmarksnumber = 0 ,chkvar=0;
                int iRows = dataGridView1.Rows.Count;
                int iCheckedCount = 0;
                for (int i = 0; i < iRows; i++)
                {
                    int iChecked = 0;
                    iChecked = Convert.ToInt32(dataGridView1.Rows[i].Cells["Select"].FormattedValue);
                    iCheckedCount += iChecked;
                }

                cmbmarksnumber = Convert.ToInt32(cmbmarks.Text);
                lblmarksnumber =lblmarksnumber + (cmbmarksnumber * iCheckedCount);
               

                Totalqt = Convert.ToInt32(txtMarks.Text);
                chkvar = cmbmarksnumber * iCheckedCount;
                if (chkvar == Totalqt)
                {   
                        // checking question type is added or not
                        for (int i = 0; i < QType.Count; i++)
                        {
                            if (Convert.ToInt32(QType[i]) == cmbqtype.SelectedIndex)
                            {
                                MessageBox.Show("Question type is already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        //checking question number is added or not
                        for (int i = 0; i < QNo.Count; i++)
                        {
                            if (QNo[i].ToString() == txtQNo.Text + " " + txtSubTitle.Text)
                            {
                                MessageBox.Show("Question no. is already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }


                        //Totalqt = TotalMarks + Convert.ToInt32(txtTotalMarks.Text);
                        if (Totalqt > Convert.ToInt32(txtTotalMarks.Text))
                        {
                            MessageBox.Show("Marks are exceeding than the Total marks of question paper ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                        TotalMarks = Convert.ToInt32(txtTotalMarks.Text);
                        //lblAddeddMarks.Text = Totalqt.ToString();
                        
                        //int countchecked = 0;
                        //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        //{
                        //    if ((bool)dataGridView1.Rows[i].Cells["Select"].Value)
                        //    {
                        //        countchecked++;
                        //    }
                        //}


                       
                        //validations
                        int cnt = 0;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value) == true)
                            {
                                cnt++;
                            }
                        }
                        if (cnt == 0)
                        {

                            MessageBox.Show("Questions not selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        QType.Add(cmbqtype.SelectedIndex);//adding question index to array list
                        QNo.Add(txtQNo.Text + " " + txtSubTitle.Text);//ading question no
                        //making question type
                        strQP += "<tr>";
                        strQP += "<td>";
                        strQP += "<b>" + txtQNo.Text + "&nbsp; " + txtSubTitle.Text + "<b>";
                        strQP += "</td>";
                        strQP += "<td>";
                        strQP += "<b>" + cmbqtype.Text + "<b>";
                        if (txttitle.Text.Trim() != "")
                        {
                            strQP += "(" + txttitle.Text + ")";
                        }
                        strQP += "</td>";
                        strQP += "<td>";
                        strQP += "<b>" + txtMarks.Text + "<b>";
                        strQP += "</td>";
                        strQP += "</tr>";

                        //QNo++;
                        //txtQNo.Text = QNo.ToString();

                        //making question
                        int no = 1;
                        int marksfor = Convert.ToInt32(cmbmarks.Text);
                        int totmarks = Convert.ToInt32(txtMarks.Text);
                        int count = totmarks / marksfor;
                        //dataGridView1.Rows.Count;
                        //AddQuestion(no, count);
                        //no++;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value) == true)
                            {
                                strQP += "<tr>";
                                strQP += "<td>";
                                strQP += no.ToString();
                                no++;
                                strQP += "</td>";
                                strQP += "<td>";
                                strQP += dataGridView1.Rows[i].Cells[1].Value.ToString();
                                strQP += "</td>";
                                strQP += "<td>";
                                strQP += "&nbsp;";
                                strQP += "</td>";
                                strQP += "</tr>";
                            }
                        }
                        strQP += "<tr>";
                        strQP += "<td>";
                        strQP += "&nbsp;";
                        strQP += "</td>";
                        strQP += "<td>";
                        strQP += "&nbsp;";
                        strQP += "</td>";
                        strQP += "<td>";
                        strQP += "&nbsp;";
                        strQP += "</td>";
                        strQP += "</tr>";
                        MessageBox.Show("Question(s) added successfully");
                        cmbqtype.Enabled = true;
                        lblAddeddMarks.Text = Convert.ToString(lblmarksnumber);
                    
                }
                if (chkvar < Totalqt)
                {
                    MessageBox.Show("Less questions are selected than the the assigned marks (Select some more questions).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (chkvar > Totalqt)
                {
                    MessageBox.Show("More questions are selected than the the assigned marks (Deselect some questions).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //else
                //{
                //    MessageBox.Show("Marks are assigned incorrecty for question type & each of its question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else
            {
                MessageBox.Show("Select and Enter values...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string strBody = "";
           
            //strBody += "<html>";
            //strBody += "<body>";
            //strBody += "<center><h1>Exam:" + strExamName + "</center></h1>";
            //strBody += "<center><h2>Class:" + strClass + "</center></h2>";
            //strBody += "<center><h2>Subject:" + strSubject + "</center></h2>";
            //strBody += "<table width='100%' cellpadding='1' cellspacing='2'>";

            strBody += strQP;
            int Totalqt=0;
            if (Totalqt > Convert.ToInt32(txtTotalMarks.Text))
            {
                MessageBox.Show("Total marks are less than " + txtTotalMarks.Text +", You can not generate question paper");
                return;
            }
            strBody += "<table>";
            strBody += "</body>";
            strBody += "</html>";
            StreamWriter sw = new StreamWriter("A.html");
            sw.Write(strQP);
            sw.Close();

           

            string strPath = AppDomain.CurrentDomain.BaseDirectory + "A.html";
            process1.StartInfo.FileName = strPath;
            process1.Start();
        }

        private void txtQNo_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtQNo.Text)
            {
                if (char.IsNumber(character))
                {
                    str += character;
                }
                else
                {
                    txtQNo.Text = str;
                    txtQNo.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Numbers", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtSubTitle_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtSubTitle.Text)
            {
                if (char.IsLetter(character))
                {
                    str += character;
                }
                else
                {
                    txtSubTitle.Text = str;
                    txtSubTitle.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Letters", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtTotalMarks_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtTotalMarks.Text)
            {
                if (char.IsNumber(character))
                {
                    str += character;
                }
                else
                {
                    txtTotalMarks.Text = str;
                    txtTotalMarks.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Numbers", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtMarks_TextChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (char character in txtMarks.Text)
            {
                if (char.IsNumber(character))
                {
                    str += character;
                }
                else
                {
                    txtMarks.Text = str;
                    txtMarks.SelectionStart = str.Length;
                    MessageBox.Show("Enter Only Numbers", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            //SqlCommand cmd = new SqlCommand("select * from tbl_data", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);  
           
        }

        private void btnLoadQuestions_Click(object sender, EventArgs e)
        {
            // chapterid = objfunc.GetId("select Chapter_ID from Chapter where ChapterName='"+cmbchapter.Text+"'  and Class_ID ="+classid+" and Subject_ID="+subjectid+"");
            DataTable dtC = new DataTable();
            DataTable dtQ = new DataTable();
            dtQ.Columns.Add("Question_ID", typeof(int));
            dtQ.Columns.Add("Question", typeof(string));
            dtQ.Columns.Add("Chk", typeof(int));

            if (checkedListBox1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    string strChapterName = checkedListBox1.CheckedItems[i].ToString();
                    //get chapter id from chapter name
                    string strcmd = "select Chapter_ID from Chapter where ChapterName='" + strChapterName + "'  and Class_ID =" + classid + " and Subject_ID=" + subjectid;
                    dtC = new DataTable();
                    dtC = SQLHelper.GetData(strcmd);

                    DataTable dtT = new DataTable();
                   
                        chapterid = Convert.ToInt32(dtC.Rows[0]["Chapter_ID"].ToString());
                        string query = "";
                        switch (cmbqtype.Text)
                        {

                            case "Fill in the blanks":
                                if (objfunc.CheckDup("select Question_ID from mks1_FIB where Chapter_ID = " + chapterid + ""))
                                {
                                    query = "select Question_ID,Question, 0 as Chk from mks1_FIB where Chapter_ID =" + chapterid + " and  Subject_ID =" + subjectid + "  and Class_ID= " + classid + "";
                                    //dataGridView1 = objfunc.GridLoadDS(dataGridView1, query);

                                    dtT = SQLHelper.GetData(query);
                                    dtQ.Merge(dtT);
                                }
                                else
                                {

                                    MessageBox.Show("Questions not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    cmbqtype.Enabled = true;
                                  
                                }
                                break;

                            case "True or False":
                                if (objfunc.CheckDup("select Question_ID from mks1_TRUEORFALSE where Chapter_ID = " + chapterid + ""))
                                {
                                query = "select Question_ID,Question, 0 as Chk from mks1_TRUEORFALSE where Chapter_ID =" + chapterid + " and  Subject_ID =" + subjectid + "  and Class_ID= " + classid + "";
                                dtT = SQLHelper.GetData(query);
                                dtQ.Merge(dtT);
                                 }
                                else
                                {
                                    MessageBox.Show("Questions not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cmbqtype.Enabled = true;
                                }
                                break;

                            case "Answer in one sentences":
                                 if (objfunc.CheckDup("select Question_ID from mks2_ONESENTENCE where Chapter_ID = " + chapterid + ""))
                                {
                                query = "select Question_ID,Question, 0 as Chk from mks2_ONESENTENCE where Chapter_ID =" + chapterid + " and  Subject_ID =" + subjectid + "  and Class_ID= " + classid + "";
                                dtT = SQLHelper.GetData(query);
                                dtQ.Merge(dtT);
                                 }
                                else
                                {
                                    MessageBox.Show("Questions not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cmbqtype.Enabled = true;
                                }
                                break;

                            case "Answer the following":
                                 if (objfunc.CheckDup("select Question_ID from mks3_ANSTHEFOLLOWING where Chapter_ID = " + chapterid + ""))
                                {
                                query = "select Question_ID,Question, 0 as Chk from mks3_ANSTHEFOLLOWING where Chapter_ID =" + chapterid + " and  Subject_ID =" + subjectid + "  and Class_ID= " + classid + "";
                                dtT = SQLHelper.GetData(query);
                                dtQ.Merge(dtT);
                                 }
                                else
                                {
                                    MessageBox.Show("Questions not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cmbqtype.Enabled = true;
                                }
                                break;
                            case "Give reason":
                                if (objfunc.CheckDup("select Question_ID from mks4_GIVEREASON where Chapter_ID = " + chapterid + ""))
                                {
                                query = "select Question_ID,Question, 0 as Chk from mks4_GIVEREASON where Chapter_ID =" + chapterid + " and  Subject_ID =" + subjectid + "  and Class_ID= " + classid + "";
                                dtT = SQLHelper.GetData(query);
                                dtQ.Merge(dtT);
                                 }
                                else
                                {
                                    MessageBox.Show("Questions not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cmbqtype.Enabled = true;
                                }
                                break;

                            case "Answer in brief":

                                if (objfunc.CheckDup("select Question_ID from mks5_ANSINBRIEF where Chapter_ID = " + chapterid + ""))
                                {
                                    query = "select Question_ID,Question, 0 as Chk from mks5_ANSINBRIEF where Chapter_ID =" + chapterid + " and  Subject_ID =" + subjectid + "  and Class_ID= " + classid + "";
                                    dtT = SQLHelper.GetData(query);
                                    dtQ.Merge(dtT);
                                }
                                else
                                {
                                    MessageBox.Show("Questions not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cmbqtype.Enabled = true;
                                }
                                break;

                            case "Short Notes":
                                if (objfunc.CheckDup("select Question_ID from mks5_SHORTNOTES where Chapter_ID = " + chapterid + ""))
                                {

                                    query = "select Question_ID,Question, 0 as Chk from mks5_SHORTNOTES where Chapter_ID =" + chapterid + " and  Subject_ID =" + subjectid + "  and Class_ID= " + classid + "";
                                    dtT = SQLHelper.GetData(query);
                                    dtQ.Merge(dtT);
                                }
                                else
                                {
                                    MessageBox.Show("Questions not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cmbqtype.Enabled = true;
                                }
                                break;



                            //case "Multiple choice question":

                            //    if (objfunc.CheckDup("select Question_ID from mks1_MCQ where Question='" + txtQuestion.Text + "'"))
                            //    {

                            //        MessageBox.Show("Quetion is already stored");
                            //        return;
                            //    }
                            //    else
                            //    {
                            //        query = "insert into mks1_MCQ values(@Question, @Option_a, @Option_b, @Option_c, @Option_d,@Chapter_ID, @Subject_ID, @Class_ID)";
                            //        objcon.Open();
                            //        objcon.cmd.CommandText = query;
                            //        objcon.cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
                            //        objcon.cmd.Parameters.AddWithValue("@Chapter_ID", chapterid);
                            //        objcon.cmd.Parameters.AddWithValue("@Subject_ID", subjectid);
                            //        objcon.cmd.Parameters.AddWithValue("@Class_ID", classid);
                            //        objcon.cmd.Parameters.AddWithValue("@Option_a", optiona.Text);
                            //        objcon.cmd.Parameters.AddWithValue("@Option_b", optionb.Text);
                            //        objcon.cmd.Parameters.AddWithValue("@Option_c", optionc.Text);
                            //        objcon.cmd.Parameters.AddWithValue("@Option_d", optiond.Text);
                            //        objcon.cmd.ExecuteNonQuery();
                            //        objcon.Close();
                            //        MessageBox.Show("Data Saved Sucessfully...");
                            //        objfunc.CleanForm(this);
                            //    }
                            //    break;

                                //default: MessageBox.Show("Questions not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //cmbqtype.Enabled = true;
                                //break;
                        }
                   
                }//End of Loop

            }
            else
            {
                MessageBox.Show("Chapters not selected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = dtQ;
            
        }

        private void cmbqtype_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbqtype.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            txtQNo.Text = null;
            txtMarks.Text = null;
            txtSubTitle.Text = null;
            txttitle.Text = null;
            cmbmarks.Text = null;

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows.RemoveAt(i);
                i--;
                if (dataGridView1.Rows.Count == 0)
                {
                    return;
                }
                else
                {
                    while (dataGridView1.Rows.Count == 0)
                        continue;
                }
            }
            
        }
    }
}
