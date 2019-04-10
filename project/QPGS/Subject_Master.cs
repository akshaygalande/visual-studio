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
    public partial class Subject_Master : Form
    {
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        static int subjectid;
        string strID = "";
        public Subject_Master()
        {
            InitializeComponent();
        }

        private void Subject_Master_Load(object sender, EventArgs e)
        {
            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Subject_ID,SubjectName from Subject_MST");


        }


        private bool validate()
        {
            bool valid = true;
            if (txtsubject.Text == "")
            {
                valid = false;
                txtsubject.BackColor = Color.Red;
            }
            else
            {
                txtsubject.BackColor = Color.White;
            }
            return valid;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    if (objfunc.CheckDup("select SubjectName from Subject_MST where SubjectName ='" + txtsubject.Text + "'"))
                    {
                        MessageBox.Show(" This Chapter already exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        objcon.Open();
                        string query = "insert into Subject_MST(SubjectName) values(@SubjectName)";
                        objcon.cmd.CommandText = query;
                        objcon.cmd.Parameters.AddWithValue("@SubjectName", txtsubject.Text);
                        objcon.cmd.ExecuteNonQuery();
                        objcon.cmd.Parameters.Clear();
                        objcon.Close();
                        MessageBox.Show("Data Saved Sucessfully...");
                        objfunc.CleanForm(this);
                        dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Subject_ID,SubjectName from Subject_MST");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Values");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Subject_Master obj = new Subject_Master();
            this.Hide();
            obj.Close();
        }

        private bool checkdata()
        {
            subjectid = objfunc.GetId("select Subject_ID from Subject_MST where SubjectName='" + txtsubject.Text + "'");
            bool check = true;
            if (objfunc.CheckDup("select CSM_ID from Class_Subject_Mapping where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Chapters for this Subject has been mapped so cannot delete this class ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }
            if (objfunc.CheckDup("select Chapter_ID from Chapter where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Chapter for this Subject has been added so cannot delete this class ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks1_FIB where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Question for this Subject is been stored in database so you cant delete this class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks1_TRUEORFALSE where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Question for this Subject is been stored in database so you cant delete this class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks2_ONESENTENCE where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Question for this Subject is been stored in database so you cant delete this class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks3_ANSTHEFOLLOWING where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Question for this Subject is been stored in database so you cant delete this class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks4_GIVEREASON where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Question for this Subject is been stored in database so you cant delete this class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks5_ANSINBRIEF where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Question for this Subject is been stored in database so you cant delete this class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks5_ANSINBRIEF where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Question for this Subject is been stored in database so you cant delete this class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }
            if (objfunc.CheckDup("select Question_ID from mks1_MCQ where Subject_ID='" + subjectid + "'"))
            {
                MessageBox.Show("Question for this Subject is been stored in database so you cant delete this class", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return check;
            }

            else
            {
                check = true;
                return check;
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (strID != "")
                {
                    if (checkdata() == false)
                    {
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Do you really want to delete?", "Question", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            objcon.Open();
                            string query = "DELETE FROM Subject_MST WHERE Subject_ID=@strID";
                            objcon.cmd.CommandText = query;
                            objcon.cmd.Parameters.AddWithValue("strID", strID);
                            objcon.cmd.ExecuteNonQuery();
                            objcon.Close();
                            MessageBox.Show("Data deleted Sucessfully...");
                            objfunc.CleanForm(this);
                            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Subject_ID,SubjectName from Subject_MST");
                            strID = "";
                        }
                        else
                        {
                            return;
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Any row was not selected (Double click on the row to select it).");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                strID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                btndelete.Enabled = true;
                txtsubject.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(strID!="")
                {
                    objcon.Open();
                    string query = "Update Subject_MST set SubjectName= @SubjectName where Subject_ID=" + strID + " ";
                    objcon.cmd.CommandText = query;
                    objcon.cmd.Parameters.AddWithValue("@SubjectName", txtsubject.Text);
                    objcon.cmd.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("Data Saved Sucessfully...");
                    objfunc.CleanForm(this);
                    dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select  Subject_ID,SubjectName from Subject_MST");
                    strID = "";
                }
                else
                {
                    MessageBox.Show("Any row was not selected (Double click on the row to select it).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
