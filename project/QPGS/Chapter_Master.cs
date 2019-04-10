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
    public partial class Chapter_Master : Form
    {
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
        static int classid,subjectid;
        string strID = "";
        public Chapter_Master()
        {
            InitializeComponent();
        }

        private void Chapter_Master_Load(object sender, EventArgs e)
        {
            cmbclass = objfunc.LoadCombo(cmbclass, "select ClassName from Class_Mst");
            //dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select Chapter_ID, ClassName, SubjectName, ChapterName from Chapter inner join Class_Mst on Chapter.Class_ID=Class_Mst.Class_ID inner join Subject_MST on Chapter.Subject_ID=Subject_MST.Subject_ID ;");
        }

        private void cmbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + cmbclass.Text + "'");
            cmbSubject = objfunc.LoadCombo(cmbSubject, "select SubjectName from Class_Subject_Mapping inner join Subject_MST on Class_Subject_Mapping.Subject_ID=Subject_MST.Subject_ID inner join Class_Mst on Class_Subject_Mapping.Class_ID=Class_MST.Class_ID where (Class_Subject_Mapping.Class_ID=" + classid + ")");
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

            if (txtchapter.Text == "")
            {
                valid = false;
                txtchapter.BackColor = Color.Red;
            }
            else
            {
                txtchapter.BackColor = Color.White;
            }
            return valid;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (objfunc.CheckDup("select ChapterName from Chapter where ChapterName ='" + txtchapter.Text + "'"))
                {
                    MessageBox.Show(" This Chapter already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + cmbclass.Text + "'");
                    subjectid = objfunc.GetId("select Subject_ID from Subject_MST where SubjectName='" + cmbSubject.Text + "'");
                    string query = "";
                    query = "insert into Chapter (ChapterName,Class_ID,Subject_ID) values( @Chapter, @Class_ID, @Subject_ID)";
                    objcon.Open();
                    objcon.cmd.CommandText = query;
                    objcon.cmd.Parameters.AddWithValue("@Chapter", txtchapter.Text);
                    objcon.cmd.Parameters.AddWithValue("@Class_ID", classid);
                    objcon.cmd.Parameters.AddWithValue("@Subject_ID", subjectid);

                    objcon.cmd.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("Data Saved Sucessfully...");
                    objfunc.CleanForm(this);
                    dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select Chapter.Chapter_ID, ClassName, SubjectName, ChapterName  from Chapter inner join Class_Mst on Chapter.Class_ID= Class_Mst.Class_ID inner join Subject_MST on Chapter.Subject_ID = Subject_MST.Subject_ID where Chapter.Class_ID=" + classid + " and  Chapter.Subject_ID=" + subjectid + "");
                }
            }
            else
            {
                MessageBox.Show("Enter values");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (strID != "")
                {
                    if (MessageBox.Show("Do you really want to delete?", "Question", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objcon.Open();
                        string query = "DELETE FROM Chapter WHERE Chapter_ID=@strID";
                        objcon.cmd.CommandText = query;
                        objcon.cmd.Parameters.AddWithValue("strID", strID);
                        objcon.cmd.ExecuteNonQuery();
                        objcon.Close();
                        MessageBox.Show("Data deleted Sucessfully...");
                        objfunc.CleanForm(this);
                        dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select Chapter.Chapter_ID, ClassName, SubjectName, ChapterName  from Chapter inner join Class_Mst on Chapter.Class_ID= Class_Mst.Class_ID inner join Subject_MST on Chapter.Subject_ID = Subject_MST.Subject_ID where Chapter.Class_ID=" + classid + " and  Chapter.Subject_ID=" + subjectid + "");
                        strID = "";
                    }

                    else
                    {
                        return;
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
                
            }
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

            subjectid = objfunc.GetId("select Subject_ID from Subject_MST where SubjectName='" + cmbSubject.Text + "'");

            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select Chapter.Chapter_ID, ClassName, SubjectName, ChapterName  from Chapter inner join Class_Mst on Chapter.Class_ID= Class_Mst.Class_ID inner join Subject_MST on Chapter.Subject_ID = Subject_MST.Subject_ID where Chapter.Class_ID="+classid+" and  Chapter.Subject_ID="+subjectid+"");
        
        }

        private void txtchapter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
