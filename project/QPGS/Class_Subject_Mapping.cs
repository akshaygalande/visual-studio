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
    public partial class Class_Subject_Mapping : Form
    {
        static int classid, subjectid;
        string strID = "";
        Connection objcon = new Connection();
        DataBinding objfunc = new DataBinding();
     
        
        public Class_Subject_Mapping()
        {
            InitializeComponent();
        }

        private void Class_Subject_Mapping_Load(object sender, EventArgs e)
        {
            dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select CSM_ID,ClassName,SubjectName from Class_Subject_Mapping inner join Class_Mst on Class_Subject_Mapping.Class_ID=Class_Mst.Class_ID inner join Subject_MST on Class_Subject_Mapping.Subject_ID=Subject_MST.Subject_ID");
            objfunc.LoadCombo(cmbclass, "select ClassName from Class_Mst");
            objfunc.LoadCombo(cmbsubject, "select SubjectName from Subject_MST");
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if(cmbsubject.Text=="")
            {

                valid = false;
                cmbsubject.BackColor = Color.Red;
            }
            else
            {
                cmbsubject.BackColor = Color.White;
            }
            return valid;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            classid = objfunc.GetId("select Class_ID from Class_Mst where ClassName='" + cmbclass.Text + "'");
            subjectid = objfunc.GetId("select Subject_ID from Subject_MST where SubjectName='" + cmbsubject.Text + "'");


            try
            {
                if (validate())
                {
                    objcon.Open();
                    string query = "insert into Class_Subject_Mapping(Class_ID,Subject_ID) values(@classid,@subjectid)";
                    objcon.cmd.CommandText = query;
                    objcon.cmd.Parameters.AddWithValue("@classid", classid);
                    objcon.cmd.Parameters.AddWithValue("@subjectid", subjectid);
                    objcon.cmd.ExecuteNonQuery();
                    objcon.Close();
                    MessageBox.Show("Data Saved Sucessfully...");

                    dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select CSM_ID,ClassName,SubjectName from Class_Subject_Mapping inner join Class_Mst on Class_Subject_Mapping.Class_ID=Class_Mst.Class_ID inner join Subject_MST on Class_Subject_Mapping.Subject_ID=Subject_MST.Subject_ID");
                    objfunc.CleanForm(this);
                }
                else
                {
                    MessageBox.Show("Enter Values..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            try
            {
                if (strID != "")
                {
                    if (MessageBox.Show("Do you really want to delete?", "Question", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objcon.Open();
                        string query = "DELETE FROM Class_Subject_Mapping WHERE CSM_ID=@strID";
                        objcon.cmd.CommandText = query;
                        objcon.cmd.Parameters.AddWithValue("strID", strID);
                        objcon.cmd.ExecuteNonQuery();
                        objcon.Close();
                        MessageBox.Show("Data deleted Sucessfully...");

                        dataGridView1 = objfunc.GridLoadDS(dataGridView1, "select CSM_ID,ClassName,SubjectName from Class_Subject_Mapping inner join Class_Mst on Class_Subject_Mapping.Class_ID=Class_Mst.Class_ID inner join Subject_MST on Class_Subject_Mapping.Subject_ID=Subject_MST.Subject_ID");
                        objfunc.CleanForm(this);
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
            }
        }
    }
}
